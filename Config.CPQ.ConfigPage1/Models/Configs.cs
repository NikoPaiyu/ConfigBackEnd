using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Config.CPQ.ConfigPage.Models
{
    [BsonIgnoreExtraElements]

    public class Configs
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("ConfigId")]
        public string configId { get; set; }
        [BsonElement("ConfigName")]
        public string configName { get; set; }
        [BsonElement("CreatedByEmail")]
        public string createdByEmail { get; set; }
        [BsonElement("CustomerId")]
        public string customerId { get; set; }
        [BsonElement("Status")]
        public string status { get; set; }
        [BsonElement("Category")]
        public string category { get; set; }
        [BsonElement("Series")]
        public string series { get; set; }
    }
}
