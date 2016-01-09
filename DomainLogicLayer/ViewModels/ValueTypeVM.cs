using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  DomainLogicLayer.ViewModels
{
    public class ValueTypeVM
    {
        private int _id;

        private string _valueType;

        public int Id
        {
            get { return _id; }
        }

        public string Type
        {
            get { return _valueType; }
            set { _valueType = value; }
        }

        public ValueTypeVM(int id, string type)
        {
            _id = id;
            _valueType = type;
        }
    }

}
