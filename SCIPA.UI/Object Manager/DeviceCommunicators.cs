using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCIPA.Domain.Inbound;
using SCIPA.Domain.Logic;
using SCIPA.Models;

namespace SCIPA.UI.Object_Manager
{
    public partial class DeviceCommunicators : Form
    {
        DeviceController devCont = new DeviceController();
        CommunicatorController commCont = new CommunicatorController();
        private DataReader reader;
        private Device selectedDevice;

        public DeviceCommunicators()
        {
            InitializeComponent();
            bStart.Enabled = false;
        }

        private void DeviceCommunicators_Load(object sender, EventArgs e)
        {
            bStart.Enabled = false;
            cbDevices.Items.Clear();
            var devList = devCont.GetAllDevices().ToList();

            foreach (var dev in devList)
            {
                cbDevices.Items.Add(dev);
            }
        }

        private void cbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            bStart.Enabled = false;
            cbCommunicators.Items.Clear();
            selectedDevice = (Device)cbDevices.SelectedItem;
            var commList = commCont.GetAllFileCommunicators().Where(comm => comm.Device.Id == selectedDevice.Id);

            foreach (var comm in commList)
            {
                cbCommunicators.Items.Add(comm);
            }
        }

        private void cbCommunicators_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCommunicators.SelectedItem != null)
            {
                bStart.Enabled = true;
            }
        }

        private void bStart_Click(object sender, EventArgs e)
        {
            Communicator selectedCommunicator = (Communicator)cbCommunicators.SelectedItem;

            switch (selectedCommunicator.Type)
            {
                case CommunicatorType.FlatFile:
                    reader = new FlatFileReader(new FlatFileHandler((FileCommunicator)cbCommunicators.SelectedItem));
                    break;
                case CommunicatorType.Serial:
                    reader = new SerialDataReader(new SerialDataHandler((SerialCommunicator)cbCommunicators.SelectedItem));
                    break;
                case CommunicatorType.Database:
                    reader = new DatabaseReader(new DatabaseHandler((DatabaseCommunicator)cbCommunicators.SelectedItem));
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

           
            Loop(null);
        }

        private void Loop(object obj)
        {
            while (true)
            {
                while (reader.AvailableValues() > 0)
                {
                    lbValues.Items.Add(reader.GetNextValueAsString());
                    lbValues.Refresh();
                }
                Thread.Sleep(500);
            }
        }
    }
}
