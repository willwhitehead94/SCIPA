using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Device
    {
        private int _id { get; set; }

        private string _name { get; set; }

        private bool _readOnly { get; set; }

        private int? _locationId { get; set; }

        private double? _faultTolerance { get; set; }

        private int _valueTypeId { get; set; }

        private int _lowestValue { get; set; }

        private int _highestValue { get; set; }

        public Device(int id, string name, bool readOnly, int? locationId, double? faultTolerance, int valueTypeId, int lowestValue, int highestValue)
        {
            this._id = id;
            this._name = name;
            this._readOnly = readOnly;
            this._locationId = locationId;
            this._faultTolerance = faultTolerance;
            this._valueTypeId = valueTypeId;
            this._lowestValue = lowestValue;
            this._highestValue = highestValue;
        }

        public Device(string id, string name, string readOnly, string locationId, string faultTolerance, string valueTypeId, string lowestValue, string highestValue)
        {
            this._id = Convert.ToInt32(id);
            this._name = name;
            this._readOnly = Convert.ToBoolean(readOnly);
            this._locationId = Convert.ToInt32(locationId);
            this._faultTolerance = Convert.ToDouble(faultTolerance);
            this._valueTypeId = Convert.ToInt32(valueTypeId);
            this._lowestValue = Convert.ToInt32(lowestValue);
            this._highestValue = Convert.ToInt32(highestValue);

        }
    }
}
