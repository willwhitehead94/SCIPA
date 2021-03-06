﻿using System;
using SCIPA.Domain.Generic;
using SCIPA.Models;
using ValueType = SCIPA.Models.ValueType;

namespace SCIPA.Domain.Inbound
{
    /// <summary>
    /// Reader class for Database connections. The Reader classes are used to read the approrpiate
    /// data that has been imported by the Handler.  It is important to remember the hierachical
    /// structure of INBOUND data is as follows ( '>' indicates that {left} is part of {right} )
    /// Communicator > Handler > Reader
    /// 
    /// Device's use the above hierachy to read, handle and work with both in and outbound data to/from 
    /// the process.
    /// </summary>
    public abstract class DataReader
    {
        /// <summary>
        /// The handler used for monitoring the connection to the data.
        /// </summary>
        protected DataHandler _handler = null;

        /// <summary>
        /// The device that owns (has produced) any values incoming.
        /// </summary>
        protected Device _parentDevice = null;

        /// <summary>
        /// Returns the number of values available in the queue.
        /// </summary>
        /// <returns></returns>
        public int AvailableValues()
        {
            return _handler.InboundDataQueue.Count;
        }

        /// <summary>
        /// Stores the handler's ValueType. Defaults to STRING.
        /// TODO Create an abstract class for all communicators to remove the need for this.
        /// </summary>
        protected ValueType HandlerValueType = ValueType.String;

        /// <summary>
        /// Once the inbond values are converted to the correct format successfully,
        /// the value is stored here as a string.
        /// </summary>
        protected string Data { get; set; } = "";

        /// <summary>
        /// The most recent 'Value' object.
        /// </summary>
        protected Value InboundData { get; set; }

        /// <summary>
        /// String convert of the most recent 'Value' object.
        /// </summary>
        protected string InboundData_Str { get; set; }

        /// <summary>
        /// Integer convert of the most recent 'Value' object.
        /// </summary>
        protected int InboundData_Int { get; set; }

        /// <summary>
        /// Float convert of the most recent 'Value' object.
        /// Stored as Decimal because of database constraints.s
        /// </summary>
        protected decimal InboundData_Flt { get; set; }

        /// <summary>
        /// Boolean convert of the most recent 'Value' object.
        /// </summary>
        protected bool InboundData_Bln { get; set; }

        /// <summary>
        /// Checks the value is both readable and deqeued from the handler.
        /// If so, the value is taken, converted and stored locally.
        /// Once stored locally, the system will record the 'Value' in the database.
        /// </summary>
        private void GetRequiredValue()
        {
            if (IsReadable() && ValueDequeued())
            {
                if (CutToRequiredLength())
                {
                    if (ConvertValueToFormat())
                    {
                        CommitValueToDatabase();
                    }
                }
            }
        }

        /// <summary>
        /// Checks that the _handler is both available and has items awaiting in the queue.
        /// </summary>
        /// <returns>Success/fail boolean.</returns>
        public bool IsReadable()
        {
            return (_handler != null && _handler.InboundDataQueue.Count > 0);
        }


        /// <summary>
        /// Attempts to dequeue the latest object from the handler.
        /// </summary>
        /// <returns>Success/fail boolean.</returns>
        private bool ValueDequeued()
        {
            try
            {
                InboundData = _handler.InboundDataQueue.Dequeue();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Takes the InboundData and cuts to the desired length based upon the start and end charectors.
        /// </summary>
        /// <returns>Success or fail boolean.</returns>
        private bool CutToRequiredLength()
        {
            Communicator temp = _handler.GetCommunicator();

            string data = InboundData.StringValue;

            int startChar = temp.StartChar;
            int endChar = temp.EndChar;

            bool ReadWholeFile = (startChar == 0) && (endChar == 0);
            bool ReadToEndFromStartChar = (startChar > 0) && (endChar == 0);
            bool ReadToEndCharFromStartChar = (startChar > 0) && (endChar < data.Length);

            try
            {
                if (ReadWholeFile)
                {
                    data = data + "";
                }
                else if (ReadToEndFromStartChar)
                {
                    data = data.Substring(startChar);
                }
                else if (ReadToEndCharFromStartChar)
                {
                    int length = endChar - startChar;
                    data = data.Substring(startChar, length);
                }
            }
            catch (Exception e)
            {
                DebugOutput.Print("The data in the could not be constrained as requested.", e.Message);
                return false;
            }

            InboundData.StringValue = data;
            return true;
        }

        /// <summary>
        /// Converts the string representation of the data to the required format. If successful,
        /// the value is stored back as a string.
        /// </summary>
        /// <returns>Success/fail boolean.</returns>
        private bool ConvertValueToFormat()
        {
            DebugOutput.Print("Converting the value to ", HandlerValueType.ToString());
            bool ConvertedOk = false;

            if (InboundData != null)
            {
                string tempStr;
                tempStr = InboundData.StringValue.ToString();
                InboundData_Str = tempStr;
                InboundData.StringValue = InboundData_Str;

                int tempInt;
                int.TryParse(InboundData.StringValue, out tempInt);
                InboundData_Int = tempInt;
                InboundData.IntegerValue = InboundData_Int;

                decimal tempDecimal;
                decimal.TryParse(InboundData.StringValue, out tempDecimal);
                InboundData_Flt = tempDecimal;
                InboundData.FloatValue = InboundData_Flt;

                bool tempBool;
                bool.TryParse(InboundData.StringValue, out tempBool);
                InboundData_Bln = tempBool;
                InboundData.BooleanValue = InboundData_Bln;

                ConvertedOk = true;
            }


            //switch (HandlerValueType)
            //{
            //    case ValueType.Integer:
            //        {
            //            int convertedInt = int.MinValue;
            //            if (int.TryParse(InboundData.StringValue, out convertedInt))
            //            {
            //                Data = convertedInt.ToString();
            //                InboundData.StringValue = Data;
            //                ConvertedOk = true;
            //            }

            //            break;
            //        }
            //    case ValueType.Float:
            //        {
            //            float convertedFloat = float.MinValue;
            //            if (float.TryParse(InboundData.StringValue, out convertedFloat))
            //            {
            //                Data = convertedFloat.ToString();
            //                InboundData.StringValue = Data;
            //                ConvertedOk = true;
            //            }

            //            break;
            //        }
            //    case ValueType.Boolean:
            //        {
            //            bool returnValue = false;
            //            if (bool.TryParse(InboundData.StringValue, out returnValue))
            //            {
            //                Data = returnValue.ToString();
            //                InboundData.StringValue = Data;
            //                ConvertedOk = true;
            //            }

            //            break;
            //        }
            //    case Models.ValueType.String:
            //        {
            //            Data = InboundData.StringValue.ToString();
            //            InboundData.StringValue = Data;
            //            ConvertedOk = true;
            //            break;
            //        }
            //}

            //If the value conversion was successful, print to console.
            if (ConvertedOk)
            {
                DebugOutput.Print("Converted value successfully: ", Data);
            }
            else
            {
                //Alert user that the value couldn't be converted... Reverting to basic string type.
                DebugOutput.Print("Value could not be converted successfully; stored the following in string format: ", Data);
            }

            return ConvertedOk;
        }

        /// <summary>
        /// Commits the Value to the database as per the DB requirements. 
        /// Also updates the Communicator's 'LastReadTime' value to be the value
        /// from the Value's Update event.
        /// </summary>
        private void CommitValueToDatabase()
        {
            //Commit the Value
            InboundData.Device = _handler.GetCommunicator().Device;
            InboundData.DeviceId = _handler.GetCommunicator().Device.Id;
            InboundData.CommunicatorId = _handler.GetCommunicator().Id;
            var newObj = _handler._repo.CreateValue(InboundData);

            //Update the Communicator
            var comm = _handler.GetCommunicator();
            comm.LastReadTime = InboundData.EventTime;
            _handler._repo.UpdateCommunicator(comm);

            //Commit to MongoDb
            var mongodb = new Data.Repository.MongoRepository();
            mongodb.AddNewValue(newObj);

            //Check Rules against the Value
            var ruleChecker = new RuleChecker();
            ruleChecker.CheckRulesForValue(newObj);
        }

        /// <summary>
        /// Gets the next inbound Value object from the reader. Returns null if there are no new values.
        /// </summary>
        /// <returns>Value object of the next value in the queue.</returns>
        public Value GetNextValue()
        {
            if (AvailableValues() > 0)
            {
                GetRequiredValue();

                return InboundData;
            }

            return null;
        }

        /// <summary>
        /// Public method to get latest value as an int.
        /// </summary>
        /// <returns>Int if the type is int, null otherwise.</returns>
        public int? GetNextValueAsInt()
        {
            if (HandlerValueType== Models.ValueType.Integer)
            {
                if (AvailableValues() > 0)
                {
                    GetRequiredValue();
                    return Convert.ToInt32(Data);
                }
                else
                {
                    DebugOutput.Print("No data available!");
                }
            }
            return null;
        }

        /// <summary>
        /// Public method to get latest value as a float.
        /// </summary>
        /// <returns>Float if the type is float, null otherwise.</returns>
        public float? GetNextValueAsFloat()
        {
            if (HandlerValueType == Models.ValueType.Float)
            {
                if (AvailableValues() > 0)
                {
                    GetRequiredValue();
                    return (float)Convert.ToDouble(Data);
                }
                else
                {
                    DebugOutput.Print("No data available!");
                }
            }
            return null;
        }

        /// <summary>
        /// Public method to get latest value as an boolean.
        /// </summary>
        /// <returns>Boolean if the type is boolean, null otherwise.</returns>
        public bool? GetNextValueAsBoolean()
        {
            if (HandlerValueType == Models.ValueType.Boolean)
            {
                if (AvailableValues() > 0)
                {
                    GetRequiredValue();
                    return Convert.ToBoolean(Data);
                }
                else
                {
                    DebugOutput.Print("No data available!");
                }
                
            }
            return null;
        }

        /// <summary>
        /// Public method to get latest value as a string.
        /// </summary>
        /// <returns>String representation of the latest value.</returns>
        public string GetNextValueAsString()
        {
            GetRequiredValue();

            if (HandlerValueType == Models.ValueType.String)
            {
                if (AvailableValues() > 0)
                {
                    GetRequiredValue();
                    return Data;
                }
                else
                {
                    DebugOutput.Print("No data available!");
                }

            }
            return null;
        }
    }
}