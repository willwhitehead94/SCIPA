using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class FlatFileHandler
    {
        public enum ValueType
        {
            Integer,
            Real,
            String,
            Boolean
        };


#region Variables

        private string FilePath;

        private int StartChar;

        private int DataLength;

        private ValueType VType;

        private FileAccess FAccess;

        private string FileContents;

        private string valueFromFile;

        private object requiredValue;

        private bool InRange;

        private DateTime FileLastUpdated = DateTime.MinValue;

#endregion Variables

        public FlatFileHandler()
        {
            //generic blank object.... TODO: remove!
        }

        public FlatFileHandler(string FilePath, int StartChar = 0, int DataLength = 0,string ValType = "String", FileAccess FAccess = FileAccess.Read)
        {
            this.FilePath = @FilePath;
            this.StartChar = StartChar;
            this.DataLength = DataLength;
            this.VType = ValueType.Integer;
            this.FAccess = FAccess;
        }

        public object GetRequiredValue()
        {
            OpenFileAndReadContents();
            valueFromFile = ReadValueFromOpenFile();
            requiredValue = GetValueInCorrectFormat();

            return requiredValue;
        }

        public bool FileIsReadable()
        {
            string contentTest = OpenFileAndReadContents();

            if (contentTest != "" || contentTest != null)
            {
                return true;
            }

            return false;
        }

        private string OpenFileAndReadContents()
        {

            if (File.Exists(FilePath))
            {
                if (File.GetLastWriteTime(FilePath) > FileLastUpdated)
                {
                    try
                    {
                        TextReader fileReaderObject = new StreamReader(new FileStream(FilePath, FileMode.Open, FAccess, FileShare.ReadWrite));
                        var FileContents = fileReaderObject.ReadToEnd();
                        fileReaderObject.Close();
                        fileReaderObject.Dispose();

                        FileLastUpdated = File.GetLastWriteTime(FilePath);
                        this.FileContents = FileContents.ToString();
                    }
                    catch (Exception e)
                    {
                        
                    }
                }

                if(FileContents.Length >= StartChar && FileContents.Length >= (StartChar + DataLength))
                {
                    InRange = true;
                }

                return FileContents.ToString();
            }

            return null;
        }

        private string ReadValueFromOpenFile()
        {
            bool ReadToEnd = DataLength == 0 ? true : false;
            valueFromFile = FileContents;

            if (FileContents.Length >= StartChar && (!ReadToEnd && FileContents.Length >= (StartChar + DataLength)))
            {
                try
                {
                    valueFromFile = FileContents.Substring(StartChar, DataLength);
                }
                catch (Exception e)
                {
                    throw new FileLoadException(
                        "The data in the file did not match the constraints given to read the data.");
                }
            }

            return valueFromFile;
        }

        private object GetValueInCorrectFormat()
        {
            switch (VType)
            {
                case ValueType.Integer:
                {
                    int convertedInt = int.MinValue;
                    int.TryParse(valueFromFile, out convertedInt);
                    requiredValue = convertedInt;
                    break;
                }
                case ValueType.Real:
                {
                    double convertedDouble = double.MinValue;
                    double.TryParse(valueFromFile, out convertedDouble);
                    requiredValue = convertedDouble;
                    break;
                }
                case ValueType.Boolean:
                    {
                        bool returnValue = false;
                        bool valueBoolable = bool.TryParse(valueFromFile, out valueBoolable);
                        if (valueBoolable)
                        {
                            requiredValue = returnValue;
                        }
                        break;
                    }
                case ValueType.String:
                {
                    requiredValue = valueFromFile;
                    break;
                }
            }

            return requiredValue;
        }
    }
}
