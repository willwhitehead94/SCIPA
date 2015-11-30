using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    class Service
    {
        /// <summary>
        /// Global static method available to all aspects of the application to unify the
        /// debug print messages coming from the application. Reduces the using of the
        /// diagnostics library to this class only.
        /// </summary>
        /// <param name="Message">The text to print to the debug console.</param>
        public static void DebugPrint(string Message)
        {
            string Output = string.Format("SCIPA {0} - {1}", DateTime.Now, Message);
            LogDebugStatements(Output);
            Debug.WriteLine(Output);
        }

        /// <summary>
        /// Debug printing where more than one element is required. In this instance,
        /// the first message prints as normal with the second element following it
        /// after a colon.
        /// </summary>
        /// <param name="Message">The text to print to the debug console.</param>
        /// <param name="SecondMessage">The supporting data required to be printed.</param>
        public static void DebugPrint(string Message, string SecondMessage)
        {
            DebugPrint(string.Format("{0}:  {1}", Message, SecondMessage));
        }

        /// <summary>
        /// Stores the debug statements to a file for analysis following the runtime events.
        /// </summary>
        /// <param name="statement"></param>
        public static void LogDebugStatements(string statement)
        {
            string dir = Properties.Settings.Default.DebugOutputDir;
            string file = DateTime.Now.ToString("yyyy-MM-dd") + " DAL.log";

            dir += file;

            System.IO.File.AppendAllText(@dir, statement + Environment.NewLine);
        }
    }
}
