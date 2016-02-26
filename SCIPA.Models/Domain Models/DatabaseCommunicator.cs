namespace SCIPA.Models
{
    public partial class DatabaseCommunicator : Communicator, IDomainModel
    {
        public int id { get; set; }
        public string connectionString { get; set; }

        public string query { get; set; }

        public int databaseTypeId { get; set; }

        public virtual DatabaseType DatabaseType { get; set; }
    }
}
