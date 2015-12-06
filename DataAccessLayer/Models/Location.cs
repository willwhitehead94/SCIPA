using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Location
    {
        private int _id { get; set; }

        private string _name { get; set; }

        private double? _longitude { get; set; }

        private double? _latitude { get; set; }

        private string _notes { get; set; }


        public int Id
        {
            get { return _id; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double? Longitude
        {
            get { return _longitude; }
            set { _longitude = value;}
        }

        public double? Latitude
        {
            get { return _latitude; }
            set { _latitude = value; }
        }

        public string Notes
        {
            get { return _notes; }
            set { _notes = value; }
        }


        public Location (int id, string name, double? longitude, double? latitude, string notes)
        {
            _id = id;
            Name = name;
            Longitude = longitude;
            Latitude = latitude;
            Notes = notes;
        }

        public Location (string id, string name, string longitude, string latitude, string notes)
        {
            _id = Convert.ToInt32(id);

            Name = name;

            double temp = double.MinValue;
            if(double.TryParse(longitude, out temp))
            {
                Longitude = temp;
            }
            else
            {
                Longitude = null;
            }

            temp = double.MinValue;
            if (double.TryParse(latitude,out temp))
            {
                Latitude = temp;
            }
            else
            {
                Latitude = null;
            }

            Notes = notes;

        }
    }

}
