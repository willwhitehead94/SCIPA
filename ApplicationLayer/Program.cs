using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApplicationLayer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DomainLogicLayer.Service.DebugPrint("A new instance of SCIPA has been started!");

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new DataManagers.AlarmManager());

            //bool temp = DomainLogicLayer.Service.CheckMyThinking("SELECT id FROM Device");

            //DomainLogicLayer.Service.CheckMyThinking();

        }
    }
}
