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
            lDevice.Text = _device.ToString();

            cbValueType.DataSource = Enum.GetValues(typeof(Models.ValueType));
            cbRuleType.DataSource = Enum.GetValues(typeof(Models.RuleType));
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            var model = new Models.Rule()
            {
                DeviceId = _device.Id,
                Device = _device,

                RuleType = (Models.RuleType) cbRuleType.SelectedItem,
                ValueType = (Models.ValueType) cbValueType.SelectedItem,
                Action = null,
                Alarm = cAlarm.Checked,
                Constraint = tConstraint.Text,
                Name = tName.Text
            };

            var deviceController = new DeviceController();
            deviceController.CreateRule(model);
        }
    }
}
