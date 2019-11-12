using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Config.CPQ.Pricing.Models
{
       public interface IPricingDatabaseSettings
    {
       
            string PricingCollectionName { get; set; }
            string ConnectionString { get; set; }
            string DatabaseName { get; set; }
        
    }
}
