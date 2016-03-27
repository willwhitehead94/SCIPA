using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using SCIPA.Domain.Logic;
using System.Threading;
using SCIPA.Domain.Generic;
using SCIPA.Models;
using ValueType = SCIPA.Models.ValueType;

namespace SCIPA.Domain.Outbound
{
    public class SerialDataHandler:DataHandler
    {
        /// <summary>
        /// Serial Port object used to connect to, send and receive messages from the COM Port.
        /// </summary>
        private SerialPort _sPort;

        /// <summary>
        /// Constructor taking a SerialCommunicator object so as to allow COM settings to be
        /// implemented.
        /// </summary>
        /// <param name="communicator"></param>
        public SerialDataHandler(SerialCommunicator communicator)
        {
            //Create temp variable to read the required values.
            var comm = (SerialCommunicator) communicator;

            //Initialise the COM Port settings.
            _sPort = new SerialPort(comm.ComPort)
            {
                BaudRate = comm.BaudRate,
                Parity = Parity.None,
                StopBits = StopBits.One,
                DataBits = comm.DataBits,
                Handshake = Handshake.None,
                DtrEnable=comm.IsDTR,
                RtsEnable = comm.IsRTS
            };
        }


        /// <summary>
        /// Repeatedly checks the connection state of the COM port.
        /// If the connection fails a certain number of time, the COM is ignored.
        /// </summary>
        private bool CheckPort
        {
            get
            {
                try
                {
                    int secondsToWaitBetweenChecks = 1;
                    int checksPerformed = 0;

                    //Do not try more than three times to open the port...
                    while (checksPerformed < 3)
                    {
                        Thread.Sleep(secondsToWaitBetweenChecks * 1000);
                        if (_sPort.IsOpen)
                        {
                            checksPerformed = 0;
                        }
                        else
                        {
                            try
                            {
                                _sPort.Open();
                                if (_sPort.IsOpen)
                                {
                                    DebugOutput.Print("Serial WRITE connection reopened on port ", _sPort.PortName);
                                    _sPort.Close();
                                    return true;
                                }
                                DebugOutput.Print($"Serial WRITE connection could not be opened on port ", _sPort.PortName);
                                return false;
                            }
                            catch (Exception e) { checksPerformed++; DebugOutput.Print(_sPort.PortName + " could not be reopened for writing. ", e.Message); }
                        }
                    }
                }
                catch (Exception)
                {
                    DebugOutput.Print($"There was a failure when opening {_sPort.PortName} for writing! Failed.");
                    return false;
                }

                return false;

            }
        }


        /// <summary>
        /// Transmit the passed Value parameter to the Communicator's port.
        /// </summary>
        /// <param name="value">Message to print to file.</param>
        /// <returns>Successful/Fail boolean.</returns>
        public bool OutputValue(string value)
        {
            DebugOutput.Print($"Attempting to write '{value}' to {_sPort.PortName}");

            try
            {
                //Ensure appropriate access to the file can be obtained.
                if (CheckPort)
                {
                    try
                    {
                        //Open, Write and Close.
                        _sPort.Open();
                        if (_sPort.IsOpen)
                        {
                            _sPort.WriteLine(value);
                        }
                        _sPort.Close();
                        DebugOutput.Print($"'{value}' was written to {_sPort.PortName} successfully.");
                        return true;
                    }
                    catch (Exception e)
                    {
                        DebugOutput.Print($"'{value}' failed to be written to {_sPort.PortName} successfully. ", e.Message);
                        return false;
                        throw;
                    }
                }
                DebugOutput.Print($"Did not write '{value}' because of CheckPort fail.");
            }
            catch (Exception e)
            {
                DebugOutput.Print($"Did not write '{value}' because of ", e.Message);
            }

            return false;
        }
    }
}