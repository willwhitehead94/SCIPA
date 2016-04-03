using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCIPA.Domain.Generic;
using SCIPA.Domain.Logic;
using SCIPA.Models;

namespace SCIPA.UI.HMI
{
    public partial class DataBoard : Form
    {
        private Communicator _communicator = null;
        private Device _device = null;
        private Models.Rule _rule = null;
        private Models.Action _action = null;

        public DataBoard(Communicator _comm, Device _dev)
        {
            InitializeComponent();
            _communicator = _comm;
            _device = _dev;
        }

        private void add_bSaveSource_Click(object sender, EventArgs e)
        {

            if (_communicator is DatabaseCommunicator)
            {
                _communicator = new DatabaseCommunicator()
                {
                    DbType = (DatabaseType) add_cbDatabaseType.SelectedItem,
                    ValueType = (Models.ValueType) add_cbValueType.SelectedItem,
                    ConnectionString = add_tConnectionString.Text,
                    Query = add_tQuery.Text,
                    StartChar = GetStartChar(),
                    EndChar = GetEndChar(),
                    Device = _device,
                    //Id = GetNextIdNumber(),
                    Inbound = true,
                    Type = CommunicatorType.Database,
                    Action = null
                };
            }
            else if (_communicator is SerialCommunicator)
            {
                _communicator = new SerialCommunicator()
                {
                    StartChar = GetStartChar(),
                    EndChar = GetEndChar(),
                    ValueType = (Models.ValueType) add_cbValueType.SelectedItem,
                    BaudRate = Convert.ToInt32(add_tBaudRate.Text),
                    ComPort = add_cbComPort.SelectedItem.ToString(),
                    DataBits = Convert.ToByte(add_tDataBits.Text),
                    IsDTR = add_cbDtr.Checked,
                    IsRTS = add_cbRts.Checked,
                    Device = _device,
                    Inbound = true,
                    Type = CommunicatorType.Serial,
                    Action = null
                    //Id = GetNextIdNumber()
                };
            }
            else if (_communicator is FileCommunicator)
            {
                _communicator = new FileCommunicator()
                {
                    FilePath = add_tFilePath.Text,
                    ValueType = (Models.ValueType) add_cbValueType.SelectedItem,
                    StartChar = GetStartChar(),
                    EndChar = GetEndChar(),
                    Device = _device,
                    Type = CommunicatorType.FlatFile,
                    Inbound = true,
                    Action = null
                    //Id = GetNextIdNumber()
                };
            }

            _communicator.Device = _device;

            var _controller = new CommunicatorController();
            var Id = _controller.SaveCommunicator(_communicator);
            if (Id != null) _communicator.Id = (int) Id;
            DebugOutput.Print($"a new Communicator was created with ID {_communicator.Id.ToString()}");

            this.Close();
        }

        private void DataBoard_Load(object sender, EventArgs e)
        {
            add_cbCommType.DataSource = Enum.GetValues(typeof (Models.CommunicatorType));
            add_cbValueType.DataSource = Enum.GetValues(typeof (Models.ValueType));
            add_cbDatabaseType.DataSource = Enum.GetValues(typeof (Models.DatabaseType));
            add_cbComPort.DataSource = SerialPort.GetPortNames();
            add_cbRuleCheckValue.DataSource = Enum.GetValues(typeof (Models.ValueType));
            add_cbRuleType.DataSource = Enum.GetValues(typeof (Models.RuleType));

            //Adds known rules for the device to the list box.
            var controller = new RuleController();
            add_cbRule.Items.Clear();
            foreach (Models.Rule rule in controller.RetrieveRulesForDevice(_device.Id)) add_cbRule.Items.Add(rule);

            //Adds outbound comms to the Action list box.
            var commController = new CommunicatorController();
            add_cbCommunicatorDestination.Items.Clear();
            List<Communicator> allComms = commController.GetAllCommunicators().Where(c => c.Device.Id == _device.Id && c.Inbound == false).ToList();
            add_cbCommunicatorDestination.Items.AddRange(allComms.ToArray());
                
        }

        private void add_bRefreshComPorts_Click(object sender, EventArgs e)
        {
            add_cbComPort.DataSource = SerialPort.GetPortNames();
            add_cbComPort.Refresh();
        }

        private int GetStartChar()
        {
            var start = 0;

            int.TryParse(add_tStartChar.Text, out start);

            return start;
        }

        private int GetEndChar()
        {
            var end = 0;
            int.TryParse(add_tEnd.Text, out end);
            if (end > 0)
            {
                return GetStartChar() + end;
            }

            return end;
        }

        public Communicator GetCommunicator()
        {
            return _communicator;
        }

        public Device GetDevice()
        {
            return _device;
        }

        public Models.Rule GetRule()
        {
            return _rule;
        }

        public Models.Action GetAction()
        {
            return _action;
        }

        public void GoToCommunicatorPage()
        {
            add_tcInnerPages.SelectedTab = pDataConnection;
        }

        public void GoToRulePage()
        {
            add_tcInnerPages.SelectedTab = pRules;
        }

        public void GoToActionPage(Models.Rule rule = null)
        {
            add_tcInnerPages.SelectedTab = pActions;

            if (rule == null) return;

            //Create action for specific rule if rule was specified.
            _rule = rule;
            add_cbRule.Items.Add(rule);
            add_cbRule.SelectedIndex = 0;
            add_cbRule.Enabled = false;


        }

        private void add_cbCommType_SelectedIndexChanged(object sender, EventArgs e)
        {
            add_tcInnerPages = new CustomTabControl();

            var specalism = (CommunicatorType) add_cbCommType.SelectedItem;
            switch (specalism)
            {
                case CommunicatorType.FlatFile:
                    _communicator = new FileCommunicator();
                    add_tcInnerPagesSourceSetting.SelectedTab = pFlatFile;
                    break;
                case CommunicatorType.Serial:
                    _communicator = new SerialCommunicator();
                    add_tcInnerPagesSourceSetting.SelectedTab = pSerial;
                    break;
                case CommunicatorType.Database:
                    _communicator = new DatabaseCommunicator();
                    add_tcInnerPagesSourceSetting.SelectedTab = pDatabase;
                    break;
                default:
                    break;
            }
        }

        private void add_cbValueType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_bAddAction_Click(object sender, EventArgs e)
        {
            //Save the Rule
            add_bSaveRule.PerformClick();

            //Select this rule
            add_cbRule.SelectedItem = _rule;

            //Show the page.
            add_tcInnerPages.SelectedTab = pActions;
        }

        private void add_cbRule_SelectedIndexChanged(object sender, EventArgs e)
        {
            var devController = new DeviceController();
            var commController = new CommunicatorController();

            _rule.Device = devController.RetrieveDevice(_rule.DeviceId);
            _device = _rule.Device;
            add_cbCommunicatorDestination.Items.AddRange(commController.GetAllCommunicators().Where(com=>com.Device.Id==_rule.DeviceId && com.Inbound==false).ToArray());

        }

        private void add_bSaveRule_Click(object sender, EventArgs e)
        {
            var contoller = new RuleController();

            _rule = new Models.Rule()
            {
                Device = _device,
                Action = _action,
                Alarm = add_cAlarm.Checked,
                Constraint = add_tConstraint.Text,
                Name = add_tRuleName.Text,
                DeviceId = _device.Id,
                RuleType = (Models.RuleType)add_cbRuleType.SelectedItem,
                ValueType = (Models.ValueType)add_cbRuleCheckValue.SelectedItem
            };

            contoller.CreateRule(_rule);
            contoller.UpdateRule(_rule);

            this.Close();
        }

        private void bSaveAction_Click(object sender, EventArgs e)
        {
            var ruleSelected = add_cbRule.SelectedItem != null;
            var destinationSelected = add_cbCommunicatorDestination.SelectedItem != null;
            var outputEntered = add_tOutputValue.Text != "";

            if (!(ruleSelected && destinationSelected && outputEntered))
            {
                DebugOutput.Print("Unable to save - not all data has been entered!");
                return;
            }

            _rule = (Models.Rule) add_cbRule.SelectedItem;
            _communicator = (Models.Communicator)add_cbCommunicatorDestination.SelectedItem;

            var newAction = new Models.Action()
            {
                Rule   = _rule,
                RuleId = _rule.Id,
                Communicator =_communicator,
                CommunicatorId = _communicator.Id,
                OutputValue = add_tOutputValue.Text,
                Enabled = add_cActionEnabled.Checked
            };

            var controller = new ActionController();
            var action = controller.CreateAction(newAction);

            if (action != null)
            {
                DebugOutput.Print("Successfully created a new Action.");
            }
        }
    }
}
