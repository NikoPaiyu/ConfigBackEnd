using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Config.CPQ.configPage2.Models
{
    public class DeploymentServices
    {
       
        public IList<LogisticServiceBasicDeliveryAA> logisticServiceBasicDeliveryAAs { get; set; }

      
        public IList<InstallationServicesAA> installationServicesAAs { get; set; }
    }
}

[BsonIgnoreExtraElements]
public class InstallationServicesAA
{
    public string value { get; set; }
    public bool isSelected { get; set; }
}

[BsonIgnoreExtraElements]
public class LogisticServiceBasicDeliveryAA
{
    public string value { get; set; }
    public bool isSelected { get; set; }
}

   