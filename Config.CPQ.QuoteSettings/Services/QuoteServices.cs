using System.Collections.Generic;
using System.Linq;
using Config.CPQ.QuoteSettings.Models;
using MongoDB.Driver;


namespace Config.CPQ.QuoteSettings.Services
{
    public class QuoteServices
    {
        private readonly IMongoCollection<Quote> _quotesettings;
        public QuoteServices(IQuoteDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _quotesettings = database.GetCollection<Quote>(settings.QuoteCollectionName);
        }

            public List<Quote> Get() =>
            _quotesettings.Find(quote => true).ToList();

            public Quote Get(string id) =>
            _quotesettings.Find<Quote>(quote => quote.Id == id).FirstOrDefault();

            public Quote Create(Quote quote)
            {
                _quotesettings.InsertOne(quote);
                return quote;
            }

        public void Update(string id, Quote quoteIn) =>
            _quotesettings.ReplaceOne(quote => quote.Id == id, quoteIn);

        public void Remove(Quote quoteIn) =>
            _quotesettings.DeleteOne(quote => quote.Id == quoteIn.Id);

        public void Remove(string id) =>
            _quotesettings.DeleteOne(quote => quote.Id == id);

    }
}
