using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class FileCommunicator
    {
        private int _id; 

        private string _filePath;

        private int? _startChar;

        private int? _endChar;

        private int _openModeId;


        public int Id
        {
            get { return _id; }
        }

        public string FilePath
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

        public FileCommunicator(int id, string filePath, int openModeId)
        {
            _id = id;
            FilePath = filePath;
            OpenModeId = openModeId;

        }

        public FileCommunicator(string id, string filePath, string openModeId)
        {
            _id = Convert.ToInt32(id);
            FilePath = filePath;
            OpenModeId = Convert.ToInt32(openModeId);
        }
    }

}
