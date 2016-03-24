using SCIPA.Domain.Logic;
using SCIPA.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using SCIPA.Domain.Generic;
using ValueType = SCIPA.Models.ValueType;


namespace SCIPA.Domain.Inbound
{
    public class FlatFileHandler : DataHandler
    {
        /// <summary>
        /// System object to watch the given file. Throws event when file updates.
        /// </summary>
        private FileSystemWatcher _backgroundFSW = null;

        /// <summary>
        /// File CommunicatorModel object used to store the connection settings.
        /// </summary>
        public Models.FileCommunicator Communicator = null;

        /// <summary>
        /// List of paths already being watched by the system.
        /// </summary>
        private static List<string> PathsBeingWatched = new List<string>();

        /// <summary>
        /// Event to execute when the file is updated.
        /// </summary>
        public event FileUpdatedHandler onFileUpdate;

        /// <summary>
        /// Local strings used to determine the difference between the three similar values;
        /// file name, file path and the folder path.
        /// </summary>
        private string _filePath, _folderPath, _fileName;

        /// <summary>
        /// Constructor takes a file communicator object. If the file in question is already
        /// being watched, this is ignored. Otherwise, the file is watched by a system file watcher
        /// object.
        /// </summary>
        /// <param name="comms">File CommunicatorModel</param>
        public FlatFileHandler(FileCommunicator comms)
        {
            if (PathsBeingWatched.Contains(@comms.FilePath))
            {
                DebugOutput.Print("Already watching for updates on file at ", comms.FilePath);
            }
            else
            {
                DebugOutput.Print("Attempting to create new connection to file at ", comms.FilePath);
                Communicator = comms;
                StartFileWatcher();
            }
        }

        /// <summary>
        /// Ensure the file is valid, available and OK to open.
        /// </summary>
        /// <returns>Success of fail boolean.</returns>
        private bool CheckFile()
        {
            try
            {
                //Set local _filePath variable to the entire path of the file.
                _filePath = Communicator.FilePath;

                //Find last slash in the string (i.e. jump to file name and extension)
                int lastSlashIndex = Communicator.FilePath.LastIndexOf('\\') + 1;
                _fileName = Communicator.FilePath.Substring(lastSlashIndex);

                //Change fullPath to contain only the file path (excludes the filename).
                _folderPath = Communicator.FilePath.Substring(0,
                    (_filePath.Length - (_filePath.Length - lastSlashIndex)));

                //Check file exists and is accessible
                if (System.IO.File.Exists(_filePath))
                {
                    DebugOutput.Print("Connected to file at ", Communicator.FilePath);

                    return true;
                }
            }
            catch
            {
                return false;
            }


            //If unable to access the file, return false
            return false;
        }

        /// <summary>
        /// Starts the FileSystemWatcher object and monitors for file changes.
        /// </summary>
        private void StartFileWatcher()
        {
            if (CheckFile())
            {
                _backgroundFSW = new FileSystemWatcher();

                _backgroundFSW.Path = _folderPath;
                _backgroundFSW.NotifyFilter = System.IO.NotifyFilters.LastWrite;
                _backgroundFSW.Filter = _fileName;

                _backgroundFSW.Changed += FileChangeTrigger;
                onFileUpdate += OnFileUpdateEvent;

                PathsBeingWatched.Add(@_filePath);
                DebugOutput.Print("Now watching for updates on the file at ", Communicator.FilePath);

                _backgroundFSW.EnableRaisingEvents = true;
            }
            else
            {
                DebugOutput.Print("This file could not be connected to! Ensure you have permissions.");
            }
        }

        /// <summary>
        /// Called when the backgroundFSW detects an appropriate change in the file being watched.
        /// Calls the 'OnFileUpdateEvent'.
        /// </summary>
        /// <param name="sender">System.</param>
        /// <param name="e">FileSystem arguments.</param>
        private void FileChangeTrigger(object sender, FileSystemEventArgs e)
        {
            DateTime EventOccurenceTime = DateTime.Now;
            TimeSpan WaitPeriod = new TimeSpan(0, 0, 1);

            //Only allows one occurence per the time in the 'WaitPeriod' object.
            if (!((EventOccurenceTime - _lastIncomingMessage) < WaitPeriod))
            {
                _lastIncomingMessage = EventOccurenceTime;
                if (onFileUpdate != null)
                {
                    DebugOutput.Print("Change detected on file at ", Communicator.FilePath);
                    string LastKnownValue = DateTime.Now.ToString();
                    OnFileUpdateEvent(this, new FileUpdatedEventArgs(LastKnownValue));
                }
            }

        }

        /// <summary>
        /// Custom code executed when the file has been updated. Waits 100ms to ensure the file has had chance to close.
        /// Enqueues any newly read values.
        /// </summary>
        /// <param name="source">System.</param>
        /// <param name="e">Updated File arguments.</param>
        private void OnFileUpdateEvent(object source, FileUpdatedEventArgs e)
        {
            Thread.Sleep(100);
            string fileText = ReadFile();
            if (fileText != "")
            {
                _lastIncomingMessage = DateTime.Now;
                string info = "Incoming data received from {0}: '{1}'";
                info = string.Format(info, _fileName, fileText);
                DebugOutput.Print(info);

                EnqueueData(new Value()
                {
                    Type = ValueType.String,
                    EventTime = DateTime.Now,
                    StringValue = fileText,
                    Inbound = true  
                });

                //InboundDataQueue.Enqueue(new Value()
                //{
                //    ValueType = ValueType.String,
                //    CommType = CommunicatorType.FlatFile,
                //    EventTime = DateTime.Now,
                //    StringValue = fileText,
                //    Inbound = true
                //});
            }
        }

        /// <summary>
        /// When requested, this method simply opens the file from the communicator
        /// and returns the file, as a string, in full.
        /// </summary>
        /// <returns>All lines from the file, with a buffer size of 256.</returns>
        private string ReadFile()
        {
            DebugOutput.Print("reading file now");
            DateTime lastWriteTime = File.GetLastWriteTime(Communicator.FilePath);
            string fileContents = "";

            try
            {
                const Int32 BufferSize = 256;
                using (var fileStream = File.OpenRead(Communicator.FilePath))
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
                    {
                        fileContents = streamReader.ReadToEnd();
                    }

                    //TextReader fileReaderObject =
                    //    new StreamReader(new FileStream(CommunicatorModel.FilePath, FileMode.Open, FileAccess.Read,
                    //        FileShare.Read));
                    //fileContents = fileReaderObject.ReadToEnd();
                    //fileReaderObject.Close();
                    //fileReaderObject.Dispose();
                    //fileContents = System.IO.File.ReadAllText(CommunicatorModel.FilePath);

                Communicator.LastReadTime = lastWriteTime;
                fileContents = fileContents.Trim();
            }
            catch (IOException e)
            {
                DebugOutput.Print("IO Error occured at the file", e.Message);
            }
            catch (Exception e)
            {
                DebugOutput.Print("Attempt to read file failed!", e.Message);
                fileContents = "";
            }

            return fileContents;
        }

        public override Communicator GetCommunicator()
        {
            return Communicator;
        }
    }
}
