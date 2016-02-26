using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIPA.Domain.Logic
{
    public static class Configuration
    {
        private static string DefaultDirectory { get; } = @"C:\scipa\";
        public static string LogFilePath { get; } = DefaultDirectory + "log.dat";
    }
}
