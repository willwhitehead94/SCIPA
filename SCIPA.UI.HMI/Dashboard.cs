using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SCIPA.Domain.Generic;

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
            this.report_rvReportViewer.RefreshReport();
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
            DebugOutput.Print("Dashboard: Start");
            pTabPanel.SelectedTab = pStart;
        }

        private void bStopProcess_Click(object sender, EventArgs e)
        {
            DebugOutput.Print("Dashboard: Stop");
            pTabPanel.SelectedTab = pStop;
        }

        private void bAddNew_Click(object sender, EventArgs e)
        {
            DebugOutput.Print("Dashboard: Add New Device");
            pTabPanel.SelectedTab = pAddNewDevice;
        }

        private void bModify_Click(object sender, EventArgs e)
        {
            DebugOutput.Print("Dashboard: Modify Device");
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
            }
        }
    }
}
