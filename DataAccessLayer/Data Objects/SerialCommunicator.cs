using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Data_Objects
{
    public class SerialCommunicator
    {
        private int id { get; set; }

        private int comPort { get; set; }

        private int baudRate { get; set; }

        private byte dataBits { get; set; }

        private bool? isRTS { get; set; }

        private bool? isDTR { get; set; }

    }

}
