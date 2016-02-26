using System.Collections.Generic;

namespace SCIPA.Models
{
    public partial class DatabaseCommunicator : Communicator, IDomainModel
    {
        public DatabaseCommunicator()
        {
            Communicators = new HashSet<CommunicatorModel>();
        }

        public int id { get; set; }
        public string connectionString { get; set; }

        public string query { get; set; }

        public int databaseTypeId { get; set; }

        public virtual ICollection<CommunicatorModel> Communicators { get; set; }

        public virtual DatabaseTechnologyType DatabaseType { get; set; }
    }
}
