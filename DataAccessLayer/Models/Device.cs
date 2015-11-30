using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Device
    {
        public bool changesMade = false;

        private int _id { get; set; }

        private string _name { get; set; }

        private bool _readOnly { get; set; }

        private int? _locationId { get; set; }

        private double? _faultTolerance { get; set; }

        private int _valueTypeId { get; set; }

        private double? _lowestValue { get; set; }

        private double? _highestValue { get; set; }

        private bool _enabled { get; set; }

        /// <summary>
        /// A nullable, blank instantiation of a Device object.
        /// </summary>
        public Device()
        {
            //This is a blank and nullable device.
        }

        /// <summary>
        /// Constructor for a new, full-bodied Device object, accepting parameters for all device information.
        /// </summary>
        /// <param name="id">Identification number</param>
        /// <param name="name">Human-friendly name</param>
        /// <param name="readOnly">Boolean as to whether the object is updatable</param>
        /// <param name="locationId">The ID of the location (as per the RDB)</param>
        /// <param name="faultTolerance">The fault tolerance to allow within the lowest-to-highest range</param>
        /// <param name="valueTypeId">ID of the value type (i.e. string, int, double etc)</param>
        /// <param name="lowestValue">The lowest acceptable value from this Device</param>
        /// <param name="highestValue">The highest accetpable value from this Device</param>
        /// <param name="enabled">Boolean as to whether this Device is currently enabled</param>
        public Device(int id, string name, bool readOnly, int? locationId, double? faultTolerance, int valueTypeId, double lowestValue, double highestValue, bool enabled = true)
        {
            this._id = id;
            this._name = name;
            this._readOnly = readOnly;
            this._locationId = locationId;
            this._faultTolerance = faultTolerance;
            this._valueTypeId = valueTypeId;
            this._lowestValue = lowestValue;
            this._highestValue = highestValue;
            this._enabled = enabled;
        }

        /// <summary>
        /// String based constructor for a new, full-bodied Device object. Usually called by the controller following a download/read from the RDB.
        /// </summary>
        /// <param name="id">Identification number</param>
        /// <param name="name">Human-friendly name</param>
        /// <param name="readOnly">Boolean as to whether the object is updatable</param>
        /// <param name="locationId">The ID of the location (as per the RDB)</param>
        /// <param name="faultTolerance">The fault tolerance to allow within the lowest-to-highest range</param>
        /// <param name="valueTypeId">ID of the value type (i.e. string, int, double etc)</param>
        /// <param name="lowestValue">The lowest acceptable value from this Device</param>
        /// <param name="highestValue">The highest accetpable value from this Device</param>
        /// <param name="enabled">Boolean as to whether this Device is currently enabled</param>
        public Device(string id, string name, string readOnly, string locationId, string faultTolerance, string valueTypeId, string lowestValue, string highestValue, string enabled = "true")
        {
            int tempInt = int.MinValue;
            double tempDouble = double.MinValue;
            bool tempBool = false;

            //Reads and sets the id number of the device.
            int.TryParse(id, out tempInt);
            _id = tempInt;

            //No conversion required for the name.
            _name = name;

            //Location can be null, and as such, must allow for this to be the case.
            if (int.TryParse(locationId, out tempInt))
            {
                _locationId = tempInt;
            }
            else
            {
                _locationId = null;
            }

            //FaultTolerance can be null, and as such, must allow for this to be the case.
            if (double.TryParse(faultTolerance,out tempDouble))
            {
                _faultTolerance = tempDouble;
            }
            else
            {
                _faultTolerance = null;
            }

            //ValueTypeId is a required value, and always will be. There's no requirement therefore to test for null values.
            int.TryParse(valueTypeId, out tempInt);
            _valueTypeId = tempInt;

            //The Lowest and Highest values are both optional, and thus should check for null values.
            if (double.TryParse(lowestValue, out tempDouble))
            {
                _lowestValue = tempInt;
            }
            else
            {
                _lowestValue = null;
            }

            if (double.TryParse(highestValue, out tempDouble))
            {
                _highestValue = tempInt;
            }
            else
            {
                _highestValue = null;
            }

            //Enabled is an optional param, so if nothing is passed, a true value is assigned regardless.
            //No further data checks required.
            _enabled = Convert.ToBoolean(enabled);

        }
        
        /// <summary>
        /// Get the ID number of the current Device.
        /// </summary>
        /// <returns>ID Number</returns>
        public int GetId()
        {
            return _id;
        }

        /// <summary>
        /// Get the Name of the current Device.
        /// </summary>
        /// <returns>Name</returns>
        public string GetName()
        {
            return _name;
        }

        /// <summary>
        /// Set the Name of the current Device.
        /// </summary>
        /// <param name="name">New Name</param>
        public void SetName(string name)
        {
            _name = name;
            changesMade = true;
        }

        /// <summary>
        /// Get whether or not the Device is read only.
        /// </summary>
        /// <returns>Read Only State</returns>
        public bool IsReadOnly()
        {
            return _readOnly;
        }

        /// <summary>
        /// Sets whether or not the Device is read only.
        /// </summary>
        /// <param name="readOnly">New Read Only State</param>
        public void SetReadOnly(bool readOnly)
        {
            _readOnly = readOnly;
            changesMade = true;
        }

        /// <summary>
        /// Gets the ID number of the location of this Device.
        /// This can be used to download Location data from the appropriate controller.
        /// </summary>
        /// <returns>Location ID</returns>
        public int? GetLocationId()
        {
            return _locationId;
        }

        /// <summary>
        /// Sets the ID of the location of this Device.
        /// </summary>
        /// <param name="id">Location ID</param>
        public void SetLocation(int id)
        {
            _locationId = id;
            changesMade = true;
        }

        /// <summary>
        /// Sets the Location of this Device from a physical Location object.
        /// </summary>
        /// <param name="location">Location object</param>
        public void SetLocation(Location location)
        {
            SetLocation(location.GetId());
            changesMade = true;
        }

        /// <summary>
        /// Gets the acceptable Fault Tolerance for this Device.
        /// </summary>
        /// <returns>Fault Tolerance</returns>
        public double? GetFaultTolerance()
        {
            return _faultTolerance;
        }

        /// <summary>
        /// Sets the acceptable Fault Tolerance for this Device.
        /// </summary>
        /// <param name="tolerance">New Fault Tolerance</param>
        public void SetFaultTolerance(double tolerance)
        {
            _faultTolerance = tolerance;
        }

        /// <summary>
        /// Gets the Value Type (by ID) for this Device.
        /// </summary>
        /// <returns>ID of the Value Type</returns>
        public int GetValueTypeId()
        {
            return _valueTypeId;
        }

        /// <summary>
        /// Sets the Value Type of this Device (by ID).
        /// </summary>
        /// <param name="id">New Value Type ID</param>
        public void SetValueType(int id)
        {
            _valueTypeId = id;
            changesMade = true;
        }

        /// <summary>
        /// Sets the Value Type of this Device (by ValueType object).
        /// </summary>
        /// <param name="valueType">New Value Type</param>
        public void SetValueType(ValueType valueType)
        {
            SetValueType(valueType.GetId());
            changesMade = true;
        }

        /// <summary>
        /// Gets the lowest acceptable value.
        /// </summary>
        /// <returns>Lowest Value</returns>
        public double? GetLowestValue()
        {
            return _lowestValue;
        }

        /// <summary>
        /// Sets the lowest acceptable value for this Device.
        /// </summary>
        /// <param name="lowest">New Lowest Value</param>
        public void SetLowestValue(double lowest)
        {
            _lowestValue = lowest;
            changesMade = true;
        }


        /// <summary>
        /// Gets the highest acceptable value for this Device.
        /// </summary>
        /// <returns>Highest Value</returns>
        public double? GetHighestValue()
        {
            return _highestValue;
        }

        /// <summary>
        /// Sets the highest acceptable value for this Device.
        /// </summary>
        /// <param name="highest">New Highest Value</param>
        public void SetHighestValue(double highest)
        {
            _highestValue = highest;
            changesMade = true;
        }

        /// <summary>
        /// Returns a boolean as to whether or not the device is 'enabled'.
        /// </summary>
        /// <returns>Boolean</returns>
        public bool IsEnabled()
        {
            return _enabled;
        }


    }
}
