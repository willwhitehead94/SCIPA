using System.Linq.Expressions;
using DAL = SCIPA.Data.AccessLayer.Models; //DataBase Model
using DOM = SCIPA.Models; //DoMain Model
using DOMR = SCIPA.Models.Resources;

namespace SCIPA.Data.Repository
{
    public class Converter
    {
        public DAL.Device ConvertToData(DOM.Device domainModel)
        {
            return new DAL.Device()
            {
                
            };
        }

        public DOM.Device ConvertToDomain(DAL.Device dataModel)
        {
            return new DOM.Device()
            {
                
            };
        }

        public DAL.Action ConvertToData(DOM.Action domainModel)
        {
            return new DAL.Action()
            {
                
            };
        }

        public DOM.Action ConvertToDomain(DAL.Action dataModel)
        {
            return new DOM.Action()
            {
                
            };
        }

        public DAL.DatabaseCommunicator ConvertToData(DOM.DatabaseCommunicator domainModel)
        {
            return new DAL.DatabaseCommunicator()
            {
                
            };
        }

        public DOM.DatabaseCommunicator ConvertToDomain(DAL.DatabaseCommunicator dataModel)
        {
            return new DOM.DatabaseCommunicator()
            {
                
            };
        }

        public DAL.FileCommunicator ConvertToData(DOM.FileCommunicator domainModel)
        {
            return new DAL.FileCommunicator()
            {
                
            };
        }

        public DOM.FileCommunicator ConvertToDomain(DAL.FileCommunicator dataModel)
        {
            return new DOM.FileCommunicator()
            {
                
            };
        }

        public DAL.SerialCommunicator ConvertToData(DOM.SerialCommunicator domainModel)
        {
            return new  DAL.SerialCommunicator()
            {
                
            };
        }

        public DOM.SerialCommunicator ConvertToDomain(DAL.SerialCommunicator dataModel)
        {
            return new DOM.SerialCommunicator()
            {
                
            };
        }

        public DAL.Rule ConvertToData(DOM.Rule domainModel)
        {
            return new DAL.Rule()
            {
                
            };
        }

        public DOM.Rule ConvertToDomain(DAL.Rule dataModel)
        {
            return new DOM.Rule()
            {
                
            };
        }

        public DAL.Value ConvertToData(DOMR.Value value)
        {
            return new DAL.Value()
            {
                
            };
        }

        public DOMR.Value ConvertToDomain(DAL.Value value)
        {
            return new DOMR.Value()
            {
                
            };
        }
    }
}