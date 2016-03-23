namespace SCIPA.Models
{
    using System;
    using System.Collections.Generic;

    public abstract partial class Communicator
    {
        public int Id { get; set; }
        public int StartChar { get; set; }
        public int EndChar { get; set; }
        public System.DateTime LastReadTime { get; set; } = new DateTime(1980, 01, 01);
        public CommunicatorType Type { get; set; }
        public ValueType ValueType { get; set; }
        public bool Inbound { get; set; }

        public virtual Device Device { get; set; }
    }
}
