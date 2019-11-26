using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Confiq.Cpq.Line.Models
{
    public class Lines
    {

        [BsonId]
        //[BsonIgnoreIfDefault]
        [BsonRepresentation(BsonType.ObjectId)]
        
        public string Id { get; set; }
        [BsonElement("Quote Number")]
        public string quoteNumber { get; set; }
        [BsonElement("Line Number")]
        public double lineNumber {
            get;
            set;
        }
       
        public int Quantity { get; set; }
        [BsonElement("Part Number")]
        public string partNumber { get; set; }
        public string Description { get; set; } 
        [BsonElement("List Price")]
        public double listPrice { get; set; }
        [BsonElement("Standard Discount Percent")]
        public double stdDisc { get; set; }
        [BsonElement("Standard Net Price")]
        public double stdNetprice { get; set; }
        [BsonElement("Rest Discount")]
        public double restDisc { get; set; }
        [BsonElement("Rest Type Percent")]
        public float restType { get; set; }
        [BsonElement("Reqt Net")]
        public double reqtNet { get; set; }
        
}


}

