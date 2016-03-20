using System;

namespace SCIPA.Models
{
    public abstract class Communicator
    {
        private readonly DateTime _earliestDateTimeAllowed = new DateTime(year: 1980, month: 1, day: 1);

        protected Communicator()
        {
            //ensures that the earliets possible date is with
            //both C# and SQL Server constraints.
            LastReadTime = _earliestDateTimeAllowed;
        }

        public int StartChar { get; set; }

        public int EndChar { get; set; }

        public DateTime LastReadTime { get; set; }
            //get { return LastReadTime; }
            //set
            //{
            //    //ensures that the earliets possible date is with
            //    //both C# and SQL Server constraints.
            //    LastReadTime = value < _earliestDateTimeAllowed ? _earliestDateTimeAllowed : value;
            //}
        

        public ValueType ValueValueType { get; set; }

        public virtual Device Device { get; set; }
    }
}