using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Controllers
{
    /// <summary>
    /// This abstract class is used to define methods that can be used by any of the inheriting Controller objects.
    /// Designed primarily to be a 'resource library' of sorts, for logical testing/database interrigation.
    /// </summary>
    abstract public class Controller
    {
        /// <summary>
        /// Checks whether the ID is already on the database or not. 
        /// </summary>
        /// <param name="id">The id number of the object we intend to check.</param>
        /// <param name="tableName">The name of the table to check against.</param>
        /// <returns>Success/Fail boolean.</returns>
        internal static bool IdExistsOnDatabase(int id, string tableName)
        {
            //Connect to db via a default connection
            DataAccessLayer.DatabaseHandler db = new DatabaseHandler();

            //Request the id field from the database.
            int downloadedValue = int.MinValue;

            string query = string.Format("SELECT [id] FROM [{0}] WHERE id='{1}'", tableName, id);

            db.Execute(query);

            //If the returned value is an integer, then check if that int is the same as the ID
            if (int.TryParse(db.GetSingleValueFromFirstTableInSet(), out downloadedValue))
            {
                if (downloadedValue == id)
                {
                    //If true, then we know the id currently is available on the db.
                    Service.DebugPrint("The object appears to be already stored on the database (ID number was found)");
                    return true;
                }
            }

            //The record did not exist, or returned corrupted. Writable.
            Service.DebugPrint("Unable to find that ID number on the database!");
            return false;
        }

        /// <summary>
        /// Collects the ID number for the latest record on the given table, so long as the table contains an 'id' field.
        /// </summary>
        /// <param name="tableName">The table to investigate on the database.</param>
        /// <returns>If the table does not contain 'id', null is returned. Otherwise, an integer is returned.</returns>
        internal static int? GetLatestId(string tableName)
        {
            string query = string.Format("SELECT MAX(id) FROM [{0}]", tableName);

            int downloadedValue = int.MinValue;

            DatabaseHandler db = new DatabaseHandler();
            bool successfulExecute = db.Execute(query);

            if (successfulExecute)
            {
                if (int.TryParse(db.GetSingleValueFromFirstTableInSet(), out downloadedValue))
                {
                    Service.DebugPrint(string.Format("The current max ID for {0} is {1}", tableName, downloadedValue));
                    return downloadedValue;
                }
                else
                {
                    Service.DebugPrint("No records found. New records will be created at 0.");
                    return 0;
                }
            }
            else
            {
                Service.DebugPrint(string.Format("Unable to find the max ID for {0}", tableName));
                return null;
            }
        
        }
    }
}
