using Config.CPQ.ConfigPage.Models;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;

namespace Config.CPQ.ConfigPage.Services
{
    public class ConfigService
    {
        private readonly IMongoCollection<Configs> _config;

        public ConfigService(IConfigDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _config = database.GetCollection<Configs>(settings.ConfigCollectionName);
        }

        public List<Configs> Get() =>
            _config.Find(config => true).ToList();

        public Configs Get(string id) =>
            _config.Find<Configs>(config => config.Id == id).FirstOrDefault();

        public List<Configs> Geta(string configid) =>
            _config.Find<Configs>(config => config.configId == configid).ToList();

        public List<Configs> Getb(string configname) =>
              _config.Find<Configs>(config => config.configName == configname).ToList();

        public List<Configs> Getc(string createdbyemail) =>
            _config.Find<Configs>(config => config.createdByEmail == createdbyemail).ToList();

        public List<Configs> Getd(string customerid) =>
            _config.Find<Configs>(config => config.customerId == customerid).ToList();

        public List<Configs> Gete(string category) =>
            _config.Find<Configs>(config => config.category == category).ToList();

        public List<Configs> GetConfigList(string searchText)=>
            _config.Find<Configs>(config => config.configId == searchText|| config.configName == searchText|| config.createdByEmail == searchText|| config.customerId == searchText|| config.category == searchText).ToList();
    
    }
}
