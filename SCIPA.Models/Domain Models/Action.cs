namespace SCIPA.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Action
    {
        public int Id { get; set; }
        public string OutputValue { get; set; }
        public int DeviceId { get; set; }

        public virtual Device Device { get; set; }
    }
}
