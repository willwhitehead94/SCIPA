using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    abstract class Model
    {
        private int _id;

        private bool _enabled;

        public int Id
        {
            get { return _id; }
        }

        public bool IsEnabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }
    }
}
