using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Config.CPQ.configPage2.Models
{
    public class ConfigTabs
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public int seriesId { get; set; }
        public string config { get; set; }
        public LineType linetype { get; set; }

    }
}
