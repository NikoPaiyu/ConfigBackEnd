using System.Collections.Generic;
using System.Linq;
using Config.CPQ.configPage2.Models;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Driver;

namespace Config.CPQ.configPage2.Services
{
    public class PartService
    {
        private readonly IMongoCollection<partlist> _part;
        private readonly IMongoCollection<Product> _product;

        public PartService(IConfigPageDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _part = database.GetCollection<partlist>(settings.PartListCollectionName);
            _product = database.GetCollection<Product>(settings.ProductCollectionName);
        }
        public partlist Create(string value)
        {
            string[] ds = value.Split('-');
            Product prdt = _product.Find<Product>(prt => prt.partNumber == ds[0]).FirstOrDefault();
            partlist p = new partlist();
            p.partNumber = prdt.partNumber;
            p.quantity = 1;
            p.Description = prdt.Description;
            p.listPrice = prdt.listPrice;
            _part.InsertOne(p);
            return p;
        }

        public ActionResult<List<partlist>> Get()
        {

            return _part.Find(category => true).ToList();
        }
    }
}
