using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIPA.Models.Resources
{
    public class Value
    {
        public eType ValueType { get; set; } = eType.String;

        public eComm CommType { get; set; }

        public DateTime EventTime { get; set; }

        public string NewValue { get; set; }


    }
}
