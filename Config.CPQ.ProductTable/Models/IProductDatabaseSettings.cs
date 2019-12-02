using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Config.CPQ.ProductTable.Models
{
    public interface IProductDatabaseSettings
    {
        string ProductCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}