using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SCIPA.Domain.Generic
{
    public static class DebugOutput
    {
        private static string _logPath = Configuration.LogFilePath;
        private static string _lastLogMessage = "";
        private static Queue<string> _logQueue = new Queue<string>();
        private static bool _printingToLog = false;

        public static void Print(string message, string secondMessage = "")
        {
            string output = "{0} - {1} {2}";
            output = string.Format(output, DateTime.Now.ToString(), message.ToUpper(), secondMessage);

            _lastLogMessage = output;
            _logQueue.Enqueue(output);

            if (!_printingToLog)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(StartLogging));
            }
        }



        public static void StartLogging(object obv)
        {
            while (true)
            {
                _printingToLog = true;

                if (_logQueue.Count>0)
                {
                    try { File.AppendAllText(_logPath, _logQueue.Dequeue() + Environment.NewLine); }
                    catch (IOException ioe) { DebugOutput.Print("IO Error accessing the log! ", ioe.Message); }
                    catch { DebugOutput.Print("General exception occured writing to log..."); }

                    Thread.Sleep(200);
                }
            }
        }
    }
}
