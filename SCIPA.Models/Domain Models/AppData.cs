namespace SCIPA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AppData
    {
        public string BusinessName { get; set; }
        public string Supervisor { get; set; }
        public string Enabled { get; set; }
        public System.Guid Instance { get; set; }
    }
}
