using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIPA.Domain.Logic;
using SCIPA.Models;
using SCIPA.Models.Resources;

namespace SCIPA.Domain.Inbound
{
    public class SerialDataReader : DataReader
    {
        /// <summary>
        /// Constructor, required only a working Serial Handler.
        /// </summary>
        /// <param name="handler"></param>
        public SerialDataReader(SerialDataHandler handler)
        {
            HandlerValueType = handler.Communicator.ValueValueType;
            _handler = handler;
        }
    }
}
