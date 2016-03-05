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

namespace SCIPA.UI
{
    public partial class CreateDevice : Form
    {
        private DeviceController _controller = new DeviceController();

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
            _controller.SaveDevice(Convert.ToInt32(tId.Text), tName.Text, tLocation.Text, tCustodian.Text, enabled);
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
    }
}
