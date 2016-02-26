using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIPA.Models
{
    public enum eType { String, Integer, Float, Boolean };

    public enum eComm
    {
        FlatFile,
        Serial,
        Database
    };

    public enum DatabaseTechnologyType { SQL, OLE, ODBC };
}
