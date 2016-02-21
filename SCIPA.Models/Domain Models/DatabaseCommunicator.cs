using System.Collections.Generic;

namespace SCIPA.Models
{
    public partial class DatabaseCommunicator : IDomainModel
    {
        public DatabaseCommunicator()
        {
            Communicators = new HashSet<Communicator>();
        }

        public int id { get; set; }
        public string connectionString { get; set; }

        public int databaseTypeId { get; set; }

        public virtual ICollection<Communicator> Communicators { get; set; }

        public virtual DatabaseType DatabaseType { get; set; }
    }
}
