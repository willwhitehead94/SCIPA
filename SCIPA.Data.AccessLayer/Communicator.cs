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
    
    public partial class Communicator
    {
        public int Id { get; set; }
        public string StartChar { get; set; }
        public string EndChar { get; set; }
        public string LastReadTime { get; set; }
    
        public virtual Device Device { get; set; }
    }
}