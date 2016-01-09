using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class DeviceValueVM
    {
        private int _id;

        private int _deviceId;

        private DateTime _date;

        private DateTime? _time;

        private string _value;

        private bool _withinTolerance;

        public int Id
        {
            get { return _id; }
        }

        public int DeviceId
        {
            get { return _deviceId; }
            set { _deviceId = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public DateTime? Time
        {
            get { return _time; }
            set { _time = value; }
        }

        public string Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public DeviceValueVM (int id, int deviceId, DateTime date, DateTime? time, string value)
        {
            _id = id;
            DeviceId = deviceId;
            Date = date;
            Time = time;
            Value = value;
        }

        public DeviceValueVM(string id, string deviceId, string date, string time, string value)
        {
            _id = Convert.ToInt32(id);
            DeviceId = Convert.ToInt32(deviceId);
            Date = Convert.ToDateTime(date);
            Time = Convert.ToDateTime(time);
            Value = value;
        }
    }

}
