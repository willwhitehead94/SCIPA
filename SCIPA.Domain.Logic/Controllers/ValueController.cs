using System.Collections.Generic;
using SCIPA.Data.Repository;
using SCIPA.Models;

namespace SCIPA.Domain.Logic
{
    public class ValueController
    {
        public ICollection<Value> GetValuesForDevice(Device device)
        {
            var repo = new MongoRepository();
            return repo.GetAllValuesForDevice(device.Id);
        }  
    }
}