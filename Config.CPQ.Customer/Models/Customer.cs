using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace Config.CPQ.Models
{
    public class Customer
    {
        [BsonElement]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("MDCP Organisation ID")]
        public double mdcpId { get; set; }
        [BsonElement("First Name")]
        public String firstName { get; set; }
        [BsonElement("Last Name")]
        public string lastName { get; set; }
        [BsonElement("Email Address")]
        public String emailAddr { get; set; }
        [BsonElement("Telephone Number")]
        public double telNum { get; set; }
        [BsonElement("Ship To Contact")]
        public string shipContact { get; set; }
        [BsonElement("Bill To Contact")]
        public string billContact { get; set; }
        [BsonElement("Ship To Phone No")]
        public double shipPhone { get; set; }
        [BsonElement("Bill To Phone No")]
        public double billPhone { get; set; }
        [BsonElement("Sold To Address")]
        public string soldtoAddress { get; set; }
        [BsonElement("Ship To Address")]
        public shiptoaddr shiptoAddress { get; set; }
        [BsonElement("Bill To Address")]
        public billaddr billtoAddress { get; set; }
        
        
    }
    public class shiptoaddr
    {
        [BsonElement("Ship To")]
        public string shipto { get; set; }
        [BsonElement("Street")]
        public string street { get; set; }
        [BsonElement("City")]
        public string city { get; set; }
        [BsonElement("State")]
        public string state { get; set; }
        [BsonElement("Country")]
        public string country { get; set; }
        [BsonElement("Zip")]
        public int zip { get; set; }
        [BsonElement("Same As Sold To Address")]
        public bool sameasSoldaddress { get; set; }
    }
    public class billaddr
    {
        [BsonElement("Bill Address")]
        public string billaddress { get; set; }
        [BsonElement("Same As Sold To Address")]
        public bool sameasSoldaddress { get; set; }

    }
}
