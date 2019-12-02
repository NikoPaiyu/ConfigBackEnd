using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Config.CPQ.configPage2.Models
{
    public interface IConfigPageDatabaseSettings
    {
        string SeriesCollectionName { get; set; }
        string ConfigTabsCollectionName { get; set; }
        string ConfigCategoryCollectionName { get; set; }
        string ConfigCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
