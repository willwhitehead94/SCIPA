namespace SCIPA.Data.AccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class SerialCommunicator : Communicator
    {
        public string ComPort { get; set; }
        public string BaudRate { get; set; }
        public string DataBits { get; set; }
        public string IsRTS { get; set; }
        public string IsDTR { get; set; }
    }
}
