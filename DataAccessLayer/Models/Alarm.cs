using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Alarm
    {
        public bool changesMade;

        private int _id { get; set; }

        private int _deviceId { get; set; }

        private int _alarmTypeId { get; set; }

        private string _value { get; set; }

        private bool _enabled { get; set; }

        public Alarm(int id,int deviceId,int alarmTypeId,string value,bool enabled)
        {
            _id = id;
            _deviceId = deviceId;
            _alarmTypeId = alarmTypeId;
            _value = value;
            _enabled = enabled;
        }

        public Alarm(string id, string deviceId, string alarmTypeId, string value, string enabled)
        {
            _id = Convert.ToInt32(id) ;
            _deviceId = Convert.ToInt32(deviceId);
            _alarmTypeId = Convert.ToInt32(alarmTypeId);
            _value = value;
            _enabled = Convert.ToBoolean(enabled);
        }

        public int GetId()
        {
            return _id;
        }

        public int GetDeviceId()
        {
            return _deviceId;
        }
    }
}
