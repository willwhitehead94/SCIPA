﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Rule
    {
        private int _id;

        private int _deviceId;

        private string _ruleText;

        public int Id
        {
            get { return _id; }
        }

        public int DeviceId
        {
            get { return _deviceId; }
            set { _deviceId = value; }
        }

        public string RuleText
        {
            get { return _ruleText; }
            set { _ruleText = value; }
        }

        public Rule (int id, int deviceId, string ruleText)
        {
            _id = id;
            DeviceId = deviceId;
            RuleText = ruleText;
        }

        public Rule (string id, string deviceId, string ruleText)
        {
            _id = Convert.ToInt32(id);
            DeviceId = Convert.ToInt32(deviceId);
            RuleText = ruleText;
        }

    }

}