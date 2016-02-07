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
        public string FilePath { get; set; }
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

        private string _filePath;

        private int? _startChar;

        private int? _endChar;

        private int _openModeId;


        public int Id
        {
            get { return _id; }
        }

        public string FolderPath
        {
            get { return _filePath; }
            set { _filePath = value; }
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

        public void SetFilePath(string fullPath)
        {

            int lastSlashIndex = @fullPath.LastIndexOf('\\') + 1;

            string fileName = fullPath.Substring(lastSlashIndex);
            fullPath = fullPath.Substring(0, (fullPath.Length - (fullPath.Length - lastSlashIndex)));

            this.FileName = fileName;
            this.FolderPath = fullPath;
        }

        public void StartFileWatcher()
        {
            backgroundFSW.Path = FolderPath;
            backgroundFSW.NotifyFilter = System.IO.NotifyFilters.LastWrite;
            backgroundFSW.Filter = FileName;
            backgroundFSW.Changed += backgroundFSW_Changed;
            backgroundFSW.EnableRaisingEvents = true;
        }

        private void backgroundFSW_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            values.Add(DateTime.Now.ToString());

            if (onValueRecieved != null)
            {
                LastKnownValue = "new value goes here...";
                onValueRecieved(this, new NewValueRecievedEventArgs(LastKnownValue));
            }
        }

        public Object[] GetKnownValues()
        {
            object[] test = new object[3];

            test[0] = "HIGH";
            test[1] = "MEDIUM";
            test[2] = "LOW";

            return test;
        }
    }

}
