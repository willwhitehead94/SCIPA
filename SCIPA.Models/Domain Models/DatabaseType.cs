namespace SCIPA.Models
{
    using System.Collections.Generic;

    public partial class DatabaseType : IDomainModel
    {
        public DatabaseType()
        {
            DatabaseCommunicators = new HashSet<DatabaseCommunicator>();
        }

        public int id { get; set; }

        public string databaseType1 { get; set; }

        public virtual ICollection<DatabaseCommunicator> DatabaseCommunicators { get; set; }
    }
}
