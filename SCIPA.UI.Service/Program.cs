using SCIPA.Domain.Inbound;
using SCIPA.Domain.Logic;
using SCIPA.DomainLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using SCIPA.Domain.Generic;
using SCIPA.Models;

namespace SCIPA.UI.Service
{
    class Program
    {

        private static List<string> _logEntries = new List<string>();
        private static DateTime _lastLogUpdate;
        private static int ReaderRunning = 0;

        static void Main(string[] args)
        {
            AppBootSequence();

            ThreadPool.QueueUserWorkItem(new WaitCallback(ConsoleUpdate));


            

            //SerialDataHandler sdh = new SerialDataHandler("COM3");
            //SerialDataHandler sdhTwo = new SerialDataHandler("COM4");

            //Stops the 'enter' quitting the process.
            while (true)
                Console.Read();
        }

        private static void AppBootSequence()
        {
            DebugOutput.Print(" *** ************************* ***");
            Thread.Sleep(50);
            DebugOutput.Print(" *** SCIPA SERVICE HAS STARTED ***");
            Thread.Sleep(50);
            DebugOutput.Print(" *** ************************* ***");
            Thread.Sleep(1000);
        }


        /// <summary>
        /// Repeated code to ensure the console window display appropriate data.
        /// </summary>
        /// <param name="obj">Used by ThreadPooler</param>
        private static void ConsoleUpdate(object obj)
        {
            while(true)
            {
                PrintHeader();
                PrintTopMessages();
                
                ThreadPool.QueueUserWorkItem(new WaitCallback(GetLogMessages));
                

                Thread.Sleep(500);
            }
        }

        private static void PrintHeader()
        {
            Console.Clear(); 
            Console.WriteLine("************************************");
            Console.WriteLine("*** WELCOME TO THE SCIPA SERVICE ***");
            Console.WriteLine("***      {0}     ***", DateTime.Now.ToString());
            Console.WriteLine("************************************");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        /// <summary>
        /// Collects all log messages from the log file.
        /// </summary>
        /// <param name="obj">Used by the ThreadPooler.</param>
        private static void GetLogMessages(object obj)
        {
            try
            {
                //Inform the system that another log read is about to occur.
                ReaderRunning++;

                //Only read the file if there are no other readers in operations
                if (ReaderRunning < 2)
                {
                    DateTime fileWriteTime = System.IO.File.GetLastWriteTime(Configuration.LogFilePath);

                    if (fileWriteTime > _lastLogUpdate)
                    {
                        //Clear the current list.
                        _logEntries = new List<string>();
                        _lastLogUpdate = fileWriteTime;

                        //Reads all values, safely.
                        using (var streamReader = System.IO.File.OpenText(Configuration.LogFilePath))
                        {
                            var lines = streamReader.ReadToEnd().Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                            foreach (var line in lines)
                            {
                                _logEntries.Add(line);
                            }
                        }
                    }
                }
            }
            catch(System.IO.FileNotFoundException e)
            {
                DebugOutput.Print("Could not access the log file... ", e.Message);
            }
            catch(System.IO.FileLoadException e)
            {
                DebugOutput.Print("Problem opening log file... ", e.Message );
            }
            catch(Exception e)
            {
                DebugOutput.Print("General problem occured! ",e.Message);
            }
            finally
            {
                ReaderRunning--;
            }

        }

        /// <summary>
        /// Selects either the top messages or up to the limit (if there is less than the limit available)
        /// and prints to the console window.
        /// </summary>
        private static void PrintTopMessages()
        {
            int messagesToShow = 15;

            if (_logEntries != null || _logEntries.Count > 0)
            {
                int logCount = _logEntries.Count;
                int startNumber = 0;
                string output = "";

                if (logCount < messagesToShow)
                {
                    //Collect all of the entries up to the maximum.
                    startNumber = 0;
                }
                else
                {
                    //Collect the last ten entries.
                    startNumber = logCount - messagesToShow;
                }


                for (int i = logCount - messagesToShow; i < logCount; i++)
                {
                    try { output += "[" + i + "]  " + _logEntries[i] + "\n"; }
                    catch { output += "" + "\n"; }
                }

                Console.WriteLine(output);
            }
        }
    }
}
