using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIPA.Data.Repository;

namespace SCIPA.DomainLogic
{
    public class SharedResources
    {
        DataRepository _repo = new DataRepository();
        public SharedResources()
        {
        }

        public int GetValueCount()
        {
            return _repo.RetrieveAllValues().Count;
        }
    }
}
