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
using Rule = SCIPA.Models.Rule;

namespace SCIPA.UI.Object_Manager
{
    public partial class AddRule : Form
    {
        private Device _device;
        private Models.Rule _rule;
        private Models.Action _action;

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
            //Create new model.
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

            //Push to Database.
            var controller = new RuleController();
            _rule = controller.CreateRule(model);

            //Update the global Device object.
            var devController = new DeviceController();
            var index = DeviceController.AllDevices.FindIndex(d => d.Id == _device.Id);
            var allRules = new List<Rule>();
            allRules.AddRange(_device.Rules);
            allRules.Add(_rule);
            _device.Rules = allRules;
            DeviceController.AllDevices[index] = _device;
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

        private void bSetAction_Click(object sender, EventArgs e)
        {
            var addAction = new AddAction(_rule);
            addAction.ShowDialog();
            bSetAction.Text = "Action set!";
            bSetAction.Enabled = false;
            _action = addAction.GetAction();
        }
    }
}
