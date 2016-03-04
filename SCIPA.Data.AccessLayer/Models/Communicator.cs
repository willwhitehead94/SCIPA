using System;

namespace SCIPA.Data.AccessLayer.Models
{
    public abstract class Communicator
    {
        public int StartChar { get; set; }

        public int EndChar { get; set; }

        public DateTime LastReadTime { get; set; }

        public ValueType ValueValueType { get; set; }
    }
}