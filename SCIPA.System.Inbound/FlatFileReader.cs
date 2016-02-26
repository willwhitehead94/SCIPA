using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIPA.Domain.Logic;

namespace SCIPA.Domain.Inbound
{
    public class FlatFileReader : DataReader
    {
        /// <summary>
        /// Constructor, required only a working Flat File Handler.
        /// </summary>
        /// <param name="handler"></param>
        public FlatFileReader(FlatFileHandler handler)
        {
            _handlerEType = handler.Communicator.ValueEType;
            _handler = handler;
        }
    }
}
