using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLogicLayer.Objects
{
    class Rule
    {
        int Id;
        string Name;
        string Description;
        string Condition;
        Command TrueCommand;
        Command FalseCommand;
        private int tempRuleRecordId;

        public Rule(int tempRuleRecordId)
        {
            this.tempRuleRecordId = tempRuleRecordId;
        }
    }
}
