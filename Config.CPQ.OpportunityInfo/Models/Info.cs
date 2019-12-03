using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Config.CPQ.OpportunityInfo.Models
{
    public class Info
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public Qdet QDetails { get; set; }
        public Sales HPSales { get; set; }
        public Regis Registration { get; set; }
    }

    public class Qdet
    {
        
        [BsonElement("Quote Title")]
        public string quoteTitle { get; set; }
        [BsonElement("Quote Name")]
        public string quoteName { get; set; }
        [BsonElement("Opportunity ID")]
        public string opportunityId { get; set; }
        [BsonElement("Quote Version")]
        public double quoteVersion { get; set; }
        [BsonElement("Completion Date")]
        public string completionDate { get; set; }
    }

    public class Sales
    {
        [BsonElement("Customer Sales Rep")]
        public string customersalesRep { get; set; }
        [BsonElement("Partner Sales Rep")]
        public string partnersalesrep { get; set; }
    }

    public class Regis
    {
        [BsonElement("Deal ID")]
        public string dealId { get; set; }
        [BsonElement("Deal Name")]
        public string dealName { get; set; }
        [BsonElement("Deal Expiration Date")]
        public string dealexpirationDate { get; set; }
        [BsonElement("Deal Registration Status")]
        public string dealregistrationStatus { get; set; }
        [BsonElement("Create On")]
        public string createOn { get; set; }
        [BsonElement("Created By")]
        public string createdBy { get; set; }
        [BsonElement("Modified On")]
        public string modifiedOn { get; set; }
        [BsonElement("Last Modified By")]
        public string lastmodifiedBy { get; set; }
    }
}
