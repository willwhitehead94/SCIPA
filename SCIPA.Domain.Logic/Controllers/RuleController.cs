using System.Collections.Generic;
using System.Linq;
using SCIPA.Data.Repository;
using SCIPA.Models;

namespace SCIPA.Domain.Logic
{
    public class RuleController
    {
        /// <summary>
        /// All rules as on the database.
        /// </summary>
        private static ICollection<Rule> _rules = new List<Rule>();

        /// <summary>
        /// If true, the ICollection of _rules may be out of date and, as such,
        /// the system should download a new copy of the list from the database
        /// when is next appropriate.
        /// 
        /// Set to True initially to enable the population of the collection.
        /// </summary>
        public static bool UpdateRequired = true;

        /// <summary>
        /// Access to the relationtional data repository.
        /// </summary>
        private static IRelationalRepository _repo = new RelationalRepository();

        public static ICollection<Rule> GetAllRules()
        {
            UpdateRuleCollection();
            return _rules;
        } 

        /// <summary>
        /// Downloads all rules from the database if the system is due to refresh
        /// Rule collection, otherwise does nothing.
        /// </summary>
        private static void UpdateRuleCollection()
        {
            if (!UpdateRequired) return;
            _rules = _repo.RetrieveAllRules().ToList();
            UpdateRequired = false;
        }

        /// <summary>
        /// Create a new Rule on the database.
        /// </summary>
        /// <param name="rule"></param>
        public Rule CreateRule(Rule rule)
        {
            //Create new rule and store the new object.
            var newObj = _repo.CreateRule(rule);

            //Add the new rule to the list of rules.
            _rules.Add(newObj);

            //Return the new rule to the caller.
            return newObj;
        }

        public Rule RetrieveRuleById(int id)
        {
            if (_rules == null || _rules.Count ==0)
            {
                UpdateRequired = true;
                UpdateRuleCollection();
            }

            return _rules.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Rule> RetrieveRulesForDevice(int deviceId)
        {
            if (_rules == null || _rules.Count == 0)
            {
                UpdateRequired = true;
                UpdateRuleCollection();
            }

            return _rules.Where(r => r.DeviceId == deviceId);
        }

        public Rule UpdateRule(Rule rule)
        {
            return rule;
        }


        public Rule TestMethod_GetLatestRule()
        {
            UpdateRuleCollection();
            return _rules.Last();
        }
    }
}