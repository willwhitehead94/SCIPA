namespace SCIPA.Models
{
    using System.Collections.Generic;

    public partial class Device : IDomainModel
    {
        public Device()
        {
            Communicators = new HashSet<Communicator>();
            DeviceValues = new HashSet<DeviceValue>();
            Rules = new HashSet<Rule>();

            //Whitehead
            ValueType = new ValueType();
            Location = new Location();
        }

        public int id { get; set; }

        public string name { get; set; }

        public bool readOnly { get; set; }

        public int? locationId { get; set; }

        public string custodian { get; set; }

        public float? faultTolerance { get; set; }

        public int valueTypeId { get; set; }

        public virtual ValueType ValueType { get; set; }

        public int? lowestValue { get; set; }

        public int? highestValue { get; set; }

        public bool enabled { get; set; }

        public virtual Alarm Alarm { get; set; }

        public virtual Command Command { get; set; }

        public virtual Command Command1 { get; set; }

        public virtual ICollection<Communicator> Communicators { get; set; }

        public virtual Location Location { get; set; }

        public virtual ICollection<DeviceValue> DeviceValues { get; set; }

        public virtual ICollection<Rule> Rules { get; set; }
    }
}
