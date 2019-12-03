using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;



namespace Config.CPQ.ProductTable.Models
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string ProductNumber { get; set; }
        public string ProductID { get; set; }
        public string UnitListAmount { get; set; }
        public string ProductLine { get; set; }
        public string ProductDescription { get; set; }
        public string LineType { get; set; }
        public string SRT { get; set; }
        public string avail { get; set; }
        public double disco { get; set; }
        public double obsolete { get; set; }
        public string eol { get; set; }
    }
}
