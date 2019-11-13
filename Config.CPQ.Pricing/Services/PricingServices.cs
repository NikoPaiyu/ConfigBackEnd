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

        public Models.Pricing Create(Models.Pricing pricing)
        {
            _pricingsettings.InsertOne(pricing);
            return pricing;
        }

        public void Update(string id, Models.Pricing pricingIn) =>
            _pricingsettings.ReplaceOne(pricing => pricing.Id == id, pricingIn);

        public void Remove(Models.Pricing pricingIn) =>
            _pricingsettings.DeleteOne(pricing => pricing.Id == pricingIn.Id);

        public void Remove(string id) =>
            _pricingsettings.DeleteOne(pricing => pricing.Id == id);

    }
}