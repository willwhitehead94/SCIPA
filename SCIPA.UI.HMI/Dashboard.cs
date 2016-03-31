using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCIPA.Domain.Generic;
using SCIPA.Domain.Inbound;
using SCIPA.Domain.Logic;
using SCIPA.Models;
using Action = System.Action;

namespace SCIPA.UI.HMI
{
    public partial class Dashboard : Form
    {
        /// <summary>
        /// Number of Alarms that are currently Active within SCIPA.
        /// </summary>
        private int _activeAlarmCount = 0;

        /// <summary>
        /// The password required to access Admin settings from the dashboard.
        /// </summary>
        private string _settingsPassword = "letmein";

        /// <summary>
        /// The Device object currently selected.
        /// </summary>
        private Device _selectedDevice = null;

        /// <summary>
        /// Local object for temporarily storing Communicator data.
        /// Used as part of the Addition page.
        /// </summary>
        private Communicator _communicator = null;

        /// <summary>
        /// Local object for temporarily storing Rule data.
        /// Used as part of the Addition page.
        /// </summary>
        private Models.Rule _rule = null;

        
        /// <summary>
        /// Initialise the Dashboard window.
        /// </summary>
        public Dashboard()
        {
            InitializeComponent();

            //Remove design-time comments stored in the Text property.
            lStatusMessage.Text = "";
            lStatusPreceder.Text = "";
        }

        /// <summary>
        /// On the loading of the form, run the code to start
        /// the main SCIPA threads as per the required window.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SCIPAAlarmDataSet.Alarms' table. You can move, or remove it, as needed.
            this.AlarmsTableAdapter.Fill(this.SCIPAAlarmDataSet.Alarms);
            //Start the live dashboard update outside of the main thread.
            ThreadPool.QueueUserWorkItem(new WaitCallback(UpdateDashboard));
            this.report_rvReportViewer.RefreshReport();

            //Prepare any Data Sources required for the ComboBoxes.
            add_cbCommType.DataSource = Enum.GetValues(typeof(Models.CommunicatorType));
            add_cbValueType.DataSource = Enum.GetValues(typeof(Models.ValueType));
            add_cbDatabaseType.DataSource = Enum.GetValues(typeof (Models.DatabaseType));
            add_cbComPort.DataSource = SerialPort.GetPortNames();

        }

        /// <summary>
        /// Calls all the relevant Update methods within this class
        /// and updates the relevant panels.
        /// </summary>
        /// <param name="thread"></param>
        private void UpdateDashboard(object thread)
        {
            //Due to form controls being removed iteratively by the system 
            //on closing, the TRY/CATCH will automatically handle any
            //missed updates statements.

            try
            {
                //Update all required items.
                UpdateHeaderInformation();
                UpdateButtons();
                UpdateStatus();

                //Refresh required items.
                this.Invoke(new Action(pButtonPannel.Refresh));
                this.Invoke(new Action(pHeader.Refresh));
                this.Invoke(new Action(statusBar.Refresh));

                //Wait 1 second.
                System.Threading.Thread.Sleep(500);

                //Restart.
                UpdateDashboard(thread);
            }
            catch (Exception)
            {
                //Print issue to error log.
                DebugOutput.Print("Dashboard updating error.");
            }

        }

        /// <summary>
        /// Updates all elements of the Header Panel object.
        /// Each required update is passed to the forms invoke system
        /// in order to complete successfully away from the UI thread.
        /// </summary>
        private void UpdateHeaderInformation()
        {
            Action action = () => lHeaderAlarmCount.Text = $"{_activeAlarmCount} Active Alarms";
            this.Invoke(action);

            action = () => lTime.Text = $"{DateTime.Now.ToString("T")}";
            this.Invoke(action);

            action = () => lDate.Text = $"{DateTime.Now.ToString("D")}";
            this.Invoke(action);
        }

        /// <summary>
        /// Updates any buttons that may require visual updates.
        /// </summary>
        private void UpdateButtons()
        {
            Color standardColor = Color.Gainsboro;
            Color alertColorLight = Color.LightCoral;
            Color alertColorDark = Color.Firebrick;
            Color allOkayLight = Color.Aquamarine;
            Color allOkayDark = Color.Green;

            //Alarm Button (dependant on Active Alarm Count)
            if (_activeAlarmCount > 0)
                this.Invoke(bAlarms.BackColor == alertColorDark
                    ? new Action(() => bAlarms.BackColor = alertColorLight)
                    : new Action(() => bAlarms.BackColor = alertColorDark));
            else
                this.Invoke(new Action(() => bAlarms.BackColor = standardColor));

            //Process Running (dependent on Process State)
            if (_activeAlarmCount > 0)
                this.Invoke(bStartProcess.BackColor == allOkayDark
                    ? new Action(() => bStartProcess.BackColor = allOkayLight)
                    : new Action(() => bStartProcess.BackColor = allOkayDark));
            else
                this.Invoke(new Action(() => bStartProcess.BackColor = standardColor));
        }

        /// <summary>
        /// Updates the Status Bar (statusBar), primarily, the status message
        /// from the DebugOutput class.
        /// </summary>
        private void UpdateStatus()
        {
            this.Invoke(new Action(() => lStatusMessage.Text = DebugOutput.LastMessage));
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = System.Windows.Forms.MessageBox.Show(
                "Closing now will end all running SCIPA processes and may result in instability. Are you sure you want to close?",
                "Early Close Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            //If the user clicks NO to remain in SCIPA, cancel the close.
            if (result==DialogResult.No)
            { e.Cancel = true; }
        }

        private void lHeaderAlarmCount_Click(object sender, EventArgs e)
        {
            if (_activeAlarmCount == 0)
            {
                _activeAlarmCount = 1;
            }
            else
            {
                _activeAlarmCount = 0;
            }
        }

        private void bStartProcess_Click(object sender, EventArgs e)
        {
            //Print output statement as to the event.
            DebugOutput.Print("Dashboard: Start Device Process");

            //Populate appropriate objects/fields.
            var controller = new DeviceController();
            start_lbDevice.Items.Clear();
            foreach (var dev in controller.GetAllDevices())
            { start_lbDevice.Items.Add(dev);}

            //Bring page to user's view.
            pTabPanel.SelectedTab = pStart;
        }

        private void bStopProcess_Click(object sender, EventArgs e)
        {
            //Print output statement as to the event.
            DebugOutput.Print("Dashboard: Stop Device Process");

            //Populate appropriate objects/fields.
            stop_lbDevice.Items.Clear();
            foreach (var dev in DeviceController.GetActiveDevices())
            { stop_lbDevice.Items.Add(dev); }

            //Bring page to user's view.
            pTabPanel.SelectedTab = pStop;
        }

        private void bAddNew_Click(object sender, EventArgs e)
        {
            DebugOutput.Print("Dashboard: Add New Device");

            var _controller = new DeviceController();
            add_tId.Text = (_controller.CurrentMaxId() + 1).ToString();
            pTabPanel.SelectedTab = pAddNewDevice;
        }

        private void bModify_Click(object sender, EventArgs e)
        {
            //Print output statement as to the event.
            DebugOutput.Print("Dashboard: Modify Device");

            //Populate appropriate objects/fields.
            modify_lbDeviceList.Items.Clear();
            var controller = new DeviceController();
            foreach (var dev in controller.GetAllDevices())
            { modify_lbDeviceList.Items.Add(dev); }

            //Bring page to user's view.
            pTabPanel.SelectedTab = pModifyDevice;
        }

        private void bReports_Click(object sender, EventArgs e)
        {
            DebugOutput.Print("Dashboard: Reports");
            pTabPanel.SelectedTab = pReports;
        }

        private void bAlarms_Click(object sender, EventArgs e)
        {
            DebugOutput.Print("Dashboard: Alarms");
            pTabPanel.SelectedTab = pAlarms;

            alarm_lbAlarms.Items.Clear();
            
            var controller=  new AlarmController();
           // alarm_lbAlarms.Items.Add(controller.)
        }

        private void bSettings_Click(object sender, EventArgs e)
        {
            DebugOutput.Print("Dashboard: Settings");
            pTabPanel.SelectedTab = pSettings;
        }

        /// <summary>
        /// Toggles the docking state of the mainPanel.
        /// Also triggers the "full screen" message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bTogglePanelSize_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            if (pTabPanel.Dock == DockStyle.None)
            {
                pTabPanel.Dock = DockStyle.Fill;
                lStatusPreceder.Text = $"(Full Screen Mode)";
                btn.Text = "Minimise";
            }

            else
            {
                pTabPanel.Dock = DockStyle.None;
                lStatusPreceder.Text = $"";
                btn.Text = "Fullscreen";
            }

        }

        /// <summary>
        /// Allows direct access to the SCIPA Service (i.e. the log UI).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lStaticMessage_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(
                "When the console opens, type 'SCIPA.UI.Service' to run the Service application");
            var consoleApp = new SCIPA.UI.Service.Program();
            System.Diagnostics.Process.Start(@"cmd.exe", @consoleApp.exePath);
        }

        private void tSettingsPassword_TextChanged(object sender, EventArgs e)
        {
            if (tSettingsPassword.Text == _settingsPassword)
            {
                DebugOutput.Print("Showing Admin Panel!");
                tSettingsPassword.Text = "";
                System.Windows.Forms.MessageBox.Show("Settings panel would open at this point...");
            }
        }

#region Start Page

        private void start_lbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDevice = (Device) start_lbDevice.SelectedItem;
            start_tId.Text = selectedDevice.Id.ToString();
            start_tDevName.Text = selectedDevice.Name;
            start_tLocation.Text = selectedDevice.Location;
            start_tCustodian.Text = selectedDevice.Custodian;
            start_bStart.Enabled = selectedDevice.Enabled;

            //Disallow starting if already started.
            if (Inbound.GetStartedDevices().Where(dev => dev.Id == selectedDevice.Id).Any())
                start_bStart.Enabled = false;

            //Allow global access
            _selectedDevice = selectedDevice;
        }

        private void start_bStart_Click(object sender, EventArgs e)
        {
            var controller = new CommunicatorController();
            var commList = controller.GetAllCommunicators().Where(comm => comm.Device.Id == _selectedDevice.Id);

            foreach(var comm in commList)
                new Inbound(comm);

            //Once started, stops allowing a second start.
            start_bStart.Enabled = false;

        }

        #endregion Start Page

#region Stop Page
        private void stop_lbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedDevice = (Device)start_lbDevice.SelectedItem;
            stop_tId.Text = selectedDevice.Id.ToString();
            stop_tDevName.Text = selectedDevice.Name;
            stop_tLocation.Text = selectedDevice.Location;
            stop_tCustodian.Text = selectedDevice.Custodian;
            stop_bStop.Enabled = selectedDevice.Enabled;

            //Allow global access
            _selectedDevice = selectedDevice;
        }
        #endregion Stop Page

#region Add New Device Page

        private void pSources_Click(object sender, EventArgs e)
        {

        }

        private void add_bAddSource_Click(object sender, EventArgs e)
        {
            //Save the new Device.
            add_bSaveNewDevice.PerformClick();

            //Show Add Source
            add_tcInnerPages.SelectedTab = pDataConnection;
        }

        private void add_cbCommType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var specalism = (CommunicatorType)add_cbCommType.SelectedItem;
            switch (specalism)
            {
                case CommunicatorType.FlatFile:
                    _communicator=new FileCommunicator();
                    add_tcInnerPagesSourceSetting.SelectedTab = pFlatFile;
                    break;
                case CommunicatorType.Serial:
                    _communicator=new SerialCommunicator();
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

        private void add_bRefreshComPorts_Click(object sender, EventArgs e)
        {
            add_cbComPort.DataSource = SerialPort.GetPortNames();
            add_cbComPort.Refresh();
        }

        private void add_bSaveSource_Click(object sender, EventArgs e)
        {
            if (_communicator is DatabaseCommunicator)
            {
                _communicator = new DatabaseCommunicator()
                {
                    DbType = (DatabaseType)add_cbDatabaseType.SelectedItem,
                    ValueType = (Models.ValueType)add_cbValueType.SelectedItem,
                    ConnectionString = add_tConnectionString.Text,
                    Query = add_tQuery.Text,
                    StartChar = GetStartChar(),
                    EndChar = GetEndChar(),
                    Device = _selectedDevice,
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
                    ValueType = (Models.ValueType)add_cbValueType.SelectedItem,
                    BaudRate = Convert.ToInt32(add_tBaudRate.Text),
                    ComPort = add_cbComPort.SelectedItem.ToString(),
                    DataBits = Convert.ToByte(add_tDataBits.Text),
                    IsDTR = add_cbDtr.Checked,
                    IsRTS = add_cbRts.Checked,
                    Device = _selectedDevice,
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
                    ValueType = (Models.ValueType)add_cbValueType.SelectedItem,
                    StartChar = GetStartChar(),
                    EndChar = GetEndChar(),
                    Device = _selectedDevice,
                    Type = CommunicatorType.FlatFile,
                    Inbound = true,
                    Action = null
                    //Id = GetNextIdNumber()
                };
            }

            var _controller = new CommunicatorController();
            var Id = _controller.SaveCommunicator(_communicator);
            if (Id != null) _communicator.Id = (int)Id;
            DebugOutput.Print($"a new Communicator was created with ID {_communicator.Id.ToString()}");

            UpdateStartLabels();

        }

        private void UpdateStartLabels()
        {
            var _controller = new CommunicatorController();

            //Update labels.
            add_lSource.Text = $"{_controller.CountCommunicatorsForDevice(_communicator.Device.Id)} Sources...";
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

        private void add_bSaveNewDevice_Click(object sender, EventArgs e)
        {
            var _controller = new DeviceController();

            bool enabled = add_rbTrue.Checked && !add_rbFalse.Checked;
            _selectedDevice = _controller.GetDeviceObject(Convert.ToInt32(add_tId.Text), add_tName.Text, add_tLocation.Text, add_tCustodian.Text, enabled);
            if (_controller.SaveDevice(_selectedDevice) == null)
            {
                MessageBox.Show("There was an error saving the Device...");
            }
        }

        private void add_cbValueType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void add_bAddRule_Click(object sender, EventArgs e)
        {
            //Save the new Device.
            add_bSaveNewDevice.PerformClick();

            //Show Add Rule
            add_tcInnerPages.SelectedTab = pRules;
        }


        #endregion Add New Device Page

        private void alarm_cbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

#region Modify Device Page

        private void modify_lbDeviceList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedDevice = (Device) modify_lbDeviceList.SelectedItem;
                _selectedDevice = selectedDevice;
                modify_tId.Text = selectedDevice.Id.ToString();
                modify_tDevName.Text = selectedDevice.Name;
                modify_tCustodian.Text = selectedDevice.Custodian;
                modify_tLocation.Text = selectedDevice.Location;
                var enabled = (selectedDevice.Enabled) ? modify_rbTrue.Checked = true : modify_rbFalse.Checked = true;
                DebugOutput.Print("Now reviewing device: ", selectedDevice.Name);
            }
            catch (Exception exception)
            {
                DebugOutput.Print("Error reviewing the selected device. ", exception.Message);
            }
        }

        #endregion Modify Device Page

        private void modify_bSave_Click(object sender, EventArgs e)
        {
            //Update the global object with any updates values.
            _selectedDevice.Name = modify_tDevName.Text;
            _selectedDevice.Custodian = modify_tCustodian.Text;
            _selectedDevice.Location = modify_tLocation.Text;
            _selectedDevice.Enabled = modify_rbTrue.Checked;

            //Create new Device Controller.
            var controller = new DeviceController();

            //Save the Device.
           var savedDevice = controller.SaveDevice(_selectedDevice);

            //If the updated device is null or has been corupted (i.e. wrong device info), error!
            if (savedDevice == null || savedDevice.Id != _selectedDevice.Id)
            {
                MessageBox.Show("There was an error saving the Device...", _selectedDevice.ToString());
            }
            else
            {
                //Updated the global variable with a database replica.
                //(Should not change the object properties).
                _selectedDevice = savedDevice;

                //Inform the user
                DebugOutput.Print("Device was updated successfully. ",_selectedDevice.ToString());
            }
        }
    }
}
