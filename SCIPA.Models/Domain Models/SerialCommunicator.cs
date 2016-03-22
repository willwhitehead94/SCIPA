namespace SCIPA.Models
{
    using System;
    using System.Collections.Generic;

    public partial class SerialCommunicator : Communicator
    {
        public string ComPort { get; set; }
        public int BaudRate { get; set; }
        public byte DataBits { get; set; }
        public bool IsRTS { get; set; }
        public bool IsDTR { get; set; }
    }
}
