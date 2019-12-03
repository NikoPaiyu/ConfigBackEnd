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
        [BsonElement("Quantity")]
        public int qty { get; set; }
        [BsonElement("productID")]
        public string partnumber { get; set; }
        [BsonElement("Description")]
        
        public string description { get; set; } 
        [BsonElement("listPrice")]
        
       
        public double listprice { get; set; }
        [BsonElement( "stdDisc")]
        
        public double stddiscount { get; set; }
        [BsonElement("stdNetprice")]
        
        public double stdnetprice { get; set; }
        [BsonElement("restDisc")]
        
        public double restdiscount { get; set; }
        [BsonElement("restType")]
       
        public float resttype { get; set; }
         [BsonElement("reqtNet")]
        public double reqtnet { get; set; }
}


}

