using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Config.CPQ.configPage2.Models
{
    public class LineType
    {
        
        public Hardware hardware { get; set; }

        
        public IList<Accessories> accessories { get; set; }

        
        public IList<CarePacks> carePacks { get; set; }
      
        public IList<ConfigurationServices> configurationServices { get; set; }
       
        public DeploymentServices deploymentServices { get; set; }
        public BOM BOM { get; set; }

    }
}