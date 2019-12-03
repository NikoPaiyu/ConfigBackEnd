using System.Collections.Generic;

namespace Config.CPQ.configPage2.Models
{
    public class ConfigurationServices
    {
        public IList<Customer> customers { get; set; }
    }
}

public class Customer
{
    public string value { get; set; }
    public bool isSelected { get; set; }
}
    
