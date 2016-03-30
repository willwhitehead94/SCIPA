using System;
using System.Threading;
using SCIPA.Domain.Generic;
using SCIPA.Models;

namespace SCIPA.Domain.Inbound
{
    public class Inbound
    {
        private DataReader _reader = null;
        private Communicator _communicator = null;

        public Inbound(Communicator communicator)
        {
            DebugOutput.Print("Prepared the Communicator for reading. ", communicator.Id.ToString());
            _communicator = communicator;
        }

        public void Start()
        {
            Communicator selectedCommunicator = (Communicator)_communicator;

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
                while (_reader.AvailableValues() > 0)
                {
                    var newValue = _reader.GetNextValueAsString();
                }
                Thread.Sleep(1000);
            }
        }
    }
}