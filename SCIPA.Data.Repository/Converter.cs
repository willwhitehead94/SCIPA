using System.Linq.Expressions;
using DBM = SCIPA.Data.AccessLayer.Models; //DataBase Model
using DMM = SCIPA.Models; //DoMain Model

namespace SCIPA.Data.Repository
{
    public class Converter
    {
        public DBM.Device ConvertToData(DMM.Device domainModel)
        {
            return new DBM.Device()
            {
                
            };
        }

        public DMM.Device ConvertToDomain(DBM.Device dataModel)
        {
            return new DMM.Device()
            {
                
            };
        }

        public DBM.Action ConvertToData(DMM.Action domainModel)
        {
            return new DBM.Action()
            {
                
            };
        }

        public DMM.Action ConvertToDomain(DBM.Action dataModel)
        {
            return new DMM.Action()
            {
                
            };
        }

        public DBM.DatabaseCommunicator ConvertToData(DMM.DatabaseCommunicator domainModel)
        {
            return new DBM.DatabaseCommunicator()
            {
                
            };
        }

        public DMM.DatabaseCommunicator ConvertToDomain(DBM.DatabaseCommunicator dataModel)
        {
            return new DMM.DatabaseCommunicator()
            {
                
            };
        }

        public DBM.FileCommunicator ConvertToData(DMM.FileCommunicator domainModel)
        {
            return new DBM.FileCommunicator()
            {
                
            };
        }

        public DMM.FileCommunicator ConvertToDomain(DBM.FileCommunicator dataModel)
        {
            return new DMM.FileCommunicator()
            {
                
            };
        }

        public DBM.SerialCommunicator ConvertToData(DMM.SerialCommunicator domainModel)
        {
            DBM.SerialCommunicator()
            {
                
            };
        }

        public DMM.SerialCommunicator ConvertToDomain(DBM.SerialCommunicator dataModel)
        {
            return new DMM.SerialCommunicator()
            {
                
            };
        }

        public DBM.Rule ConvertToData(DMM.Rule domainModel)
        {
            return new DBM.Rule()
            {
                
            };
        }

        public DMM.Rule ConvertToDomain(DBM.Rule dataModel)
        {
            return new DMM.Rule()
            {
                
            };
        }
    }
}