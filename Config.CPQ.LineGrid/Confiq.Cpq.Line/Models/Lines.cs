using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Confiq.Cpq.Line.Models
{
    public class Lines
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string quoteNumber { get; set; }
        public int Quantity { get; set; }
        public string productID { get; set; }
        public string Description { get; set; } 
        public double listPrice { get; set; }
        public double stdDisc { get; set; }
        public double stdNetprice { get; set; }
        public double restDisc { get; set; }
        public float restType { get; set; }
        public double reqtNet { get; set; }
}


}

