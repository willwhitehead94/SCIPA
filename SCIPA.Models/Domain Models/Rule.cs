namespace SCIPA.Models
{
    using System.Collections.Generic;

    public partial class Rule : IDomainModel
    {
        public Rule()
        {
            Commands = new HashSet<Command>();
        }

        public int id { get; set; }

        public int deviceId { get; set; }

        public string ruleText { get; set; }

        public virtual Device Device { get; set; }
        public virtual ICollection<Command> Commands { get; set; }
    }
}
