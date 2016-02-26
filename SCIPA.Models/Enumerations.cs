namespace SCIPA.Models
{
    public enum ValueType
    {
        String, Integer, Float, Boolean
    };

    public enum CommunicatorType
    {
        FlatFile,
        Serial,
        Database
    };

    public enum DatabaseType
    {
        SQL, OLE, ODBC
    };
}
