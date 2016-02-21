namespace SCIPA.Models
{
    using System.Collections.Generic;
    public partial class CommunicatorType : IDomainModel
    {
        public CommunicatorType()
        {
            Communicators = new HashSet<Communicator>();
        }

        public int id { get; set; }

        public string communicatorType1 { get; set; }

        public virtual ICollection<Communicator> Communicators { get; set; }
    }
}
