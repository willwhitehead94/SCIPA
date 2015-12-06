using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public enum enumDatabaseType { Unknown, SQL, OLE, ODBC };

    public class DatabaseHandler
    {
        #region Static Defaults

        /// <summary>
        /// This is the default connection type used when there isn't one passed to the constructor.
        /// </summary>
        private enumDatabaseType defaultConnectionType = GetDatabaseType();

        /// <summary>
        /// This is the default connection string used when there isn't one passed to the constructor.
        /// </summary>
        private string defaultConnectionString = Properties.Settings.Default.DefaultDatabaseConnectionString;

        /// <summary>
        /// Method to automatically convert the default database type to the 'DatabaseType' enumeration.
        /// </summary>
        /// <returns>DatabaseType of entered database, except where fault where SQL is selected.</returns>
        private static enumDatabaseType GetDatabaseType(string dbType = null)
        {
            string enteredValue = (dbType == null ? Properties.Settings.Default.DefaultDatabaseConnectionType : dbType);
            
            switch (enteredValue.ToUpper())
            {
                case "SQL": return enumDatabaseType.SQL;
                case "OLE": return enumDatabaseType.OLE;
                case "ODBC": return enumDatabaseType.ODBC;
                default: return enumDatabaseType.SQL;
            }
        }

        #endregion Static Defaults

        /// <summary>
        /// The database connection type that this database handler will be connecting to.
        /// </summary>
        private enumDatabaseType _connectionType = enumDatabaseType.Unknown;
        
        /// <summary>
        /// The connection string to use in order to connect and communicate with the database.
        /// </summary>
        private string _connectionString;

        /// <summary>
        /// The data set of results from the last execution.
        /// </summary>
        private DataSet _lastDataSet = null;

        /// <summary>
        /// Sets the current object's connection type by convering a string object to the DatabaseType format.
        /// </summary>
        /// <param name="connectionType">Text representation of DatabaseType.</param>
        private void SetConnectionType(string connectionType)
        {
            GetDatabaseType(connectionType);
        }

        /// <summary>
        /// Sets the current object's connection type by taking a parameter of DatabaseType and setting that as current.
        /// </summary>
        /// <param name="connectionType">DatabaseType original format.</param>
        private void SetConnectionType(enumDatabaseType connectionType)
        {
            this._connectionType = connectionType;
        }

        /// <summary>
        /// Sets the local connection string value.
        /// </summary>
        /// <param name="connectionString">Text representation of the connection string.</param>
        private void SetConnectionString(string connectionString)
        {
            this._connectionString = connectionString;
        }



        /// <summary>
        /// Constructor setting the communication defaults from the configuration file.
        /// </summary>
        public DatabaseHandler()
        {
            SetConnectionString(defaultConnectionString);
            SetConnectionType(defaultConnectionType);
        }

        /// <summary>
        /// Constructor to use a defined connection string and type.
        /// </summary>
        /// <param name="connectionString">User required connection string.</param>
        /// <param name="connectionType">User required connection type (as text representation)</param>
        public DatabaseHandler(string connectionString, string connectionType)
        {
            SetConnectionString(connectionString);
            SetConnectionType(connectionType);
        }

        /// <summary>
        /// Constructor to use a defined connection string and type.
        /// </summary>
        /// <param name="connectionString">User required connection string.</param>
        /// <param name="connectionType">User required connection type</param>
        public DatabaseHandler(string connectionString, enumDatabaseType connectionType)
        {
            SetConnectionString(connectionString);
            SetConnectionType(connectionType);
        }



        /// <summary>
        /// Public method to execute an entered query string against the pre-defined connection settings.
        /// Stores the dataset into the local object's private variable.
        /// </summary>
        /// <param name="query">Query string to execute on the database server.</param>
        /// <returns>Success or fail of execution.</returns>
        public bool Execute(string query)
        {
            try
            {
                _lastDataSet = ExecuteQuery(query);
                Service.DebugPrint("Execution of query was a success.");
                return true;
            }
            catch
            {
                Service.DebugPrint("Execution of query was a failure.");
                return false;
            }
        }

        /// <summary>
        /// Private method to execite a query string against the pre-defined connection settings.
        /// </summary>
        /// <param name="query">Query string to execute on the database server.</param>
        /// <returns>The query's resulting dataset.</returns>
        private DataSet ExecuteQuery(string query)
        {
            Service.DebugPrint("About to execute:", query);

            DataSet resultDataSet = new DataSet();
            IDbConnection connection;
            IDbCommand command;
            IDbDataAdapter adapter;

            if (_connectionString == null || _connectionType == enumDatabaseType.Unknown || query == null)
                return null;

            switch (_connectionType)
            {
                case enumDatabaseType.SQL:
                    connection = new SqlConnection(_connectionString);
                    command = new SqlCommand(query, (SqlConnection)connection);
                    adapter = new SqlDataAdapter((SqlCommand)command);
                    break;
                case enumDatabaseType.ODBC:
                    connection = new OdbcConnection(_connectionString);
                    command = new OdbcCommand(query, (OdbcConnection)connection);
                    adapter = new OdbcDataAdapter((OdbcCommand)command);
                    break;
                case enumDatabaseType.OLE:
                    connection = new OleDbConnection(_connectionString);
                    command = new OleDbCommand(query, (OleDbConnection)connection);
                    adapter = new OleDbDataAdapter((OleDbCommand)command);
                    break;
                default:
                    return null;
            }

            adapter.Fill(resultDataSet);

            return resultDataSet;
        }


        public DataSet GetDataSet()
        {
            return _lastDataSet;
        }

        public DataTable GetDataTableFromDataSet(int TableIndex)
        {
            return _lastDataSet.Tables[TableIndex];
        }

        public DataTable GetDataTableFromDataSet(string TableName)
        {
            return GetDataTableFromDataSet(_lastDataSet.Tables.IndexOf(TableName));
        }

        public string GetSingleValueFromFirstTableInSet()
        {
            string value = null;

            foreach (DataRow row in _lastDataSet.Tables[0].Rows)
            {
                value =row[0].ToString();

                if (value != null)
                {
                    break;
                }
            }

            return value;
        }
    }
}
