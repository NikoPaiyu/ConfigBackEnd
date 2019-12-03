using System.Collections.Generic;
using System.Linq;
using Config.CPQ.configPage2.Models;
using MongoDB.Driver;

namespace Config.CPQ.configPage2.Services
{
    public class SeriesService
    {
        private readonly IMongoCollection<Series> _series;

        public SeriesService(IConfigPageDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _series = database.GetCollection<Series>(settings.SeriesCollectionName);
        }

        public List<Series> Get() =>
            _series.Find(series => true).ToList();

        public List<Series> Get(int id) =>
            _series.Find<Series>(series => series.categoryId == id).ToList();
    }
}
