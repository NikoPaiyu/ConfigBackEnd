using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Config.CPQ.QuoteOutput.Models
{
    public class DisplayOption
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Quote Number")]
        public string QuoteNumber { get; set; }
        public IList<lang> languages { get; set; }
        public IList<outputType> outType { get; set; }

        [BsonElement("Including Shipping and Freight Charges")]
        public bool IncludingShippingAndFreightCharges { get; set; }

        [BsonElement("Include Tax")]
        public bool IncludeTax { get; set; }

        [BsonElement("Hide Bundle Components")]
        public bool HideBundleComponents { get; set; }

        [BsonElement("Show Eclipse ID")]
        public bool ShowEclipseID { get; set; }

        [BsonElement("Show Master Deal ID")]
        public bool ShowMasterDealID { get; set; }
    }

}
