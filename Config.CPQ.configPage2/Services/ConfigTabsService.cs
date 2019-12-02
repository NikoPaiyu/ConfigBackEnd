using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Config.CPQ.configPage2.Models;
using MongoDB.Driver;

namespace Config.CPQ.configPage2.Services
{
    public class ConfigTabsService
    {
        private readonly IMongoCollection<ConfigTabs> _configs;

        public ConfigTabsService(IConfigPageDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _configs = database.GetCollection<ConfigTabs>(settings.ConfigTabsCollectionName);
        }

        public List<ConfigTabs> Get() =>
            _configs.Find(config => true).ToList();

        public List<ConfigTabs> Get(string config) =>
            _configs.Find<ConfigTabs>(config1 => config1.config == config).ToList();
    }
}

