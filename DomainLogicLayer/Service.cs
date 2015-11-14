using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace DomainLogicLayer
{
    public class Service
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


        public static bool CheckMyThinking(string query)
        {
            DatabaseHandler dbHandler = new DatabaseHandler();
            return dbHandler.Execute(query);
        }

        
    }
}
