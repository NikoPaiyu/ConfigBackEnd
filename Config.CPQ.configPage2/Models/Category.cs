using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Config.CPQ.configPage2.Models
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public int categoryId { get; set; }
        public string name { get; set; }

    }
}
