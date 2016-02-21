using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIPA.Domain.Inbound
{
    public delegate void FileUpdatedHandler(object source, FileUpdatedEventArgs fvc);

    public class FileUpdatedEventArgs : EventArgs
    {
        private DateTime EventTime { get; set; }

        private string EventInfo { get; set; }



        public FileUpdatedEventArgs(string text)
        {
            EventTime = DateTime.Now;
            EventInfo = text;
        }

        public DateTime GetEventTime()
        {
            return EventTime;
        }

        public string GetEventInfo()
        {
            return EventInfo;
        }
    }
}
