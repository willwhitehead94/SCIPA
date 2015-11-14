using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class DeviceValue
    {
        private int id { get; set; }

        private int deviceId { get; set; }

        private DateTime date { get; set; }

        private TimeSpan? time { get; set; }

        private char value { get; set; }

        private bool withinTolerance { get; set; }

    }

}
