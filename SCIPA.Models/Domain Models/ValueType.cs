namespace SCIPA.Models
{
    using System.Collections.Generic;

    public partial class ValueType : IDomainModel
    {
        public ValueType()
        {
            Commands = new HashSet<Command>();
            Communicators = new HashSet<Communicator>();
        }

        public int id { get; set; }

        public string type { get; set; }

        public virtual ICollection<Command> Commands { get; set; }

        public virtual ICollection<Communicator> Communicators { get; set; }
    }
}
