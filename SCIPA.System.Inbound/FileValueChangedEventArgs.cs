using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIPA.Domain.Inbound
{
    public delegate void FileUpdatedHandler(object source, FileUpdatedEventArgs fvc);

    /// <summary>
    /// When a Flat File is updated, an event is thrown using the FileUpdatedEventArgs, which houses
    /// key data required by the application.
    /// </summary>
    public class FileUpdatedEventArgs : EventArgs
    {
        /// <summary>
        /// The time at which this event occured.
        /// </summary>
        private DateTime EventTime { get; set; }

        /// <summary>
        /// The string data from the event.
        /// </summary>
        private string EventInfo { get; set; }


        /// <summary>
        /// Constructor creates a new set of event arguments when the file is updated.
        /// </summary>
        /// <param name="text"></param>
        public FileUpdatedEventArgs(string text)
        {
            EventTime = DateTime.Now;
            EventInfo = text;
        }

        /// <summary>
        /// Returns the event time from the event.
        /// </summary>
        /// <returns></returns>
        public DateTime GetEventTime()
        {
            return EventTime;
        }

        /// <summary>
        /// Returns the stored string entity from the event.
        /// </summary>
        /// <returns></returns>
        public string GetEventInfo()
        {
            return EventInfo;
        }
    }
}
