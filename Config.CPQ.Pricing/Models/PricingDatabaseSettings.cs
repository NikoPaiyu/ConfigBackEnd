using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Config.CPQ.Pricing.Models
{
    public class PricingDatabaseSettings : IPricingDatabaseSettings
    {
        public string PricingCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
