﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SCIPA.Domain.Generic
{
    public static class DebugOutput
    {
        private static readonly string _logPath = Configuration.LogFilePath;
        private static readonly Queue<string> _logQueue = new Queue<string>();
        private static bool _printingToLog = false;

        /// <summary>
        /// Submits a request to the printing mechanism to output the given message(s)
        /// to the Log file for the application. This log file is primarily read by the
        /// SCIPA Service UI, though it can also be used for debugging/retrospective
        /// investigations.
        /// </summary>
        /// <param name="message">Primary message to print. Always prints uppercase.</param>
        /// <param name="secondMessage">Optional secondary message.</param>
        public static void Print(string message, string secondMessage = "")
        {
            var output = "{0} - {1} {2}";
            output = string.Format(output, DateTime.Now, message.ToUpper(), secondMessage);

            _logQueue.Enqueue(output);

            if (!_printingToLog)
            {
                //Inform all that printing has begun
                _printingToLog = !_printingToLog;

                //Call new thread from pool to loop the print mechanism
                ThreadPool.QueueUserWorkItem(new WaitCallback(StartLogging));
            }
        }


        /// <summary>
        /// Continuous running thread to ensure the dir/file are available
        /// before printing the queue contents.
        /// </summary>
        /// <param name="obv">Threadpool object for call backs.</param>
        public static void StartLogging(object obv)
        {
            if (!File.Exists(_logPath))
            {
                /*
                * The log file will be automatically created by the next call to the
                * File.AppendAllText function, as part of the 'File' library.
                */

                //Blind request to create dir (does not throw error if already exists)
                Directory.CreateDirectory(_logPath.Substring(0, _logPath.LastIndexOf('\\')));
            }

            //While this is the only printer, there is something to print, and the file is available
            while (_printingToLog)
            {
                //Inform all that the log is currently in use
                _printingToLog = true;

                while (_logQueue.Count > 0)
                {
                    //Get latest value from the queue and print to Debug console
                    var message = _logQueue.Dequeue();
                    Debug.WriteLine(message);

                    //Attempt to print to file; on fail, print only to the Debug console
                    try { File.AppendAllText(_logPath, message + Environment.NewLine); }
                    catch (IOException ioe) { Debug.WriteLine("IO Error accessing the log! ", ioe.Message); }
                    catch { Debug.WriteLine("General exception occured writing to log..."); }
                }

                /*
                * Following the latest writing of output messages, 200ms delay gives OS
                * time to access the file for indexing operations if required.
                */            
                Thread.Sleep(200);
            }
        }
    }
}