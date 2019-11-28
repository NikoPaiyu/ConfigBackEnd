using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;



namespace Config.CPQ.QuoteSettings.Models
{
    public class Quote
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Deal Type")]
        public string dealType { get; set; }

        [BsonElement("Country")]
        public string country { get; set; }

        [BsonElement("Currency")]
        public string currency { get; set; }

        [BsonElement("INCO Terms")]
        public string incoTerms { get; set; }
    }
}
