using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIPA.Domain.Generic
{
    /// <summary>
    /// Global configuration class. 
    /// </summary>
    public static class Configuration
    {
        /// <summary>
        /// The default directory to be used throughout the application.
        /// Mainly used for the log directory.
        /// </summary>
        private static string DefaultDirectory { get; } = @"C:\scipa\";

        /// <summary>
        /// The full path of the log file. The log file prints all debug messages.
        /// </summary>
        public static string LogFilePath { get; } = DefaultDirectory + "log.dat";

        /// <summary>
        /// Boolean to determine whether the DebugOutput class saves the debug messages
        /// to the text file at the LogFilePath. True by default, can be set to false on
        /// systems where the outputting of the data affects the operation of the application,
        /// host Operating System, or where the size of the log may become an issue.
        /// </summary>
        public static bool OutputToLogFile { get; set; } = true;

        public static string DefaultConnectionString { get; set; } = @"Data Source=DESKTOP-81SM1A6;Initial Catalog=scipa;Integrated Security=True";
    }
}
