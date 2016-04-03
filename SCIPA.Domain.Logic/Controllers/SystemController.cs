using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIPA.Data.Repository;
using SCIPA.Domain.Generic;

namespace SCIPA.Domain.Logic
{
    public class SystemController
    {
        /// <summary>
        /// Reset the SQL Server database.
        /// </summary>
        public void ClearSql()
        {
            RelationalRepository.ClearSql();

            DebugOutput.Print("SQL Service Database dropped successfully.");
        }

        /// <summary>
        /// Reset the MongoDB database.
        /// </summary>
        public void ClearMongo()
        {
            var controller = new MongoRepository();
            controller.ClearMongo();

            DebugOutput.Print("MongoDB Database dropped successfully.");
        }

        /// <summary>
        /// Reset the Log file.
        /// </summary>
        public void ClearLog()
        {
            try { System.IO.File.WriteAllText(Configuration.LogFilePath,"");}
            catch { DebugOutput.Print("Couldn't drop LOG."); return; }

            DebugOutput.Print("LOG dropped successfully.");
        }
    }
}
