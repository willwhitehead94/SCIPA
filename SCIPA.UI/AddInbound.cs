using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCIPA.Domain.Logic;
using SCIPA.Models;

namespace SCIPA.UI
{
    public partial class AddInbound : Form
    {
        private Device _device = null;
        private Communicator _communicator = null;
        private CommunicatorController _controller = new CommunicatorController();

        public AddInbound(Device device)
        {
            InitializeComponent();
            _device = device;
        }

        private void AddInbound_Load(object sender, EventArgs e)
        {
            lHeader.Text = string.Format(lHeader.Text, _device.Id.ToString(), _device.Name);
            cbValueType.DataSource = Enum.GetValues(typeof(Models.ValueType));
            cbDBType.DataSource = Enum.GetValues(typeof (DatabaseType));
            bReloadSerialCommList.PerformClick();
        }

        private void CheckCommunicatorIsDatabase()
        {
            if (_communicator is DatabaseCommunicator)
            {
                return;
            }
            _communicator = new DatabaseCommunicator();
        }

        private void CheckCommunicatorIsFlatFile()
        {
            if (_communicator is FileCommunicator)
            {
                return;
            }
            _communicator = new FileCommunicator();
        }

        private void CheckCommunicatorIsSerial()
        {
            if (_communicator is SerialCommunicator)
            {
                return;
            }
            _communicator = new SerialCommunicator();
        }

        private void tConnString_TextChanged(object sender, EventArgs e)
        {
            CheckCommunicatorIsDatabase();
        }

        private void tQuery_TextChanged(object sender, EventArgs e)
        {
            CheckCommunicatorIsDatabase();
        }

        private void cbDBType_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCommunicatorIsDatabase();
        }

        private void tFilePath_TextChanged(object sender, EventArgs e)
        {
            CheckCommunicatorIsFlatFile();
        }

        private void cbComPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckCommunicatorIsSerial();
        }

        private void tBit_TextChanged(object sender, EventArgs e)
        {
            CheckCommunicatorIsSerial();
        }

        private void tBaud_TextChanged(object sender, EventArgs e)
        {
            CheckCommunicatorIsSerial();
        }

        private void cRTS_CheckedChanged(object sender, EventArgs e)
        {
            CheckCommunicatorIsSerial();
        }

        private void cDTR_CheckedChanged(object sender, EventArgs e)
        {
            CheckCommunicatorIsSerial();
        }

        private void bStartEndHelp_Click(object sender, EventArgs e)
        {
            string helpMsg =
                "SCIPA will read in all available data from the source you have selected.\n" +
                "For example, a serial device may send 'DEV_202.86', but only  the numerical data is required.\n\n" +
                "In this case, set the start char value to be 5 (the numbers are 0 indexed). To read to the end of a string, leave the length as 0, otherwise, enter a length.\n\n" +
                "In our example, enter a start of 5 and a length of 2 would result in SCIPA only reading '20'.";

            var result = System.Windows.Forms.MessageBox.Show(helpMsg, "Assistance",
               MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            var devList = new List<Device>();
            if (_communicator.Device != null)
            {
                devList= _communicator.Device.ToList();
            }


            if (_communicator is DatabaseCommunicator)
            {
                _communicator = new DatabaseCommunicator()
                {
                    DbType = (DatabaseType)cbDBType.SelectedItem,
                    ValueType = (Models.ValueType)cbValueType.SelectedItem,
                    ConnectionString = tConnString.Text,
                    Query = tQuery.Text,
                    StartChar = GetStartChar(),
                    EndChar = GetEndChar(),
                    Device = devList
                };
            }
            else if (_communicator is SerialCommunicator)
            {
                _communicator =new SerialCommunicator()
                {
                    StartChar = GetStartChar(),
                    EndChar = GetEndChar(),
                    ValueType = (Models.ValueType)cbValueType.SelectedItem,
                    BaudRate = Convert.ToInt32(tBaud.Text),
                    ComPort = cbComPort.SelectedText,
                    DataBits = Convert.ToByte(tBit.Text),
                    IsDTR = cDTR.Checked,
                    IsRTS = cRTS.Checked,
                    Device = devList
                };
            }
            else if (_communicator is FileCommunicator)
            {
                _communicator =new FileCommunicator()
                {
                    FilePath = tFilePath.Text,
                    ValueType = (Models.ValueType)cbValueType.SelectedItem,
                    StartChar = GetStartChar(),
                    EndChar = GetEndChar(),
                    Device = devList
                };
            }
            
            _device.Reader = _communicator;
            _controller.SaveCommunicator(_communicator, _device);
        }

        private int GetStartChar()
        {
            var start = 0;

            int.TryParse(tStartChar.Text, out start);

            return start;
        }

        private int GetEndChar()
        {
            var end = 0;
            int.TryParse(tEndChar.Text, out end);
            if (end > 0)
            {
                return GetStartChar() + end;
            }

            return end;
        }

        /// <summary>
        /// Checks the operating system for a list of available COM ports.
        /// Does not check that the port is operable (in that a port 
        /// already in use will be displayed).
        /// The combobox will be updated on each performed click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bReloadSerialCommList_Click(object sender, EventArgs e)
        {
            cbComPort.DataSource = SerialPort.GetPortNames();
            cbComPort.Refresh();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("The returned value is " + _controller.GetMaxId<DatabaseCommunicator>());
        }
    }
}
