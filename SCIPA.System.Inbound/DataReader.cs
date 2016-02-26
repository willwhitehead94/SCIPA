using System;
using SCIPA.Domain.Logic;
using SCIPA.Models;
using SCIPA.Models.Resources;

namespace SCIPA.Domain.Inbound
{
    public abstract class DataReader
    {
        /// <summary>
        /// The handler used for monitoring the connection to the data.
        /// </summary>
        protected DataHandler _handler = null;

        /// <summary>
        /// Stores the handler's eType. Defaults to STRING.
        /// TODO Create an abstract class for all communicators to remove the need for this.
        /// </summary>
        protected eType _handlerEType = eType.String;

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
                ConvertValueToFormat();
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
        /// Converts the string representation of the data to the required format. If successful,
        /// the value is stored back as a string.
        /// </summary>
        /// <returns>Success/fail boolean.</returns>
        private bool ConvertValueToFormat()
        {
            DebugOutput.Print("Converting the value to ", _handlerEType.ToString());
            bool ConvertedOk = false;

            switch (_handlerEType)
            {
                case Models.eType.Integer:
                    {
                        int convertedInt = int.MinValue;
                        if (int.TryParse(InboundData.NewValue, out convertedInt))
                        {
                            Data = convertedInt.ToString();
                            ConvertedOk = true;
                        }

                        break;
                    }
                case Models.eType.Float:
                    {
                        float convertedFloat = float.MinValue;
                        if (float.TryParse(InboundData.NewValue, out convertedFloat))
                        {
                            Data = convertedFloat.ToString();
                            ConvertedOk = true;
                        }

                        break;
                    }
                case Models.eType.Boolean:
                    {
                        bool returnValue = false;
                        if (bool.TryParse(InboundData.NewValue, out returnValue))
                        {
                            Data = returnValue.ToString();
                            ConvertedOk = true;
                        }

                        break;
                    }
                case Models.eType.String:
                    {
                        Data = InboundData.NewValue.ToString();
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
        /// Public method to get latest value as an int.
        /// </summary>
        /// <returns>Int if the type is int, null otherwise.</returns>
        public int? GetInteger()
        {
            if (_handlerEType== Models.eType.Integer)
            {
                GetRequiredValue();
                return Convert.ToInt32(Data);
            }
            return null;
        }

        /// <summary>
        /// Public method to get latest value as a float.
        /// </summary>
        /// <returns>Float if the type is float, null otherwise.</returns>
        public float? GetFloat()
        {
            if (_handlerEType == Models.eType.Float)
            {
                GetRequiredValue();
                return (float)Convert.ToDouble(Data);
            }
            return null;
        }

        /// <summary>
        /// Public method to get latest value as an boolean.
        /// </summary>
        /// <returns>Boolean if the type is boolean, null otherwise.</returns>
        public bool? GetBoolean()
        {
            if (_handlerEType == Models.eType.Boolean)
            {
                GetRequiredValue();
                return Convert.ToBoolean(Data);
            }
            return null;
        }

        /// <summary>
        /// Public method to get latest value as a string.
        /// </summary>
        /// <returns>String representation of the latest value.</returns>
        public string GetString()
        {
            GetRequiredValue();

            if (Data.Equals(""))
            {
                DebugOutput.Print("No serial data available from the COM Port "); //_handler.Communicator.comPort //TODO See note at top - add Communicator in!
            }

            return Data;
        }
    }
}