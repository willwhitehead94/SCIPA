using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO.Ports;
using SCIPA.Domain.Logic;
using System.Threading;

namespace SCIPA.Domain.Inbound
{
    public class SerialDataHandler
    {
        private const int MaximumReadsPerSecond = 1;

        private SerialPort _sPort;
        private Queue<byte> _inboundQueue;
        private DateTime _lastIncomingMessage;

        public SerialDataHandler(string portName)
        {
            _inboundQueue = new Queue<byte>();

            _sPort = new SerialPort(portName);

            _sPort.BaudRate = 9600;
            _sPort.Parity = Parity.None;
            _sPort.StopBits = StopBits.One;
            _sPort.DataBits = 8;
            _sPort.Handshake = Handshake.None;

            _sPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            try
            {
                _sPort.Open();
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

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            double ms = 1000 / MaximumReadsPerSecond;
            if (_lastIncomingMessage.AddMilliseconds(ms) < DateTime.Now)
            {
                SerialPort sp = (SerialPort)sender;
                string indata = sp.ReadLine();

                float data;

                if (float.TryParse(indata, out data))
                {
                    _lastIncomingMessage = DateTime.Now; 
                    string info = "Incoming data received from {0}: '{1}'";
                    info = string.Format(info, sp.PortName, data);
                    DebugOutput.Print(info);
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        private void CheckConnectionState(object obj)
        {
            int secondsToWaitBetweenChecks = 5;

            while (true)
            {
                Thread.Sleep(secondsToWaitBetweenChecks*1000);
                if (_sPort.IsOpen)
                {
                    //DebugOutput.Print("Serial connection is open on port ",_sPort.PortName);
                }
                else
                {
                    DebugOutput.Print("Serial connection is closed on port ", _sPort.PortName);
                    try { _sPort.Open(); }
                    catch(Exception e) { DebugOutput.Print(_sPort.PortName + " could not be reopened... Note: ", e.Message); }
                }
            }
        }
    }
}