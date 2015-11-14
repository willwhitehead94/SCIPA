using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DomainLogicLayer.Communicators
{
    public class SerialCommunicator : Communicator
    {
        private SerialPort SPort;
        private string PortName;
        private int BaudRate;
        private Parity Parity;
        private int DataBits;
        private StopBits StopBits;
        private bool? RTS;
        private bool? DTR;

        private static ICollection<SerialCommunicator> SerialCommunicators;

        public SerialCommunicator()
        {

        }

        public SerialCommunicator(int Id)
        {
            //DownloadCommunicatorInformationFromDatabase(Id);
            SPort = CheckSerialPort();
        }

        private SerialCommunicator(string PortName, int BaudRate, Parity Parity, int DataBits, StopBits StopBits, bool RTS, bool DTR)
        {
            this.PortName = PortName;
            this.BaudRate = BaudRate;
            this.Parity = Parity;
            this.DataBits = DataBits;
            this.StopBits = StopBits;
            this.RTS = RTS;
            this.DTR = DTR;
            SPort = new SerialPort(PortName, BaudRate, Parity, DataBits, StopBits);
        }

        private SerialCommunicator(string PortName, int BaudRate, Parity Parity, int DataBits)
        {
            this.PortName = PortName;
            this.BaudRate = BaudRate;
            this.Parity = Parity;
            this.DataBits = DataBits;
            SPort = new SerialPort(PortName, BaudRate, Parity, DataBits);
        }

        private SerialCommunicator(string PortName, int BaudRate, Parity Parity)
        {
            this.PortName = PortName;
            this.BaudRate = BaudRate;
            this.Parity = Parity;
            SPort = new SerialPort(PortName, BaudRate, Parity);
        }

        private SerialCommunicator(string PortName, int BaudRate)
        {
            this.PortName = PortName;
            this.BaudRate = BaudRate;
            SPort = new SerialPort(PortName, BaudRate);
        }

        private SerialCommunicator(string PortName)
        {
            this.PortName = PortName;
            SPort = new SerialPort(PortName);
        }

        public void DownloadAllCommunicatorsFromDatabase()
        {
            List<SerialCommunicator> TempList = new List<SerialCommunicator>();

            foreach (int IdNumber in GetSerialCommunicatorIdsFromDatabase())
            {
                TempList.Add(new SerialCommunicator()); //DownloadAllCommunicatorsFromDatabase(IdNumber)
            }
        }

        protected override void DownloadCommunicatorInformationFromDatabase(int Id)
        {
            throw new NotImplementedException();

            string PortName;
            int BaudRate;
            Parity Parity;
            int DataBits;
            StopBits StopBits;
            bool? RTS;
            bool? DTR;

            //Creates a default based database handler
            DatabaseHandler DatabaseConnection = new DatabaseHandler();

            //Download all data for that Id number
            DatabaseConnection.Execute(string.Format("SELECT TOP 1 * FROM SerialCommunicator WHERE Id={0}", Id));

            //Assign data to objects
            //DatabaseConnection.GetResultLists();
        }

        private List<int> GetSerialCommunicatorIdsFromDatabase()
        {
            //Connect to database

            //Download list of serial communicator objects from database

            //Return the list of IDs to caller
            return new List<int>();
        }

        /// <summary>
        /// Using the details downloaded for this serial communicator, this method checks the SPort object 
        /// and attempts to set the DTR and RTS.
        /// Port is quickly opened and closed to ensure it's operational. If port won't open, creation fails.
        /// </summary>
        /// <returns>A fully prepared Serial Port or null object if that is not possible.</returns>
        private SerialPort CheckSerialPort()
        {
            SerialPort SerialConnectionObject = null;
            bool CreationFailed = false;

            switch (SerialConnectionObject.IsOpen)
            {
                case true:
                    //Where the serial port is already open...
                    return SPort;
                    break;
                case false:
                    //Where the serial port is closed...
                    try
                    {
                        SPort.Open();
                        SPort.Close();
                        return SPort;
                    }
                    catch
                    {
                        SPort.Close();
                        return null;
                    }
                    break;
                default:
                    //Where the serial port open state is unknown or is returned incorrectly...
                    Service.DebugPrint("Something went wrong when checking the serial port", SPort.ToString());
                    return null;
                    break;
            }


            //try
            //{
            //    SerialConnectionObject = SPort;

            //    if (this.DTR != null)
            //        SerialConnectionObject.DtrEnable = (bool)DTR;

            //    if (this.RTS != null)
            //        SerialConnectionObject.RtsEnable = (bool)RTS;
            //}
            //catch
            //{
            //    SerialConnectionObject = null;
            //    CreationFailed = true;
            //    return null;
            //}

            //Service.DebugPrint("A serial port has been successfully created; about to test the object", SPort.ToString());

            //try { SPort.Open(); }
            //catch { Service.DebugPrint("Serial port failed to open during the initial test. Returning null."); CreationFailed = true; }
            //finally { SPort.Close(); }

            //if (CreationFailed)
            //    return null;
            //else
            //{
            //    SPort = SerialConnectionObject;
            //    return SerialConnectionObject;
            //}

        }
    }
}
