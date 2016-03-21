namespace SCIPA.Models
{
    using System;
    using System.Collections.Generic;

    public partial class DatabaseCommunicator : Communicator
    {
        public string ConnectionString { get; set; }
        public string Query { get; set; }
        public DatabaseType DbType { get; set; }
    }
}
