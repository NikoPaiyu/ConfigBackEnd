using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Confiq.Cpq.Line.Models
{
    public class Products
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
         public string Id { get; set; }
         public string productID { get; set; }
         public double listPrice { get; set; }
         public string Description { get; set; }
    }
}
