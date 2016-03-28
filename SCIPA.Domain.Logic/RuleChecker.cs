using System;
using System.Collections.Generic;
using System.Linq;
using SCIPA.Data.Repository;
using SCIPA.Domain.Generic;
using SCIPA.Domain.Logic;
using SCIPA.Models;
using ValueType = SCIPA.Models.ValueType;

namespace SCIPA.Domain.Inbound
{
    /// <summary>
    /// This class is used to check values against any Rules that may be in place for the device.
    /// </summary>
    public class RuleChecker
    {
        /// <summary>
        /// Access to the relationtional data repository.
        /// </summary>
        private IRelationalRepository _repo = new RelationalRepository();

        /// <summary>
        /// Instance of the RuleController class.
        /// </summary>
        private RuleController _controller = new RuleController();

        /// <summary>
        /// Check each Rule for the given Device and "TakeAction" where neccessary.
        /// </summary>
        /// <param name="value"></param>
        public void CheckRulesForValue(Value value)
        {
            //List of Rules for the appropriate device.
            var applicableRules = RuleController.GetAllRules().Where(r => r.DeviceId == value.DeviceId);

            //For every rule associated with the Device, check the Value does not break any Rules.
            //Any Rule that matches it's constraint will be passed to the 'TakeAction' method.
            foreach (var rule in applicableRules.Where(rule => CriteraMet(rule, value))) TakeAction(rule,value);
        }

        /// <summary>
        /// Determines whether or not the Rule's criteria has been met depending on the values selected by the
        /// Rule.
        /// </summary>
        /// <param name="rule"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        private bool CriteraMet(Rule rule, Value value)
        {
            //Prepare an error message to show if rule checking fails.
            var errorMsg = $"Could not check Rule {rule.Id} for '{rule.Device}'! There may have been an issue with the RuleType?";
            
            //Prepare to handle Rules of type 'Between' by pre-splitting the constraints.
            var betweenBreaker = '#';
            string constraintValueOne="", constraintValueTwo="";
            if (rule.RuleType == RuleType.Between)
            {
                //Attempt to split, if fail, print warning and fail the rule.
                try
                {
                    //Constraint splitting.
                    constraintValueOne = rule.Constraint.Substring(0, rule.Constraint.IndexOf(betweenBreaker));
                    constraintValueTwo = rule.Constraint.Substring( rule.Constraint.IndexOf(betweenBreaker)+1);
                }
                catch (Exception)
                {
                    DebugOutput.Print($"The rule (#{rule.Id}) is set to investigate values between a set range, but this could not be understood. Check the constraint!");
                    return false;
                }
            }

            //Switching on the ValueType first as some values will not allow some RuleTypes (i.e. a string cannot be </>/<=/>=)
            switch (rule.ValueType)
            {
                case ValueType.String:
                    switch (rule.RuleType)
                    {
                        case RuleType.EqualTo:
                            return (value.StringValue.Trim().Equals(rule.Constraint.Trim()));
                        case RuleType.Not:
                            return (value.StringValue.Trim().Equals(rule.Constraint.Trim()));
                        default:
                            DebugOutput.Print(errorMsg);
                            break;
                    }
                    break;
                case ValueType.Integer:
                    switch (rule.RuleType)
                    {
                        case RuleType.LessThan:
                            return (value.IntegerValue < ConvertInt(rule.Constraint));
                        case RuleType.LessThanEqualTo:
                            return (value.IntegerValue <= ConvertInt(rule.Constraint));
                        case RuleType.EqualTo:
                            return (value.IntegerValue == ConvertInt(rule.Constraint));
                        case RuleType.MoreThanEqualTo:
                            return (value.IntegerValue >= ConvertInt(rule.Constraint));
                        case RuleType.MoreThan:
                            return (value.IntegerValue > ConvertInt(rule.Constraint));
                        case RuleType.Not:
                            return (value.IntegerValue != ConvertInt(rule.Constraint));
                        case RuleType.Between:
                            return ((value.IntegerValue >= ConvertInt(constraintValueOne)) && (value.IntegerValue<=ConvertInt(constraintValueTwo)));
                        default:
                            DebugOutput.Print(errorMsg);
                            break;
                    }
                    break;
                case ValueType.Float:
                    switch (rule.RuleType)
                    {
                        case RuleType.LessThan:
                            return (value.FloatValue < ConvertDecimal(rule.Constraint));
                        case RuleType.LessThanEqualTo:
                            return (value.FloatValue <= ConvertDecimal(rule.Constraint));
                        case RuleType.EqualTo:
                            return (value.FloatValue == ConvertDecimal(rule.Constraint));
                        case RuleType.MoreThanEqualTo:
                            return (value.FloatValue >= ConvertDecimal(rule.Constraint));
                        case RuleType.MoreThan:
                            return (value.FloatValue > ConvertDecimal(rule.Constraint));
                        case RuleType.Not:
                            return (value.FloatValue != ConvertDecimal(rule.Constraint));
                        case RuleType.Between:
                            return ((value.FloatValue>= ConvertDecimal(constraintValueOne)) && (value.FloatValue<= ConvertDecimal(constraintValueTwo)));
                        default:
                            DebugOutput.Print(errorMsg);
                            break;
                    }
                    break;
                case ValueType.Boolean:
                    switch (rule.RuleType)
                    {
                        case RuleType.EqualTo:
                            return (value.BooleanValue == ConvertBool(rule.Constraint));
                        default:
                            DebugOutput.Print(errorMsg);
                            break;
                    }
                    break;
                default:
                    DebugOutput.Print(errorMsg);
                    break;
            }

            //Upon failure of conversion, the break statements will fall through.
            return false;
        }

        /// <summary>
        /// When a Rule's critera have been met, this method is called to execute any
        /// and all Actions as per the Rule's settings.
        /// An Alarm is also raised from here.
        /// </summary>
        /// <param name="rule">The passed rule.</param>
        /// <param name="value">The value that passed the rule.</param>
        private void TakeAction(Rule rule, Value value)
        {
            //Handle any requirement to Alarm.
            if (rule.Alarm)
            {
                //Create accessor to the AlarmController class.
                var controller = new AlarmController();

                //Create a new Alarm object as per the model.
                var alarm = new Alarm()
                {
                    //Id = Guid.NewGuid(),
                    Rule = rule,
                    RuleId = rule.Id,
                    Device = rule.Device,
                    DeviceId = rule.DeviceId,
                    Value = value,
                    ValueId = value.Id,
                    TimeStamp = value.EventTime,
                    Accepted = false
                };

                //Pass the alarm object to the AlarmController.
                controller.CreateAlarm(alarm);
            }

            //Handle any Actions to be taken.
            if (rule.Action != null)
            {
                //TODO Implement the required action!
            }
        }

        /// <summary>
        /// Converts the constraint string to an Integer.
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns></returns>
        private int? ConvertInt(string constraint)
        {
            var intVal = int.MinValue;
            if (int.TryParse(constraint, out intVal))
            {
                return intVal;
            }

            return null;
        }

        /// <summary>
        /// Converts the constraint string to an Decimal (Float).
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns></returns>
        private decimal? ConvertDecimal(string constraint)
        {
            var decVal = decimal.MinValue;
            if (decimal.TryParse(constraint, out decVal))
            {
                return decVal;
            }

            return null;
        }

        /// <summary>
        /// Converts the constraint string to an Boolean.
        /// </summary>
        /// <param name="constraint"></param>
        /// <returns></returns>
        private bool? ConvertBool(string constraint)
        {
            var boolVal = false;
            if (bool.TryParse(constraint, out boolVal))
            {
                return boolVal;
            }

            return null;
        }


    }
}