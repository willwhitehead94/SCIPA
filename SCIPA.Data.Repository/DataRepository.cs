using System;
using System.Collections.Generic;
using SCIPA.Models;

namespace SCIPA.Data.Repository
{
    public class DataRepository : IRepository
    {
        AccessLayer.DataController _dbController = new AccessLayer.DataController();

        public ICollection<Device> RetrieveAllDevices()
        {
            
        }
    }
}
