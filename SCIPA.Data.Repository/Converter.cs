using System;
using DAL = SCIPA.Data.AccessLayer; //Data Access Layer Models
using DOM = SCIPA.Models; //Domain Layer Models

namespace SCIPA.Data.Repository
{
    public class Converter : IConverter
    {
        public DAL.Device ConvertToData(DOM.Device domainModel)
        {
            throw new NotImplementedException();
        }

        public DOM.Device ConvertToDomain(DAL.Device dataModel)
        {
            throw new NotImplementedException();
        }

        public DAL.Action ConvertToData(DOM.Action domainModel)
        {
            throw new NotImplementedException();
        }

        public DOM.Action ConvertToDomain(DAL.Action dataModel)
        {
            throw new NotImplementedException();
        }

        public DAL.DatabaseCommunicator ConvertToData(DOM.DatabaseCommunicator domainModel)
        {
            throw new NotImplementedException();
        }

        public DOM.DatabaseCommunicator ConvertToDomain(DAL.DatabaseCommunicator dataModel)
        {
            throw new NotImplementedException();
        }

        public DAL.FileCommunicator ConvertToData(DOM.FileCommunicator domainModel)
        {
            throw new NotImplementedException();
        }

        public DOM.FileCommunicator ConvertToDomain(DAL.FileCommunicator dataModel)
        {
            throw new NotImplementedException();
        }

        public DAL.SerialCommunicator ConvertToData(DOM.SerialCommunicator domainModel)
        {
            throw new NotImplementedException();
        }

        public DOM.SerialCommunicator ConvertToDomain(DAL.SerialCommunicator dataModel)
        {
            throw new NotImplementedException();
        }

        public DAL.Rule ConvertToData(DOM.Rule domainModel)
        {
            throw new NotImplementedException();
        }

        public DOM.Rule ConvertToDomain(DAL.Rule dataModel)
        {
            throw new NotImplementedException();
        }

        public DAL.Value ConvertToData(DOM.Value domainModel)
        {
            throw new NotImplementedException();
        }

        public DOM.Value ConvertToDomain(DAL.Value dataModel)
        {
            throw new NotImplementedException();
        }

        public DOM.ValueType ConvertToDomain(DAL.ValueType dataModel)
        {
            throw new NotImplementedException();
        }

        public DAL.ValueType ConvertToData(DOM.ValueType domainModel)
        {
            throw new NotImplementedException();
        }

        public DOM.CommunicatorType ConvertToData(DAL.CommunicatorType dataModel)
        {
            throw new NotImplementedException();
        }

        public DAL.CommunicatorType ConvertToDomain(DOM.CommunicatorType domainModel)
        {
            throw new NotImplementedException();
        }

        public DAL.RuleType ConvertToData(DOM.RuleType domainModel)
        {
            throw new NotImplementedException();
        }

        public DOM.RuleType ConvertToDomain(DAL.RuleType domainModel)
        {
            throw new NotImplementedException();
        }

        public DAL.DatabaseType ConvertToData(DOM.DatabaseType dataModel)
        {
            throw new NotImplementedException();
        }

        public DOM.DatabaseType ConvertToDomain(DAL.DatabaseType dataModel)
        {
            throw new NotImplementedException();
        }

        public DAL.CommunicatorType ConvertToData(DOM.CommunicatorType domainModel)
        {
            throw new NotImplementedException();
        }

        public DOM.CommunicatorType ConvertToDomain(DAL.CommunicatorType dataModel)
        {
            throw new NotImplementedException();
        }

        public DAL.AppData ConvertToData(DOM.AppData domainModel)
        {
            throw new NotImplementedException();
        }

        public DOM.AppData ConvertToDomain(DAL.AppData dataModel)
        {
            throw new NotImplementedException();
        }

        public DOM.Communicator ConvertToDomain(DAL.Communicator dataModel)
        {
            {
                if (dataModel is DAL.SerialCommunicator)
                {
                    return ConvertToDomain((DAL.SerialCommunicator)dataModel);
                }
                else if (dataModel is DAL.FileCommunicator)
                {
                    return ConvertToDomain((DAL.FileCommunicator)dataModel);
                }
                else if (dataModel is DAL.DatabaseCommunicator)
                {
                    return ConvertToDomain((DAL.DatabaseCommunicator)dataModel);
                }

                return null;
            }
        }

        public DAL.Communicator ConvertToData(DOM.Communicator domainModel)
        {
            {
                if (domainModel is DOM.SerialCommunicator)
                {
                    return ConvertToData((DOM.SerialCommunicator)domainModel);
                }
                else if (domainModel is DOM.FileCommunicator)
                {
                    return ConvertToData((DOM.FileCommunicator)domainModel);
                }
                else if (domainModel is DOM.DatabaseCommunicator)
                {
                    return ConvertToData((DOM.DatabaseCommunicator)domainModel);
                }

                return null;
            }
        }
    }
}