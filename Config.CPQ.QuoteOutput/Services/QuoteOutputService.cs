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

        public DisplayOption Get(string quoteNumber) =>
            _displayoptions.Find<DisplayOption>(displayoption => displayoption.QuoteNumber == quoteNumber).FirstOrDefault();

    }
}
