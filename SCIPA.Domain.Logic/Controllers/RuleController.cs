using System.Collections.Generic;
using System.Linq;
using SCIPA.Data.Repository;
using SCIPA.Models;

namespace SCIPA.Domain.Logic
{
    /// <summary>
    /// Controller class for all Rule objects within the application.
    /// </summary>
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

        /// <summary>
        /// Returns a list of all known Rule objects to the caller.
        /// </summary>
        /// <returns></returns>
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
            _rules.Clear();
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

        /// <summary>
        /// Returns a single Rule object via it's ID number.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Rule RetrieveRuleById(int id)
        {
            if (_rules == null || _rules.Count ==0)
            {
                UpdateRequired = true;
                UpdateRuleCollection();
            }

            return _rules.FirstOrDefault(r => r.Id == id);
        }

        /// <summary>
        /// Returns a list of Rules that are associated with 
        /// a given Device via the Device ID.
        /// </summary>
        /// <param name="deviceId"></param>
        /// <returns></returns>
        public IEnumerable<Rule> RetrieveRulesForDevice(int deviceId)
        {
            if (_rules == null || _rules.Count == 0)
            {
                UpdateRequired = true;
                UpdateRuleCollection();
            }

            return _rules.Where(r => r.DeviceId == deviceId);
        }

        /// <summary>
        /// Updates a Rule that already exists on the database.
        /// </summary>
        /// <param name="rule"></param>
        /// <returns></returns>
        public Rule UpdateRule(Rule rule)
        {
            return _repo.UpdateRule(rule);
        }

        /// <summary>
        /// Used during development, this method simply returns the newest 
        /// Rule on the database.
        /// </summary>
        /// <returns></returns>
        public Rule TestMethod_GetLatestRule()
        {
            UpdateRuleCollection();
            if (_rules.Where(r => r.Id == 0).Any())
            {
                //dont want 0 IDs
                UpdateRequired = true;
                UpdateRuleCollection();
            }

            return _rules.Last();
        }
    }
}