using System;

namespace SCIPA.Models.Resources
{
    public class Value
    {
        public ValueType ValueType { get; set; } = ValueType.String;

        public CommunicatorType CommType { get; set; }

        public DateTime EventTime { get; set; }

        public string NewValue { get; set; }


    }
}
