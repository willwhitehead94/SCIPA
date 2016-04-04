using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MongoDB.Driver;
using SCIPA.Domain.Generic;
using SCIPA.Domain.Logic;
using SCIPA.Models;

namespace SCIPA.Testing
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Ensures that SCIPA is able to connect to SQL Server.
        /// </summary>
        [TestMethod]
        public void ConnectToSQLServerDatabase()
        {
            var connextionString = @"provider=System.Data.SqlClient;provider connection string=&quot;data source=.;initial catalog=SCIPA;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            var query = "SELECT TOP 5 * FROM [SCIPA].[dbo].[Values]";

            var dcm = new DatabaseConnectionManager(DatabaseType.SQL, Configuration.DefaultConnectionString,query,true);
            dcm.Execute();
        }

        /// <summary>
        /// Ensures that SCIPA is able to connect to MongoDB.
        /// </summary>
        [TestMethod]
        public void ConnectToMongoDBDatabase()
        {
            var connectionString = "mongodb://localhost:27017";
            MongoClient _client = new MongoClient(connectionString);
            IMongoDatabase _db = _client.GetDatabase("SCIPA");
        }
    }
}
