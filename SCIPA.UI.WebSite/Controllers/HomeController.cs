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
        /// <summary>
        /// Main controller - used to access the Alarm data.
        /// </summary>
        AlarmController controller = new AlarmController();

        /// <summary>
        /// Device controller to load Device details for display on the form.
        /// </summary>
        DeviceController devCont = new DeviceController();

        /// <summary>
        /// Value controller to load specific Value information on the form.
        /// </summary>
        ValueController valCont = new ValueController();

        /// <summary>
        /// Rule controller to allow specific Rule data to be displayed.
        /// </summary>
        RuleController rulCont = new RuleController();

        //The number of hours to load alarm data for.
        private int Hours = 72;

        /// <summary>
        /// Local collection of Alarms from the database.
        /// </summary>
        ICollection<SCIPA.Models.Alarm> allAlarms = new List<Alarm>();

        /// <summary>
        /// Home page action. Loads all alarms by default from the given Hours period.
        /// Passing a true boolean will show only the unacknowledged alarms.
        /// </summary>
        /// <param name="unacceptedOnly"></param>
        /// <returns></returns>
        public ActionResult Index(bool unacceptedOnly=false)
        {
            List<Alarm> alarmList = new List<Alarm>();
            allAlarms=new List<Alarm>();

            alarmList = unacceptedOnly ? UnacceptedOnly() : AllAlarms();
            
            //For each alarm in the list, download the additional details.
            foreach (var alarm in alarmList)
            {
                //Load controller-specific data into the Alarm object.
                alarm.Device = devCont.RetrieveDevice(alarm.DeviceId);
                alarm.Value = valCont.GetValueById(alarm.ValueId);
                alarm.Rule = rulCont.RetrieveRuleById(alarm.RuleId);

                //Add the alarm to the global list.
                allAlarms.Add(alarm);
            }

            //Pass to the view.
            return View(allAlarms);
        }

        /// <summary>
        /// Download all alarsm within the given period.
        /// </summary>
        /// <returns></returns>
        public List<Alarm> AllAlarms()
        {
            return controller.GetAllAlarms(Hours).ToList();
        }


        /// <summary>
        /// Download all Alarms within the period but only return
        /// those who're not yet acknowledged.
        /// </summary>
        /// <returns></returns>
        public List<Alarm> UnacceptedOnly()
        {
            return AllAlarms().Where(al => al.Accepted = false).ToList();
        } 

        /// <summary>
        /// Allow users to acknowledge the alarms from the site.
        /// </summary>
        /// <param name="id"></param>
        public void Acknowledge(int id)
        {
            controller.Acknowledge(controller.GetAllAlarms(Hours).FirstOrDefault(alm=> alm.Id==id));
            Redirect("Index");
        }


    }
}
