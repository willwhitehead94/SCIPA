using SCIPA.Models;
using System;
using System.IO;
using System.Text;
using SCIPA.Domain.Generic;


namespace SCIPA.Domain.Outbound
{
    /// <summary>
    /// Flat file variant of the Handler class for outbound data.
    /// </summary>
    public class FlatFileHandler : DataHandler
    {
        /// <summary>
        /// Local strings used to determine the difference between the three similar values;
        /// file name, file path and the folder path.
        /// </summary>
        private string _filePath, _folderPath, _fileName;

        /// <summary>
        /// The value that caused the required write.
        /// </summary>
        private Value _value = null;

        /// <summary>
        /// Constructor takes a file communicator object.
        /// </summary>
        /// <param name="comms">File Communicator Model</param>
        public FlatFileHandler(FileCommunicator comms, Rule rule, Value val)
        {
            //Set the Communicator object.
            _communicator = comms;

            //Configure the local File Path variables.
            _filePath = comms.FilePath;

            //Give access to the value.
            _value = val;

            //Output the data required - any instance of [val] is replaced with the actual value
            StringBuilder builder = new StringBuilder(rule.Action.OutputValue);
            builder.Replace("[val]", _value.StringValue);

            //Output the string
            OutputValue(builder.ToString());
        }

        /// <summary>
        /// Ensure the file is valid, available and OK to open.
        /// </summary>
        /// <returns>Success of fail boolean.</returns>
        private bool CheckFile
        {
            get
            {
                try
                {
                    //Find last slash in the string (i.e. jump to file name and extension)
                    int lastSlashIndex = _filePath.LastIndexOf('\\') + 1;
                    _fileName = _filePath.Substring(lastSlashIndex);

                    //Change fullPath to contain only the file path (excludes the filename).
                    _folderPath = _filePath.Substring(0,
                        (_filePath.Length - (_filePath.Length - lastSlashIndex)));

                    //Check file exists and is accessible
                    if (System.IO.File.Exists(_filePath))
                    {
                        DebugOutput.Print($"Connected to file at {_filePath}");

                        //System checker
                        var result = System.IO.File.OpenWrite(_filePath);

                        if (result.CanWrite)
                        {
                            DebugOutput.Print($"{_fileName} can be written to.");
                            result.Close();
                            return true;
                        }

                        result.Close();
                    }
                }
                catch (Exception e)
                {
                    DebugOutput.Print($"Could not gain access to {_fileName}. An error occured!", e.Message);
                    return false;
                }


                //If unable to access the file, return false
                DebugOutput.Print($"Unable to gain access to {_fileName}.");
                return false;
            }
        }

        /// <summary>
        /// Print the passed Value parameter to the Communicator's file path.
        /// </summary>
        /// <param name="value">Message to print to file.</param>
        /// <returns>Successful/Fail boolean.</returns>
        public bool OutputValue(string value)
        {
            DebugOutput.Print($"Attempting to write '{value}' to {_fileName}");

            try
            {
                //Ensure appropriate access to the file can be obtained.
                if (CheckFile)
                {
                    //Using StreamWriter ensures proper disposal of the object following write.
                    using (var writer = new StreamWriter(@_filePath))
                    {
                        writer.WriteLine(value);
                    }
                    DebugOutput.Print($"Successful write of '{value}'.");
                    return true;
                }
                DebugOutput.Print($"Did not write '{value}' because of CheckFile fail.");
            }
            catch (Exception e)
            {
                DebugOutput.Print($"Did not write '{value}' because of ",e.Message);
            }

            return false;
        }
    }
}
