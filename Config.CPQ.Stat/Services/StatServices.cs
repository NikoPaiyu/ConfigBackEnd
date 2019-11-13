using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

        public Stat1 Create(Stat1 stat1)
        {
            _stat1settings.InsertOne(stat1);
            return stat1;
        }

        public void Update(string id, Stat1 stat1In) =>
            _stat1settings.ReplaceOne(stat1 => stat1.Id == id, stat1In);

        public void Remove(Stat1 stat1In) =>
            _stat1settings.DeleteOne(stat1 => stat1.Id == stat1In.Id);

        public void Remove(string id) =>
            _stat1settings.DeleteOne(stat1 => stat1.Id == id);

    }
}
