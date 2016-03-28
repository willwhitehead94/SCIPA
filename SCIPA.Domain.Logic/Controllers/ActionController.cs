using System.Collections.Generic;
using SCIPA.Data.Repository;
using SCIPA.Models;

namespace SCIPA.Domain.Logic
{
    public class ActionController
    {
        public static List<Action> _allActions = new List<Action>();

        private RelationalRepository _repo = new RelationalRepository();

        public ActionController()
        {
            
        }

        public Action CreateAction(Action action)
        {
            var newAction = _repo.CreateAction(action);
            _allActions.Add(newAction);
            return newAction;
        }
    }
}