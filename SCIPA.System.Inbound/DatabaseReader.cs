namespace SCIPA.Domain.Inbound
{
    public class DatabaseReader :DataReader
    {
        /// <summary>
        /// Constructor, required only a working Database Handler.
        /// </summary>
        /// <param name="handler"></param>
        public DatabaseReader(DatabaseHandler handler)
        {
            HandlerValueType = handler.Communicator.ValueValueType;
            _handler = handler;
        }
    }
}