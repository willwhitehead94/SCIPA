using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCIPA.Models;

namespace SCIPA.UI
{
    public partial class AddInbound : Form
    {
        private Device _device = null;

        public AddInbound(Device device)
        {
            InitializeComponent();
            _device = device;
        }

        private void AddInbound_Load(object sender, EventArgs e)
        {
            lDeviceId.Text = _device.Id.ToString();
        }
    }
}
