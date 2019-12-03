using System.Collections.Generic;

namespace Config.CPQ.configPage2.Models
{
    public class Hardware
    {
        
        public IList<WarrantyExtensionBuilding> warrantyExtensionBuildings { get; set; }
       
        public IList<OutOfBandManageability> outOfBandManageabilities { get; set; }
        
        public IList<DIBMisc> dIBMiscs { get; set; }
       
        public IList<DIBHardware> dIBHardwares { get; set; }
        
        public IList<CountryHardwareKit> countryHardwareKit { get; set; }
        
        public string kmatProductID { get; set; }
        
        public string startingPointConfigID { get; set; }
    }
}

public class WarrantyExtensionBuilding
{
    public string value { get; set; }
    public bool isSelected { get; set; }

}

public class OutOfBandManageability
{
    public string value { get; set; }
    public bool isSelected { get; set; }
}

public class DIBMisc
{
    public string value { get; set; }
    public bool isChecked { get; set; }
}

public class DIBHardware
{
    public string value { get; set; }
    public bool isChecked { get; set; }
}

public class CountryHardwareKit
{
    public string value { get; set; }
    public bool isSelected { get; set; }
}
    
