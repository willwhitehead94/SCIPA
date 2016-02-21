using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCIPA.Domain.Logic
{
    public class FlatFileReader
    {
        private Models.FileCommunicator _comm = new Models.FileCommunicator();
        private string FileContents { get; set; }

        private bool FileContentsUpdated { get; set; } = false;


        public FlatFileReader(string FilePath, int StartChar = 0, int DataLength = 0)
        {
            _comm.FilePath = FilePath;
            _comm.StartChar = StartChar;
            _comm.EndChar = StartChar + DataLength;
        }

        public FlatFileReader(Models.FileCommunicator fileComm)
        {
            _comm = fileComm;
        }

        public int? GetInteger()
        {
            if (!FileContentsUpdated)
                GetRequiredValue();

            if (_comm.ValueType == Models.Type.Integer)
                return Convert.ToInt32(FileContents);

            return null;
        }

        public float? GetFloat()
        {
            if (!FileContentsUpdated)
                GetRequiredValue();

            if (_comm.ValueType == Models.Type.Float)
                return (float)Convert.ToDouble(FileContents);

            return null;
        }

        public bool? GetBoolean()
        {
            if (!FileContentsUpdated)
                GetRequiredValue();

            if (_comm.ValueType == Models.Type.Boolean)
                return Convert.ToBoolean(FileContents);

            return null;
        }

        public string GetString()
        {
            if (!FileContentsUpdated)
                GetRequiredValue();

            return FileContents;
        }




        private void GetRequiredValue()
        {
            OpenFileAndReadContents();
            ReadValueFromFile();
            ConvertValueToFormat();
        }

        public bool FileIsReadable()
        {
            bool readOk = OpenFileAndReadContents();
            bool contentOk = false;

            if (FileContents != "" || FileContents != null)
            {
                contentOk = true;
            }

            return (readOk && contentOk);
        }

        private bool OpenFileAndReadContents()
        {
            if (File.Exists(_comm.FilePath))
            {
                DebugOutput.Print("Reading file at ", _comm.FilePath);

                DateTime LastWriteTime = File.GetLastWriteTime(_comm.FilePath);

                if (LastWriteTime > _comm.LastReadTime)
                {
                    try
                    {
                        TextReader fileReaderObject = new StreamReader(new FileStream(_comm.FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite));
                        var FileContents = fileReaderObject.ReadToEnd();
                        fileReaderObject.Close();
                        fileReaderObject.Dispose();

                        _comm.LastReadTime = LastWriteTime;
                        this.FileContents = FileContents.ToString();
                    }
                    catch (Exception e)
                    {
                        DebugOutput.Print("Attempt to read file failed!", e.Message);
                        return false;
                    }
                }

                //Check the file contents read mean the start and end values are obtainable.
                if (FileContents.Length >= _comm.StartChar && FileContents.Length >= (_comm.StartChar + (_comm.EndChar - _comm.StartChar)))
                {
                    DebugOutput.Print("Data range OK for file at ", _comm.FilePath);
                    return true;
                }
            }

            //File did not contain the required data/range.
            DebugOutput.Print("Unavailable file at ", _comm.FilePath);
            return false;
        }

        private bool ReadValueFromFile()
        {
            DebugOutput.Print("Collecting value from file at ", _comm.FilePath);
            bool ReadToEnd = _comm.EndChar == 0 ? true : false;

            if (FileContents.Length >= _comm.StartChar && (!ReadToEnd && FileContents.Length >= (_comm.EndChar)))
            {
                try
                {
                    int length = _comm.EndChar - _comm.StartChar;
                    if (length>0)
                    {
                        FileContents = FileContents.Substring(_comm.StartChar, length);
                        DebugOutput.Print("Obtained value from file at ", _comm.FilePath);
                    }
                    return true;
                }
                catch (Exception e)
                {
                    DebugOutput.Print("The data in the file did not match the constraints given for file at ", _comm.FilePath);
                    throw new FileLoadException(
                        "The data in the file did not match the constraints given to read the data.");
                }
            }

            return false;
        }

        private bool ConvertValueToFormat()
        {
            DebugOutput.Print("Converting the value to ", _comm.ValueType.ToString());
            bool ConvertedOk = false;

            switch (_comm.ValueType)
            {
                case Models.Type.Integer:
                    {
                        int convertedInt = int.MinValue;
                        if (int.TryParse(FileContents, out convertedInt))
                        {
                            FileContents = convertedInt.ToString();
                            ConvertedOk = true;
                        }

                        break;
                    }
                case Models.Type.Float:
                    {
                        float convertedFloat = float.MinValue;
                        if (float.TryParse(FileContents, out convertedFloat))
                        {
                            FileContents = convertedFloat.ToString();
                            ConvertedOk = true;
                        }

                        break;
                    }
                case Models.Type.Boolean:
                    {
                        bool returnValue = false;
                        if (bool.TryParse(FileContents, out returnValue))
                        {
                            FileContents = returnValue.ToString();
                            ConvertedOk = true;
                        }

                            break;
                    }
                case Models.Type.String:
                    {
                        FileContents = FileContents.ToString();
                        ConvertedOk = true;
                        break;
                    }
            }

            if (ConvertedOk)
            {
                DebugOutput.Print("Converted value successfully: ", FileContents);
            }
            else
            {
                DebugOutput.Print("Value could not be converted successfully; stored the following in string format: ", FileContents);
            }

            return ConvertedOk;
        }



    }
}
