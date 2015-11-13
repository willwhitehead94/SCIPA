using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data_Objects
{
    public class Device
    {
        private int id { get; set; }

        private char name { get; set; }

        private bool readOnly { get; set; }

        private int? locationId { get; set; }

        private double? faultTolerance { get; set; }

        private int valueTypeId { get; set; }

        private int lowestValue { get; set; }

        private int highestValue { get; set; }

    }
}
