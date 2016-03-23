namespace SCIPA.Models
{
    using System;
    using System.Collections.Generic;

    public abstract partial class Communicator
    {
        public int Id { get; set; }
        public int StartChar { get; set; }
        public int EndChar { get; set; }
        public System.DateTime LastReadTime { get; set; }
        public CommunicatorType Type { get; set; }
        public ValueType ValueType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual IEnumerable<Device> Device { get; set; }
    }
}
