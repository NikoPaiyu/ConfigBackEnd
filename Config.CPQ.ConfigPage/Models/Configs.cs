using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Config.CPQ.ConfigPage.Models
{
    public class Configs
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string ConfigId { get; set; }
        public string ConfigName { get; set; }
        public string CreatedByEmail { get; set; }
        public string CustomerId { get; set; }
        public string Status { get; set; }
        public string Category { get; set; }
        public string Series { get; set; }
    }
}
