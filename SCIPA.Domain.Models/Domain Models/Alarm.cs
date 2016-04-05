namespace SCIPA.Models
{
    public partial class Alarm
    {
        public int Id { get; set; }
        public System.DateTime TimeStamp { get; set; }
        public int DeviceId { get; set; }
        public int ValueId { get; set; }
        public int RuleId { get; set; }
        public bool Accepted { get; set; }

        public virtual Device Device { get; set; }
        public virtual Value Value { get; set; }
        public virtual Rule Rule { get; set; }

        public override string ToString()
        {
            var active = Accepted ? "(Acknowledged)" : "(Active)";
            return $"{Id}: {TimeStamp} {active}";
        }
    }
}