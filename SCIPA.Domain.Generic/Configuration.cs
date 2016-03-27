using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIPA.Domain.Generic
{
    public static class Configuration
    {
        /// <summary>
        /// The default directory to be used throughout the application.
        /// Mainly used for the log directory.
        /// </summary>
        private static string DefaultDirectory { get; } = @"C:\scipa\";

        /// <summary>
        /// The full path of the log file.
        /// </summary>
        public static string LogFilePath { get; } = DefaultDirectory + "log.dat";
    }
}
