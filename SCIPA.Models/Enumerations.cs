namespace SCIPA.Models
{
    /// <summary>
    /// Controls the type of values that the application can process.
    /// </summary>
    public enum ValueType
    {
        String, Integer, Float, Boolean
    };

    /// <summary>
    /// Controls the types of communication the application can process.
    /// </summary>
    public enum CommunicatorType
    {
        FlatFile,
        Serial,
        Database
    };

    /// <summary>
    /// Controls the types of database that the application can connect to.
    /// </summary>
    public enum DatabaseType
    {
        SQL, OLE, ODBC
    };

    /// <summary>
    /// Controls the type of rules available against device values.
    /// </summary>
    public enum RuleType
    {
        LessThan,
        LessThanEqualTo,
        EqualTo,
        MoreThanEqualTo,
        MoreThan,
        Not,
        Between
    }
}
