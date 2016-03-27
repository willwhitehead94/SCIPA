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
        private Models.Rule _rule;

        public AddRule(Device device)
        {
            InitializeComponent();
            _device = device;
        }

        private void AddRule_Load(object sender, EventArgs e)
        {
            this.Text = _device.ToString();
            lDevice.Text = _device.ToString();

            //Create list of available Value Types to read for this rule.
            cbValueType.DataSource = Enum.GetValues(typeof(Models.ValueType));
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

            var controller = new RuleController();
            _rule = controller.CreateRule(model);
        }

        private void cbValueType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set the Rule Types available dependant on the selected ValueType.
            var selected = (Models.ValueType)(cbValueType.SelectedItem);

            //Clear the current list.
            cbRuleType.DataSource = null;
            cbRuleType.Items.Clear();

            //Integer and Float have all options (so Integer falls through).
            switch (selected)
            {
                case Models.ValueType.Integer:
                case Models.ValueType.Float:
                    cbRuleType.DataSource = Enum.GetValues(typeof(Models.RuleType));
                    break;
                case Models.ValueType.String:
                    cbRuleType.Items.Add(Models.RuleType.EqualTo);
                    cbRuleType.Items.Add(Models.RuleType.Not);
                    break;
                case Models.ValueType.Boolean:
                    cbRuleType.Items.Add(Models.RuleType.EqualTo);
                    break;
            }

            //Refresh the ComboBox.
            cbRuleType.Refresh();
        }
    }
}
