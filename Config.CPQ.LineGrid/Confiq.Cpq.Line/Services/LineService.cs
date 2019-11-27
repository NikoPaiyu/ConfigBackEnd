using Confiq.Cpq.Line.Models;
using MongoDB.Bson;
using MongoDB.Driver;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            linein.reqtNet = linein.restType *( linein.stdNetprice / 100);
            _line.ReplaceOne(line => line.Id == id, linein);
            return linein;
        }

        public Lines UpdateDiscAmt(string id, Lines linein)
        {

            linein.reqtNet = linein.restDisc;
            _line.ReplaceOne(line => line.Id == id, linein);
            return linein;
        }

        //extra code
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


        //public Lines Get(string quotenumber,string partnumber) =>
        //   _line.Find(line => line.quoteNumber == quotenumber && line.partNumber==partnumber).FirstOrDefault();

        public Lines CreateLine(string qouteno,string ptdid)
        {
            Products prdt=_product.Find<Products>(prt => prt.productID == ptdid).FirstOrDefault();
            Lines l1 = new Lines();
            l1.quoteNumber = qouteno;
            l1.productID = ptdid;
            l1.Description = prdt.Description;
            l1.listPrice = prdt.listPrice;
            _line.InsertOne(l1);
            return l1;
        }

  

        //public Lines Create(Lines line)
        //{
        //    _line.InsertOne(line);
        //    return line;
        //}
        //public Lines Geta(string quotenumber) =>
        //    _line.Find<Lines>(line => line.quoteNumber ==quotenumber).FirstOrDefault();

        public void UpdateA(string quotenumber)
        {
            var filter = Builders<Lines>.Filter.Eq("quoteNumber", quotenumber);
            var update = Builders<Lines>.Update.Set("restDisc", 0).Set("restType",0);
            _line.UpdateMany(filter, update);

            //return result;
        }

        public Lines Update(string id, Lines lineIn)
        {
            lineIn.stdNetprice = lineIn.Quantity * lineIn.listPrice;
            _line.ReplaceOne(line => line.Id == id, lineIn);
            return lineIn;
        }
       

        //public void UpdateA(string quotenumber, Lines lineIn)
        //{
        //    _line.ReplaceOne(line => line.quoteNumber == quotenumber, lineIn);
        //}

        public void Remove(Lines lineIn) =>
            _line.DeleteOne(line => line.Id == lineIn.Id);

    }




}
