using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class DatabaseCommunicatorVM
    {
        private int _id;

        private string _connectionString;

        private int _databaseTypeId;


        public int Id
        {
            get { return _id; }
        }

        public string ConnectionString
        {
            get { return _connectionString; }
            set { _connectionString = value; }
        }

        public int DatabaseTypeId
        {
            get { return _databaseTypeId; }
            set { _databaseTypeId = value; }
        }

        public DatabaseCommunicatorVM (int id, string connectionString, int databaseTypeId)
        {
            _id = id;
            ConnectionString = connectionString;
            DatabaseTypeId = databaseTypeId;
        }

        public DatabaseCommunicatorVM(string id, string connectionString, string databaseTypeId)
        {
            _id = Convert.ToInt32(id);
            ConnectionString = connectionString;
            DatabaseTypeId = Convert.ToInt32(databaseTypeId);
        }
    }

}
