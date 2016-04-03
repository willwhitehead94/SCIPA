using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIPA.Domain.Logic;
using SCIPA.Models;

namespace SCIPA.Domain.Inbound
{
    /// <summary>
    /// Reader class for Flat File connections. The Reader classes are used to read the approrpiate
    /// data that has been imported by the Handler.  It is important to remember the hierachical
    /// structure of INBOUND data is as follows ( '>' indicates that {left} is part of {right} )
    /// Communicator > Handler > Reader
    /// 
    /// Device's use the above hierachy to read, handle and work with both in and outbound data to/from 
    /// the process.
    /// </summary>
    public class FlatFileReader : DataReader
    {
        /// <summary>
        /// Constructor, required only a working Flat File Handler.
        /// </summary>
        /// <param name="handler"></param>
        public FlatFileReader(FlatFileHandler handler)
        {
            //HandlerValueType = handler.Communicator.ValueType;
            _handler = handler;
        }
    }
}
