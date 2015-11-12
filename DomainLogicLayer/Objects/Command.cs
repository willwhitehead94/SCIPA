using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DomainLogicLayer.Communicators;

namespace DomainLogicLayer.Objects
{
    class Command
    {
        int Id;
        string Name;
        string Description;
        string ValueToTransmit;
        Communicator Communicator;

        public Command()
        {
            Id = int.MinValue;
            Name = null;
            Description = null;
            ValueToTransmit = null;
            Communicator = null;
        }

        public Command(int Id)
        {
            Service.DebugPrint("Building Command from ID", Id.ToString());
            DownloadCommandInformationFromDatabase(Id);

        }

        /// <summary>
        /// Downloads and sets the general information for this command.
        /// </summary>
        /// <param name="Id">The ID number of the command to download.</param>
        private void DownloadCommandInformationFromDatabase(int Id)
        {
            Service.DebugPrint("Updating information for Command", Id.ToString());

            //Creates new instance of the database handler, and sets-up the connection to the database.
            DatabaseHandler Data = new DatabaseHandler();

            //Executes the required SQL statement to retrieve the required data.
            Data.Execute(string.Format("SELECT TOP 1 Name,Description,ValueToTransmit,CommunicatorId FROM Command WHERE Id = {0}", Id), true);

            //Converts the data from the returned object list to the correct format, and calls the creation
            //of the required objects.
            object[] DatabaseResults = Data.GetResultObject()[0];

            this.Id = Id;
            this.Name = DatabaseResults[0].ToString();
            this.Description = DatabaseResults[1].ToString();
            this.ValueToTransmit = DatabaseResults[2].ToString();
            this.Communicator = null;

            //Attempt to collect the communicator ID, and pass this figure to the Communicator class to
            //have the data downloaded correctly.
            int CommunicatorId = int.MinValue;
            int.TryParse(DatabaseResults[3].ToString(), out CommunicatorId);

            if (CommunicatorId != int.MinValue) { }
            //Communicator = new Communicator(CommunicatorId);
        }

        /// <summary>
        /// Returns the human-readable information for this command. Overrides the generic function.
        /// </summary>
        /// <returns>Name: Description (or "Null Command" when null)</returns>
        public override string ToString()
        {
            string ToReturn = String.Format("{0}: {1}", Name, Description);

            if (Id == int.MinValue)
                ToReturn = "Null Device";

            return ToReturn;
        }
    }
}
