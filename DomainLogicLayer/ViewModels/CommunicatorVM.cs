using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogicLayer.Models
{
    public class CommunicatorVM
    {
        private int _id;

        private int _deviceId;

        private int _communicatorTypeId;

        private int _subId;

        private int _valueTypeId;

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public int DeviceId
        {
            get
            {
                return _deviceId;
            }

            set
            {
                _deviceId = value;
            }
        }

        public int CommunicatorTypeId
        {
            get
            {
                return _communicatorTypeId;
            }

            set
            {
                _communicatorTypeId = value;
            }
        }

        public int SubId
        {
            get
            {
                return _subId;
            }

            set
            {
                _subId = value;
            }
        }

        public int ValueTypeId
        {
            get
            {
                return _valueTypeId;
            }

            set
            {
                _valueTypeId = value;
            }
        }


        public CommunicatorVM(int id, int deviceId, int communicatorTypeId, int subId, int valueTypeId)
        {
            _id = id;

            DeviceId = deviceId;
            CommunicatorTypeId = communicatorTypeId;
            SubId = subId;
            ValueTypeId = valueTypeId;
        }

        public CommunicatorVM(string id, string deviceId, string communicatorTypeId, string subId, string valueTypeId)
        {
            _id = Convert.ToInt32(id);

            DeviceId = Convert.ToInt32(deviceId);
            CommunicatorTypeId = Convert.ToInt32(communicatorTypeId);
            SubId = Convert.ToInt32(subId);
            ValueTypeId = Convert.ToInt32(valueTypeId);
        }
    }
}
