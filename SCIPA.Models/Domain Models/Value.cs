namespace SCIPA.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Value
    {
        public int Id { get; set; }
        public System.DateTime EventTime { get; set; }
        public bool Inbound { get; set; }
        public ValueType Type { get; set; }
        public int DeviceId { get; set; }
        public Device Device { get; set; }
        public int CommunicatorId { get; set; }
        public int IntegerValue { get; set; }
        public decimal FloatValue { get; set; }
        public bool BooleanValue { get; set; }
        public string StringValue { get; set; }
    }
}
