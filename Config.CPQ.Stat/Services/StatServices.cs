using System.Collections.Generic;
using System.Linq;
using Config.CPQ.Static.Models;
using MongoDB.Driver;

namespace Config.CPQ.Static
{
    public class StatServices
    {
        private readonly IMongoCollection<Stat1> _stat1settings;
        public StatServices(IStatDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _stat1settings = database.GetCollection<Stat1>(settings.StatCollectionName);
        }

        public List<Stat1> Get() =>
        _stat1settings.Find(stat1 => true).ToList();

        public Stat1 Get(string id) =>
        _stat1settings.Find<Stat1>(stat1 => stat1.Id == id).FirstOrDefault();

 
    }
}
