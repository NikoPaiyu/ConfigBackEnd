using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Config.CPQ.QuoteOutput.Models
{
    public class DisplayOption
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Quote Number")]
        public string QuoteNumber { get; set; }

        [BsonElement("Quote Title")]
        public string QuoteTitle { get; set; }

        public string Customer { get; set; }

        [BsonElement("Quote status")]
        public string QuoteStatus { get; set; }

       /* [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }*/

        [BsonElement("Output Type")]
        public string OutputType { get; set; }

        [BsonElement("Output Language")]
        public string OutputLanguage { get; set; }

        [BsonElement("Including shipping and frieght")]
        public bool IncludingShippingAndFrieghtCharges { get; set; }

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
