using SCIPA.Domain.Logic;
using SCIPA.Models;
using System;
using System.Collections.Generic;
using System.IO;


namespace SCIPA.Domain.Inbound
{
    public class FlatFileHandler
    {
        private static List<string> PathsBeingWatched = new List<string>();

        private FileSystemWatcher _backgroundFSW = null;
        private DateTime _lastMessageReceived;
        private Models.FileCommunicator _fileComms = null;

        private string _filePath, _folderPath, _fileName;
        private DateTime _lastUpdate;

        private string _lastValueRead;

        public event FileUpdatedHandler onFileUpdate;

        public FlatFileHandler(FileCommunicator comms)
        {
            if (PathsBeingWatched.Contains(@comms.FilePath))
            {
                DebugOutput.Print("Already watching for updates on file at ", comms.FilePath);
            }
            else
            {
                DebugOutput.Print("Attempting to create new connection to file at ", comms.FilePath);
                _fileComms = comms;
                StartFileWatcher();
            }
        }

        private bool CheckFile()
        {
            try
            {
                //Set local _filePath variable to the entire path of the file.
                _filePath = _fileComms.FilePath;

                //Find last slash in the string (i.e. jump to file name and extension)
                int lastSlashIndex = _fileComms.FilePath.LastIndexOf('\\') + 1;
                _fileName = _fileComms.FilePath.Substring(lastSlashIndex);

                //Change fullPath to contain only the file path (excludes the filename).
                _folderPath = _fileComms.FilePath.Substring(0, (_filePath.Length - (_filePath.Length - lastSlashIndex)));

                //Check file exists and is accessible
                if (System.IO.File.Exists(_filePath))
                {
                    DebugOutput.Print("Connected to file at ", _fileComms.FilePath);

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
                DebugOutput.Print("Now watching for updates on the file at ", _fileComms.FilePath);

                _backgroundFSW.EnableRaisingEvents = true;
            }
        }

        /// <summary>
        /// Called when the backgroundFSW detects an appropriate change in the file being watched.
        /// Calls the 'OnFileUpdateEvent'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FileChangeTrigger(object sender, FileSystemEventArgs e)
        {
            DateTime EventOccurenceTime = DateTime.Now;
            TimeSpan WaitPeriod = new TimeSpan(0, 0, 1);

            //Only allows one occurence per the time in the 'WaitPeriod' object.
            if (!((EventOccurenceTime - _lastUpdate) <  WaitPeriod))
            {
                _lastUpdate = EventOccurenceTime;
                if (onFileUpdate != null)
                {
                    DebugOutput.Print("Change detected on file at ", _fileComms.FilePath);
                    string LastKnownValue = DateTime.Now.ToString();
                    OnFileUpdateEvent(this, new FileUpdatedEventArgs(LastKnownValue));
                }
            }

        }


        private void OnFileUpdateEvent(object source, FileUpdatedEventArgs e)
        {
            //what to do when the file udpates
            //Console.WriteLine(e.GetEventInfo());

            

            Domain.Logic.FlatFileReader ffr = new Logic.FlatFileReader(_fileComms);

            string _newValue = ffr.GetString().Trim();

            if (_lastValueRead != null && _lastValueRead != "" && _newValue != "")
            {
                if (_newValue.Trim().Equals(_lastValueRead.Trim()))
                {
                    DebugOutput.Print("Value has not changed; ", _lastValueRead);
                }
                else
                {
                    DebugOutput.Print("New value retrieved: ", _newValue);
                }
            }
            else
            {
                _lastValueRead = _newValue;
            }
        }

        public string GetLastValueRead()
        {
            return _lastValueRead;
        }


    }
}
