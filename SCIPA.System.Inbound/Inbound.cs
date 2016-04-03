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
        private DataReader _reader = null;
        private Communicator _communicator = null;
        private static List<Device> _startedDevices = new List<Device>();

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

        private void Loop(object obj)
        {
            while (true)
            {
                int x = 0;

                while (_reader.AvailableValues() > 0)
                {
                    var newValue = _reader.GetNextValueAsString();
                }
                Thread.Sleep(1000);
            }
        }

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

        public static List<Device> GetStartedDevices()
        {
            return _startedDevices;
        } 
    }
}