using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Microsoft.SqlServer.Dts.Runtime;
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
        /// Local object for temporarily storing Action data.
        /// Used as part of the Addition page.
        /// </summary>
        private Models.Action _action = null;

        /// <summary>
        /// Local object for temporarily storing Value data. Used as part of the Value Investigator.
        /// </summary>
        private Models.Value _value = null;

        #region Dashboard Generic Methods
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
            //Start the live dashboard update outside of the main thread.
            ThreadPool.QueueUserWorkItem(new WaitCallback(UpdateDashboard));
            ThreadPool.QueueUserWorkItem(new WaitCallback(UpdateActiveAlarms));
            this.report_rvReportViewer.RefreshReport();

            //Prepare any Data Sources required for the ComboBoxes.
            modcomms_cbCommType.DataSource = Enum.GetValues(typeof(Models.CommunicatorType));
            modcomms_cbValueType.DataSource = Enum.GetValues(typeof(Models.ValueType));
            modcomms_cbDatabaseType.DataSource = Enum.GetValues(typeof(Models.DatabaseType));
            modrules_cbValueType.DataSource = Enum.GetValues(typeof(Models.ValueType));

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
        /// Method to update the header label with a count of active alarms from
        /// within the last 24 hours.
        /// </summary>
        private void UpdateActiveAlarms(object threadable)
        {
            var controller = new AlarmController();
            while (true)
            {
                /*
                * Updates to the Alarm Count are handled within TRY/CATCH because there is potential
                * for external changes that may cut/slow the data flow/connection.
                */

                try
                {
                    //Only counts alarms that have been active for longer than 24 hours.
                    var liveCount = controller.GetAllAlarms(24).Count(a => !a.Accepted);

                    //_activeAlarmCount = controller.GetAllAlarms(24).Count(a => !a.Accepted);
                    _activeAlarmCount = controller.GetActiveAlarmCount();

                    //Sleep for X seconds
                    System.Threading.Thread.Sleep(1000);

                }
                catch (Exception e)
                {
                    DebugOutput.Print("Alarm Updating Error - ", e.Message);
                }
            }
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
            if (DeviceController.GetActiveDevices().Count == 0)
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
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void lHeaderAlarmCount_Click(object sender, EventArgs e)
        {
            //This method was used during development to test the colour changing
            //loops, as well as auto updating of Alarm Count values.

            //Removed for release.

            //if (_activeAlarmCount == 0)
            //{
            //    _activeAlarmCount = 1;
            //}
            //else
            //{
            //    _activeAlarmCount = 0;
            //}
        }
        #endregion Dashboard Generic Methods

        #region Dashboard Navigation Button Handlers
        private void bStartProcess_Click(object sender, EventArgs e)
        {
            //Print output statement as to the event.
            DebugOutput.Print("Dashboard: Start Device Process");

            //Populate appropriate objects/fields.
            var controller = new DeviceController();
            start_lbDevice.Items.Clear();
            foreach (var dev in controller.GetAllDevices())
            {
                start_lbDevice.Items.Add(dev);
            }

            //Bring page to user's view.
            pTabPanel.SelectedTab = pStart;
        }

        private void bStopProcess_Click(object sender, EventArgs e)
        {
            //Print output statement as to the event.
            DebugOutput.Print("Dashboard: Stop Device Process");

            //Populate appropriate objects/fields.
            stop_lbDevice.Items.Clear();
            var controller = new DeviceController();
            foreach (var dev in controller.GetAllDevices())
            {
                stop_lbDevice.Items.Add(dev);
            }

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
            {
                modify_lbDeviceList.Items.Add(dev);
            }

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

            //Clear the ListBox
            alarm_lbAlarms.Items.Clear();

            //Load the correct element from the list, 72 hours.
            alarm_cbPeriod.SelectedItem = alarm_cbPeriod.Items[5];

            //Show the page.
            pTabPanel.SelectedTab = pAlarms;
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
        #endregion Dashboard Navigation Button Handlers

        #region Settings Page
        private void tSettingsPassword_TextChanged(object sender, EventArgs e)
        {
            if (tSettingsPassword.Text == _settingsPassword)
            {
                DebugOutput.Print("Showing Admin Panel!");
                tSettingsPassword.Text = "";
                var admin = new AdminPanel();
                admin.ShowDialog();
                DebugOutput.Print("Panel Closed.");
            }
        }
        #endregion Settings Page

        #region Start Page

        private void start_lbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                DebugOutput.Print("Could not load data for selected object. ",ex.Message);
            }
        }

        private void start_bStart_Click(object sender, EventArgs e)
        {
            try
            {
                var controller = new CommunicatorController();
                var commList = controller.GetAllCommunicators().Where(comm => comm.Device.Id == _selectedDevice.Id);

                foreach (var comm in commList)
                    new Inbound(comm);

                //Once started, stops allowing a second start.
                start_bStart.Enabled = false;
            }
            catch
            {
                DebugOutput.Print("Unable to start the selected device!");
            }

        }

        #endregion Start Page

        #region Stop Page

        private void stop_lbDevice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectedDevice = (Device) stop_lbDevice.SelectedItem;
                //stop_tId.Text = selectedDevice.Id.ToString(); //Removed.
                stop_tDevName.Text = selectedDevice.Name;
                stop_tLocation.Text = selectedDevice.Location;
                stop_tCustodian.Text = selectedDevice.Custodian;

                //Load the values from MongoDb
                var max = 10000; //Max number of records to display
                var controller = new ValueController();
                stop_lbValues.Items.Clear();

                //Only add upto the first 'max' values.
                var allValues = controller.GetValuesForDevice(selectedDevice);

                if (allValues != null && allValues.Any())
                {
                    var vals = allValues.Take(max).ToArray();

                    var distinct = new List<string>();
                    foreach (var val in vals.Where(val => !distinct.Contains(val.ToString())))
                    {
                        distinct.Add(val.ToString());
                    }


                    stop_lbValues.Items.AddRange(distinct.ToArray());
                }

                //Allow global access
                _selectedDevice = selectedDevice;
            }
            catch (Exception ex)
            {
                DebugOutput.Print("Could not load data for selected object. ", ex.Message);
            }
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

            //Create and display the DataBoard form.
            var window = new DataBoard(_communicator, _selectedDevice);
            window.GoToCommunicatorPage();
            window.ShowDialog();

            //Get the Comm object created.
            _communicator = window.GetCommunicator();

            //Update the labels.
            UpdateStartLabels();
        }

        private void UpdateStartLabels()
        {
            var comm_controller = new CommunicatorController();
            var rule_controller = new RuleController();
            var acti_controller = new ActionController();
            
            try
            {
                //Update labels.
                add_lSource.Text = $"{comm_controller.CountCommunicatorsForDevice(_communicator.Device.Id)} Sources...";
                add_lRules.Text = $"{rule_controller.RetrieveRulesForDevice(_selectedDevice.Id).Count()} Rules...";
            }
            catch
            {
                //Update labels.
                add_lSource.Text = $"0 Sources...";
                add_lRules.Text = $"0 Rules...";
            }
        }

        private void add_bSaveNewDevice_Click(object sender, EventArgs e)
        {
            var _controller = new DeviceController();

            bool enabled = add_rbTrue.Checked && !add_rbFalse.Checked;
            _selectedDevice = _controller.GetDeviceObject(Convert.ToInt32(add_tId.Text), add_tName.Text,
                add_tLocation.Text, add_tCustodian.Text, enabled);

            var newDevice = _controller.SaveDevice(_selectedDevice);
            _selectedDevice = newDevice;

            if (newDevice== null)
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

            //Create and display the DataBoard form.
            var window = new DataBoard(_communicator, _selectedDevice);
            window.GoToRulePage();
            window.ShowDialog();

            //Get the Comm object created.
            _rule = window.GetRule();

            //Update the labels.
            UpdateStartLabels();
        }

        private void add_bAddAction_Click(object sender, EventArgs e)
        {

        }

        private void add_bSaveRule_Click(object sender, EventArgs e)
        {

        }

        private void add_bNewAction_Click(object sender, EventArgs e)
        {
            //Save the new Device.
            add_bSaveNewDevice.PerformClick();

            //Create and display the DataBoard form.
            var window = new DataBoard(_communicator, _selectedDevice);
            window.GoToActionPage();
            window.ShowDialog();

            //Get the Comm object created.
            _action = window.GetAction();

            //Update the labels.
            UpdateStartLabels();
        }


        #endregion Add New Device Page

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



        private void modify_bSave_Click(object sender, EventArgs e)
        {
            try
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
                    DebugOutput.Print("Device was updated successfully. ", _selectedDevice.ToString());
                }
            }
            catch (Exception ex)
            {
                DebugOutput.Print("Could not save data for selected object. ", ex.Message);
            }
        }

        private void modify_bComms_Click(object sender, EventArgs e)
        {
            try
            {
                //Loads the relevant communicators.
                var controller = new CommunicatorController();
                modcomms_lbComms.Items.Clear();
                modcomms_lbComms.Items.AddRange(
                    controller.GetAllCommunicators().Where(c => c.Device.Id == _selectedDevice.Id).ToArray());

                if (modcomms_lbComms.Items.Count > 0)
                {
                    //Select the first element
                    modcomms_lbComms.SelectedItem = modcomms_lbComms.Items[0];

                    //Shows the modify tab.
                    pTabPanel.SelectedTab = pModifyCommunicators;
                }
                else
                {
                    var msg =
                        System.Windows.Forms.MessageBox.Show(
                            "There are no Communicators for this Device.", "No Communicators Available",
                            MessageBoxButtons.OK, MessageBoxIcon.Hand);

                    // -------- Create new communicator ----------

                    //Create and display the DataBoard form.
                    var window = new DataBoard(null, _selectedDevice);
                    window.GoToCommunicatorPage();
                    window.ShowDialog();

                    //Get the Comm object created.
                    _communicator = window.GetCommunicator();
                }
            }
            catch (Exception ex)
            {
                DebugOutput.Print("Could not load/store/update information for selected Device", ex.Message);
            }
        }

        #endregion Modify Device Page

        #region Modify Communicator Information PAge

        private void modcomms_cbCommType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (CommunicatorType) modcomms_cbCommType.SelectedItem;
            switch (selected)
            {
                case CommunicatorType.FlatFile:
                    modcomms_tpCommType.SelectedTab = pModFile;
                    break;
                case CommunicatorType.Serial:
                    modcomms_tpCommType.SelectedTab = pModSerial;
                    break;
                case CommunicatorType.Database:
                    modcomms_tpCommType.SelectedTab = pModDatabase;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void modcomms_bBack_Click(object sender, EventArgs e)
        {
            pTabPanel.SelectedTab = pModifyDevice;
        }

        private void modcomms_lbComms_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (Communicator)modcomms_lbComms.SelectedItem;

            modcomms_tStart.Text = selected.StartChar.ToString();
            modcomms_tEnd.Text = selected.EndChar.ToString();
            modcomms_tLastReadTime.Text = selected.LastReadTime.ToString();
            modcomms_cbValueType.SelectedItem = (Models.ValueType)selected.ValueType;
            modcomms_cbCommType.SelectedItem = selected.Type;
            modcomms_rbInbound.Checked = selected.Inbound;
            modcomms_rbOutbound.Checked = !selected.Inbound;

            switch (selected.Type)
            {
                case CommunicatorType.FlatFile:
                    var fTemp = (FileCommunicator)selected;
                    modcomms_tFilePath.Text = fTemp.FilePath;
                    break;
                case CommunicatorType.Serial:
                    var sTemp = (SerialCommunicator)selected;
                    modcomms_cbComPort.SelectedText = sTemp.ComPort;
                    modcomms_tBaudRate.Text = sTemp.BaudRate.ToString();
                    modcomms_tDataBits.Text = sTemp.DataBits.ToString();
                    modcomms_cbDtr.Checked = sTemp.IsDTR;
                    modcomms_cbRts.Checked = sTemp.IsRTS;
                    break;
                case CommunicatorType.Database:
                    var dTemp = (DatabaseCommunicator)selected;
                    modcomms_tConnectionString.Text = dTemp.ConnectionString;
                    modcomms_tQuery.Text = dTemp.Query;
                    modcomms_cbDatabaseType.SelectedItem = dTemp.DbType;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void modcomms_bSaveComm_Click(object sender, EventArgs e)
        {
            //Collect the selected item and store globally
            _communicator = (Communicator)modcomms_lbComms.SelectedItem;

            /*
           * Preparing all of the standard (abstract) Communicator fields
           */
            //Id does not update
            _communicator.StartChar = Convert.ToInt32(modcomms_tStart.Text);
            _communicator.EndChar = Convert.ToInt32(modcomms_tEnd.Text);
            _communicator.LastReadTime = Convert.ToDateTime(modcomms_tLastReadTime.Text);
            //CommType does not update
            _communicator.ValueType = (Models.ValueType)modcomms_cbValueType.SelectedItem;
            _communicator.Inbound = modcomms_rbInbound.Checked;

            /*
            * Preparing FileCommunicator fields
            */
            if (_communicator is FileCommunicator)
            {
                var temp = (FileCommunicator)_communicator;
                temp.FilePath = modcomms_tFilePath.Text;

                //Store this in the global variable.
                _communicator = temp;
            }

            else if (_communicator is SerialCommunicator)
            {
                var temp = (SerialCommunicator)_communicator;
                temp.ComPort = modcomms_cbComPort.SelectedItem.ToString();
                temp.BaudRate = Convert.ToInt32(modcomms_tBaudRate.Text);
                temp.DataBits = Convert.ToByte(modcomms_tDataBits.Text);
                temp.IsDTR = modcomms_cbDtr.Checked;
                temp.IsRTS = modcomms_cbRts.Checked;

                //Store this in the global variable.
                _communicator = temp;
            }

            else if (_communicator is DatabaseCommunicator)
            {
                var temp = (DatabaseCommunicator)_communicator;
                temp.ConnectionString = modcomms_tConnectionString.Text;
                temp.Query = modcomms_tQuery.Text;
                temp.DbType = (Models.DatabaseType)modcomms_cbDatabaseType.SelectedItem;

                //Store this in the global variable.
                _communicator = temp;
            }

            //Save the Communicator
            var controller = new CommunicatorController();
            controller.SaveCommunicator(_communicator);

            //Inform user.
            DebugOutput.Print("Successfully updated Communicator settings for ", _communicator.ToString());
        }

        private void modcomms_bResetDate_Click(object sender, EventArgs e)
        {
            var dt = new DateTime(1980, 01, 01);
            modcomms_tLastReadTime.Text = dt.ToString();
        }

        #endregion Modify Communicator Information Page.

        #region Alarm Page
        private void alarm_cbPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hours = Convert.ToInt32(alarm_cbPeriod.SelectedItem);

            var controller = new AlarmController();
            var alarmList = controller.GetAllAlarms(hours);

            alarm_lbAlarms.Items.Clear();

            if (alarmList != null && alarmList.Any())
            {
                alarm_lbAlarms.Items.AddRange(alarmList.OrderByDescending(a => a.TimeStamp).ToArray());
            }
        }
        #endregion Alarm Page

        #region Modify Rules Page

        private void modify_bRules_Click(object sender, EventArgs e)
        {
            //Loads the relevant communicators.
            var controller = new RuleController();
            modrules_lbRules.Items.Clear();
            modrules_lbRules.Items.AddRange(
                controller.RetrieveRulesForDevice(_selectedDevice.Id).ToArray());

            if (modrules_lbRules.Items.Count > 0)
            {
                //Select the first element
                modrules_lbRules.SelectedItem = modrules_lbRules.Items[0];



                //Shows the modify tab.
                pTabPanel.SelectedTab = pModifyRules;
            }
            else
            {
                var msg =
                    System.Windows.Forms.MessageBox.Show(
                        "There are no Rules for this Device.", "No Rules Available",
                        MessageBoxButtons.OK, MessageBoxIcon.Hand);

                // -------- Create new rule ----------

                //Create and display the DataBoard form.
                var window = new DataBoard(null, _selectedDevice);
                window.GoToRulePage();
                window.ShowDialog();

                //Get the Comm object created.
                _rule = window.GetRule();
            }
        }

        private void modrules_lbRules_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (Models.Rule)modrules_lbRules.SelectedItem;

            //Set global accessible value for the Rule object.
            _rule = selected;

            //Fill in required data.
            modrules_Name.Text = selected.Name;
            modrules_tConstraint.Text = selected.Constraint;
            modrules_cAlarm.Checked = selected.Alarm;
            modrules_cbValueType.SelectedItem = selected.ValueType;
            modrules_cbRuleType.SelectedItem = selected.RuleType;
        }

        private void modrules_cbValueType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set the Rule Types available dependant on the selected ValueType.
            var selected = (Models.ValueType)(modrules_cbValueType.SelectedItem);

            //Clear the current list.
            modrules_cbRuleType.DataSource = null;
            modrules_cbRuleType.Items.Clear();

            //Integer and Float have all options (so Integer falls through).
            switch (selected)
            {
                case Models.ValueType.Integer:
                case Models.ValueType.Float:
                    modrules_cbRuleType.DataSource = Enum.GetValues(typeof(Models.RuleType));
                    break;
                case Models.ValueType.String:
                    modrules_cbRuleType.Items.Add(Models.RuleType.EqualTo);
                    modrules_cbRuleType.Items.Add(Models.RuleType.Not);
                    break;
                case Models.ValueType.Boolean:
                    modrules_cbRuleType.Items.Add(Models.RuleType.EqualTo);
                    break;
                default:
                    DebugOutput.Print("Unable to process the Rule selection type. Reverting to default.");
                    modrules_cbRuleType.Items.Add(Models.RuleType.EqualTo);
                    break;
            }

            //Refresh the ComboBox.
            modrules_cbRuleType.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pTabPanel.SelectedTab = pModifyDevice;
        }

        private void modrules_tBack_Click(object sender, EventArgs e)
        {
            pTabPanel.SelectedTab = pModifyDevice;
        }

        private void modrules_tSave_Click(object sender, EventArgs e)
        {
            _rule.Alarm = modrules_cAlarm.Checked;
            _rule.Name = modrules_Name.Text;
            _rule.Constraint = modrules_tConstraint.Text;
            _rule.RuleType = (Models.RuleType) modrules_cbRuleType.SelectedItem;
            _rule.ValueType = (Models.ValueType) modrules_cbValueType.SelectedItem;
           
            var controller = new RuleController();
            var updated = controller.UpdateRule(_rule);

            if (updated != null)
            {
                _rule = updated;
                DebugOutput.Print($"Rule '{updated}' was updated.");
                return;
            }

            DebugOutput.Print($"Could not updated {updated}!");
        }

        private void modrules_bSetAction_Click(object sender, EventArgs e)
        {
            //Save the Rule as it stands.
            modrules_tSave.PerformClick();

            var controller = new ActionController();
            if (controller.RetrieveActionsForRule(_rule.Id).Any())
            {
                //Get the actual Action.
                var action = controller.RetrieveActionsForRule(_rule.Id).FirstOrDefault();
                _action = action;

                //Load the values required.
                modact_cEnabled.Checked = action.Enabled;
                modact_tValue.Text = action.OutputValue;
                modact_tRule.Text = _rule.ToString();

                //Download the required communicator
                var commController = new CommunicatorController();
                var comm = commController.GetAllCommunicators().FirstOrDefault(c => c.Id == action.CommunicatorId);

                if (comm != null)
                {
                    _communicator = comm;
                    _action.Communicator = comm;
                    modact_tComm.Text = comm.ToString();
                }
                else
                {
                    modact_tComm.Text = "";
                }

                //Actions exist.
                pTabPanel.SelectedTab = pModifyActions;
            }
            else
            {
                var db = new DataBoard(_communicator,_selectedDevice);
                db.GoToActionPage(_rule);
                db.ShowDialog();

                _action = db.GetAction();
                DebugOutput.Print("Changes made in the Data Manager are saved.");
            }

        }

        private void modact_bBack_Click(object sender, EventArgs e)
        {
            pTabPanel.SelectedTab = pModifyDevice;
        }

        private void modact_bSave_Click(object sender, EventArgs e)
        {
            _action.Rule = _rule;
            _action.RuleId = _rule.Id;
            _action.Communicator = _communicator;
            _action.CommunicatorId = _communicator.Id;
            _action.OutputValue = modact_tValue.Text;
            _action.Enabled = modact_cEnabled.Checked;

            var controller = new ActionController();
            var updated = controller.UpdateAction(_action);

            if (updated == null)
            {
                DebugOutput.Print("Update of the Action failed!");
            }
            else
            {
                _action = updated;
                DebugOutput.Print("Action was updated successfully.");
            }
        }

        private void modify_bActions_Click(object sender, EventArgs e)
        {

        }

        private void alarm_lbAlarms_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Resetting the form.
            alarm_bRule.Enabled = false;
            alarm_bDevice.Enabled = false;
            alarm_tDateTime.Text = "";
            alarm_rbTrue.Checked = false;
            alarm_rbFalse.Checked = false;
            alarm_tValue.Text = "";
            alarm_tDevice.Text = "";

            try
            {
                var selected = (Alarm) alarm_lbAlarms.SelectedItem;

                alarm_tDateTime.Text = selected.TimeStamp.ToString();
                alarm_rbTrue.Checked = selected.Accepted;
                alarm_rbFalse.Checked = !selected.Accepted;

                //Get Value information.
                if (selected.ValueId > 0)
                {
                    var controller = new ValueController();
                    _value = controller.GetValueById(selected.ValueId);
                    selected.Value = _value;
                    alarm_tValue.Text = selected.Value.StringValue;
                }

                //Get Rule information.
                if (selected.RuleId > 0)
                {
                    var controller = new RuleController();
                    _rule = controller.RetrieveRuleById(selected.RuleId);
                    alarm_bRule.Enabled = true;
                }

                //Get Device information.
                if (selected.DeviceId > 0)
                {
                    var controller = new DeviceController();
                    _selectedDevice = controller.RetrieveDevice(selected.DeviceId);
                    selected.Device = _selectedDevice;
                    alarm_tDevice.Text = _selectedDevice.ToString();
                    alarm_bDevice.Enabled = true;
                }
            }
            catch
            {
                DebugOutput.Print("Attempted to load an alarm and failed...");
            }
        }

        private void alarm_Acknowledge_Click(object sender, EventArgs e)
        {
            //Submit an acknowledgment request to the controller.
            var controller = new AlarmController();
            controller.Acknowledge((Alarm)alarm_lbAlarms.SelectedItem);

            //Update the alarm object in the list.
            alarm_lbAlarms.SelectedItem = controller.LastAlarm;
        }

        private void alarm_bDevice_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(_selectedDevice.ToString(), "SCIPA");
        }

        private void alarm_bRule_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show(_rule.ToString(), "SCIPA");
        }

        private void report_lbReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Report server URL is the current machine (localhost)
            report_rvReportViewer.ServerReport.ReportServerUrl = new System.Uri("http://localhost/reportserver");

            //All reports are deployed as part of SCIPA, and as such, reports follow
            //the namespacing conventions.
            var reportPath = "/SCIPA.Domain.BI.Reporting/";

            switch (report_lbReports.SelectedIndex)
            {
                case 0:
                    reportPath = $"{reportPath}DeviceValuesOverview";
                    break;
                case 1:
                    reportPath = $"{reportPath}DeviceValuesReport";
                    break;
                case 2:
                    reportPath = $"{reportPath}ValuesOverTime";
                    break;
                case 3:
                    reportPath = $"{reportPath}AlarmOverview";
                    break;
                case 4:
                    //Case 4 is the Excel Export SSIS package.

                    //Ensure the file is there
                    if (!System.IO.File.Exists(@"C:\Users\Will Whitehead\Desktop\Output.xls"))
                    {
                        //File doesnt exist - the blank template must exist.
                        System.Windows.Forms.MessageBox.Show("You do not have the blank template available. Aborting...");
                        return;
                    }

                    //Location of the SSIS Package.
                    string packageLocation = @"C:\Users\Will Whitehead\Dropbox\University\Year 4\Computing Project\"
                                                   +@"SCIPA\SCIPA.Domain.BI.Integration\ExportDeviceValuesToExcel.dtsx";
                    var app = new Microsoft.SqlServer.Dts.Runtime.Application();
                    var package = app.LoadPackage(packageLocation, null);
                    var packageResult = package.Execute();

                    //Inform users of success/fail of package.
                    if (packageResult == DTSExecResult.Failure)
                    {
                        DebugOutput.Print("Failed to Export data to Excel");
                        System.Windows.Forms.MessageBox.Show("The export process failed. Aborted.");
                        return;
                    }
                    else
                    {
                        DebugOutput.Print("Successfully exported data to Excel");
                        System.Windows.Forms.MessageBox.Show("The file on your desktop successfully updated.");
                        return;
                    }

                    //Return to ensure that the report viewer doesn't refresh blankly.
                case 5:
                    //Case 5 is the Values over 72 hours old being staged, backed up and removed via an SSIS package.

                    var msg = System.Windows.Forms.MessageBox.Show("This service will remove all values older than 72 hours from the SCIPA database. Values will first be backed up to an XLS document on your dekstop before being removed. Are you sure you want to continue?","Delete Old Data",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation);
                    if (msg == DialogResult.No)
                    {
                        DebugOutput.Print("Cancelled old data deletion.");
                        return;
                    }

                    DebugOutput.Print("Attempting to remove all old Values from the database...");

                    //Ensure the file is there
                    if (!System.IO.File.Exists(@"C:\Users\Will Whitehead\Desktop\Output Values.xls"))
                    {
                        //File doesnt exist - the blank template must exist.
                        System.Windows.Forms.MessageBox.Show("You do not have the blank template available. Aborting...");
                        return;
                    }

                    //Location of the SSIS Package.
                    packageLocation = @"C:\Users\Will Whitehead\Dropbox\University\Year 4\Computing Project\"
                                                   + @"SCIPA\SCIPA.Domain.BI.Integration\ValueProcessor.dtsx";
                    app = new Microsoft.SqlServer.Dts.Runtime.Application();
                    package = app.LoadPackage(packageLocation, null);
                    packageResult = package.Execute();

                    //Inform users of success/fail of package.
                    if (package.ExecutionStatus!=DTSExecStatus.Completed && packageResult == DTSExecResult.Failure)
                    {
                        DebugOutput.Print("Failed to Export data to Excel. Did not delete.");
                        System.Windows.Forms.MessageBox.Show("The export process failed. Aborted.");
                        return;
                    }
                    else
                    {
                        DebugOutput.Print("Successfully exported data to Excel, data was deleted.");
                        System.Windows.Forms.MessageBox.Show("The file on your desktop successfully updated.");
                        return;
                    }

                    //Return to ensure that the report viewer doesn't refresh blankly.
            }

            //Set the desired report.
            report_rvReportViewer.ServerReport.ReportPath = reportPath;


            //Load the desired report.
            report_rvReportViewer.RefreshReport();
           // report_rvReportViewer.Refresh();
            


        }

        private void modcomms_bAddNewComm_Click(object sender, EventArgs e)
        {
            //Create and display the DataBoard form.
            var window = new DataBoard(_communicator, _selectedDevice);
            window.GoToCommunicatorPage();
            window.ShowDialog();

            //Get the Comm object created.
            _communicator = window.GetCommunicator();

            //Return to Device list
            modcomms_bBack.PerformClick();
        }

        private void modrules_bAddNewRule_Click(object sender, EventArgs e)
        {
            //Create and display the DataBoard form.
            var window = new DataBoard(_communicator, _selectedDevice);
            window.GoToRulePage();
            window.ShowDialog();

            //Get the Comm object created.
            _rule = window.GetRule();

            //Return to Device list
            modrules_tBack.PerformClick();
        }
    }

    #endregion Modify Rules Page
}
