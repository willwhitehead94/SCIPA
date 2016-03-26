using System;
using System.Collections.Generic;
using System.Linq;
using SCIPA.Data.Repository;
using SCIPA.Domain.Generic;
using SCIPA.Models;
using ValueType = SCIPA.Models.ValueType;

namespace SCIPA.Domain.Inbound
{
    public class RuleChecker
    {
        /// <summary>
        /// All rules as on the database.
        /// </summary>
        private static ICollection<Rule> _rules;

        /// <summary>
        /// If true, the ICollection of Rules may be out of date and, as such,
        /// the system should download a new copy of the list from the database
        /// when is next appropriate.
        /// 
        /// Set to True initially to enable the population of the collection.
        /// </summary>
        private static bool _updateRuleList = true;

        /// <summary>
        /// Access to the relationtional data repository.
        /// </summary>
        private IRelationalRepository _repo = new RelationalRepository();

        /// <summary>
        /// Downloads all rules from the database if the system is due to refresh
        /// Rule collection, otherwise does nothing.
        /// </summary>
        public void UpdateRuleCollection()
        {
            if (!_updateRuleList) return;
            _rules = _repo.RetrieveAllRules().ToList();
            _updateRuleList = false;
        }

        public RuleChecker()
        {
            UpdateRuleCollection();
        }

        public void CheckRulesForDevice(Device device)
        {
            
        }

        public void CheckRulesForValue(Value value)
        {
            var applicableRules = _rules.Where(r => r.DeviceId == value.DeviceId);

            foreach (var rule in applicableRules)
            {
                
            }
        }

        private bool CriteraMet(Rule rule, Value value)
        {
            var errorMsg = $"Could not check Rule {rule.Id} for '{rule.Device}'!";

            switch (rule.ValueType)
            {
                case ValueType.String:
                    switch (rule.RuleType)
                    {
                        case RuleType.EqualTo:
                            break;
                        case RuleType.Not:
                            break;
                        default:
                            DebugOutput.Print(errorMsg);
                            break;
                    }
                    break;
                case ValueType.Integer:
                    switch (rule.RuleType)
                    {
                        case RuleType.LessThan:
                            break;
                        case RuleType.LessThanEqualTo:
                            break;
                        case RuleType.EqualTo:
                            break;
                        case RuleType.MoreThanEqualTo:
                            break;
                        case RuleType.MoreThan:
                            break;
                        case RuleType.Not:
                            break;
                        case RuleType.Between:
                            break;
                        default:
                            DebugOutput.Print(errorMsg);
                            break;
                    }
                    break;
                case ValueType.Float:
                    switch (rule.RuleType)
                    {
                        case RuleType.LessThan:
                            break;
                        case RuleType.LessThanEqualTo:
                            break;
                        case RuleType.EqualTo:
                            break;
                        case RuleType.MoreThanEqualTo:
                            break;
                        case RuleType.MoreThan:
                            break;
                        case RuleType.Not:
                            break;
                        case RuleType.Between:
                            break;
                        default:
                            DebugOutput.Print(errorMsg);
                            break;
                    }
                    break;
                case ValueType.Boolean:
                    switch (rule.RuleType)
                    {
                        case RuleType.EqualTo:
                            break;
                        default:
                            DebugOutput.Print(errorMsg);
                            break;
                    }
                    break;
                default:
                    DebugOutput.Print(errorMsg);
                    break;
            }
        }

        private int? ConvertInt(string constraint)
        {
            var intVal = int.MinValue;
            if (int.TryParse(constraint, out intVal))
            {
                return intVal;
            }

            return null;
        }

        private decimal? ConvertDecimal(string constraint)
        {
            var decVal = decimal.MinValue;
            if (decimal.TryParse(constraint, out decVal))
            {
                return decVal;
            }

            return null;
        }

        private bool? ConvertBool(string constraint)
        {
            var boolVal = false;
            if (bool.TryParse(constraint, out boolVal))
            {
                return boolVal;
            }

            return null;
        }

        //private T ConvertConstraint<T>(string constraint)
        //{
        //    if (T is Type(int))
        //    {

        //    }
        //}

        //private bool IntegerCheck(int value, string constraint)
        //{

        //}

        //private bool FloatCheck(decimal value, string constraint)
        //{

        //}

        //private bool BoolCheck(bool value, string constaint)
        //{

        //}

        //private bool StringCheck(bool value, string constraint)
        //{

        //}
    }
}