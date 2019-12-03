using Confiq.Cpq.Line.Models;
using MongoDB.Driver;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Confiq.Cpq.Line.Services
{
    public class LineService
    {
        private readonly IMongoCollection<Lines> _line;
        private readonly IMongoCollection<Products> _product;
        private readonly IMongoCollection<Header> _head;

        public LineService(ILineDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _line = database.GetCollection<Lines>(settings.LineCollectionName);
            _product = database.GetCollection<Products>(settings.ProductCollectionName);
            _head = database.GetCollection<Header>(settings.HeadersCollectionName);
        }

        public Lines UpdateDisc(string id, Lines linein)
        {

            linein.reqtnet = linein.resttype *( linein.stdnetprice / 100);
            _line.ReplaceOne(line => line.Id == id, linein);
            return linein;
        }

        public Lines UpdateDiscAmt(string id, Lines linein)
        {

            linein.reqtnet = linein.restdiscount;
            _line.ReplaceOne(line => line.Id == id, linein);
            return linein;
        }

      
        public string SampleJSONSerilaize()
        {
            FinalClass output = new FinalClass();
            output.colDef = _head.Find(line => true).FirstOrDefault();
            output.rowDta = _line.Find(line => true).ToList();
            string objjsonData = JsonConvert.SerializeObject(output);
            return objjsonData;
        }

        public List<Lines> Get() =>
            _line.Find(line => true).ToList();
        public List<Header> Getheader() =>
           _head.Find(line => true).ToList();
        public Lines Get(string id) =>
            _line.Find<Lines>(line => line.Id == id).FirstOrDefault();

        public Lines CreateLine(string qouteno,string ptdid)
        {
            Products prdt=_product.Find<Products>(prt => prt.productID == ptdid).FirstOrDefault();
            Lines l1 = new Lines();
            l1.quoteNumber = qouteno;
            l1.partnumber = ptdid;
            l1.description = prdt.Description;
            l1.listprice = prdt.listPrice;
            _line.InsertOne(l1);
            return l1;
        }


        public void UpdateA(string quotenumber)
        {
            var filter = Builders<Lines>.Filter.Eq("quoteNumber", quotenumber);
            var update = Builders<Lines>.Update.Set("restdiscount", 0).Set("resttype", 0);
            _line.UpdateMany(filter, update);

        }
        public void Update(string id, Lines lineIn)
        {
            lineIn.stdnetprice = lineIn.qty * lineIn.listprice;
            if (lineIn.restdiscount != 0)
                lineIn.reqtnet = lineIn.restdiscount;
            else if (lineIn.resttype != 0)
                lineIn.reqtnet = lineIn.resttype * (lineIn.stdnetprice / 100);
            else
                lineIn.reqtnet = 0;
            _line.ReplaceOne(line => line.Id == id, lineIn);
           
        }
 

        public void Remove(Lines lineIn) =>
            _line.DeleteOne(line => line.Id == lineIn.Id);

    }

}
