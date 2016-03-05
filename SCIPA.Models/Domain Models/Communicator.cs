using System;

namespace SCIPA.Models
{
    public abstract class Communicator
    {
        public int StartChar { get; set; }

        public int EndChar { get; set; }

        public DateTime LastReadTime { get; set; }

        public ValueType ValueValueType { get; set; }

        public virtual Device Device { get; set; }
    }
}