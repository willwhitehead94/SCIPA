using DOM = SCIPA.Models;
using DAL = SCIPA.Data.AccessLayer;

namespace SCIPA.Data.Repository
{
    public interface IConverter
    {
        DAL.Device ConvertToData(DOM.Device domainModel);

        DOM.Device ConvertToDomain(DAL.Device dataModel);

        DAL.Action ConvertToData(DOM.Action domainModel);

        DOM.Action ConvertToDomain(DAL.Action dataModel);

        DAL.DatabaseCommunicator ConvertToData(DOM.DatabaseCommunicator domainModel);

        DOM.DatabaseCommunicator ConvertToDomain(DAL.DatabaseCommunicator dataModel);

        DAL.FileCommunicator ConvertToData(DOM.FileCommunicator domainModel);

        DOM.FileCommunicator ConvertToDomain(DAL.FileCommunicator dataModel);

        DAL.SerialCommunicator ConvertToData(DOM.SerialCommunicator domainModel);

        DOM.SerialCommunicator ConvertToDomain(DAL.SerialCommunicator dataModel);

        DAL.Rule ConvertToData(DOM.Rule domainModel);

        DOM.Rule ConvertToDomain(DAL.Rule dataModel);

        DAL.Value ConvertToData(DOM.Value domainModel);

        DOM.Value ConvertToDomain(DAL.Value dataModel);

        DOM.ValueType ConvertToDomain(DAL.ValueType dataModel);

        DAL.ValueType ConvertToData(DOM.ValueType domainModel);

        DOM.CommunicatorType ConvertToData(DAL.CommunicatorType dataModel);

        DAL.CommunicatorType ConvertToDomain(DOM.CommunicatorType domainModel);

        DAL.RuleType ConvertToData(DOM.RuleType domainModel);

        DOM.RuleType ConvertToDomain(DAL.RuleType domainModel);

        DAL.DatabaseType ConvertToData(DOM.DatabaseType dataModel);

        DOM.DatabaseType ConvertToDomain(DAL.DatabaseType dataModel);

        DAL.CommunicatorType ConvertToData(DOM.CommunicatorType domainModel);

        DOM.CommunicatorType ConvertToDomain(DAL.CommunicatorType dataModel);

        DAL.AppData ConvertToData(DOM.AppData domainModel);

        DOM.AppData ConvertToDomain(DAL.AppData dataModel);




        DOM.Communicator ConvertToDomain(DAL.Communicator dataModel);

        DAL.Communicator ConvertToData(DOM.Communicator domainModel);
    }
}