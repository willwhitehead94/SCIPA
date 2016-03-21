using System;
using System.Data.Common;
using System.IO;
using SCIPA.Domain.Generic;
using SCIPA.Domain.Logic;
using SCIPA.Models;
using ValueType = SCIPA.Models.ValueType;

namespace SCIPA.Domain.Inbound
{
    public abstract class DataReader
    {
        /// <summary>
        /// The handler used for monitoring the connection to the data.
        /// </summary>
        protected DataHandler _handler = null;

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
        /// Checks the value is both readable and deqeued from the handler.
        /// If so, the value is taken, converted and stored locally.
        /// </summary>
        private void GetRequiredValue()
        {
            if (IsReadable() && ValueDequeued())
            {
                if (CutToRequiredLength())
                {
                    ConvertValueToFormat();
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

            switch (HandlerValueType)
            {
                case Models.ValueType.Integer:
                    {
                        int convertedInt = int.MinValue;
                        if (int.TryParse(InboundData.StringValue, out convertedInt))
                        {
                            Data = convertedInt.ToString();
                            InboundData.StringValue = Data;
                            ConvertedOk = true;
                        }

                        break;
                    }
                case Models.ValueType.Float:
                    {
                        float convertedFloat = float.MinValue;
                        if (float.TryParse(InboundData.StringValue, out convertedFloat))
                        {
                            Data = convertedFloat.ToString();
                            InboundData.StringValue = Data;
                            ConvertedOk = true;
                        }

                        break;
                    }
                case Models.ValueType.Boolean:
                    {
                        bool returnValue = false;
                        if (bool.TryParse(InboundData.StringValue, out returnValue))
                        {
                            Data = returnValue.ToString();
                            InboundData.StringValue = Data;
                            ConvertedOk = true;
                        }

                        break;
                    }
                case Models.ValueType.String:
                    {
                        Data = InboundData.StringValue.ToString();
                        InboundData.StringValue = Data;
                        ConvertedOk = true;
                        break;
                    }
            }

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

            if (Data.Equals(""))
            {
                DebugOutput.Print("No data available!"); //TODO See note at top - add CommunicatorModel in!
            }

            return Data;
        }
    }
}