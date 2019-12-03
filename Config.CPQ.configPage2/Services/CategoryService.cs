using System.Collections.Generic;
using System.Linq;
using Config.CPQ.configPage2.Models;
using MongoDB.Driver;

namespace Config.CPQ.configPage2.Services
{
    public class CategoryService
    {
        private readonly IMongoCollection<Category> _category;

        public CategoryService(IConfigPageDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _category = database.GetCollection<Category>(settings.ConfigCategoryCollectionName);
        }

        public List<Category> Get() =>
            _category.Find(category => true).ToList();

        public Category Get(int id) =>
            _category.Find<Category>(category => category.categoryId == id).FirstOrDefault();

    }
}
