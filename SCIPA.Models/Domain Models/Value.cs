namespace SCIPA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Value
    {
        public int Id { get; set; }
        public string EventTime { get; set; }
        public string StringValue { get; set; }
        public string Inbound { get; set; }
        public int DeviceId { get; set; }
    
        public virtual Device Device { get; set; }
    }
}