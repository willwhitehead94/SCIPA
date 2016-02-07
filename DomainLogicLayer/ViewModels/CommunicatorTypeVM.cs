﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class CommunicatorTypeVM
    {
        private int _id;

        private string _communicatorType;

        public int Id
        {
            get { return _id; }
        }

        public string AlarmValueType
        {
            get { return _communicatorType; }
            set { _communicatorType = value; }
        }

        public CommunicatorTypeVM(int id, string type)
        {
            _id = id;
            _communicatorType = type;
        }

    }

}