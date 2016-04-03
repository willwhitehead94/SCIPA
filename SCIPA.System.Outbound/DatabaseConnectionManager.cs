using System;
using System.Collections.Generic;
using System.Data;
using SCIPA.Domain.Generic;
using SCIPA.Models;

namespace SCIPA.Domain.Outbound
{
    /// <summary>
    /// This class can be used to connect to either an SQL, an OLE or an ODBC database.
    /// No special objects are required.
    /// 
    /// To use, instantiate a new object of this type, and pass the DatabaseType (via the enum)
    /// and the connection string.
    /// 
    /// To execute a query, call the .Execute method against your new object; if you're executing
    /// a non-query (in that no results are returned, such as an 'insert'), you can also pass
    /// 'false' as the 'ExpectResults' parameter.
    /// </summary>
    public class DatabaseConnectionManager
    {
        #region Default InboundValues

        /// <summary>
        /// This is the default connection type used when there isn't one passed to the constructr.
        /// </summary>
        private DatabaseType DefaultConnectionType = DatabaseType.SQL;

        /// <summary>
        /// This is the default connection string used when there isn't one passed to the constructor.
        /// </summary>
        private string DefaultConnectionString = Configuration.DefaultConnectionString;

        #endregion Default InboundValues

        #region Variables

        /// <summary>
        /// The selected connection type, which has to be one of the preset options.
        /// </summary>
        private DatabaseType ConnectionType;

        /// <summary>
        /// The actual connection to the data source.
        /// </summary>
        private IDbConnection DatabaseConnection;

        /// <summary>
        /// The connection string to connect to the database with.
        /// </summary>
        private string ConnectionString;

        /// <summary>
        /// The query to execute against the connection string.
        /// </summary>
        private string Query;

        /// <summary>
        /// A list of Object arrays. Each Object array constitues a record from the database.
        /// The Record Object contains a result for each column returned via the query.
        /// </summary>
        private List<Object[]> ResultSet;

        /// <summary>
        /// Numerical value of the affected rows.
        /// </summary>
        private int AffectedRows;

        #endregion Variables

        #region Constructor(s)

        /// <summary>
        /// Constructor method creates a new DatabaseHandler object with the default connection string
        /// and connection type. These values can be changed within the 'Default' region of the 
        /// DatabaseHandler class.
        /// </summary>
        public DatabaseConnectionManager()
        {
            this.ConnectionType = DefaultConnectionType;
            this.ConnectionString = DefaultConnectionString;
        }

        /// <summary>
        /// Constructor method creates a DatabaseHandler object with a preset data type
        /// and connection string.
        /// </summary>
        public DatabaseConnectionManager(DatabaseType Type, string ConnectionString)
        {
            this.ConnectionType = Type;
            this.ConnectionString = ConnectionString;
        }

        /// <summary>
        /// Constructor method creates a DatabaseHandler object with a preset data type
        /// and connection string, but also executes the query immediately.
        /// </summary>
        public DatabaseConnectionManager(DatabaseType Type, string ConnectionString, string Query, bool ExpectResults = true)
        {
            this.ConnectionType = Type;
            this.ConnectionString = ConnectionString;
            this.Query = Query;

            Execute(this.Query, ExpectResults);
        }

        #endregion Constructor

        #region Public Methods

        /// <summary>
        /// Takes a query to execute, along with an optional param to determine whether or not
        /// results are expected. NonQuerys, such as Insert and Update statements do not return results,
        /// and as such, the 'ExpectResults' param should be set to false.
        /// 
        /// It is common, however, for most queries to require responses, so this is the default setting.
        /// </summary>
        /// <param name="Query"></param>
        /// <param name="ExpectResults"></param>
        /// <returns></returns>
        public bool Execute(String Query = "", bool ExpectResults = true)
        {
            if (Query != "")
            {
                this.Query = Query;
            }

            DebugOutput.Print("About to execute SQL query: ", this.Query);

            this.AffectedRows = int.MinValue;
            this.ResultSet = null;

            IDbConnection DatabaseConnection = GetDatabaseConnection(ConnectionType);

            return InternalExecute(DatabaseConnection, ExpectResults);
        }

        /// <summary>
        /// Returns the List of results. Records are stored in an object array.
        /// </summary>
        public List<Object[]> GetResultObject()
        {
            if (ResultSet.Count == 0 || ResultSet == null)
                return null;
            else
                return ResultSet;
        }

        /// <summary>
        /// Returns the List of results. Records are stored in an object array.
        /// The integer being passed out is the number of affected rows (in this instance, the number of records).
        /// </summary>
        public List<Object[]> GetResultObject(out int AffectedRows)
        {
            AffectedRows = this.AffectedRows;
            return GetResultObject();
        }

        /// <summary>
        /// Returns a list of lists that make up every record returned via the database.
        /// Each List<> is a record, each string inside the child List<> is a value.
        /// 
        /// For example "SELECT TOP 3 Name, Age FROM Person" would return List<List<string>>    
        ///     - The first list would contain 3 list<string> objects.
        ///     - Each of the second list<string> objects would contain 2 string
        ///       objects (to represent Name and Age).
        /// </summary>
        public List<List<string>> GetResultLists()
        {
            List<Object[]> ResultObject = GetResultObject();

            if (ResultObject != null)
            {
                List<List<string>> AllRecords = new List<List<string>>();
                List<string> SingleRecord = new List<string>();

                foreach (Object[] Record in ResultObject)
                {
                    foreach (string Value in Record)
                    {
                        SingleRecord.Add(Value);
                    }
                    AllRecords.Add(SingleRecord);
                }

                return AllRecords;
            }
            else
                return null;
        }

        /// <summary>
        /// Method returns an integer value of the affected records from the last query
        /// executed by this object.
        /// </summary>
        /// <returns></returns>
        public int GetAffectedRows()
        {
            return AffectedRows;
        }

        #endregion Public Methods

        #region Private Methods

        /// <summary>
        /// Creates a new database connection based on the DatabaseType the user has selected.
        /// The database connection is then stored in the local, private variable 'DatabaseConnection'
        /// If already created, a new database connection is not created.
        /// </summary>
        private IDbConnection GetDatabaseConnection(DatabaseType DataType)
        {
            if (this.DatabaseConnection != null)
            {
                return this.DatabaseConnection;
            }

            switch (DataType)
            {
                case DatabaseType.SQL: DatabaseConnection = new System.Data.SqlClient.SqlConnection(ConnectionString); break;
                case DatabaseType.ODBC: DatabaseConnection = new System.Data.Odbc.OdbcConnection(ConnectionString); break;
                case DatabaseType.OLE: DatabaseConnection = new System.Data.OleDb.OleDbConnection(ConnectionString); break;
                default: DatabaseConnection = null; break;
            }

            return DatabaseConnection;
        }

        /// <summary>
        /// This method determines which type of execution is required given user input from
        /// other methods. 
        /// As a private method, this execution is only performed internally.
        /// </summary>
        private bool InternalExecute(IDbConnection DatabaseConnection, bool ExpectResults)
        {
            bool SuccessfulExecute = false;
            int AffectedRows = 0;

            if (DatabaseConnection == null)
                return false;

            ConnectionState StartState = DatabaseConnection.State;

            try
            {
                if (StartState != ConnectionState.Open)
                    DatabaseConnection.Open();

                if (ExpectResults)
                    SuccessfulExecute = ExecuteQuery(DatabaseConnection.CreateCommand(), out AffectedRows);
                else
                {
                    SuccessfulExecute = ExecuteNonQuery(DatabaseConnection.CreateCommand(), out AffectedRows);
                }
            }
            catch (InvalidOperationException e)
            {
                //Usually occurs when the system cannot connect to the database
                DebugOutput.Print("Invalid connection attempt. ", e.Message);
            }
            catch (Exception e)
            {
                DebugOutput.Print("Unable to contact and connect to database. ",e.Message);
            }
            finally
            {
                //Leave the connection as we found it (i.e. close it if it came closed)
                if (StartState.Equals(ConnectionState.Closed))
                    DatabaseConnection.Close();

                this.AffectedRows = AffectedRows;
            }

            return SuccessfulExecute;
        }

        /// <summary>
        /// This method executes a query against the database connection where a result is expected.
        /// Results are stored in the ResultSet private object.
        /// Affected rows are calculated by the number of records returned.
        /// </summary>
        private bool ExecuteQuery(IDbCommand DatabaseCommand, out int AffectedRows)
        {
            List<Object[]> AllRecords = new List<object[]>();
            IDataReader DataReader;

            try
            {
                DatabaseCommand.CommandText = Query;
                DataReader = DatabaseCommand.ExecuteReader();

                Object[] SingleRecord = new Object[DataReader.FieldCount];

                while (DataReader.Read())
                {
                    SingleRecord = new Object[DataReader.FieldCount];

                    for (int ColumnCounter = 0; ColumnCounter < DataReader.FieldCount; ColumnCounter++)
                        SingleRecord[ColumnCounter] = DataReader.GetValue(ColumnCounter).ToString();

                    AllRecords.Add(SingleRecord);
                }
            }
            catch
            {
                return false;
            }
            finally
            {
                AffectedRows = AllRecords.Count;
                ResultSet = AllRecords;
            }

            return true;
        }

        /// <summary>
        /// This method executes a query against the database connection where a result is NOT required.
        /// Results are NOT stored.
        /// Affected rows are calculated by the number of rows affected on the database.
        /// </summary>
        private bool ExecuteNonQuery(IDbCommand DatabaseCommand, out int AffectedRows)
        {
            AffectedRows = 0;

            try
            {
                DatabaseCommand.CommandText = Query;
                AffectedRows = DatabaseCommand.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }

        #endregion Private Methods
    }
}