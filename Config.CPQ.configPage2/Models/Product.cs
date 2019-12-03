﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Config.CPQ.configPage2.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string partNumber { get; set; }

        public string Description { get; set; }
        public double listPrice { get; set; }
    }
}
