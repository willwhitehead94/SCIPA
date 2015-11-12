using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DomainLogicLayer.Communicators
{
    public class DatabaseCommunicator : Communicator
    {
        public DatabaseCommunicator()
        {
            Service.DebugPrint("test new comm");
        }

        public DatabaseCommunicator(int Id)
        {
            DownloadCommunicatorInformationFromDatabase(Id);
        }

        /// <summary>
        /// Downloads and sets the general information for this communicator.
        /// </summary>
        /// <param name = "Id" > The ID number of the communicator to download.</param>
        protected override void DownloadCommunicatorInformationFromDatabase(int Id)
        {
            Service.DebugPrint("Updating information for Communicator", Id.ToString());

            //Creates new instance of the database handler, and sets-up the connection to the database.
            DatabaseHandler Data = new DatabaseHandler();

            //Executes the required SQL statement to retrieve the required data.
            Data.Execute(string.Format("SELECT TOP 1 Name,Description,ValueToTransmit,CommunicatorId FROM Command WHERE Id = {0}", Id), true);

            //Converts the data from the returned object list to the correct format, and calls the creation
            //of the required objects.
            object[] DatabaseResults = Data.GetResultObject()[0];

            this.Id = Id;
            //this.Name = DatabaseResults[0].ToString();
            //this.Description = DatabaseResults[1].ToString();
            //this.ValueToTransmit = DatabaseResults[2].ToString();
            //this.Communicator = null;

            //Attempt to collect the communicator ID, and pass this figure to the Communicator class to
            //have the data downloaded correctly.
            //int CommunicatorId = int.MinValue;
            //int.TryParse(DatabaseResults[3].ToString(), out CommunicatorId);

            //if (CommunicatorId != int.MinValue)
            //    Communicator = new Communicator(CommunicatorId);
        }
    }
}
