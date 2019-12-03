using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace Confiq.Cpq.Line.Models
{
    public class Header
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public IList<headers> colDef { get; set; }
    }

    public class headers
    {
        public string headerName { get; set; }
        public string field { get; set; }
        public bool sortable { get; set; }
        public bool editable { get; set; }
        public string cellEditor { get; set; }

    }
}
