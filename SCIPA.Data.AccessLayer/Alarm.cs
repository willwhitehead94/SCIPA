//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCIPA.Data.AccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alarm
    {
        public int Id { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public int DeviceId { get; set; }
        public int ValueId { get; set; }
        public int RuleId { get; set; }
        public bool Accepted { get; set; }
    }
}
