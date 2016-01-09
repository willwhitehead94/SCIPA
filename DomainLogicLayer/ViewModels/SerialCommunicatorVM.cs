using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class SerialCommunicatorVM
    {
        private int _id;

        private int _comPort;

        private int _baudRate;

        private byte _dataBits;

        private bool? _isRTS;

        private bool? _isDTR;

        public int Id
        {
            get { return _id; }
        }

        public int ComPort
        {
            get { return _comPort; }
            set { _comPort = value; }
        }

        public int BaudRate
        {
            get { return _baudRate; }
            set { _baudRate = value; }
        }

        public byte DataBits
        {
            get { return _dataBits; }
            set { _dataBits = value; }
        }

        public bool? isRTS
        {
            get { return _isRTS; }
            set { isRTS = value; }
        }

        public bool? isDTR
        {
            get { return _isDTR; }
            set { isDTR = value; }
        }

        public SerialCommunicatorVM(int id, int comPort, int baudRate, byte dataBits, bool? rts = null, bool? dtr = null)
        {
            _id = id;
            ComPort = comPort;
            BaudRate = baudRate;
            DataBits = dataBits;

            isRTS = rts;
            isDTR = dtr;
        }

        public SerialCommunicatorVM(string id, string comPort, string baudRate, string dataBits, string rts = null, string dtr = null)
        {
            _id = Convert.ToInt32(id);
            ComPort = Convert.ToInt32(comPort);
            BaudRate = Convert.ToInt32(baudRate);
            DataBits = Convert.ToByte(dataBits);

            if (rts != null)
            {
                isRTS = Convert.ToBoolean(rts);
            }

            if (dtr != null)
            {
                isDTR = Convert.ToBoolean(dtr);
            }
        }
    }


}
