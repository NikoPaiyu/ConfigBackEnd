using MongoDB.Bson.Serialization.Attributes;

namespace Config.CPQ.configPage2.Models
{
    public class CarePacks
    {
        [BsonElement("partNumber")]
        public string PartNumber { get; set; }
        public string description { get; set; }
        public bool isChecked { get; set; }
        public bool isRecommended { get; set; }
    }
}