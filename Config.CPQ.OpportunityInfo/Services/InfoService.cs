using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Config.CPQ.OpportunityInfo.Models;

namespace Config.CPQ.OpportunityInfo.Services
{
    public class InfoService
    {
        private readonly IMongoCollection<Info> _details;
        public InfoService(IInfoDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _details = database.GetCollection<Info>(settings.InfoCollectionName);
        }
        public List<Info> Get() =>
            _details.Find(detail => true).ToList();

        public Info Get(string id) =>
            _details.Find<Info>(detail => detail.Id == id).FirstOrDefault();
    }
}
