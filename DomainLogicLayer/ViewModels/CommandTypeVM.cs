using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class CommandTypeVM
    {
        private int _id;

        private string _commandType;

        public int Id
        {
            get { return _id; }
        }

        public string CommandValueType
        {
            get { return _commandType; }
            set { _commandType = value; }
        }

        public CommandTypeVM(int id, string type)
        {
            _id = id;
            _commandType = type;
        }

    }
}
