using System.Collections.Generic;
using System.Linq;
using Config.CPQ.QuoteOutput.Models;
using MongoDB.Driver;

namespace Config.CPQ.QuoteOutput.Services
{
    public class QuoteOutputService
    {
        private readonly IMongoCollection<DisplayOption> _displayoptions;

        public QuoteOutputService(IQuoteOutputDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _displayoptions = database.GetCollection<DisplayOption>(settings.QuoteOutputCollectionName);
        }
        public List<DisplayOption> Get() =>
            _displayoptions.Find(displayoption => true).ToList();


        public DisplayOption Get(string id) =>
            _displayoptions.Find<DisplayOption>(displayoption => displayoption.Id == id).FirstOrDefault();

        public DisplayOption Create(DisplayOption displayoption)
        {
            _displayoptions.InsertOne(displayoption);
            return displayoption;
        }

        public void Update(string id, DisplayOption displayoptionIn) =>
            _displayoptions.ReplaceOne(displayoption => displayoption.Id == id, displayoptionIn);

        public void Remove(DisplayOption displayoptionIn) =>
            _displayoptions.DeleteOne(displayoption => displayoption.Id == displayoptionIn.Id);

        public void Remove(string id) =>
            _displayoptions.DeleteOne(displayoption => displayoption.Id == id);
    }
}
