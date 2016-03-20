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
    public partial class CreateDevice : Form
    {
        private DeviceController _controller = new DeviceController();
        private Device _device = null;

        public CreateDevice()
        {
            InitializeComponent();
        }

        private void CreateDevice_Load(object sender, EventArgs e)
        {
            tId.Text = (_controller.CurrentMaxId()+1).ToString();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            bool enabled = rbTrue.Checked && !rbFalse.Checked;
            _device = _controller.GetDeviceObject(Convert.ToInt32(tId.Text), tName.Text, tLocation.Text, tCustodian.Text, enabled);
            if (!_controller.SaveDevice(_device))
            {
                MessageBox.Show("There was an error saving the Device...");
            }
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            var result = System.Windows.Forms.MessageBox.Show("Your changes will be lost?", "Are you sure you want to close?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void bAddSource_Click(object sender, EventArgs e)
        {
            var result = System.Windows.Forms.MessageBox.Show("Adding a data source will save the device information. Proceed with adding a data source?", "Save and Continue?",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                bSave.PerformClick();
                AddInbound ai = new AddInbound(_device);
                ai.ShowDialog();
            }
        }

        private void bAddDestination_Click(object sender, EventArgs e)
        {
            var result = System.Windows.Forms.MessageBox.Show("Adding a data destination will save the device information. Proceed with adding a data destination?", "Save and Continue?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
            }
        }

        private void bAddRule_Click(object sender, EventArgs e)
        {
            var result = System.Windows.Forms.MessageBox.Show("Adding a data rule will save the device information. Proceed with adding a rule?", "Save and Continue?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {

            }
        }
    }
}
