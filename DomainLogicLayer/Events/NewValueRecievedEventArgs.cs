using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogicLayer.Events
{
    public delegate void NewValuesRecievedHandler(object source, NewValueRecievedEventArgs e);

    public class NewValueRecievedEventArgs : EventArgs
    {
        private DateTime EventTime
        {
            get; set;
        }

        private string EventInfo
        {
            get; set;
        }

        public NewValueRecievedEventArgs(string text)
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
