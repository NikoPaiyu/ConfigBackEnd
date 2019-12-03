using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Config.CPQ.ProductTable.Models;
using MongoDB.Driver;


namespace Config.ProductTable.Services
{
    public class ProductServices
    {
        private readonly IMongoCollection<Product> _productsettings;
        public ProductServices(IProductDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _productsettings = database.GetCollection<Product>(settings.ProductCollectionName);
        }
        public List<Product> Get() =>
           _productsettings.Find(product => true).ToList();

        public Product Get(string id) =>
            _productsettings.Find<Product>(product => product.Id == id).FirstOrDefault();

        public List<Product> GetProductList(string searchText) =>
            _productsettings.Find<Product>(product => product.ProductID == searchText || product.ProductDescription == searchText).ToList();

    }
}
