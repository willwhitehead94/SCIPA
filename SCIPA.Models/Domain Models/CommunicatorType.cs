namespace SCIPA.Models
{
    using System.Collections.Generic;
    public partial class CommunicatorType : IDomainModel
    {
        public CommunicatorType()
        {
            Communicators = new HashSet<CommunicatorModel>();
        }

        public int id { get; set; }

        public string communicatorType1 { get; set; }

        public virtual ICollection<CommunicatorModel> Communicators { get; set; }
    }
}
