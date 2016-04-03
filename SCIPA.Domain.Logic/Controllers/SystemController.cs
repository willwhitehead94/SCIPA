using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIPA.Data.Repository;

namespace SCIPA.Domain.Logic
{
    public class SystemController
    {
        public void ClearSql()
        {
            
        }

        public void ClearMongo()
        {
            
        }

        public void ClearLog()
        {
            RelationalRepository.ClearSql();
        }
    }
}
