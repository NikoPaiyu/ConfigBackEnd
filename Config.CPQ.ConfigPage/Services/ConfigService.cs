using Config.CPQ.ConfigPage.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


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
            _config.Find<Configs>(config => config.ConfigId == configid).ToList();

        public List<Configs> Getb(string configname) =>
              _config.Find<Configs>(config => config.ConfigName == configname).ToList();

        public List<Configs> Getc(string createdbyemail) =>
            _config.Find<Configs>(config => config.CreatedByEmail == createdbyemail).ToList();

        public List<Configs> Getd(string customerid) =>
            _config.Find<Configs>(config => config.CustomerId == customerid).ToList();

        public List<Configs> Gete(string category) =>
            _config.Find<Configs>(config => config.Category == category).ToList();

        public List<Configs> GetConfigList(string searchText)=>
            _config.Find<Configs>(config => config.ConfigId == searchText|| config.ConfigName == searchText|| config.CreatedByEmail == searchText|| config.CustomerId == searchText|| config.Category == searchText).ToList();
    
    }
}
