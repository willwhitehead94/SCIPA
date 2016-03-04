using System;
using System.Dynamic;

namespace SCIPA.Data.AccessLayer.Models
{
    public class Value
    {
        public int Id { get; set; }

        public ValueType ValueType { get; set; } = ValueType.String;

        public CommunicatorType CommType { get; set; }

        public DateTime EventTime { get; set; }

        public string StringValue { get; set; }

        public bool Inbound { get; set; }

        public virtual Device Device { get; set; }
    }
}
