using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCIPA.Domain.Logic;
using SCIPA.Models;

namespace SCIPA.UI
{
    public partial class SetDeviceCommunicators : Form
    {
        private Device localisedDevice = null;

        public SetDeviceCommunicators(Device device)
        {
            InitializeComponent();
            localisedDevice = device;

            this.Text = "Settings for " + localisedDevice.Name;
        }

        private void SetDeviceCommunicators_Load(object sender, EventArgs e)
        {
            var _controller = new CommunicatorController();
            IEnumerable<Communicator> commsList = _controller.GetAllFileCommunicators();

            foreach (var comm in commsList)
            {
                cbReader.Items.Add(comm);
                cbWriter.Items.Add(comm);
            }
        }

        private void cbReader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReader.SelectedItem == cbWriter.SelectedItem)
            {
                System.Windows.Forms.MessageBox.Show(
                    "You cannot select the same communicator for both reading and writing");
                return;
            }
            localisedDevice.Reader = (Communicator)cbReader.SelectedItem;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            localisedDevice = localisedDevice;
            var cont = new DeviceController();
            cont.SaveDevice(localisedDevice);
        }

        private void cbWriter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbReader.SelectedItem == cbWriter.SelectedItem)
            {
                System.Windows.Forms.MessageBox.Show(
                    "You cannot select the same communicator for both reading and writing");
                return;
            }
            localisedDevice.Writer = (Communicator)cbWriter.SelectedItem;
        }
    }
}
