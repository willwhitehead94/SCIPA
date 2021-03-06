﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using SCIPA.Domain.Logic;
using SCIPA.Models;

namespace SCIPA.UI.WebSite.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Main controller - used to access the Alarm data.
        /// </summary>
        readonly AlarmController controller = new AlarmController();

        /// <summary>
        /// Device controller to load Device details for display on the form.
        /// </summary>
        readonly DeviceController deviceController = new DeviceController();

        /// <summary>
        /// Value controller to load specific Value information on the form.
        /// </summary>
        readonly ValueController valueController = new ValueController();

        /// <summary>
        /// Rule controller to allow specific Rule data to be displayed.
        /// </summary>
        readonly RuleController ruleController = new RuleController();

        /// <summary>
        /// The number of hours to load alarm data for.
        /// </summary>
        private int hoursToRetrieve = 72;

        /// <summary>
        /// Local collection of Alarms from the database.
        /// </summary>
        ICollection<SCIPA.Models.Alarm> allAlarms = new List<Alarm>();

        /// <summary>
        /// Home page action. Loads all alarms by default from the given hoursToRetrieve period.
        /// Passing a true boolean will show only the unacknowledged alarms.
        /// </summary>
        /// <param name="unacceptedOnly"></param>
        /// <returns></returns>
        public ActionResult Index(bool? accepted=null)
        {
            List<Alarm> alarmList = new List<Alarm>();
            allAlarms=new List<Alarm>();

            if (accepted == null)
            {
                alarmList=AllAlarms();
            }
            else
            {
                alarmList = (bool)accepted ? AcceptedOnly() : UnacceptedOnly();
            }
            
            //For each alarm in the list, download the additional details.
            foreach (var alarm in alarmList)
            {
                //Load controller-specific data into the Alarm object.
                alarm.Device = deviceController.RetrieveDevice(alarm.DeviceId);
                alarm.Value = valueController.GetValueById(alarm.ValueId);
                alarm.Rule = ruleController.RetrieveRuleById(alarm.RuleId);

                //Add the alarm to the global list.
                allAlarms.Add(alarm);
            }

            //Pass to the view.
            return View(allAlarms);
        }

        /// <summary>
        /// Allow users to acknowledge the alarms from the site.
        /// </summary>
        /// <param name="id"></param>
        public void Acknowledge(int id)
        {
            controller.Acknowledge(controller.GetAllAlarms(hoursToRetrieve).FirstOrDefault(alm => alm.Id == id));
            Redirect("Index");
        }

#region Collection of Appropriate Data

        /// <summary>
        /// Download all alarsm within the given period.
        /// </summary>
        /// <returns></returns>
        public List<Alarm> AllAlarms()
        {
            return controller.GetAllAlarms(hoursToRetrieve).ToList();
        }

        /// <summary>
        /// Download all Alarms within the period but only return
        /// those who're not yet acknowledged.
        /// </summary>
        /// <returns></returns>
        public List<Alarm> UnacceptedOnly()
        {
            return AllAlarms().Where(al => al.Accepted == false).ToList();
        }

        /// <summary>
        /// Download all Alarms within the period but only return
        /// those who're already acknowledged.
        /// </summary>
        /// <returns></returns>
        public List<Alarm> AcceptedOnly()
        {
            return AllAlarms().Where(al => al.Accepted).ToList();
        }

#endregion Collection of Appropriate Data
    }
}
