using Confiq.Cpq.Line.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Confiq.Cpq.Line.Services
{
    public class LineService
    {
        private readonly IMongoCollection<Lines> _line; 

        public LineService(ILineDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _line = database.GetCollection<Lines>(settings.LineCollectionName);
            
        }

        public List<Lines> Get() =>
            _line.Find(line => true).ToList();

        public Lines Get(string id) =>
            _line.Find<Lines>(line => line.Id == id).FirstOrDefault();
        

        public Lines Get(string quotenumber,string partnumber) =>
           _line.Find(line => line.quoteNumber == quotenumber && line.partNumber==partnumber).FirstOrDefault();
       

        public Lines Create(Lines line)
        {
            _line.InsertOne(line);
            return line;
        }

        public void Update(string id, Lines lineIn) =>
            _line.ReplaceOne(line => line.Id == id, lineIn);

       // public void Update(Lines lineIn,int quant) =>
            //_line.ReplaceOne(line => line.Quantity!=quant , lineIn);


        public void Remove(Lines lineIn) =>
            _line.DeleteOne(line => line.Id == lineIn.Id);

        //public void Remove(string quotenumber,string partnumber) =>
        //    _line.DeleteOne(line => line.quoteNumber == quotenumber && line.partNumber==partnumber);
    }




}
