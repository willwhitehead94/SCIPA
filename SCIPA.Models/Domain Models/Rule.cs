namespace SCIPA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rule
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
    
        public virtual Device Device { get; set; }
    }
}
