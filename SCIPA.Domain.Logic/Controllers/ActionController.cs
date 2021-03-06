﻿using System.Collections.Generic;
using System.Runtime.InteropServices;
using SCIPA.Data.Repository;
using SCIPA.Models;

namespace SCIPA.Domain.Logic
{
    /// <summary>
    /// Controller class for all Action objects within the application.
    /// </summary>
    public class ActionController
    {
        /// <summary>
        /// Static list of all known Actions as per the database.
        /// </summary>
        public static List<Action> _allActions = new List<Action>();

        /// <summary>
        /// Local access to the SQL Database repository.
        /// </summary>
        private RelationalRepository _repo = new RelationalRepository();

        /// <summary>
        /// Creates a new isntance of an Action object both for application use and the
        /// database. The new object is pushed to the database immediately.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public Action CreateAction(Action action)
        {
            var newAction = _repo.CreateAction(action);
            _allActions.Add(newAction);
            return newAction;
        }

        public IEnumerable<Action> RetrieveActionsForRule(int ruleId)
        {
            var temp = _repo.RetrieveActionsForRule(ruleId);
            return temp;
        }

        /// <summary>
        /// Updates the existing Action object on the database if it exists. Ignores otherwise.
        /// </summary>
        /// <param name="action"></param>
        /// <returns></returns>
        public Action UpdateAction(Action action)
        {
            var temp = _repo.UpdateAction(action);
            return temp;
        }


    }
}