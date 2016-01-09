using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class DatabaseTypeVM
    {
        private int _id;

        private enumDatabaseType _databaseType;

        public int Id
        {
            get { return _id; }
        }

        public enumDatabaseType DatabaseConnectionType
        {
            get { return _databaseType; }
            set { _databaseType = value; }
        }

        public DatabaseTypeVM(int id, enumDatabaseType databaseType)
        {
            _id = id;
            DatabaseConnectionType = databaseType;
        }

        public DatabaseTypeVM(string id, string databaseType)
        {

            _id = Convert.ToInt32(id);

            switch (databaseType.ToUpper())
            {
                case "SQL": DatabaseConnectionType = enumDatabaseType.SQL; break;
                case "OLE": DatabaseConnectionType = enumDatabaseType.OLE; break;
                case "ODBC": DatabaseConnectionType = enumDatabaseType.ODBC; break;
                default: DatabaseConnectionType = enumDatabaseType.SQL; break;
            }
        }
    }

}
