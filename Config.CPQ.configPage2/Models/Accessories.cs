using MongoDB.Bson.Serialization.Attributes;

namespace Config.CPQ.configPage2.Models
{
    public class Accessories
    {
        [BsonElement("recommended")]
        public string Recommended { get; set; }

        [BsonElement("partNumber")]
        public string PartNumber { get; set; }

        [BsonElement("description")]
        public string Description { get; set; }

        [BsonElement("isChecked")]
        public bool IsChecked { get; set; }
    }
}