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

namespace SCIPA.UI.Object_Manager
{
    public partial class AddRule : Form
    {
        private Device _device;

        public AddRule(Device device)
        {
            InitializeComponent();
            _device = device;
        }

        private void AddRule_Load(object sender, EventArgs e)
        {
            this.Text = _device.ToString();
        }
    }
}
