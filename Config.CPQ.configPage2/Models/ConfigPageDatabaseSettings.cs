using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Config.CPQ.configPage2.Models
{
    public class ConfigPageDatabaseSettings : IConfigPageDatabaseSettings
    {
         public string SeriesCollectionName { get; set; }
         public string ConfigTabsCollectionName { get; set; }
         public string ConfigCategoryCollectionName { get; set; }
         public string ConfigCollectionName { get; set; }
         public string ConnectionString { get; set; }
         public string DatabaseName { get; set; }
    
    }
}

