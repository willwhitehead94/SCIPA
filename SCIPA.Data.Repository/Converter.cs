using System;
using System.Collections.Generic;
using System.Linq;
using SCIPA.Domain.Generic;
using DAL = SCIPA.Data.AccessLayer.Models; //DataBase Model
using DOM = SCIPA.Models; //DoMain Model
using DOMR = SCIPA.Models.Resources;

namespace SCIPA.Data.Repository
{
    public class Converter
    {
        public DAL.Device ConvertToData(DOM.Device domainModel)
        {
            ICollection<DAL.Value> outboundVals = null, inboundVals = null;
            ICollection<DAL.Rule> rules = null;

            if (domainModel.OutboundValues != null)
            {
                outboundVals = domainModel.OutboundValues.Select(ConvertToData).ToList();
            }

            if (domainModel.InboundValues != null)
            {
                inboundVals = domainModel.InboundValues.Select(ConvertToData).ToList();
            }

            if (domainModel.Rules != null)
            {
                rules = domainModel.Rules.Select(ConvertToData).ToList();
            }

            return new DAL.Device()
            {
                Id = domainModel.Id,
                InboundReader = domainModel.InboundReader,
                Location = domainModel.Location,
                Name = domainModel.Name,
                Custodian = domainModel.Custodian,
                OutboundValues = outboundVals,
                Rules = rules,
                Enabled = domainModel.Enabled,
                InboundValues = inboundVals,
                OutboundWriter = domainModel.OutboundWriter
            };
        }

        public DOM.Device ConvertToDomain(DAL.Device dataModel)
        {
            if (dataModel == null) return null;

            ICollection<DOMR.Value> outboundVals = null, inboundVals = null;
            ICollection<DOM.Rule> rules = null;

            try
            {
                if (dataModel.OutboundValues != null)
                {
                    outboundVals = dataModel.OutboundValues.Select(ConvertToDomain).ToList();
                }

                if (dataModel.InboundValues != null)
                {
                    inboundVals = dataModel.InboundValues.Select(ConvertToDomain).ToList();
                }

                if (dataModel.Rules != null)
                {
                    rules = dataModel.Rules.Select(ConvertToDomain).ToList();
                }
            }
            catch (Exception e)
            {
                DebugOutput.Print("Conversion Error (Handled). ",e.Message);
            }

            //var inboundVals = dataModel.InboundValues.Select(ConvertToDomain).ToList();
            //var outboundVals = dataModel.OutboundValues.Select(ConvertToDomain).ToList();
            //var rules = dataModel.Rules.Select(ConvertToDomain).ToList();

            return new DOM.Device()
            {
                Custodian = dataModel.Custodian,
                Enabled = dataModel.Enabled,
                InboundValues = inboundVals,
                Name = dataModel.Name,
                OutboundValues = outboundVals,
                OutboundWriter = dataModel.OutboundWriter,
                Rules = rules,
                Id = dataModel.Id,
                InboundReader = dataModel.InboundReader,
                Location = dataModel.Location
            };
        }

        public DAL.Action ConvertToData(DOM.Action domainModel)
        {
            return new DAL.Action()
            {
                Id = domainModel.Id,
                OutputValue = domainModel.OutputValue,
                Device = ConvertToData(domainModel.Device)
            };
        }

        public DOM.Action ConvertToDomain(DAL.Action dataModel)
        {
            return new DOM.Action()
            {
                Device = ConvertToDomain(dataModel.Device),
                Id = dataModel.Id,
                OutputValue = dataModel.OutputValue
            };
        }

        public DAL.DatabaseCommunicator ConvertToData(DOM.DatabaseCommunicator domainModel)
        {
            return new DAL.DatabaseCommunicator()
            {
                DatabaseType = ConvertToData(domainModel.DatabaseType),
                EndChar = domainModel.EndChar,
                LastReadTime = domainModel.LastReadTime,
                StartChar = domainModel.StartChar,
                ValueValueType = ConvertToData(domainModel.ValueValueType),
                connectionString = domainModel.connectionString,
                databaseTypeId = domainModel.databaseTypeId,
                id = domainModel.id,
                query = domainModel.query
                //Device = 
            };
        }

        public DOM.DatabaseCommunicator ConvertToDomain(DAL.DatabaseCommunicator dataModel)
        {
            return new DOM.DatabaseCommunicator()
            {
                id = dataModel.id,
                StartChar = dataModel.StartChar,
                EndChar = dataModel.EndChar,
                connectionString = dataModel.connectionString,
                databaseTypeId = dataModel.databaseTypeId,
                query = dataModel.query,
                DatabaseType = ConvertToDomain(dataModel.DatabaseType),
                LastReadTime = dataModel.LastReadTime,
                ValueValueType = ConvertToDomain(dataModel.ValueValueType)
            };
        }

        public DAL.FileCommunicator ConvertToData(DOM.FileCommunicator domainModel)
        {
            return new DAL.FileCommunicator()
            {
                EndChar = domainModel.EndChar,
                LastReadTime = domainModel.LastReadTime,
                ValueValueType = ConvertToData(domainModel.ValueValueType),
                //Device = 
                FilePath = domainModel.FilePath,
                Id = domainModel.Id,
                StartChar = domainModel.StartChar
            };
        }

        public DOM.FileCommunicator ConvertToDomain(DAL.FileCommunicator dataModel)
        {
            return new DOM.FileCommunicator()
            {
                StartChar = dataModel.StartChar,
                EndChar = dataModel.EndChar,
                FilePath = dataModel.FilePath,
                Id = dataModel.Id,
                LastReadTime = dataModel.LastReadTime,
                ValueValueType = ConvertToDomain(dataModel.ValueValueType)
            };
        }

        public DAL.SerialCommunicator ConvertToData(DOM.SerialCommunicator domainModel)
        {
            return new  DAL.SerialCommunicator()
            {
                //Device =
                EndChar = domainModel.EndChar,
                LastReadTime = domainModel.LastReadTime,
                StartChar = domainModel.StartChar,
                ValueValueType = ConvertToData(domainModel.ValueValueType),
                baudRate = domainModel.baudRate,
                comPort = domainModel.comPort,
                dataBits = domainModel.dataBits,
                id = domainModel.id,
                isDTR = domainModel.isDTR,
                isRTS = domainModel.isRTS
            };
        }

        public DOM.SerialCommunicator ConvertToDomain(DAL.SerialCommunicator dataModel)
        {
            return new DOM.SerialCommunicator()
            {
                StartChar = dataModel.StartChar,
                baudRate = dataModel.baudRate,
                comPort = dataModel.comPort,
                dataBits = dataModel.dataBits,
                id = dataModel.id,
                isDTR = dataModel.isDTR,
                isRTS = dataModel.isRTS,
                EndChar = dataModel.EndChar,
                LastReadTime = dataModel.LastReadTime,
                ValueValueType = ConvertToDomain(dataModel.ValueValueType)
            };
        }

        public DAL.Rule ConvertToData(DOM.Rule domainModel)
        {
            return new DAL.Rule()
            {
                //Device =
                ActionOnConditionsMet = ConvertToData(domainModel.ActionOnConditionsMet),
                AlarmOnConditionsMet = domainModel.AlarmOnConditionsMet,
                ConditionMet = domainModel.ConditionMet,
                Id = domainModel.Id,
                RuleType = ConvertToData(domainModel.RuleType),
                ValueOne = domainModel.ValueOne,
                ValueOneType = ConvertToData(domainModel.ValueOneType),
                ValueTwo = domainModel.ValueTwo,
                ValueTwoType = ConvertToData(domainModel.ValueTwoType)
            };
        }

        public DOM.Rule ConvertToDomain(DAL.Rule dataModel)
        {
            return new DOM.Rule()
            {
                Id = dataModel.Id,
                RuleType = ConvertToDomain(dataModel.RuleType),
                ValueTwoType = ConvertToDomain(dataModel.ValueTwoType),
                ValueOneType = ConvertToDomain(dataModel.ValueOneType),
                ValueOne = dataModel.ValueOne,
                ConditionMet = dataModel.ConditionMet,
                ValueTwo = dataModel.ValueTwo,
                AlarmOnConditionsMet = dataModel.AlarmOnConditionsMet,
                ActionOnConditionsMet = ConvertToDomain(dataModel.ActionOnConditionsMet)
            };
        }

        public DAL.Value ConvertToData(DOMR.Value domainModel)
        {
            return new DAL.Value()
            {
                //Device = 
                CommType = ConvertToData(domainModel.CommType),
                EventTime = domainModel.EventTime,
                Id = domainModel.Id,
                Inbound = domainModel.Inbound,
                StringValue = domainModel.StringValue,
                ValueType = ConvertToData(domainModel.ValueType)
            };
        }

        public DOMR.Value ConvertToDomain(DAL.Value dataModel)
        {
            return new DOMR.Value()
            {
                Id = dataModel.Id,
                Inbound = dataModel.Inbound,
                ValueType = ConvertToDomain(dataModel.ValueType),
                StringValue = dataModel.StringValue,
                EventTime = dataModel.EventTime,
                CommType = ConvertToDomain(dataModel.CommType)
            };
        }

        public DOM.ValueType ConvertToDomain(DAL.ValueType dataModel)
        {
            switch (dataModel)
            {
                case DAL.ValueType.String:
                    return DOM.ValueType.String;
                case DAL.ValueType.Integer:
                    return DOM.ValueType.Integer;
                case DAL.ValueType.Float:
                    return DOM.ValueType.Float;
                case DAL.ValueType.Boolean:
                    return DOM.ValueType.Boolean;
                default:
                    return DOM.ValueType.String;
            }
        }

        public DAL.ValueType ConvertToData(DOM.ValueType domainModel)
        {
            switch (domainModel)
            {
                case DOM.ValueType.String:
                    return DAL.ValueType.String;
                case DOM.ValueType.Integer:
                    return DAL.ValueType.Integer;
                case DOM.ValueType.Float:
                    return DAL.ValueType.Float;
                case DOM.ValueType.Boolean:
                    return DAL.ValueType.Boolean;
                default:
                    return DAL.ValueType.String;
            }
        }

        public DOM.CommunicatorType ConvertToData(DAL.CommunicatorType dataModel)
        {
            switch (dataModel)
            {
                case DAL.CommunicatorType.Database:
                    return DOM.CommunicatorType.Database;
                case DAL.CommunicatorType.FlatFile:
                    return DOM.CommunicatorType.FlatFile;
                case DAL.CommunicatorType.Serial:
                    return DOM.CommunicatorType.Serial;
                default:
                    return DOM.CommunicatorType.Database;
            }
        }

        public DAL.CommunicatorType ConvertToDomain(DOM.CommunicatorType domainModel)
        {
            switch (domainModel)
            {
                case DOM.CommunicatorType.Database:
                    return DAL.CommunicatorType.Database;
                case DOM.CommunicatorType.FlatFile:
                    return DAL.CommunicatorType.FlatFile;
                case DOM.CommunicatorType.Serial:
                    return DAL.CommunicatorType.Serial;
                default:
                    return DAL.CommunicatorType.Database;
            }
        }

        public DAL.RuleType ConvertToData(DOM.RuleType domainModel)
        {
            switch (domainModel)
            {
                case DOM.RuleType.Between:
                    return DAL.RuleType.Between;
                case DOM.RuleType.EqualTo:
                    return DAL.RuleType.EqualTo;
                case DOM.RuleType.LessThan:
                    return DAL.RuleType.LessThan;
                case DOM.RuleType.LessThanEqualTo:
                    return DAL.RuleType.LessThanEqualTo;
                case DOM.RuleType.MoreThan:
                    return DAL.RuleType.MoreThan;
                case DOM.RuleType.MoreThanEqualTo:
                    return DAL.RuleType.MoreThanEqualTo;
                case DOM.RuleType.Not:
                    return DAL.RuleType.Not;
                default:
                    return DAL.RuleType.EqualTo;
            }
        }

        public DOM.RuleType ConvertToDomain(DAL.RuleType domainModel)
        {
            switch (domainModel)
            {
                case DAL.RuleType.Between:
                    return DOM.RuleType.Between;
                case DAL.RuleType.EqualTo:
                    return DOM.RuleType.EqualTo;
                case DAL.RuleType.LessThan:
                    return DOM.RuleType.LessThan;
                case DAL.RuleType.LessThanEqualTo:
                    return DOM.RuleType.LessThanEqualTo;
                case DAL.RuleType.MoreThan:
                    return DOM.RuleType.MoreThan;
                case DAL.RuleType.MoreThanEqualTo:
                    return DOM.RuleType.MoreThanEqualTo;
                case DAL.RuleType.Not:
                    return DOM.RuleType.Not;
                default:
                    return DOM.RuleType.EqualTo;
            }
        }

        public DAL.DatabaseType ConvertToData(DOM.DatabaseType dataModel)
        {
            switch (dataModel)
            {
                case DOM.DatabaseType.ODBC:
                    return DAL.DatabaseType.ODBC;
                case DOM.DatabaseType.OLE:
                    return DAL.DatabaseType.OLE;
                case DOM.DatabaseType.SQL:
                    return DAL.DatabaseType.SQL;
                default: return DAL.DatabaseType.SQL;
            }
        }

        public DOM.DatabaseType ConvertToDomain(DAL.DatabaseType dataModel)
        {
            switch (dataModel)
            {
                case DAL.DatabaseType.ODBC:
                    return DOM.DatabaseType.ODBC;
                case DAL.DatabaseType.OLE:
                    return DOM.DatabaseType.OLE;
                case DAL.DatabaseType.SQL:
                    return DOM.DatabaseType.SQL;
                default: return DOM.DatabaseType.SQL;
            }
        }

        public DAL.CommunicatorType ConvertToData(DOM.CommunicatorType domainModel)
        {
            switch (domainModel)
            {
                case DOM.CommunicatorType.Database:
                    return DAL.CommunicatorType.Database;
                case DOM.CommunicatorType.FlatFile:
                    return DAL.CommunicatorType.FlatFile;
                case DOM.CommunicatorType.Serial:
                    return DAL.CommunicatorType.Serial;
                default: return DAL.CommunicatorType.Database;
            }
        }

        public DOM.CommunicatorType ConvertToDomain(DAL.CommunicatorType dataModel)
        {
            switch (dataModel)
            {
                case DAL.CommunicatorType.Database:
                    return DOM.CommunicatorType.Database;
                case DAL.CommunicatorType.FlatFile:
                    return DOM.CommunicatorType.FlatFile;
                case DAL.CommunicatorType.Serial:
                    return DOM.CommunicatorType.Serial;
                default: return DOM.CommunicatorType.Database;
            }
        }

        public DAL.ApplicationInformation ConvertToData(DOM.ApplicationInformation ai)
        {
            return new DAL.ApplicationInformation()
            {
                ApplicationEnabled = ai.ApplicationEnabled,
                BusinessName = ai.BusinessName
            };
        }

        public DOM.ApplicationInformation ConvertToDomain(DAL.ApplicationInformation ai)
        {
            return new DOM.ApplicationInformation()
            {
                ApplicationEnabled = ai.ApplicationEnabled,
                BusinessName = ai.BusinessName
            };
        }
    }
}