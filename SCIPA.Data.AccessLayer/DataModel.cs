namespace SCIPA.Data.AccessLayer
{
    using System;
    using System.Data.Entity;
    using SCIPA.Data.AccessLayer.Models;
    using System.Linq;

    public class DataModel : DbContext
    {
        // Your context has been configured to use a 'dataModel' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'SCIPA.Data.AccessLayer.dataModel' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'dataModel' 
        // connection string in the application configuration file.
        public DataModel()
            : base("name=dataModel")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Models.Action> Actions { get; set; }

        public virtual DbSet<ApplicationInformation> ApplicationInformation { get; set; }

        public virtual DbSet<DatabaseCommunicator> DatabaseCommunicators { get; set; }

        public virtual DbSet<SerialCommunicator> SerialCommunicators { get; set; }

        public virtual DbSet<FileCommunicator> FileCommunicators { get; set; }

        public virtual DbSet<Device> Devices { get; set; }

        public virtual DbSet<Rule> Rules { get; set; }

        public virtual  DbSet<Value> Values { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}