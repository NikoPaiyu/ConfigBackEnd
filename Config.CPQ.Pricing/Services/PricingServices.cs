using System.Collections.Generic;
using System.Linq;
using Config.CPQ.Pricing.Models;
using MongoDB.Driver;


namespace Config.CPQ.Pricing.Services
{
    public class PricingServices
    {
        private readonly IMongoCollection<Models.Pricing> _pricingsettings;
        public PricingServices(IPricingDatabaseSettings settings)
        {
           var client = new MongoClient(settings.ConnectionString);
           var database = client.GetDatabase(settings.DatabaseName);

           _pricingsettings = database.GetCollection<Models.Pricing>(settings.PricingCollectionName);
        }

        public List<Models.Pricing> Get() =>
        _pricingsettings.Find(pricing => true).ToList();

        public Models.Pricing Get(string id) =>
        _pricingsettings.Find<Models.Pricing>(pricing => pricing.Id == id).FirstOrDefault();


    }
}