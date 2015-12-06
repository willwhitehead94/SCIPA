﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class AlarmType
    {
        private int _id;

        private string _alarmType;

        public int Id
        {
            get { return _id; }
        }

        public string AlarmValueType
        {
            get { return _alarmType; }
            set { _alarmType = value; }
        }

        public AlarmType(int id, string type)
        {
            _id = id;
            _alarmType = type;
        }

    }
}
