using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer.Models
{
    public class Command
    {
        private int _id;

        private int _deviceId;

        private int _commandTypeId;

        private int _communicatorId;

        private string _commandText;

        private int _returnValueTypeId;

        private bool _enabled;


        public int Id
        {
            get { return _id; }
        }

        public int DeviceId
        {
            get { return _deviceId; }
            set { _deviceId = value; }
        }

        public int CommandTypeId
        {
            get { return _commandTypeId; }
            set { _commandTypeId = value; }
        }

        public int CommunicatorId
        {
            get { return _communicatorId; }
            set { _communicatorId = value; }
        }

        public string CommandText
        {
            get { return _commandText; }
            set { _commandText = value; }
        }

        public int ReturnValueTypeId
        {
            get { return _returnValueTypeId; }
            set { _returnValueTypeId = value; }
        }

        public bool Enabled
        {
            get { return _enabled;}
            set { _enabled = value; }
        }

        public Command (int id, int deviceId, int commandTypeId, int communicatorId, string commandText, int returnValueTypeId, bool enabled)
        {
            _id = id;
            _deviceId = deviceId;
            _commandTypeId = commandTypeId;
            _commandText = commandText;
            _returnValueTypeId = returnValueTypeId;
            _enabled = enabled;
        }

        public Command(string id, string deviceId, string commandTypeId, string communicatorId, string commandText, string returnValueTypeId, string enabled)
        {
            _id = Convert.ToInt32(id);
            _deviceId = Convert.ToInt32(deviceId);
            _commandTypeId = Convert.ToInt32(commandTypeId);
            _commandText = commandText;
            _returnValueTypeId = Convert.ToInt32(returnValueTypeId);
            _enabled = Convert.ToBoolean(enabled);
        }

    }
}
