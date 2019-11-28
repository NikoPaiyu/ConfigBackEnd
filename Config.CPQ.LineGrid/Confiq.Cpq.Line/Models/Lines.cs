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
        public int qty { get; set; }
        public string partnumber { get; set; }
        public string description { get; set; } 
        public double listprice { get; set; }
        public double stddiscount { get; set; }
        public double stdnetprice { get; set; }
        public double restdiscount { get; set; }
        public float resttype { get; set; }
        public double reqtnet { get; set; }
}


}

