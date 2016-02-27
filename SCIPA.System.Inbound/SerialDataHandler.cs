using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using SCIPA.Domain.Logic;
using System.Threading;
using SCIPA.Models;
using SCIPA.Models.Resources;
using ValueType = SCIPA.Models.ValueType;

namespace SCIPA.Domain.Inbound
{
    public class SerialDataHandler:DataHandler
    {
        /// <summary>
        /// Serial Port object used to connect to, send and receive messages from the COM Port.
        /// </summary>
        private SerialPort _sPort;

        /// <summary>
        /// Serial CommunicatorModel object used to store the COM settings.
        /// </summary>
        public SerialCommunicator Communicator { get; set; }

        /// <summary>
        /// Boolean is only true if the com has been closed and could not be opened
        /// for a set number of attempts. The default is three.
        /// </summary>
        private bool _portOutOfService = false;



        /// <summary>
        /// Constructor taking a SerialCommunicator object so as to allow COM settings to be
        /// implemented. Listening starts immediately.
        /// </summary>
        /// <param name="communicator"></param>
        public SerialDataHandler(SerialCommunicator communicator)
        {
            Communicator = communicator;

            _sPort = new SerialPort(Communicator.comPort);

            _sPort.BaudRate = 9600;
            _sPort.Parity = Parity.None;
            _sPort.StopBits = StopBits.One;
            _sPort.DataBits = 8;
            _sPort.Handshake = Handshake.None;

            _sPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            try
            {
                if (_portOutOfService)
                {
                    _sPort.DataReceived -= DataReceivedHandler;
                    throw new IOException("Port stopped responding. Closing connection on " + Communicator.comPort);
                }

                ThreadPool.QueueUserWorkItem(new WaitCallback(CheckConnectionState));
            }
            catch(System.IO.IOException ioe)
            {
                DebugOutput.Print(_sPort.PortName + " has an IO error! ", ioe.Message);
            }
            catch(UnauthorizedAccessException uae)
            {
                DebugOutput.Print(_sPort.PortName + " has an Access error! ", uae.Message);
            }
            catch(Exception e)
            {
                DebugOutput.Print(_sPort.PortName + " has a general error! ", e.Message);
            }
            
        }

        /// <summary>
        /// Executed on data received event - adds the new value to the queue.
        /// </summary>
        /// <param name="sender">Event Received Handler.</param>
        /// <param name="e">Event received data.</param>
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            double ms = 60000 / MaximumReadsPerMinute;
            if (_lastIncomingMessage.AddMilliseconds(ms) < DateTime.Now)
            {
                SerialPort sp = (SerialPort)sender;
                string indata = sp.ReadLine().Trim();

                if (indata != "")
                {
                    _lastIncomingMessage = DateTime.Now;
                    string info = "Incoming data received from {0}: '{1}'";
                    info = string.Format(info, sp.PortName, indata);
                    DebugOutput.Print(info);

                    InboundDataQueue.Enqueue(new Value()
                    {
                        ValueType = ValueType.String,
                        CommType = CommunicatorType.Serial,
                        EventTime = DateTime.Now,
                        StringValue = indata,
                        Inbound = true
                    });
                }
            }
        }

        /// <summary>
        /// Repeatedly checks the connection state of the COM port.
        /// If the connection fails a certain number of time, the COM is ignored.
        /// </summary>
        /// <param name="obj">Threadable object.</param>
        private void CheckConnectionState(object obj)
        {
            int secondsToWaitBetweenChecks = 5;
            int checksPerformed = 0;

            //Do not try more than three times to open the port...
            while (checksPerformed < 3)
            {
                Thread.Sleep(secondsToWaitBetweenChecks*1000);
                if (_sPort.IsOpen)
                {
                    checksPerformed = 0;
                }
                else
                {
                    
                    try {
                        _sPort.Open();
                        DebugOutput.Print("Serial connection reopened on port ", _sPort.PortName);
                    }
                    catch(Exception e) { checksPerformed++; DebugOutput.Print(_sPort.PortName + " could not be reopened. ", e.Message); }
                }
            }

            DebugOutput.Print("Now ignoring ",_sPort.PortName);
            _portOutOfService = true;
        }


        public override Communicator GetCommunicator()
        {
            return Communicator;
        }
    }
}