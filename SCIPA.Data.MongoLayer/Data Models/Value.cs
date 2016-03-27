using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SCIPA.Data.MongoLayer
{
    public class Value
    {
        [BsonId]
        public ObjectId ObjectId { get; set; }
        public int ValueId { get; set; }
        public System.DateTime EventTime { get; set; }
        public bool Inbound { get; set; }
        public string Type { get; set; }
        public int DeviceId { get; set; }
        public int IntegerValue { get; set; }
        public decimal FloatValue { get; set; }
        public bool BooleanValue { get; set; }
        public string StringValue { get; set; }
    }
}