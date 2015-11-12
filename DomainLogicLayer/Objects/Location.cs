using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogicLayer.Objects
{
    class Location
    {
        int LocationId;
        string LocationName;
        string LocationDescription;

        double LocationLong;
        double LocationLat;
        private int id;

        public Location(int id)
        {
            this.id = id;
        }
    }
}
