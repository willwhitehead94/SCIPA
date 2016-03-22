namespace SCIPA.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Value
    {
        public int Id { get; set; }
        public System.DateTime EventTime { get; set; }
        public string StringValue { get; set; }
        public bool Inbound { get; set; }
        public ValueType Type { get; set; }

        public virtual Device Device { get; set; }
    }
}
