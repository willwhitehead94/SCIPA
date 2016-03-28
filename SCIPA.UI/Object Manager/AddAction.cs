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

namespace SCIPA.UI.Object_Manager
{
    public partial class AddAction : Form
    {
        private Models.Rule _rule = null;
        private Models.Action _action = null;
        private Models.Communicator _comm = null;

        public AddAction(Models.Rule rule)
        {
            //Initialise
            InitializeComponent();
            _rule = rule;

            //If Action already created, load the info.
            _action = rule.Action;

            //If Communicator already created, load the info.
            if (_action != null)
            {
                var controller = new CommunicatorController();
                _comm = controller.GetAllCommunicators().FirstOrDefault(c => c.Id == rule.Action.CommunicatorId);
            }
        }

        private void AddAction_Load(object sender, EventArgs e)
        {
            this.Text = "Create/Modify Rule Action";
            lRule.Text = _rule.ToString();

            if (_comm != null) bCommunicator.Text = _comm.ToString();

            if (_action != null)
            {
                tOutput.Text = _action.OutputValue;
                cEnabled.Checked = _action.Enabled;
            }

        }

        private void bCommunicator_Click(object sender, EventArgs e)
        {
            if (_comm == null)
            { 
                var devCont = new DeviceController();
                var device = devCont.RetrieveDevice(_rule.DeviceId);

                var ai = new AddCommunicator(device,false);
                ai.ShowDialog();
                _comm = ai._communicator;
            }
            else
            {
                var cm = new CommunicatorModifier(_comm);
                cm.ShowDialog();
            }
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            if (_comm != null && _rule != null && tOutput.Text != "")
            {
                if (_action==null) _action = new Models.Action();

                _action.CommunicatorId = _comm.Id;
                _action.Enabled = cEnabled.Checked;
                _action.OutputValue = tOutput.Text;
                _action.Communicator = _comm;
                _action.Rule = _rule;
                _action.RuleId = _rule.Id;
                //_action.Id

                var controller = new ActionController();
                _action = controller.CreateAction(_action);
                if (_action.Id > 0) System.Windows.Forms.MessageBox.Show("Success!");
            }
        }
    }
}
