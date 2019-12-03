using MongoDB.Driver;
using System.Collections.Generic;
using System.Linq;
using Config.CPQ.Models;

namespace Config.CPQ.Services
{
    public class CustomerServices
    {
        private readonly IMongoCollection<Customer> _customer;
        public CustomerServices(ICustomerDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            _customer = database.GetCollection<Customer>(settings.CustomerCollectionName);
        }
        public List<Customer> Get() =>
            _customer.Find(customer => true).ToList();
        public Customer Get(string id) =>
           _customer.Find<Customer>(customer => customer.Id == id).FirstOrDefault();
       

    }
}
