using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace SCIPA.Data.MongoLayer
{
    public class Process
    {
        public Process()
        {
            Values = new List<Value>();
        }

        [BsonId]
        public ObjectId ObjectId { get; set; }

        [BsonElement("DeviceId")]
        public int DeviceId { get; set; }

        [BsonElement("DeviceName")]
        public string Name { get; set; }

        [BsonElement("DeviceLocation")]
        public string Location { get; set; }

        [BsonElement("DeviceCustodian")]
        public string Custodian { get; set; }

        [BsonElement("DeviceEnabled")]
        public bool Enabled { get; set; }

        [BsonElement("DeviceValues")]
        public IEnumerable<Value> Values { get; set; }
    }
}
