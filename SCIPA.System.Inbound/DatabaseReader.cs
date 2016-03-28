using SCIPA.Models;

namespace SCIPA.Domain.Inbound
{
    /// <summary>
    /// Abstract class for all Reader types. The Reader classes are used to read the approrpiate
    /// data that has been imported by the Handler.  It is important to remember the hierachical
    /// structure of INBOUND data is as follows ( '>' indicates that {left} is part of {right} )
    /// Communicator > Handler > Reader
    /// 
    /// Device's use the above hierachy to read, handle and work with both in and outbound data to/from 
    /// the process.
    /// </summary>
    public class DatabaseReader :DataReader
    {
        /// <summary>
        /// Constructor, required only a working Database Handler.
        /// </summary>
        /// <param name="handler"></param>
        public DatabaseReader(DatabaseHandler handler)
        {
            HandlerValueType = handler.Communicator.ValueType;
            _handler = handler;
        }
    }
}