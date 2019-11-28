using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Config.CPQ.Static.Models
{
    public interface IStatDatabaseSettings
    {
       
     string StatCollectionName { get; set; }
     string ConnectionString { get; set; }
     string DatabaseName { get; set; }

    }
}
