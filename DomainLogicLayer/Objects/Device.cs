using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DomainLogicLayer.Objects
{
    class Device
    {
        /// <summary>
        /// The identifying integer for this device as defined by the database.
        /// </summary>
        int Id;

        /// <summary>
        /// The device's Human-friendly name.
        /// </summary>
        string Name;

        /// <summary>
        /// A brief description of this device.
        /// </summary>
        string Description;

        /// <summary>
        /// The physical real-world location of this device.
        /// </summary>
        Location Location;

        /// <summary>
        /// The 'rules' associated with this device. The rules/conditions imposed upon this device during the process.
        /// See the Rule class for a description.
        /// </summary>
        List<Rule> Rules = new List<Rule>();

        /// <summary>
        /// The 'commands' assiciated with this device. The options available to the process for this device.
        /// See the Command class for a description.
        /// </summary>
        List<Command> Commands = new List<Command>();

        /// <summary>
        /// The last value known for this device.
        /// </summary>
        string MostRecentValue;

        /// <summary>
        /// The current state of the device.
        /// </summary>
        string CurrentState;

        /// <summary>
        /// Constructor to create a generic, unused Device object. All internal variables are null.
        /// </summary>
        public Device()
        {
            Id = int.MinValue;
            Name = null;
            Description = null;
            Location = null;
            Rules = null;
            Commands = null;
            MostRecentValue = null;
            CurrentState = null;
        }

        /// <summary>
        /// Constructor to create a new Device object that will connect to the database and download
        /// all required data via the Device's Id number.
        /// </summary>
        /// <param name="Id">Used to determine the device, and thus, to download all the relevant data.</param>
        public Device(int Id)
        {
            Service.DebugPrint("Building Device from ID", Id.ToString());

            DownloadDeviceInformationFromDatabase(Id);
            DownloadCommandInformationFromDatabase(Id);
            DownloadRuleInformationFromDatabase(Id);
        }

        /// <summary>
        /// Downloads and sets the local variables with the general information for this device.
        /// </summary>
        /// <param name="Id">The ID number of the device to download.</param>
        private void DownloadDeviceInformationFromDatabase(int Id)
        {
            Service.DebugPrint("Updating general information for Device", Id.ToString());

            //Creates new instance of the database handler, and sets-up the connection to the database.
            DatabaseHandler Data = new DatabaseHandler(DatabaseType.SQL, DataAccessLayer.Properties.Settings.Default.DefaultDatabaseConnectionString);

            //Executes the required SQL statement to retrieve the required data.
            Data.Execute(string.Format("SELECT TOP 1 Id,Name,Description FROM Device WHERE Id = {0}", Id), true);

            //Converts the data from the returned object list to the correct format, and updates
            //local variables as required.
            object[] DatabaseResults = Data.GetResultObject()[0];

            int.TryParse(DatabaseResults[0].ToString(), out this.Id); ///Id
            this.Name = DatabaseResults[1].ToString(); //Name
            this.Description = DatabaseResults[2].ToString(); //Description

            //Passes the Id of the device to the Location class so that it can retrieve it's own data, as required.
            this.Location = new Location(Id);
        }

        /// <summary>
        /// Downloads and sets the command information for this device.
        /// </summary>
        /// <param name="Id">The ID number of the device to download.</param>
        private void DownloadCommandInformationFromDatabase(int Id)
        {
            Service.DebugPrint("Updating command information for Device", Id.ToString());

            //Creates new instance of the database handler, and sets-up the connection to the database.
            DatabaseHandler Data = new DatabaseHandler();

            //Executes the required SQL statement to retrieve the required data.
            Data.Execute(string.Format("SELECT Id FROM Command WHERE DeviceId = {0}", Id), true);

            //Converts the data from the returned object list to the correct format, and calls the creation
            //of the required objects.
            foreach (object[] CommandRecord in Data.GetResultObject())
            {
                int TempCommandId = int.MinValue;
                int.TryParse(CommandRecord[0].ToString(), out TempCommandId);

                if (TempCommandId != int.MinValue)
                {
                    Commands.Add(new Command(TempCommandId));
                }
            }
        }

        /// <summary>
        /// Downloads and sets the rule information for this device.
        /// </summary>
        /// <param name="Id">The ID number of the device to download.</param>
        private void DownloadRuleInformationFromDatabase(int Id)
        {
            Service.DebugPrint("Updating rule information for Device", Id.ToString());

            //Creates new instance of the database handler, and sets-up the connection to the database.
            DatabaseHandler Data = new DatabaseHandler();

            //Executes the required SQL statement to retrieve the required data.
            Data.Execute(string.Format("SELECT Id FROM Rule WHERE DeviceId = {0}", Id), true);

            //Converts the data from the returned object list to the correct format, and calls the creation
            //of the required objects.
            foreach (object[] RuleRecord in Data.GetResultObject())
            {
                int TempRuleRecordId = int.MinValue;
                int.TryParse(RuleRecord[0].ToString(), out TempRuleRecordId);

                if (TempRuleRecordId != int.MinValue)
                {
                    Rules.Add(new Rule(TempRuleRecordId));
                }
            }
        }

        /// <summary>
        /// Basic method to return the last known value for this device.
        /// </summary>
        /// <returns>String representation of the last known value.</returns>
        public string GetLastKnownValue()
        {
            return MostRecentValue;
        }

        /// <summary>
        /// Returns the human-readable information for this device. Overrides the generic function.
        /// </summary>
        /// <returns>Name: Description (or "Null Device" when null)</returns>
        public override string ToString()
        {
            string ToReturn = String.Format("{0}: {1}", Name, Description);

            if (Id == int.MinValue)
                ToReturn = "Null Device";

            return ToReturn;
        }
    }
}
