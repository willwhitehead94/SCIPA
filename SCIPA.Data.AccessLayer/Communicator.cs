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
    
    public abstract partial class Communicator
    {
        public int Id { get; set; }
        public int StartChar { get; set; }
        public int EndChar { get; set; }
        public System.DateTime LastReadTime { get; set; }
        public CommunicatorType Type { get; set; }
        public ValueType ValueType { get; set; }
    
        public virtual Device Device { get; set; }
    }
}
