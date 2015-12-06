using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Alarm
    {
        private bool changesMade;

        private int _id;

        private int _deviceId;

        private int _alarmTypeId;

        private string _value;

        private bool _enabled;

        private bool _currentlyInAlarm;



        public int Id
        {
            get { return _id; }
        }


        public int DeviceId
        {
            get { return _deviceId; }
            set { _deviceId = value; }
        }

        public int AlarmTypeId
        {
            get { return _alarmTypeId; }
            set { _alarmTypeId = value; }
        }

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public bool IsEnabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }

        public bool IsAlarming
        {
            get { return _currentlyInAlarm; }
            set { _currentlyInAlarm = value; }
        }

        public bool ChangesMade
        {
            get { return changesMade; }
            set { changesMade = value; }
        }

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


    }
}
