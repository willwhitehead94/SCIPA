using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class FileOpenMode
    {
        private int _id;

        private string _openMode;

        private FileAccess _faOpenMode;

        public int Id
        {
            get { return _id; }
        }

        public string OpenMode
        {
            get { return _openMode; }
            set { _openMode = value; UpdateFileShare(); }
        }

        public FileAccess FAOpenMode
        {
            get { return _faOpenMode; }
        }


        public FileOpenMode(int id, string openMode)
        {
            _id = id;
            OpenMode = openMode;
        }

        public FileOpenMode(string id, string openMode)
        {
            _id = Convert.ToInt32(id);
            OpenMode = openMode;
        }

        /// <summary>
        /// Sets the internal FileAccess variable according to the value downloaded from the RDB.
        /// Only called via the 'OpenModeString' updating.
        /// </summary>
        private void UpdateFileShare()
        {
            switch(OpenMode)
            {
                case "READ": _faOpenMode = FileAccess.Read; break;
                case "WRITE": _faOpenMode = FileAccess.Write; break;
                default: _faOpenMode = FileAccess.Read; break;
            }
        }

    }

}
