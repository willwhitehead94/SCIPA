namespace SCIPA.Models
{
    using System;
    using System.Collections.Generic;

    public partial class Rule
    {
        public int Id { get; set; }
        public int DeviceId { get; set; }
        public string Name { get; set; }
        public ValueType ValueType { get; set; }
        public RuleType RuleType { get; set; }
        public string Constraint { get; set; }
        public bool Alarm { get; set; }

        public virtual Device Device { get; set; }
        public virtual Action Action { get; set; }

        public override string ToString()
        {
            return $"{Id}: {Name} for Device #{DeviceId}";
        }
    }
}
