using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLogicLayer.Events;

namespace DomainLogicLayer.Models
{
    public class FileCommunicatorVM
    {
        public string DeviceName { get; set; }
        public string FileName { get; set; }
        public string ValueType { get; set; }

public bool ReadOnly { get; set; }
        public int CheckTime { get; set; }
        public DateTime? LastUpdateTime { get; set; }
        public bool ReadUpdatesOnly { get; set; }
        public string DefaultValue { get; set; }
        public bool Nullable { get; set; }

        public string LastKnownValue { get; set; }

        private FileSystemWatcher backgroundFSW;

        public List<string> values = new List<string>();

        public event NewValuesRecievedHandler onValueRecieved;


        private int _id; 

        private string _folderPath;

        private int? _startChar;

        private int? _endChar;

        private int _openModeId;


        public int Id
        {
            get { return _id; }
        }

        public string FolderPath
        {
            get { return _folderPath; }
            set { _folderPath = value; }
        }

        public int? StartChar
        {
            get { return _startChar; }
            set { _startChar = value; }
        }

        public int? EndChar
        {
            get { return _endChar; }
            set { _endChar = value; }
        }

        public int OpenModeId
        {
            get { return _openModeId; }
            set { _openModeId = value; }
        }

        public FileCommunicatorVM()
        {
            backgroundFSW = new FileSystemWatcher();
        }
                

        public FileCommunicatorVM(int id, string filePath, int openModeId)
        {
            _id = id;
            //FolderPath = filePath;
            OpenModeId = openModeId;

        }

        public FileCommunicatorVM(string id, string filePath, string openModeId)
        {
            _id = Convert.ToInt32(id);
            //FolderPath = filePath;
            OpenModeId = Convert.ToInt32(openModeId);
        }

        
        //-------------------------------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// Sets the full file path for the object.
        /// </summary>
        /// <param name="fullPath">File path, name and extension.</param>
        public void SetFilePath(string fullPath)
        {
            //Find last slash in the string (i.e. jump to file name and extension)
            int lastSlashIndex = @fullPath.LastIndexOf('\\') + 1;
            string fileName = fullPath.Substring(lastSlashIndex);


            //Change fullPath to contain only the file path (excludes the filename).
            fullPath = fullPath.Substring(0, (fullPath.Length - (fullPath.Length - lastSlashIndex)));

            this.FileName = fileName;
            this.FolderPath = fullPath;
        }

        /// <summary>
        /// Starts the FileSystemWatcher instance, watching the filepath as stored within the object.
        /// When the file is updated, the backgroundFSQ_Changed method is invoked.
        /// </summary>
        public void StartFileWatcher()
        {
            try
            {
                backgroundFSW.Path = FolderPath;
                backgroundFSW.NotifyFilter = System.IO.NotifyFilters.LastWrite;
                backgroundFSW.Filter = FileName;
                backgroundFSW.Changed += backgroundFSW_Changed;
                backgroundFSW.EnableRaisingEvents = true;
            }
            catch (FileNotFoundException fnfe)
            {
                throw new FileNotFoundException();
            }
            catch (PathTooLongException ptle)
            {
                throw new PathTooLongException();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        /// <summary>
        /// When the backgroundFSW object detects a change in the monitored file, the application invokes this code
        /// to notify any subscribers of the 'onValueRecieved' event of the change, passing this class and 'NewValueRecievedEventArgs'.
        /// </summary>
        /// <param name="sender">This class.</param>
        /// <param name="e">The arguments surrounding the execution.</param>
        private void backgroundFSW_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            values.Add(DateTime.Now.ToString());

            if (onValueRecieved != null)
            {
                LastKnownValue = ReadValueFromFile();
                onValueRecieved(this, new NewValueRecievedEventArgs(LastKnownValue));
            }
        }

        private string ReadValueFromFile()
        {
            DataAccessLayer.FlatFileHandler ffh;
            FileAccess accessType = FileAccess.Read;

            if (!this.ReadOnly)
            {
                accessType = FileAccess.ReadWrite;
            }

            if (StartChar != null && StartChar>=0 && EndChar < 1)
            {
                ffh = new DataAccessLayer.FlatFileHandler(FolderPath + FileName,(int)StartChar,0,this.ValueType,accessType);
                var test = ffh.requiredValue;
            }
            else if(StartChar >= 0 && EndChar >=1)
            {
                int length = (int)EndChar - (int)StartChar;
                ffh = new DataAccessLayer.FlatFileHandler(FolderPath + FileName,(int)StartChar,length,this.ValueType,accessType);
            }

            return "13";

        }


        public bool CheckFileExists()
        {
            return File.Exists(FolderPath + FileName);
        }
    }

}
