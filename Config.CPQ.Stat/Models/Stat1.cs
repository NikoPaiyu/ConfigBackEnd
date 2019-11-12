using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;



namespace Config.CPQ.Static.Models
{
    public class Stat1
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Quote Number")]
        public string QuoteNumber { get; set; }

        [BsonElement("Quote Title")]
        public string QuoteTitle { get; set; }

        [BsonElement("Customer")]
        public string Customer { get; set; }

        [BsonElement("Quote Status")]
        public string QuoteStatus { get; set; }
    }
}