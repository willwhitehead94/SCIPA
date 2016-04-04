using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using SCIPA.Domain.Logic;
using SCIPA.Models;

namespace SCIPA.UI.WebSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var controller = new AlarmController();
            var devCont = new DeviceController();
            var valCont = new ValueController();
            var rulCont = new RuleController();

            var alarmList = controller.GetAllAlarms(72);
            ICollection<SCIPA.Models.Alarm> allAlarms= new List<Alarm>();

            foreach (var alarm in alarmList)
            {
                alarm.Device = devCont.RetrieveDevice(alarm.DeviceId);
                alarm.Value = valCont.GetValueById(alarm.ValueId);
                alarm.Rule = rulCont.RetrieveRuleById(alarm.RuleId);

                allAlarms.Add(alarm);
            }

            return View(allAlarms);
        }
    }
}
