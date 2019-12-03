using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;



namespace Config.CPQ.Pricing.Models
{
    public class Pricing
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Currency")]
        public string currency { get; set; }

        [BsonElement("Geo")]
        public string geo { get; set; }

        [BsonElement("Terms nof Delivery")]
        public string   TermsOfDelivery { get; set; }

        [BsonElement("Use Default Price Descriptor")]
        public bool UseDefaultPriceDescriptor { get; set; }

        [BsonElement("List Price Only Quote")]
        public bool ListPriceOnlyQuote { get; set;}


    }
}
