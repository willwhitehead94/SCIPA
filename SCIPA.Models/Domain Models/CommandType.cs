namespace SCIPA.Models
{
    using System.Collections.Generic;

    public partial class CommandType : IDomainModel
    {
        public CommandType()
        {
            Commands = new HashSet<Command>();
        }

        public int id { get; set; }

        public string commandType1 { get; set; }

        public virtual ICollection<Command> Commands { get; set; }
    }
}
