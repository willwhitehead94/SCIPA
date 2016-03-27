using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SCIPA.Data.MongoLayer
{
    public class Device
    {
        [BsonId]
        public ObjectId ObjectId { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Custodian { get; set; }
        public bool Enabled { get; set; }
    }
}