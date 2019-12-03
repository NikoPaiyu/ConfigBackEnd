using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Config.CPQ.ProductTable.Models
{
    public class ProductDatabaseSettings : IProductDatabaseSettings
    {
        public string ProductCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}