namespace SCIPA.Models
{
    using System;
    using System.Collections.Generic;
    
    public abstract partial class Communicator
    {
        public int Id { get; set; }
        public string StartChar { get; set; }
        public string EndChar { get; set; }
        public string LastReadTime { get; set; }
    
        public virtual Device Device { get; set; }
    }
}
