using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using SCIPA.Domain.Generic;
using SCIPA.Models;

namespace SCIPA.Domain.Inbound
{
    public class Inbound
    {
        /// <summary>
        /// The reader of the data.
        /// </summary>
        private DataReader _reader = null;

        /// <summary>
        /// The communicator settings to use as part of the reading
        /// process.
        /// </summary>
        private Communicator _communicator = null;

        /// <summary>
        /// List of devices that have started reading.
        /// </summary>
        private static List<Device> _startedDevices = new List<Device>();

        /// <summary>
        /// Last known value for this Inbound source.
        /// </summary>
        public string LastValue = "";

        /// <summary>
        /// Constructor of the Comm inbound service.
        /// </summary>
        /// <param name="communicator"></param>
        public Inbound(Communicator communicator)
        {
            DebugOutput.Print("Prepared the Communicator for reading. ", communicator.Id.ToString());
            _communicator = communicator;

            Start();

            UpdateActiveDeviceList();
        }

        public void Start()
        {
            Communicator selectedCommunicator = (Communicator)_communicator;
            if (!selectedCommunicator.Inbound) return;

            switch (selectedCommunicator.Type)
            {
                case CommunicatorType.FlatFile:
                    _reader = new FlatFileReader(new FlatFileHandler((FileCommunicator)_communicator));
                    break;
                case CommunicatorType.Serial:
                    _reader = new SerialDataReader(new SerialDataHandler((SerialCommunicator)_communicator));
                    break;
                case CommunicatorType.Database:
                    _reader = new DatabaseReader(new DatabaseHandler((DatabaseCommunicator)_communicator));
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            ThreadPool.QueueUserWorkItem(new WaitCallback(Loop));
        }

        /// <summary>
        /// Repeatedly checks the handler for any unseen values every second.
        /// </summary>
        /// <param name="obj"></param>
        private void Loop(object obj)
        {
            while (true)
            {
                int x = 0;

                while (_reader.AvailableValues() > 0)
                {
                    var val = _reader.GetNextValueAsString();

                    if (val != null)
                        val = val.Trim();

                    LastValue = val; 
                }
                Thread.Sleep(1000);
            }
        }

        /// <summary>
        /// Adds the started device to a list.
        /// </summary>
        private void UpdateActiveDeviceList()
        {
            if (_communicator.Device == null) return;

            //Make sure we only ever add a device object to the list once.
            if (_startedDevices.Count(dev => dev.Id == _communicator.Device.Id) < 1)
            {
                _startedDevices.Add(_communicator.Device);
                Domain.Logic.DeviceController.AddActiveDevice(_communicator.Device);
            }
        }

        /// <summary>
        /// Returns a list of any started devices.
        /// </summary>
        /// <returns></returns>
        public static List<Device> GetStartedDevices()
        {
            return _startedDevices;
        } 
    }
}