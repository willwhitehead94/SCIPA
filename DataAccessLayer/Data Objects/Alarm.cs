using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data_Objects
{
    public class Alarm
    {
        private int id { get; set; }

        private int deviceId { get; set; }

        private int alarmTypeId { get; set; }

        private char value { get; set; }

    }
}
