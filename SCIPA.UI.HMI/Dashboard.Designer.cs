namespace SCIPA.UI.HMI
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.AlarmsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHeader = new System.Windows.Forms.Panel();
            this.lHeaderAlarmCount = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.lSeperator = new System.Windows.Forms.Label();
            this.lTime = new System.Windows.Forms.Label();
            this.lScipa = new System.Windows.Forms.Label();
            this.bStartProcess = new System.Windows.Forms.Button();
            this.bStopProcess = new System.Windows.Forms.Button();
            this.bAddNew = new System.Windows.Forms.Button();
            this.bModify = new System.Windows.Forms.Button();
            this.bReports = new System.Windows.Forms.Button();
            this.bAlarms = new System.Windows.Forms.Button();
            this.pButtonPannel = new System.Windows.Forms.Panel();
            this.bSettings = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lStaticMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lStatusPreceder = new System.Windows.Forms.ToolStripStatusLabel();
            this.lStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.bTogglePanelSize_Status = new System.Windows.Forms.Button();
            this.pTabPanel = new SCIPA.UI.HMI.CustomTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.label35 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.pStart = new System.Windows.Forms.TabPage();
            this.start_tLocation = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.start_tCustodian = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.start_tDevName = new System.Windows.Forms.TextBox();
            this.start_tId = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.start_bStart = new System.Windows.Forms.Button();
            this.start_lbDevice = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.pStop = new System.Windows.Forms.TabPage();
            this.stop_lbValues = new System.Windows.Forms.ListBox();
            this.stop_tLocation = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.stop_tCustodian = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.stop_tDevName = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.stop_lbDevice = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pAddNewDevice = new System.Windows.Forms.TabPage();
            this.add_lActions = new System.Windows.Forms.Label();
            this.add_bNewAction = new System.Windows.Forms.Button();
            this.label72 = new System.Windows.Forms.Label();
            this.add_bClearNewDevice = new System.Windows.Forms.Button();
            this.add_bSaveNewDevice = new System.Windows.Forms.Button();
            this.add_lRules = new System.Windows.Forms.Label();
            this.add_bAddRule = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.add_lSource = new System.Windows.Forms.Label();
            this.add_bAddSource = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.add_rbFalse = new System.Windows.Forms.RadioButton();
            this.add_rbTrue = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.add_tLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.add_tCustodian = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.add_tName = new System.Windows.Forms.TextBox();
            this.add_tId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.lHeader_Add = new System.Windows.Forms.Label();
            this.pModifyDevice = new System.Windows.Forms.TabPage();
            this.modify_bRules = new System.Windows.Forms.Button();
            this.modify_bComms = new System.Windows.Forms.Button();
            this.modify_bClear = new System.Windows.Forms.Button();
            this.modify_bSave = new System.Windows.Forms.Button();
            this.modify_rbFalse = new System.Windows.Forms.RadioButton();
            this.modify_rbTrue = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.modify_tLocation = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.modify_tCustodian = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.modify_tDevName = new System.Windows.Forms.TextBox();
            this.modify_tId = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.modify_lbDeviceList = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pReports = new System.Windows.Forms.TabPage();
            this.report_rvReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.report_lbReports = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pAlarms = new System.Windows.Forms.TabPage();
            this.alarm_rbFalse = new System.Windows.Forms.RadioButton();
            this.alarm_rbTrue = new System.Windows.Forms.RadioButton();
            this.label29 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.alarm_cbPeriod = new System.Windows.Forms.ComboBox();
            this.alarm_Acknowledge = new System.Windows.Forms.Button();
            this.alarm_bRule = new System.Windows.Forms.Button();
            this.alarm_bDevice = new System.Windows.Forms.Button();
            this.alarm_tValue = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.alarm_tDateTime = new System.Windows.Forms.TextBox();
            this.alarm_tDevice = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.alarm_lbAlarms = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.pSettings = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.tSettingsPassword = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.pModifyCommunicators = new System.Windows.Forms.TabPage();
            this.modcomms_bAddNewComm = new System.Windows.Forms.Button();
            this.modcomms_bBack = new System.Windows.Forms.Button();
            this.modcomms_bSaveComm = new System.Windows.Forms.Button();
            this.modcomms_tpCommType = new SCIPA.UI.HMI.CustomTabControl();
            this.pModBlank = new System.Windows.Forms.TabPage();
            this.pModFile = new System.Windows.Forms.TabPage();
            this.modcomms_tFilePath = new System.Windows.Forms.TextBox();
            this.label70 = new System.Windows.Forms.Label();
            this.pModDatabase = new System.Windows.Forms.TabPage();
            this.label67 = new System.Windows.Forms.Label();
            this.modcomms_tQuery = new System.Windows.Forms.TextBox();
            this.modcomms_cbDatabaseType = new System.Windows.Forms.ComboBox();
            this.label68 = new System.Windows.Forms.Label();
            this.modcomms_tConnectionString = new System.Windows.Forms.TextBox();
            this.label69 = new System.Windows.Forms.Label();
            this.pModSerial = new System.Windows.Forms.TabPage();
            this.label63 = new System.Windows.Forms.Label();
            this.modcomms_cbDtr = new System.Windows.Forms.CheckBox();
            this.modcomms_cbRts = new System.Windows.Forms.CheckBox();
            this.modcomms_tDataBits = new System.Windows.Forms.TextBox();
            this.label64 = new System.Windows.Forms.Label();
            this.modcomms_tBaudRate = new System.Windows.Forms.TextBox();
            this.modcomms_cbComPort = new System.Windows.Forms.ComboBox();
            this.label65 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.modcomms_bResetDate = new System.Windows.Forms.Button();
            this.modcomms_rbOutbound = new System.Windows.Forms.RadioButton();
            this.modcomms_rbInbound = new System.Windows.Forms.RadioButton();
            this.label57 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.modcomms_cbValueType = new System.Windows.Forms.ComboBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.modcomms_tLastReadTime = new System.Windows.Forms.TextBox();
            this.modcomms_cbCommType = new System.Windows.Forms.ComboBox();
            this.modcomms_tEnd = new System.Windows.Forms.TextBox();
            this.label61 = new System.Windows.Forms.Label();
            this.modcomms_tStart = new System.Windows.Forms.TextBox();
            this.label62 = new System.Windows.Forms.Label();
            this.modcomms_lbComms = new System.Windows.Forms.ListBox();
            this.label56 = new System.Windows.Forms.Label();
            this.pModifyRules = new System.Windows.Forms.TabPage();
            this.modrules_bSetAction = new System.Windows.Forms.Button();
            this.label77 = new System.Windows.Forms.Label();
            this.modrules_cAlarm = new System.Windows.Forms.CheckBox();
            this.modrules_tConstraint = new System.Windows.Forms.TextBox();
            this.label76 = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.modrules_cbRuleType = new System.Windows.Forms.ComboBox();
            this.label74 = new System.Windows.Forms.Label();
            this.modrules_cbValueType = new System.Windows.Forms.ComboBox();
            this.modrules_tBack = new System.Windows.Forms.Button();
            this.modrules_tSave = new System.Windows.Forms.Button();
            this.modrules_Name = new System.Windows.Forms.TextBox();
            this.label71 = new System.Windows.Forms.Label();
            this.modrules_lbRules = new System.Windows.Forms.ListBox();
            this.label73 = new System.Windows.Forms.Label();
            this.pModifyActions = new System.Windows.Forms.TabPage();
            this.modact_tComm = new System.Windows.Forms.TextBox();
            this.modact_bNewComm = new System.Windows.Forms.Button();
            this.label78 = new System.Windows.Forms.Label();
            this.modact_cEnabled = new System.Windows.Forms.CheckBox();
            this.modact_tValue = new System.Windows.Forms.TextBox();
            this.label79 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.modact_bBack = new System.Windows.Forms.Button();
            this.modact_bSave = new System.Windows.Forms.Button();
            this.modact_tRule = new System.Windows.Forms.TextBox();
            this.label81 = new System.Windows.Forms.Label();
            this.label82 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmsBindingSource)).BeginInit();
            this.pHeader.SuspendLayout();
            this.pButtonPannel.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.pTabPanel.SuspendLayout();
            this.Home.SuspendLayout();
            this.pStart.SuspendLayout();
            this.pStop.SuspendLayout();
            this.pAddNewDevice.SuspendLayout();
            this.pModifyDevice.SuspendLayout();
            this.pReports.SuspendLayout();
            this.pAlarms.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pSettings.SuspendLayout();
            this.pModifyCommunicators.SuspendLayout();
            this.modcomms_tpCommType.SuspendLayout();
            this.pModFile.SuspendLayout();
            this.pModDatabase.SuspendLayout();
            this.pModSerial.SuspendLayout();
            this.pModifyRules.SuspendLayout();
            this.pModifyActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // AlarmsBindingSource
            // 
            this.AlarmsBindingSource.DataMember = "Alarms";
            // 
            // pHeader
            // 
            this.pHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pHeader.BackColor = System.Drawing.Color.Black;
            this.pHeader.Controls.Add(this.lHeaderAlarmCount);
            this.pHeader.Controls.Add(this.lDate);
            this.pHeader.Controls.Add(this.lSeperator);
            this.pHeader.Controls.Add(this.lTime);
            this.pHeader.Controls.Add(this.lScipa);
            this.pHeader.Location = new System.Drawing.Point(12, 12);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(1948, 106);
            this.pHeader.TabIndex = 0;
            // 
            // lHeaderAlarmCount
            // 
            this.lHeaderAlarmCount.AutoSize = true;
            this.lHeaderAlarmCount.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeaderAlarmCount.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lHeaderAlarmCount.Location = new System.Drawing.Point(761, 30);
            this.lHeaderAlarmCount.Name = "lHeaderAlarmCount";
            this.lHeaderAlarmCount.Size = new System.Drawing.Size(357, 51);
            this.lHeaderAlarmCount.TabIndex = 4;
            this.lHeaderAlarmCount.Text = "14 Active Alarms";
            this.lHeaderAlarmCount.Click += new System.EventHandler(this.lHeaderAlarmCount_Click);
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDate.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lDate.Location = new System.Drawing.Point(339, 3);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(357, 51);
            this.lDate.TabIndex = 1;
            this.lDate.Text = "January 1st 2016";
            // 
            // lSeperator
            // 
            this.lSeperator.AutoSize = true;
            this.lSeperator.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSeperator.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lSeperator.Location = new System.Drawing.Point(703, 8);
            this.lSeperator.Name = "lSeperator";
            this.lSeperator.Size = new System.Drawing.Size(72, 74);
            this.lSeperator.TabIndex = 3;
            this.lSeperator.Text = "|";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTime.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lTime.Location = new System.Drawing.Point(339, 50);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(190, 49);
            this.lTime.TabIndex = 2;
            this.lTime.Text = "01:03:42";
            // 
            // lScipa
            // 
            this.lScipa.AutoSize = true;
            this.lScipa.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lScipa.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lScipa.Location = new System.Drawing.Point(-12, -13);
            this.lScipa.Name = "lScipa";
            this.lScipa.Size = new System.Drawing.Size(364, 127);
            this.lScipa.TabIndex = 0;
            this.lScipa.Text = "SCIPA";
            // 
            // bStartProcess
            // 
            this.bStartProcess.BackColor = System.Drawing.Color.Gainsboro;
            this.bStartProcess.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStartProcess.Location = new System.Drawing.Point(1, -3);
            this.bStartProcess.Name = "bStartProcess";
            this.bStartProcess.Size = new System.Drawing.Size(270, 85);
            this.bStartProcess.TabIndex = 7;
            this.bStartProcess.Text = "START DEVICE PROCESSES";
            this.bStartProcess.UseVisualStyleBackColor = false;
            this.bStartProcess.Click += new System.EventHandler(this.bStartProcess_Click);
            // 
            // bStopProcess
            // 
            this.bStopProcess.BackColor = System.Drawing.Color.Gainsboro;
            this.bStopProcess.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStopProcess.Location = new System.Drawing.Point(277, -3);
            this.bStopProcess.Name = "bStopProcess";
            this.bStopProcess.Size = new System.Drawing.Size(270, 85);
            this.bStopProcess.TabIndex = 8;
            this.bStopProcess.Text = "VALUE INVESTIGATOR";
            this.bStopProcess.UseVisualStyleBackColor = false;
            this.bStopProcess.Click += new System.EventHandler(this.bStopProcess_Click);
            // 
            // bAddNew
            // 
            this.bAddNew.BackColor = System.Drawing.Color.Gainsboro;
            this.bAddNew.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddNew.Location = new System.Drawing.Point(553, -3);
            this.bAddNew.Name = "bAddNew";
            this.bAddNew.Size = new System.Drawing.Size(270, 85);
            this.bAddNew.TabIndex = 9;
            this.bAddNew.Text = "ADD NEW DEVICE";
            this.bAddNew.UseVisualStyleBackColor = false;
            this.bAddNew.Click += new System.EventHandler(this.bAddNew_Click);
            // 
            // bModify
            // 
            this.bModify.BackColor = System.Drawing.Color.Gainsboro;
            this.bModify.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModify.Location = new System.Drawing.Point(829, -3);
            this.bModify.Name = "bModify";
            this.bModify.Size = new System.Drawing.Size(270, 85);
            this.bModify.TabIndex = 10;
            this.bModify.Text = "MODIFY DEVICE";
            this.bModify.UseVisualStyleBackColor = false;
            this.bModify.Click += new System.EventHandler(this.bModify_Click);
            // 
            // bReports
            // 
            this.bReports.BackColor = System.Drawing.Color.Gainsboro;
            this.bReports.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReports.Location = new System.Drawing.Point(1105, -3);
            this.bReports.Name = "bReports";
            this.bReports.Size = new System.Drawing.Size(270, 85);
            this.bReports.TabIndex = 11;
            this.bReports.Text = "PROCESS REPORTS";
            this.bReports.UseVisualStyleBackColor = false;
            this.bReports.Click += new System.EventHandler(this.bReports_Click);
            // 
            // bAlarms
            // 
            this.bAlarms.BackColor = System.Drawing.Color.Gainsboro;
            this.bAlarms.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAlarms.Location = new System.Drawing.Point(1381, -3);
            this.bAlarms.Name = "bAlarms";
            this.bAlarms.Size = new System.Drawing.Size(270, 85);
            this.bAlarms.TabIndex = 12;
            this.bAlarms.Text = "ALARMS";
            this.bAlarms.UseVisualStyleBackColor = false;
            this.bAlarms.Click += new System.EventHandler(this.bAlarms_Click);
            // 
            // pButtonPannel
            // 
            this.pButtonPannel.BackColor = System.Drawing.Color.Transparent;
            this.pButtonPannel.Controls.Add(this.bSettings);
            this.pButtonPannel.Controls.Add(this.bAlarms);
            this.pButtonPannel.Controls.Add(this.label6);
            this.pButtonPannel.Controls.Add(this.bStopProcess);
            this.pButtonPannel.Controls.Add(this.bStartProcess);
            this.pButtonPannel.Controls.Add(this.bReports);
            this.pButtonPannel.Controls.Add(this.bAddNew);
            this.pButtonPannel.Controls.Add(this.bModify);
            this.pButtonPannel.Location = new System.Drawing.Point(11, 130);
            this.pButtonPannel.Name = "pButtonPannel";
            this.pButtonPannel.Size = new System.Drawing.Size(1949, 85);
            this.pButtonPannel.TabIndex = 13;
            // 
            // bSettings
            // 
            this.bSettings.BackColor = System.Drawing.Color.DarkGray;
            this.bSettings.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSettings.Location = new System.Drawing.Point(1679, 0);
            this.bSettings.Name = "bSettings";
            this.bSettings.Size = new System.Drawing.Size(270, 85);
            this.bSettings.TabIndex = 13;
            this.bSettings.Text = "SETTINGS";
            this.bSettings.UseVisualStyleBackColor = false;
            this.bSettings.Click += new System.EventHandler(this.bSettings_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(1633, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 74);
            this.label6.TabIndex = 5;
            this.label6.Text = "|";
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStaticMessage,
            this.lStatusPreceder,
            this.lStatusMessage});
            this.statusBar.Location = new System.Drawing.Point(0, 1183);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1972, 38);
            this.statusBar.TabIndex = 15;
            this.statusBar.Text = "statusStrip1";
            // 
            // lStaticMessage
            // 
            this.lStaticMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStaticMessage.Name = "lStaticMessage";
            this.lStaticMessage.Size = new System.Drawing.Size(193, 33);
            this.lStaticMessage.Text = "SCIPA System";
            this.lStaticMessage.Click += new System.EventHandler(this.lStaticMessage_Click);
            // 
            // lStatusPreceder
            // 
            this.lStatusPreceder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatusPreceder.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lStatusPreceder.Name = "lStatusPreceder";
            this.lStatusPreceder.Size = new System.Drawing.Size(222, 33);
            this.lStatusPreceder.Text = "Minor Messages";
            // 
            // lStatusMessage
            // 
            this.lStatusMessage.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatusMessage.Name = "lStatusMessage";
            this.lStatusMessage.Size = new System.Drawing.Size(385, 33);
            this.lStatusMessage.Text = "Application Status Messages";
            // 
            // bTogglePanelSize_Status
            // 
            this.bTogglePanelSize_Status.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bTogglePanelSize_Status.Location = new System.Drawing.Point(1751, 1144);
            this.bTogglePanelSize_Status.Name = "bTogglePanelSize_Status";
            this.bTogglePanelSize_Status.Size = new System.Drawing.Size(209, 65);
            this.bTogglePanelSize_Status.TabIndex = 1;
            this.bTogglePanelSize_Status.Text = "Fullscreen";
            this.bTogglePanelSize_Status.UseVisualStyleBackColor = true;
            this.bTogglePanelSize_Status.Click += new System.EventHandler(this.bTogglePanelSize_Click);
            // 
            // pTabPanel
            // 
            this.pTabPanel.Controls.Add(this.Home);
            this.pTabPanel.Controls.Add(this.pStart);
            this.pTabPanel.Controls.Add(this.pStop);
            this.pTabPanel.Controls.Add(this.pAddNewDevice);
            this.pTabPanel.Controls.Add(this.pModifyDevice);
            this.pTabPanel.Controls.Add(this.pReports);
            this.pTabPanel.Controls.Add(this.pAlarms);
            this.pTabPanel.Controls.Add(this.pSettings);
            this.pTabPanel.Controls.Add(this.pModifyCommunicators);
            this.pTabPanel.Controls.Add(this.pModifyRules);
            this.pTabPanel.Controls.Add(this.pModifyActions);
            this.pTabPanel.Location = new System.Drawing.Point(11, 221);
            this.pTabPanel.Name = "pTabPanel";
            this.pTabPanel.SelectedIndex = 0;
            this.pTabPanel.Size = new System.Drawing.Size(1949, 959);
            this.pTabPanel.TabIndex = 14;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.label35);
            this.Home.Controls.Add(this.label30);
            this.Home.Location = new System.Drawing.Point(10, 47);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1929, 902);
            this.Home.TabIndex = 7;
            this.Home.Text = "pHome";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.label35.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label35.Location = new System.Drawing.Point(0, 504);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(1939, 398);
            this.label35.TabIndex = 2;
            this.label35.Text = "SOFTWARE CONTROLLED INDUSTRIAL\r\nPROCESS AUTOMATION SYSTEM";
            this.label35.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Century Gothic", 100F, System.Drawing.FontStyle.Bold);
            this.label30.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label30.Location = new System.Drawing.Point(-9, 18);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(1960, 614);
            this.label30.TabIndex = 1;
            this.label30.Text = "SCIPA";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pStart
            // 
            this.pStart.Controls.Add(this.start_tLocation);
            this.pStart.Controls.Add(this.label31);
            this.pStart.Controls.Add(this.start_tCustodian);
            this.pStart.Controls.Add(this.label32);
            this.pStart.Controls.Add(this.start_tDevName);
            this.pStart.Controls.Add(this.start_tId);
            this.pStart.Controls.Add(this.label21);
            this.pStart.Controls.Add(this.label22);
            this.pStart.Controls.Add(this.start_bStart);
            this.pStart.Controls.Add(this.start_lbDevice);
            this.pStart.Controls.Add(this.label17);
            this.pStart.Location = new System.Drawing.Point(10, 47);
            this.pStart.Name = "pStart";
            this.pStart.Size = new System.Drawing.Size(1929, 902);
            this.pStart.TabIndex = 0;
            this.pStart.Text = "StartProcess";
            this.pStart.UseVisualStyleBackColor = true;
            // 
            // start_tLocation
            // 
            this.start_tLocation.Enabled = false;
            this.start_tLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_tLocation.Location = new System.Drawing.Point(1095, 201);
            this.start_tLocation.Margin = new System.Windows.Forms.Padding(7);
            this.start_tLocation.Name = "start_tLocation";
            this.start_tLocation.Size = new System.Drawing.Size(799, 55);
            this.start_tLocation.TabIndex = 42;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(796, 208);
            this.label31.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(190, 48);
            this.label31.TabIndex = 41;
            this.label31.Text = "Location:";
            // 
            // start_tCustodian
            // 
            this.start_tCustodian.Enabled = false;
            this.start_tCustodian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_tCustodian.Location = new System.Drawing.Point(1095, 270);
            this.start_tCustodian.Margin = new System.Windows.Forms.Padding(7);
            this.start_tCustodian.Name = "start_tCustodian";
            this.start_tCustodian.Size = new System.Drawing.Size(799, 55);
            this.start_tCustodian.TabIndex = 40;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(796, 277);
            this.label32.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(220, 48);
            this.label32.TabIndex = 39;
            this.label32.Text = "Custodian:";
            // 
            // start_tDevName
            // 
            this.start_tDevName.Enabled = false;
            this.start_tDevName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_tDevName.Location = new System.Drawing.Point(1095, 132);
            this.start_tDevName.Margin = new System.Windows.Forms.Padding(7);
            this.start_tDevName.Name = "start_tDevName";
            this.start_tDevName.Size = new System.Drawing.Size(799, 55);
            this.start_tDevName.TabIndex = 38;
            // 
            // start_tId
            // 
            this.start_tId.Enabled = false;
            this.start_tId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_tId.Location = new System.Drawing.Point(1095, 63);
            this.start_tId.Margin = new System.Windows.Forms.Padding(7);
            this.start_tId.Name = "start_tId";
            this.start_tId.Size = new System.Drawing.Size(799, 55);
            this.start_tId.TabIndex = 37;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(796, 139);
            this.label21.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(282, 48);
            this.label21.TabIndex = 36;
            this.label21.Text = "Device Name:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(796, 70);
            this.label22.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(233, 48);
            this.label22.TabIndex = 35;
            this.label22.Text = "ID Number:";
            // 
            // start_bStart
            // 
            this.start_bStart.Enabled = false;
            this.start_bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_bStart.Location = new System.Drawing.Point(876, 393);
            this.start_bStart.Margin = new System.Windows.Forms.Padding(7);
            this.start_bStart.Name = "start_bStart";
            this.start_bStart.Size = new System.Drawing.Size(960, 128);
            this.start_bStart.TabIndex = 34;
            this.start_bStart.Text = "Start Selected Device";
            this.start_bStart.UseVisualStyleBackColor = true;
            this.start_bStart.Click += new System.EventHandler(this.start_bStart_Click);
            // 
            // start_lbDevice
            // 
            this.start_lbDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.start_lbDevice.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_lbDevice.FormattingEnabled = true;
            this.start_lbDevice.ItemHeight = 65;
            this.start_lbDevice.Items.AddRange(new object[] {
            "Device",
            "Device",
            "Device",
            "Device",
            "Device",
            "Device",
            "Device",
            "Device"});
            this.start_lbDevice.Location = new System.Drawing.Point(53, 72);
            this.start_lbDevice.Name = "start_lbDevice";
            this.start_lbDevice.Size = new System.Drawing.Size(713, 784);
            this.start_lbDevice.TabIndex = 5;
            this.start_lbDevice.SelectedIndexChanged += new System.EventHandler(this.start_lbDevice_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label17.Location = new System.Drawing.Point(6, 2);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(728, 51);
            this.label17.TabIndex = 4;
            this.label17.Text = "Start Process Monitoring by Device";
            // 
            // pStop
            // 
            this.pStop.Controls.Add(this.stop_lbValues);
            this.pStop.Controls.Add(this.stop_tLocation);
            this.pStop.Controls.Add(this.label33);
            this.pStop.Controls.Add(this.stop_tCustodian);
            this.pStop.Controls.Add(this.label34);
            this.pStop.Controls.Add(this.stop_tDevName);
            this.pStop.Controls.Add(this.label23);
            this.pStop.Controls.Add(this.stop_lbDevice);
            this.pStop.Controls.Add(this.label18);
            this.pStop.Location = new System.Drawing.Point(10, 47);
            this.pStop.Name = "pStop";
            this.pStop.Size = new System.Drawing.Size(1929, 902);
            this.pStop.TabIndex = 1;
            this.pStop.Text = "StopProcess";
            this.pStop.UseVisualStyleBackColor = true;
            // 
            // stop_lbValues
            // 
            this.stop_lbValues.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stop_lbValues.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_lbValues.FormattingEnabled = true;
            this.stop_lbValues.ItemHeight = 65;
            this.stop_lbValues.Location = new System.Drawing.Point(819, 276);
            this.stop_lbValues.Name = "stop_lbValues";
            this.stop_lbValues.Size = new System.Drawing.Size(1091, 589);
            this.stop_lbValues.TabIndex = 49;
            // 
            // stop_tLocation
            // 
            this.stop_tLocation.Enabled = false;
            this.stop_tLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_tLocation.Location = new System.Drawing.Point(1111, 141);
            this.stop_tLocation.Margin = new System.Windows.Forms.Padding(7);
            this.stop_tLocation.Name = "stop_tLocation";
            this.stop_tLocation.Size = new System.Drawing.Size(799, 55);
            this.stop_tLocation.TabIndex = 48;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(812, 148);
            this.label33.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(190, 48);
            this.label33.TabIndex = 47;
            this.label33.Text = "Location:";
            // 
            // stop_tCustodian
            // 
            this.stop_tCustodian.Enabled = false;
            this.stop_tCustodian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_tCustodian.Location = new System.Drawing.Point(1111, 210);
            this.stop_tCustodian.Margin = new System.Windows.Forms.Padding(7);
            this.stop_tCustodian.Name = "stop_tCustodian";
            this.stop_tCustodian.Size = new System.Drawing.Size(799, 55);
            this.stop_tCustodian.TabIndex = 46;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(812, 217);
            this.label34.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(220, 48);
            this.label34.TabIndex = 45;
            this.label34.Text = "Custodian:";
            // 
            // stop_tDevName
            // 
            this.stop_tDevName.Enabled = false;
            this.stop_tDevName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_tDevName.Location = new System.Drawing.Point(1111, 72);
            this.stop_tDevName.Margin = new System.Windows.Forms.Padding(7);
            this.stop_tDevName.Name = "stop_tDevName";
            this.stop_tDevName.Size = new System.Drawing.Size(799, 55);
            this.stop_tDevName.TabIndex = 44;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(812, 79);
            this.label23.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(282, 48);
            this.label23.TabIndex = 42;
            this.label23.Text = "Device Name:";
            // 
            // stop_lbDevice
            // 
            this.stop_lbDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.stop_lbDevice.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_lbDevice.FormattingEnabled = true;
            this.stop_lbDevice.ItemHeight = 65;
            this.stop_lbDevice.Items.AddRange(new object[] {
            "Device",
            "Device",
            "Device",
            "Device",
            "Device",
            "Device",
            "Device",
            "Device"});
            this.stop_lbDevice.Location = new System.Drawing.Point(53, 72);
            this.stop_lbDevice.Name = "stop_lbDevice";
            this.stop_lbDevice.Size = new System.Drawing.Size(713, 784);
            this.stop_lbDevice.TabIndex = 39;
            this.stop_lbDevice.SelectedIndexChanged += new System.EventHandler(this.stop_lbDevice_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label18.Location = new System.Drawing.Point(6, 2);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(393, 51);
            this.label18.TabIndex = 4;
            this.label18.Text = "Value Investigator";
            // 
            // pAddNewDevice
            // 
            this.pAddNewDevice.AutoScroll = true;
            this.pAddNewDevice.Controls.Add(this.add_lActions);
            this.pAddNewDevice.Controls.Add(this.add_bNewAction);
            this.pAddNewDevice.Controls.Add(this.label72);
            this.pAddNewDevice.Controls.Add(this.add_bClearNewDevice);
            this.pAddNewDevice.Controls.Add(this.add_bSaveNewDevice);
            this.pAddNewDevice.Controls.Add(this.add_lRules);
            this.pAddNewDevice.Controls.Add(this.add_bAddRule);
            this.pAddNewDevice.Controls.Add(this.label10);
            this.pAddNewDevice.Controls.Add(this.add_lSource);
            this.pAddNewDevice.Controls.Add(this.add_bAddSource);
            this.pAddNewDevice.Controls.Add(this.label5);
            this.pAddNewDevice.Controls.Add(this.add_rbFalse);
            this.pAddNewDevice.Controls.Add(this.add_rbTrue);
            this.pAddNewDevice.Controls.Add(this.label4);
            this.pAddNewDevice.Controls.Add(this.add_tLocation);
            this.pAddNewDevice.Controls.Add(this.label3);
            this.pAddNewDevice.Controls.Add(this.add_tCustodian);
            this.pAddNewDevice.Controls.Add(this.label2);
            this.pAddNewDevice.Controls.Add(this.add_tName);
            this.pAddNewDevice.Controls.Add(this.add_tId);
            this.pAddNewDevice.Controls.Add(this.label1);
            this.pAddNewDevice.Controls.Add(this.lId);
            this.pAddNewDevice.Controls.Add(this.lHeader_Add);
            this.pAddNewDevice.Location = new System.Drawing.Point(10, 47);
            this.pAddNewDevice.Name = "pAddNewDevice";
            this.pAddNewDevice.Size = new System.Drawing.Size(1929, 902);
            this.pAddNewDevice.TabIndex = 2;
            this.pAddNewDevice.Text = "AddDevice";
            this.pAddNewDevice.UseVisualStyleBackColor = true;
            // 
            // add_lActions
            // 
            this.add_lActions.AutoSize = true;
            this.add_lActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_lActions.Location = new System.Drawing.Point(682, 630);
            this.add_lActions.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.add_lActions.Name = "add_lActions";
            this.add_lActions.Size = new System.Drawing.Size(228, 48);
            this.add_lActions.TabIndex = 45;
            this.add_lActions.Text = "0 Actions...";
            // 
            // add_bNewAction
            // 
            this.add_bNewAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_bNewAction.Location = new System.Drawing.Point(339, 612);
            this.add_bNewAction.Margin = new System.Windows.Forms.Padding(7);
            this.add_bNewAction.Name = "add_bNewAction";
            this.add_bNewAction.Size = new System.Drawing.Size(329, 85);
            this.add_bNewAction.TabIndex = 44;
            this.add_bNewAction.Text = "Add Action";
            this.add_bNewAction.UseVisualStyleBackColor = true;
            this.add_bNewAction.Click += new System.EventHandler(this.add_bNewAction_Click);
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label72.Location = new System.Drawing.Point(50, 630);
            this.label72.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(170, 48);
            this.label72.TabIndex = 43;
            this.label72.Text = "Actions:";
            // 
            // add_bClearNewDevice
            // 
            this.add_bClearNewDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_bClearNewDevice.BackColor = System.Drawing.Color.Gainsboro;
            this.add_bClearNewDevice.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_bClearNewDevice.Location = new System.Drawing.Point(655, 785);
            this.add_bClearNewDevice.Name = "add_bClearNewDevice";
            this.add_bClearNewDevice.Size = new System.Drawing.Size(612, 85);
            this.add_bClearNewDevice.TabIndex = 41;
            this.add_bClearNewDevice.Text = "CLEAR ALL FIELDS";
            this.add_bClearNewDevice.UseVisualStyleBackColor = false;
            // 
            // add_bSaveNewDevice
            // 
            this.add_bSaveNewDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.add_bSaveNewDevice.BackColor = System.Drawing.Color.Gainsboro;
            this.add_bSaveNewDevice.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_bSaveNewDevice.Location = new System.Drawing.Point(1273, 760);
            this.add_bSaveNewDevice.Name = "add_bSaveNewDevice";
            this.add_bSaveNewDevice.Size = new System.Drawing.Size(612, 110);
            this.add_bSaveNewDevice.TabIndex = 14;
            this.add_bSaveNewDevice.Text = "SAVE DEVICE INFORMATION";
            this.add_bSaveNewDevice.UseVisualStyleBackColor = false;
            this.add_bSaveNewDevice.Click += new System.EventHandler(this.add_bSaveNewDevice_Click);
            // 
            // add_lRules
            // 
            this.add_lRules.AutoSize = true;
            this.add_lRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_lRules.Location = new System.Drawing.Point(682, 531);
            this.add_lRules.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.add_lRules.Name = "add_lRules";
            this.add_lRules.Size = new System.Drawing.Size(197, 48);
            this.add_lRules.TabIndex = 40;
            this.add_lRules.Text = "0 Rules...";
            // 
            // add_bAddRule
            // 
            this.add_bAddRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_bAddRule.Location = new System.Drawing.Point(339, 513);
            this.add_bAddRule.Margin = new System.Windows.Forms.Padding(7);
            this.add_bAddRule.Name = "add_bAddRule";
            this.add_bAddRule.Size = new System.Drawing.Size(329, 85);
            this.add_bAddRule.TabIndex = 39;
            this.add_bAddRule.Text = "Add Rule";
            this.add_bAddRule.UseVisualStyleBackColor = true;
            this.add_bAddRule.Click += new System.EventHandler(this.add_bAddRule_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 531);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 48);
            this.label10.TabIndex = 38;
            this.label10.Text = "Rules:";
            // 
            // add_lSource
            // 
            this.add_lSource.AutoSize = true;
            this.add_lSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_lSource.Location = new System.Drawing.Point(682, 432);
            this.add_lSource.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.add_lSource.Name = "add_lSource";
            this.add_lSource.Size = new System.Drawing.Size(322, 48);
            this.add_lSource.TabIndex = 34;
            this.add_lSource.Text = "0 Connections...";
            // 
            // add_bAddSource
            // 
            this.add_bAddSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_bAddSource.Location = new System.Drawing.Point(339, 414);
            this.add_bAddSource.Margin = new System.Windows.Forms.Padding(7);
            this.add_bAddSource.Name = "add_bAddSource";
            this.add_bAddSource.Size = new System.Drawing.Size(329, 85);
            this.add_bAddSource.TabIndex = 33;
            this.add_bAddSource.Text = "Add Data";
            this.add_bAddSource.UseVisualStyleBackColor = true;
            this.add_bAddSource.Click += new System.EventHandler(this.add_bAddSource_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 432);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(264, 48);
            this.label5.TabIndex = 32;
            this.label5.Text = "Connections:";
            // 
            // add_rbFalse
            // 
            this.add_rbFalse.AutoSize = true;
            this.add_rbFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_rbFalse.Location = new System.Drawing.Point(514, 350);
            this.add_rbFalse.Margin = new System.Windows.Forms.Padding(7);
            this.add_rbFalse.Name = "add_rbFalse";
            this.add_rbFalse.Size = new System.Drawing.Size(154, 52);
            this.add_rbFalse.TabIndex = 31;
            this.add_rbFalse.Text = "False";
            this.add_rbFalse.UseVisualStyleBackColor = true;
            // 
            // add_rbTrue
            // 
            this.add_rbTrue.AutoSize = true;
            this.add_rbTrue.Checked = true;
            this.add_rbTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_rbTrue.Location = new System.Drawing.Point(349, 348);
            this.add_rbTrue.Margin = new System.Windows.Forms.Padding(7);
            this.add_rbTrue.Name = "add_rbTrue";
            this.add_rbTrue.Size = new System.Drawing.Size(137, 52);
            this.add_rbTrue.TabIndex = 30;
            this.add_rbTrue.TabStop = true;
            this.add_rbTrue.Text = "True";
            this.add_rbTrue.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 48);
            this.label4.TabIndex = 29;
            this.label4.Text = "Enabled:";
            // 
            // add_tLocation
            // 
            this.add_tLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_tLocation.Location = new System.Drawing.Point(349, 210);
            this.add_tLocation.Margin = new System.Windows.Forms.Padding(7);
            this.add_tLocation.Name = "add_tLocation";
            this.add_tLocation.Size = new System.Drawing.Size(569, 55);
            this.add_tLocation.TabIndex = 28;
            this.add_tLocation.Text = "Under - Desk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 217);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 48);
            this.label3.TabIndex = 27;
            this.label3.Text = "Location:";
            // 
            // add_tCustodian
            // 
            this.add_tCustodian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_tCustodian.Location = new System.Drawing.Point(349, 279);
            this.add_tCustodian.Margin = new System.Windows.Forms.Padding(7);
            this.add_tCustodian.Name = "add_tCustodian";
            this.add_tCustodian.Size = new System.Drawing.Size(569, 55);
            this.add_tCustodian.TabIndex = 26;
            this.add_tCustodian.Text = "W. Whitehead";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 286);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 48);
            this.label2.TabIndex = 25;
            this.label2.Text = "Custodian:";
            // 
            // add_tName
            // 
            this.add_tName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_tName.Location = new System.Drawing.Point(349, 141);
            this.add_tName.Margin = new System.Windows.Forms.Padding(7);
            this.add_tName.Name = "add_tName";
            this.add_tName.Size = new System.Drawing.Size(569, 55);
            this.add_tName.TabIndex = 24;
            this.add_tName.Text = "Test Arduino";
            // 
            // add_tId
            // 
            this.add_tId.Enabled = false;
            this.add_tId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_tId.Location = new System.Drawing.Point(349, 72);
            this.add_tId.Margin = new System.Windows.Forms.Padding(7);
            this.add_tId.Name = "add_tId";
            this.add_tId.Size = new System.Drawing.Size(569, 55);
            this.add_tId.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 48);
            this.label1.TabIndex = 22;
            this.label1.Text = "Device Name:";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lId.Location = new System.Drawing.Point(50, 79);
            this.lId.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(233, 48);
            this.lId.TabIndex = 21;
            this.lId.Text = "ID Number:";
            // 
            // lHeader_Add
            // 
            this.lHeader_Add.AutoSize = true;
            this.lHeader_Add.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeader_Add.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lHeader_Add.Location = new System.Drawing.Point(6, 2);
            this.lHeader_Add.Name = "lHeader_Add";
            this.lHeader_Add.Size = new System.Drawing.Size(370, 51);
            this.lHeader_Add.TabIndex = 2;
            this.lHeader_Add.Text = "Add New Device";
            // 
            // pModifyDevice
            // 
            this.pModifyDevice.Controls.Add(this.modify_bRules);
            this.pModifyDevice.Controls.Add(this.modify_bComms);
            this.pModifyDevice.Controls.Add(this.modify_bClear);
            this.pModifyDevice.Controls.Add(this.modify_bSave);
            this.pModifyDevice.Controls.Add(this.modify_rbFalse);
            this.pModifyDevice.Controls.Add(this.modify_rbTrue);
            this.pModifyDevice.Controls.Add(this.label9);
            this.pModifyDevice.Controls.Add(this.modify_tLocation);
            this.pModifyDevice.Controls.Add(this.label11);
            this.pModifyDevice.Controls.Add(this.modify_tCustodian);
            this.pModifyDevice.Controls.Add(this.label12);
            this.pModifyDevice.Controls.Add(this.modify_tDevName);
            this.pModifyDevice.Controls.Add(this.modify_tId);
            this.pModifyDevice.Controls.Add(this.label13);
            this.pModifyDevice.Controls.Add(this.label14);
            this.pModifyDevice.Controls.Add(this.modify_lbDeviceList);
            this.pModifyDevice.Controls.Add(this.label7);
            this.pModifyDevice.Location = new System.Drawing.Point(10, 47);
            this.pModifyDevice.Name = "pModifyDevice";
            this.pModifyDevice.Size = new System.Drawing.Size(1929, 902);
            this.pModifyDevice.TabIndex = 3;
            this.pModifyDevice.Text = "ModifyDevice";
            this.pModifyDevice.UseVisualStyleBackColor = true;
            // 
            // modify_bRules
            // 
            this.modify_bRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_bRules.Location = new System.Drawing.Point(1371, 443);
            this.modify_bRules.Margin = new System.Windows.Forms.Padding(7);
            this.modify_bRules.Name = "modify_bRules";
            this.modify_bRules.Size = new System.Drawing.Size(460, 85);
            this.modify_bRules.TabIndex = 46;
            this.modify_bRules.Text = "Modify Rules";
            this.modify_bRules.UseVisualStyleBackColor = true;
            this.modify_bRules.Click += new System.EventHandler(this.modify_bRules_Click);
            // 
            // modify_bComms
            // 
            this.modify_bComms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_bComms.Location = new System.Drawing.Point(887, 443);
            this.modify_bComms.Margin = new System.Windows.Forms.Padding(7);
            this.modify_bComms.Name = "modify_bComms";
            this.modify_bComms.Size = new System.Drawing.Size(460, 85);
            this.modify_bComms.TabIndex = 45;
            this.modify_bComms.Text = "Modify Communicators";
            this.modify_bComms.UseVisualStyleBackColor = true;
            this.modify_bComms.Click += new System.EventHandler(this.modify_bComms_Click);
            // 
            // modify_bClear
            // 
            this.modify_bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modify_bClear.BackColor = System.Drawing.Color.Gainsboro;
            this.modify_bClear.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_bClear.Location = new System.Drawing.Point(655, 785);
            this.modify_bClear.Name = "modify_bClear";
            this.modify_bClear.Size = new System.Drawing.Size(612, 85);
            this.modify_bClear.TabIndex = 44;
            this.modify_bClear.Text = "CLEAR ALL FIELDS";
            this.modify_bClear.UseVisualStyleBackColor = false;
            // 
            // modify_bSave
            // 
            this.modify_bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modify_bSave.BackColor = System.Drawing.Color.Gainsboro;
            this.modify_bSave.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_bSave.Location = new System.Drawing.Point(1273, 760);
            this.modify_bSave.Name = "modify_bSave";
            this.modify_bSave.Size = new System.Drawing.Size(612, 110);
            this.modify_bSave.TabIndex = 43;
            this.modify_bSave.Text = "SAVE DEVICE INFORMATION";
            this.modify_bSave.UseVisualStyleBackColor = false;
            this.modify_bSave.Click += new System.EventHandler(this.modify_bSave_Click);
            // 
            // modify_rbFalse
            // 
            this.modify_rbFalse.AutoSize = true;
            this.modify_rbFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_rbFalse.Location = new System.Drawing.Point(1256, 343);
            this.modify_rbFalse.Margin = new System.Windows.Forms.Padding(7);
            this.modify_rbFalse.Name = "modify_rbFalse";
            this.modify_rbFalse.Size = new System.Drawing.Size(154, 52);
            this.modify_rbFalse.TabIndex = 42;
            this.modify_rbFalse.TabStop = true;
            this.modify_rbFalse.Text = "False";
            this.modify_rbFalse.UseVisualStyleBackColor = true;
            // 
            // modify_rbTrue
            // 
            this.modify_rbTrue.AutoSize = true;
            this.modify_rbTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_rbTrue.Location = new System.Drawing.Point(1091, 341);
            this.modify_rbTrue.Margin = new System.Windows.Forms.Padding(7);
            this.modify_rbTrue.Name = "modify_rbTrue";
            this.modify_rbTrue.Size = new System.Drawing.Size(137, 52);
            this.modify_rbTrue.TabIndex = 41;
            this.modify_rbTrue.TabStop = true;
            this.modify_rbTrue.Text = "True";
            this.modify_rbTrue.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(792, 345);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 48);
            this.label9.TabIndex = 40;
            this.label9.Text = "Enabled:";
            // 
            // modify_tLocation
            // 
            this.modify_tLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_tLocation.Location = new System.Drawing.Point(1091, 203);
            this.modify_tLocation.Margin = new System.Windows.Forms.Padding(7);
            this.modify_tLocation.Name = "modify_tLocation";
            this.modify_tLocation.Size = new System.Drawing.Size(794, 55);
            this.modify_tLocation.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(792, 210);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(190, 48);
            this.label11.TabIndex = 38;
            this.label11.Text = "Location:";
            // 
            // modify_tCustodian
            // 
            this.modify_tCustodian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_tCustodian.Location = new System.Drawing.Point(1091, 272);
            this.modify_tCustodian.Margin = new System.Windows.Forms.Padding(7);
            this.modify_tCustodian.Name = "modify_tCustodian";
            this.modify_tCustodian.Size = new System.Drawing.Size(794, 55);
            this.modify_tCustodian.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(792, 279);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(220, 48);
            this.label12.TabIndex = 36;
            this.label12.Text = "Custodian:";
            // 
            // modify_tDevName
            // 
            this.modify_tDevName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_tDevName.Location = new System.Drawing.Point(1091, 134);
            this.modify_tDevName.Margin = new System.Windows.Forms.Padding(7);
            this.modify_tDevName.Name = "modify_tDevName";
            this.modify_tDevName.Size = new System.Drawing.Size(794, 55);
            this.modify_tDevName.TabIndex = 35;
            // 
            // modify_tId
            // 
            this.modify_tId.Enabled = false;
            this.modify_tId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_tId.Location = new System.Drawing.Point(1091, 65);
            this.modify_tId.Margin = new System.Windows.Forms.Padding(7);
            this.modify_tId.Name = "modify_tId";
            this.modify_tId.Size = new System.Drawing.Size(794, 55);
            this.modify_tId.TabIndex = 34;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(792, 141);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(282, 48);
            this.label13.TabIndex = 33;
            this.label13.Text = "Device Name:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(792, 72);
            this.label14.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(233, 48);
            this.label14.TabIndex = 32;
            this.label14.Text = "ID Number:";
            // 
            // modify_lbDeviceList
            // 
            this.modify_lbDeviceList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.modify_lbDeviceList.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_lbDeviceList.FormattingEnabled = true;
            this.modify_lbDeviceList.ItemHeight = 65;
            this.modify_lbDeviceList.Location = new System.Drawing.Point(53, 72);
            this.modify_lbDeviceList.Name = "modify_lbDeviceList";
            this.modify_lbDeviceList.Size = new System.Drawing.Size(713, 784);
            this.modify_lbDeviceList.TabIndex = 4;
            this.modify_lbDeviceList.SelectedIndexChanged += new System.EventHandler(this.modify_lbDeviceList_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(6, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(566, 51);
            this.label7.TabIndex = 3;
            this.label7.Text = "Modify Device Information";
            // 
            // pReports
            // 
            this.pReports.Controls.Add(this.report_rvReportViewer);
            this.pReports.Controls.Add(this.report_lbReports);
            this.pReports.Controls.Add(this.label15);
            this.pReports.Location = new System.Drawing.Point(10, 47);
            this.pReports.Name = "pReports";
            this.pReports.Size = new System.Drawing.Size(1929, 902);
            this.pReports.TabIndex = 4;
            this.pReports.Text = "Reports";
            this.pReports.UseVisualStyleBackColor = true;
            // 
            // report_rvReportViewer
            // 
            this.report_rvReportViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.AlarmsBindingSource;
            this.report_rvReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.report_rvReportViewer.Location = new System.Drawing.Point(772, 72);
            this.report_rvReportViewer.Name = "report_rvReportViewer";
            this.report_rvReportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            this.report_rvReportViewer.ServerReport.ReportPath = "/SCIPA.Domain.BI.Reporting/DeviceValuesOverview";
            this.report_rvReportViewer.Size = new System.Drawing.Size(1154, 784);
            this.report_rvReportViewer.TabIndex = 41;
            // 
            // report_lbReports
            // 
            this.report_lbReports.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.report_lbReports.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.report_lbReports.FormattingEnabled = true;
            this.report_lbReports.ItemHeight = 65;
            this.report_lbReports.Items.AddRange(new object[] {
            "Values by Device Overview",
            "Values by Device Report",
            "Device Values Over Time",
            "Alarm Report",
            "Export to Excel",
            "Remove Old Values"});
            this.report_lbReports.Location = new System.Drawing.Point(53, 72);
            this.report_lbReports.Name = "report_lbReports";
            this.report_lbReports.Size = new System.Drawing.Size(713, 784);
            this.report_lbReports.TabIndex = 40;
            this.report_lbReports.SelectedIndexChanged += new System.EventHandler(this.report_lbReports_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label15.Location = new System.Drawing.Point(6, 2);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(338, 51);
            this.label15.TabIndex = 3;
            this.label15.Text = "Process Reports";
            // 
            // pAlarms
            // 
            this.pAlarms.Controls.Add(this.alarm_rbFalse);
            this.pAlarms.Controls.Add(this.alarm_rbTrue);
            this.pAlarms.Controls.Add(this.label29);
            this.pAlarms.Controls.Add(this.groupBox1);
            this.pAlarms.Controls.Add(this.alarm_Acknowledge);
            this.pAlarms.Controls.Add(this.alarm_bRule);
            this.pAlarms.Controls.Add(this.alarm_bDevice);
            this.pAlarms.Controls.Add(this.alarm_tValue);
            this.pAlarms.Controls.Add(this.label25);
            this.pAlarms.Controls.Add(this.alarm_tDateTime);
            this.pAlarms.Controls.Add(this.alarm_tDevice);
            this.pAlarms.Controls.Add(this.label26);
            this.pAlarms.Controls.Add(this.label27);
            this.pAlarms.Controls.Add(this.alarm_lbAlarms);
            this.pAlarms.Controls.Add(this.label16);
            this.pAlarms.Location = new System.Drawing.Point(10, 47);
            this.pAlarms.Name = "pAlarms";
            this.pAlarms.Size = new System.Drawing.Size(1929, 902);
            this.pAlarms.TabIndex = 5;
            this.pAlarms.Text = "Alarms";
            this.pAlarms.UseVisualStyleBackColor = true;
            // 
            // alarm_rbFalse
            // 
            this.alarm_rbFalse.AutoSize = true;
            this.alarm_rbFalse.Enabled = false;
            this.alarm_rbFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_rbFalse.Location = new System.Drawing.Point(1246, 416);
            this.alarm_rbFalse.Margin = new System.Windows.Forms.Padding(7);
            this.alarm_rbFalse.Name = "alarm_rbFalse";
            this.alarm_rbFalse.Size = new System.Drawing.Size(154, 52);
            this.alarm_rbFalse.TabIndex = 54;
            this.alarm_rbFalse.Text = "False";
            this.alarm_rbFalse.UseVisualStyleBackColor = true;
            // 
            // alarm_rbTrue
            // 
            this.alarm_rbTrue.AutoSize = true;
            this.alarm_rbTrue.Enabled = false;
            this.alarm_rbTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_rbTrue.Location = new System.Drawing.Point(1095, 416);
            this.alarm_rbTrue.Margin = new System.Windows.Forms.Padding(7);
            this.alarm_rbTrue.Name = "alarm_rbTrue";
            this.alarm_rbTrue.Size = new System.Drawing.Size(137, 52);
            this.alarm_rbTrue.TabIndex = 53;
            this.alarm_rbTrue.TabStop = true;
            this.alarm_rbTrue.Text = "True";
            this.alarm_rbTrue.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(796, 420);
            this.label29.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(303, 48);
            this.label29.TabIndex = 52;
            this.label29.Text = "Acknowledged:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.alarm_cbPeriod);
            this.groupBox1.Location = new System.Drawing.Point(788, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1119, 114);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Settings";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(973, 39);
            this.label24.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(136, 48);
            this.label24.TabIndex = 53;
            this.label24.Text = "hours.";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(10, 34);
            this.label28.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(420, 48);
            this.label28.TabIndex = 52;
            this.label28.Text = "View alarms from last";
            // 
            // alarm_cbPeriod
            // 
            this.alarm_cbPeriod.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_cbPeriod.FormattingEnabled = true;
            this.alarm_cbPeriod.Items.AddRange(new object[] {
            "1",
            "2",
            "6",
            "12",
            "24",
            "72",
            "168",
            "744",
            "8736"});
            this.alarm_cbPeriod.Location = new System.Drawing.Point(440, 32);
            this.alarm_cbPeriod.Name = "alarm_cbPeriod";
            this.alarm_cbPeriod.Size = new System.Drawing.Size(523, 59);
            this.alarm_cbPeriod.TabIndex = 0;
            this.alarm_cbPeriod.SelectedIndexChanged += new System.EventHandler(this.alarm_cbPeriod_SelectedIndexChanged);
            // 
            // alarm_Acknowledge
            // 
            this.alarm_Acknowledge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_Acknowledge.Location = new System.Drawing.Point(1047, 653);
            this.alarm_Acknowledge.Margin = new System.Windows.Forms.Padding(7);
            this.alarm_Acknowledge.Name = "alarm_Acknowledge";
            this.alarm_Acknowledge.Size = new System.Drawing.Size(648, 133);
            this.alarm_Acknowledge.TabIndex = 50;
            this.alarm_Acknowledge.Text = "Acknowledge Alarm";
            this.alarm_Acknowledge.UseVisualStyleBackColor = true;
            this.alarm_Acknowledge.Click += new System.EventHandler(this.alarm_Acknowledge_Click);
            // 
            // alarm_bRule
            // 
            this.alarm_bRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_bRule.Location = new System.Drawing.Point(1528, 513);
            this.alarm_bRule.Margin = new System.Windows.Forms.Padding(7);
            this.alarm_bRule.Name = "alarm_bRule";
            this.alarm_bRule.Size = new System.Drawing.Size(361, 85);
            this.alarm_bRule.TabIndex = 49;
            this.alarm_bRule.Text = "View Rule";
            this.alarm_bRule.UseVisualStyleBackColor = true;
            this.alarm_bRule.Click += new System.EventHandler(this.alarm_bRule_Click);
            // 
            // alarm_bDevice
            // 
            this.alarm_bDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_bDevice.Location = new System.Drawing.Point(804, 513);
            this.alarm_bDevice.Margin = new System.Windows.Forms.Padding(7);
            this.alarm_bDevice.Name = "alarm_bDevice";
            this.alarm_bDevice.Size = new System.Drawing.Size(710, 85);
            this.alarm_bDevice.TabIndex = 48;
            this.alarm_bDevice.Text = "View Device";
            this.alarm_bDevice.UseVisualStyleBackColor = true;
            this.alarm_bDevice.Click += new System.EventHandler(this.alarm_bDevice_Click);
            // 
            // alarm_tValue
            // 
            this.alarm_tValue.Enabled = false;
            this.alarm_tValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_tValue.Location = new System.Drawing.Point(1095, 347);
            this.alarm_tValue.Margin = new System.Windows.Forms.Padding(7);
            this.alarm_tValue.Name = "alarm_tValue";
            this.alarm_tValue.Size = new System.Drawing.Size(794, 55);
            this.alarm_tValue.TabIndex = 46;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(796, 354);
            this.label25.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(139, 48);
            this.label25.TabIndex = 45;
            this.label25.Text = "Value:";
            // 
            // alarm_tDateTime
            // 
            this.alarm_tDateTime.Enabled = false;
            this.alarm_tDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_tDateTime.Location = new System.Drawing.Point(1095, 278);
            this.alarm_tDateTime.Margin = new System.Windows.Forms.Padding(7);
            this.alarm_tDateTime.Name = "alarm_tDateTime";
            this.alarm_tDateTime.Size = new System.Drawing.Size(794, 55);
            this.alarm_tDateTime.TabIndex = 44;
            // 
            // alarm_tDevice
            // 
            this.alarm_tDevice.Enabled = false;
            this.alarm_tDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_tDevice.Location = new System.Drawing.Point(1095, 209);
            this.alarm_tDevice.Margin = new System.Windows.Forms.Padding(7);
            this.alarm_tDevice.Name = "alarm_tDevice";
            this.alarm_tDevice.Size = new System.Drawing.Size(794, 55);
            this.alarm_tDevice.TabIndex = 43;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(796, 285);
            this.label26.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(225, 48);
            this.label26.TabIndex = 42;
            this.label26.Text = "Date Time:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(796, 216);
            this.label27.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(160, 48);
            this.label27.TabIndex = 41;
            this.label27.Text = "Device:";
            // 
            // alarm_lbAlarms
            // 
            this.alarm_lbAlarms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.alarm_lbAlarms.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_lbAlarms.FormattingEnabled = true;
            this.alarm_lbAlarms.ItemHeight = 65;
            this.alarm_lbAlarms.Location = new System.Drawing.Point(53, 72);
            this.alarm_lbAlarms.Name = "alarm_lbAlarms";
            this.alarm_lbAlarms.Size = new System.Drawing.Size(713, 784);
            this.alarm_lbAlarms.TabIndex = 40;
            this.alarm_lbAlarms.SelectedIndexChanged += new System.EventHandler(this.alarm_lbAlarms_SelectedIndexChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label16.Location = new System.Drawing.Point(6, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(321, 51);
            this.label16.TabIndex = 4;
            this.label16.Text = "Process Alarms";
            // 
            // pSettings
            // 
            this.pSettings.Controls.Add(this.label20);
            this.pSettings.Controls.Add(this.tSettingsPassword);
            this.pSettings.Controls.Add(this.label19);
            this.pSettings.Location = new System.Drawing.Point(10, 47);
            this.pSettings.Name = "pSettings";
            this.pSettings.Size = new System.Drawing.Size(1929, 902);
            this.pSettings.TabIndex = 6;
            this.pSettings.Text = "Settings";
            this.pSettings.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(3, 384);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(1926, 51);
            this.label20.TabIndex = 6;
            this.label20.Text = "Enter Administrator Password";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tSettingsPassword
            // 
            this.tSettingsPassword.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tSettingsPassword.Location = new System.Drawing.Point(566, 450);
            this.tSettingsPassword.Name = "tSettingsPassword";
            this.tSettingsPassword.PasswordChar = '*';
            this.tSettingsPassword.Size = new System.Drawing.Size(798, 59);
            this.tSettingsPassword.TabIndex = 5;
            this.tSettingsPassword.TextChanged += new System.EventHandler(this.tSettingsPassword_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label19.Location = new System.Drawing.Point(6, 2);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(177, 51);
            this.label19.TabIndex = 4;
            this.label19.Text = "Settings";
            // 
            // pModifyCommunicators
            // 
            this.pModifyCommunicators.Controls.Add(this.modcomms_bAddNewComm);
            this.pModifyCommunicators.Controls.Add(this.modcomms_bBack);
            this.pModifyCommunicators.Controls.Add(this.modcomms_bSaveComm);
            this.pModifyCommunicators.Controls.Add(this.modcomms_tpCommType);
            this.pModifyCommunicators.Controls.Add(this.modcomms_bResetDate);
            this.pModifyCommunicators.Controls.Add(this.modcomms_rbOutbound);
            this.pModifyCommunicators.Controls.Add(this.modcomms_rbInbound);
            this.pModifyCommunicators.Controls.Add(this.label57);
            this.pModifyCommunicators.Controls.Add(this.label58);
            this.pModifyCommunicators.Controls.Add(this.modcomms_cbValueType);
            this.pModifyCommunicators.Controls.Add(this.label59);
            this.pModifyCommunicators.Controls.Add(this.label60);
            this.pModifyCommunicators.Controls.Add(this.modcomms_tLastReadTime);
            this.pModifyCommunicators.Controls.Add(this.modcomms_cbCommType);
            this.pModifyCommunicators.Controls.Add(this.modcomms_tEnd);
            this.pModifyCommunicators.Controls.Add(this.label61);
            this.pModifyCommunicators.Controls.Add(this.modcomms_tStart);
            this.pModifyCommunicators.Controls.Add(this.label62);
            this.pModifyCommunicators.Controls.Add(this.modcomms_lbComms);
            this.pModifyCommunicators.Controls.Add(this.label56);
            this.pModifyCommunicators.Location = new System.Drawing.Point(10, 47);
            this.pModifyCommunicators.Name = "pModifyCommunicators";
            this.pModifyCommunicators.Size = new System.Drawing.Size(1929, 902);
            this.pModifyCommunicators.TabIndex = 8;
            this.pModifyCommunicators.Text = "ModifyCommunicators";
            this.pModifyCommunicators.UseVisualStyleBackColor = true;
            // 
            // modcomms_bAddNewComm
            // 
            this.modcomms_bAddNewComm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.modcomms_bAddNewComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modcomms_bAddNewComm.Location = new System.Drawing.Point(37, 785);
            this.modcomms_bAddNewComm.Margin = new System.Windows.Forms.Padding(7);
            this.modcomms_bAddNewComm.Name = "modcomms_bAddNewComm";
            this.modcomms_bAddNewComm.Size = new System.Drawing.Size(526, 85);
            this.modcomms_bAddNewComm.TabIndex = 48;
            this.modcomms_bAddNewComm.Text = "Add New Communicator";
            this.modcomms_bAddNewComm.UseVisualStyleBackColor = true;
            this.modcomms_bAddNewComm.Click += new System.EventHandler(this.modcomms_bAddNewComm_Click);
            // 
            // modcomms_bBack
            // 
            this.modcomms_bBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modcomms_bBack.BackColor = System.Drawing.Color.Gainsboro;
            this.modcomms_bBack.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modcomms_bBack.Location = new System.Drawing.Point(655, 785);
            this.modcomms_bBack.Name = "modcomms_bBack";
            this.modcomms_bBack.Size = new System.Drawing.Size(612, 85);
            this.modcomms_bBack.TabIndex = 45;
            this.modcomms_bBack.Text = "GO BACK TO DEVICES";
            this.modcomms_bBack.UseVisualStyleBackColor = false;
            this.modcomms_bBack.Click += new System.EventHandler(this.modcomms_bBack_Click);
            // 
            // modcomms_bSaveComm
            // 
            this.modcomms_bSaveComm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modcomms_bSaveComm.BackColor = System.Drawing.Color.Gainsboro;
            this.modcomms_bSaveComm.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modcomms_bSaveComm.Location = new System.Drawing.Point(1273, 760);
            this.modcomms_bSaveComm.Name = "modcomms_bSaveComm";
            this.modcomms_bSaveComm.Size = new System.Drawing.Size(612, 110);
            this.modcomms_bSaveComm.TabIndex = 44;
            this.modcomms_bSaveComm.Text = "SAVE COMMUNICATOR INFORMATION";
            this.modcomms_bSaveComm.UseVisualStyleBackColor = false;
            this.modcomms_bSaveComm.Click += new System.EventHandler(this.modcomms_bSaveComm_Click);
            // 
            // modcomms_tpCommType
            // 
            this.modcomms_tpCommType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.modcomms_tpCommType.Controls.Add(this.pModBlank);
            this.modcomms_tpCommType.Controls.Add(this.pModFile);
            this.modcomms_tpCommType.Controls.Add(this.pModDatabase);
            this.modcomms_tpCommType.Controls.Add(this.pModSerial);
            this.modcomms_tpCommType.Location = new System.Drawing.Point(777, 432);
            this.modcomms_tpCommType.Name = "modcomms_tpCommType";
            this.modcomms_tpCommType.SelectedIndex = 0;
            this.modcomms_tpCommType.Size = new System.Drawing.Size(1134, 364);
            this.modcomms_tpCommType.TabIndex = 43;
            // 
            // pModBlank
            // 
            this.pModBlank.Location = new System.Drawing.Point(10, 47);
            this.pModBlank.Name = "pModBlank";
            this.pModBlank.Size = new System.Drawing.Size(1114, 307);
            this.pModBlank.TabIndex = 0;
            this.pModBlank.Text = "Blank Page";
            this.pModBlank.UseVisualStyleBackColor = true;
            // 
            // pModFile
            // 
            this.pModFile.Controls.Add(this.modcomms_tFilePath);
            this.pModFile.Controls.Add(this.label70);
            this.pModFile.Location = new System.Drawing.Point(10, 47);
            this.pModFile.Name = "pModFile";
            this.pModFile.Size = new System.Drawing.Size(1114, 307);
            this.pModFile.TabIndex = 1;
            this.pModFile.Text = "File";
            this.pModFile.UseVisualStyleBackColor = true;
            // 
            // modcomms_tFilePath
            // 
            this.modcomms_tFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modcomms_tFilePath.Location = new System.Drawing.Point(402, 15);
            this.modcomms_tFilePath.Name = "modcomms_tFilePath";
            this.modcomms_tFilePath.Size = new System.Drawing.Size(707, 55);
            this.modcomms_tFilePath.TabIndex = 26;
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label70.Location = new System.Drawing.Point(-11, 18);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(198, 48);
            this.label70.TabIndex = 25;
            this.label70.Text = "File Path:";
            // 
            // pModDatabase
            // 
            this.pModDatabase.Controls.Add(this.label67);
            this.pModDatabase.Controls.Add(this.modcomms_tQuery);
            this.pModDatabase.Controls.Add(this.modcomms_cbDatabaseType);
            this.pModDatabase.Controls.Add(this.label68);
            this.pModDatabase.Controls.Add(this.modcomms_tConnectionString);
            this.pModDatabase.Controls.Add(this.label69);
            this.pModDatabase.Location = new System.Drawing.Point(10, 47);
            this.pModDatabase.Name = "pModDatabase";
            this.pModDatabase.Size = new System.Drawing.Size(1114, 307);
            this.pModDatabase.TabIndex = 2;
            this.pModDatabase.Text = "Database";
            this.pModDatabase.UseVisualStyleBackColor = true;
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label67.Location = new System.Drawing.Point(-10, 143);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(314, 48);
            this.label67.TabIndex = 29;
            this.label67.Text = "Database Type:";
            // 
            // modcomms_tQuery
            // 
            this.modcomms_tQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modcomms_tQuery.Location = new System.Drawing.Point(404, 79);
            this.modcomms_tQuery.Name = "modcomms_tQuery";
            this.modcomms_tQuery.Size = new System.Drawing.Size(707, 55);
            this.modcomms_tQuery.TabIndex = 32;
            // 
            // modcomms_cbDatabaseType
            // 
            this.modcomms_cbDatabaseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modcomms_cbDatabaseType.FormattingEnabled = true;
            this.modcomms_cbDatabaseType.Location = new System.Drawing.Point(404, 140);
            this.modcomms_cbDatabaseType.Name = "modcomms_cbDatabaseType";
            this.modcomms_cbDatabaseType.Size = new System.Drawing.Size(707, 56);
            this.modcomms_cbDatabaseType.TabIndex = 27;
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label68.Location = new System.Drawing.Point(-10, 82);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(146, 48);
            this.label68.TabIndex = 31;
            this.label68.Text = "Query:";
            // 
            // modcomms_tConnectionString
            // 
            this.modcomms_tConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modcomms_tConnectionString.Location = new System.Drawing.Point(406, 18);
            this.modcomms_tConnectionString.Name = "modcomms_tConnectionString";
            this.modcomms_tConnectionString.Size = new System.Drawing.Size(707, 55);
            this.modcomms_tConnectionString.TabIndex = 30;
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label69.Location = new System.Drawing.Point(-8, 21);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(364, 48);
            this.label69.TabIndex = 28;
            this.label69.Text = "Connection String:";
            // 
            // pModSerial
            // 
            this.pModSerial.Controls.Add(this.label63);
            this.pModSerial.Controls.Add(this.modcomms_cbDtr);
            this.pModSerial.Controls.Add(this.modcomms_cbRts);
            this.pModSerial.Controls.Add(this.modcomms_tDataBits);
            this.pModSerial.Controls.Add(this.label64);
            this.pModSerial.Controls.Add(this.modcomms_tBaudRate);
            this.pModSerial.Controls.Add(this.modcomms_cbComPort);
            this.pModSerial.Controls.Add(this.label65);
            this.pModSerial.Controls.Add(this.label66);
            this.pModSerial.Location = new System.Drawing.Point(10, 47);
            this.pModSerial.Name = "pModSerial";
            this.pModSerial.Size = new System.Drawing.Size(1114, 307);
            this.pModSerial.TabIndex = 3;
            this.pModSerial.Text = "Serial";
            this.pModSerial.UseVisualStyleBackColor = true;
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label63.Location = new System.Drawing.Point(-12, 204);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(352, 48);
            this.label63.TabIndex = 39;
            this.label63.Text = "Optional Settings:";
            // 
            // modcomms_cbDtr
            // 
            this.modcomms_cbDtr.AutoSize = true;
            this.modcomms_cbDtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modcomms_cbDtr.Location = new System.Drawing.Point(404, 261);
            this.modcomms_cbDtr.Name = "modcomms_cbDtr";
            this.modcomms_cbDtr.Size = new System.Drawing.Size(686, 52);
            this.modcomms_cbDtr.TabIndex = 38;
            this.modcomms_cbDtr.Text = "DTR (Data Terminal Ready) Mode";
            this.modcomms_cbDtr.UseVisualStyleBackColor = true;
            // 
            // modcomms_cbRts
            // 
            this.modcomms_cbRts.AutoSize = true;
            this.modcomms_cbRts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modcomms_cbRts.Location = new System.Drawing.Point(404, 203);
            this.modcomms_cbRts.Name = "modcomms_cbRts";
            this.modcomms_cbRts.Size = new System.Drawing.Size(613, 52);
            this.modcomms_cbRts.TabIndex = 37;
            this.modcomms_cbRts.Text = "RTS (Request To Send) Mode";
            this.modcomms_cbRts.UseVisualStyleBackColor = true;
            // 
            // modcomms_tDataBits
            // 
            this.modcomms_tDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modcomms_tDataBits.Location = new System.Drawing.Point(404, 142);
            this.modcomms_tDataBits.Name = "modcomms_tDataBits";
            this.modcomms_tDataBits.Size = new System.Drawing.Size(707, 55);
            this.modcomms_tDataBits.TabIndex = 36;
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label64.Location = new System.Drawing.Point(-10, 145);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(202, 48);
            this.label64.TabIndex = 33;
            this.label64.Text = "Data Bits:";
            // 
            // modcomms_tBaudRate
            // 
            this.modcomms_tBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modcomms_tBaudRate.Location = new System.Drawing.Point(406, 81);
            this.modcomms_tBaudRate.Name = "modcomms_tBaudRate";
            this.modcomms_tBaudRate.Size = new System.Drawing.Size(707, 55);
            this.modcomms_tBaudRate.TabIndex = 35;
            // 
            // modcomms_cbComPort
            // 
            this.modcomms_cbComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modcomms_cbComPort.FormattingEnabled = true;
            this.modcomms_cbComPort.Location = new System.Drawing.Point(406, 19);
            this.modcomms_cbComPort.Name = "modcomms_cbComPort";
            this.modcomms_cbComPort.Size = new System.Drawing.Size(707, 56);
            this.modcomms_cbComPort.TabIndex = 31;
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label65.Location = new System.Drawing.Point(-8, 84);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(228, 48);
            this.label65.TabIndex = 34;
            this.label65.Text = "Baud Rate:";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label66.Location = new System.Drawing.Point(-8, 22);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(218, 48);
            this.label66.TabIndex = 32;
            this.label66.Text = "COM Port:";
            // 
            // modcomms_bResetDate
            // 
            this.modcomms_bResetDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modcomms_bResetDate.Location = new System.Drawing.Point(1730, 188);
            this.modcomms_bResetDate.Name = "modcomms_bResetDate";
            this.modcomms_bResetDate.Size = new System.Drawing.Size(196, 56);
            this.modcomms_bResetDate.TabIndex = 36;
            this.modcomms_bResetDate.Text = "Reset";
            this.modcomms_bResetDate.UseVisualStyleBackColor = true;
            this.modcomms_bResetDate.Click += new System.EventHandler(this.modcomms_bResetDate_Click);
            // 
            // modcomms_rbOutbound
            // 
            this.modcomms_rbOutbound.AutoSize = true;
            this.modcomms_rbOutbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modcomms_rbOutbound.Location = new System.Drawing.Point(1517, 374);
            this.modcomms_rbOutbound.Name = "modcomms_rbOutbound";
            this.modcomms_rbOutbound.Size = new System.Drawing.Size(333, 52);
            this.modcomms_rbOutbound.TabIndex = 35;
            this.modcomms_rbOutbound.TabStop = true;
            this.modcomms_rbOutbound.Text = "Outbound Data";
            this.modcomms_rbOutbound.UseVisualStyleBackColor = true;
            // 
            // modcomms_rbInbound
            // 
            this.modcomms_rbInbound.AutoSize = true;
            this.modcomms_rbInbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modcomms_rbInbound.Location = new System.Drawing.Point(1191, 374);
            this.modcomms_rbInbound.Name = "modcomms_rbInbound";
            this.modcomms_rbInbound.Size = new System.Drawing.Size(300, 52);
            this.modcomms_rbInbound.TabIndex = 34;
            this.modcomms_rbInbound.TabStop = true;
            this.modcomms_rbInbound.Text = "Inbound Data";
            this.modcomms_rbInbound.UseVisualStyleBackColor = true;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label57.Location = new System.Drawing.Point(767, 376);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(297, 48);
            this.label57.TabIndex = 33;
            this.label57.Text = "Data Direction:";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label58.Location = new System.Drawing.Point(769, 315);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(243, 48);
            this.label58.TabIndex = 32;
            this.label58.Text = "Value Type:";
            // 
            // modcomms_cbValueType
            // 
            this.modcomms_cbValueType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modcomms_cbValueType.FormattingEnabled = true;
            this.modcomms_cbValueType.Location = new System.Drawing.Point(1193, 312);
            this.modcomms_cbValueType.Name = "modcomms_cbValueType";
            this.modcomms_cbValueType.Size = new System.Drawing.Size(733, 56);
            this.modcomms_cbValueType.TabIndex = 31;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label59.Location = new System.Drawing.Point(769, 253);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(408, 48);
            this.label59.TabIndex = 30;
            this.label59.Text = "Communicator Type:";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label60.Location = new System.Drawing.Point(769, 192);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(326, 48);
            this.label60.TabIndex = 29;
            this.label60.Text = "Last Read Time:";
            // 
            // modcomms_tLastReadTime
            // 
            this.modcomms_tLastReadTime.Enabled = false;
            this.modcomms_tLastReadTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modcomms_tLastReadTime.Location = new System.Drawing.Point(1193, 189);
            this.modcomms_tLastReadTime.Name = "modcomms_tLastReadTime";
            this.modcomms_tLastReadTime.Size = new System.Drawing.Size(531, 55);
            this.modcomms_tLastReadTime.TabIndex = 28;
            // 
            // modcomms_cbCommType
            // 
            this.modcomms_cbCommType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modcomms_cbCommType.FormattingEnabled = true;
            this.modcomms_cbCommType.Location = new System.Drawing.Point(1193, 250);
            this.modcomms_cbCommType.Name = "modcomms_cbCommType";
            this.modcomms_cbCommType.Size = new System.Drawing.Size(733, 56);
            this.modcomms_cbCommType.TabIndex = 27;
            this.modcomms_cbCommType.SelectedIndexChanged += new System.EventHandler(this.modcomms_cbCommType_SelectedIndexChanged);
            // 
            // modcomms_tEnd
            // 
            this.modcomms_tEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modcomms_tEnd.Location = new System.Drawing.Point(1193, 128);
            this.modcomms_tEnd.Name = "modcomms_tEnd";
            this.modcomms_tEnd.Size = new System.Drawing.Size(733, 55);
            this.modcomms_tEnd.TabIndex = 26;
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label61.Location = new System.Drawing.Point(769, 131);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(207, 48);
            this.label61.TabIndex = 25;
            this.label61.Text = "End Char:";
            // 
            // modcomms_tStart
            // 
            this.modcomms_tStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modcomms_tStart.Location = new System.Drawing.Point(1193, 67);
            this.modcomms_tStart.Name = "modcomms_tStart";
            this.modcomms_tStart.Size = new System.Drawing.Size(733, 55);
            this.modcomms_tStart.TabIndex = 24;
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label62.Location = new System.Drawing.Point(769, 70);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(222, 48);
            this.label62.TabIndex = 23;
            this.label62.Text = "Start Char:";
            // 
            // modcomms_lbComms
            // 
            this.modcomms_lbComms.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.modcomms_lbComms.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modcomms_lbComms.FormattingEnabled = true;
            this.modcomms_lbComms.ItemHeight = 65;
            this.modcomms_lbComms.Location = new System.Drawing.Point(50, 70);
            this.modcomms_lbComms.Name = "modcomms_lbComms";
            this.modcomms_lbComms.Size = new System.Drawing.Size(713, 784);
            this.modcomms_lbComms.TabIndex = 6;
            this.modcomms_lbComms.SelectedIndexChanged += new System.EventHandler(this.modcomms_lbComms_SelectedIndexChanged);
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label56.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label56.Location = new System.Drawing.Point(3, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(652, 51);
            this.label56.TabIndex = 5;
            this.label56.Text = "Modify Communicator Settings";
            // 
            // pModifyRules
            // 
            this.pModifyRules.Controls.Add(this.modrules_bSetAction);
            this.pModifyRules.Controls.Add(this.label77);
            this.pModifyRules.Controls.Add(this.modrules_cAlarm);
            this.pModifyRules.Controls.Add(this.modrules_tConstraint);
            this.pModifyRules.Controls.Add(this.label76);
            this.pModifyRules.Controls.Add(this.label75);
            this.pModifyRules.Controls.Add(this.modrules_cbRuleType);
            this.pModifyRules.Controls.Add(this.label74);
            this.pModifyRules.Controls.Add(this.modrules_cbValueType);
            this.pModifyRules.Controls.Add(this.modrules_tBack);
            this.pModifyRules.Controls.Add(this.modrules_tSave);
            this.pModifyRules.Controls.Add(this.modrules_Name);
            this.pModifyRules.Controls.Add(this.label71);
            this.pModifyRules.Controls.Add(this.modrules_lbRules);
            this.pModifyRules.Controls.Add(this.label73);
            this.pModifyRules.Location = new System.Drawing.Point(10, 47);
            this.pModifyRules.Name = "pModifyRules";
            this.pModifyRules.Size = new System.Drawing.Size(1929, 902);
            this.pModifyRules.TabIndex = 9;
            this.pModifyRules.Text = "Modify Rules";
            this.pModifyRules.UseVisualStyleBackColor = true;
            // 
            // modrules_bSetAction
            // 
            this.modrules_bSetAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modrules_bSetAction.Location = new System.Drawing.Point(1095, 429);
            this.modrules_bSetAction.Name = "modrules_bSetAction";
            this.modrules_bSetAction.Size = new System.Drawing.Size(444, 102);
            this.modrules_bSetAction.TabIndex = 60;
            this.modrules_bSetAction.Text = "Set Action";
            this.modrules_bSetAction.UseVisualStyleBackColor = true;
            this.modrules_bSetAction.Click += new System.EventHandler(this.modrules_bSetAction_Click);
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label77.Location = new System.Drawing.Point(769, 317);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(277, 48);
            this.label77.TabIndex = 59;
            this.label77.Text = "Alarm Option:";
            // 
            // modrules_cAlarm
            // 
            this.modrules_cAlarm.AutoSize = true;
            this.modrules_cAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modrules_cAlarm.Location = new System.Drawing.Point(1193, 313);
            this.modrules_cAlarm.Name = "modrules_cAlarm";
            this.modrules_cAlarm.Size = new System.Drawing.Size(480, 52);
            this.modrules_cAlarm.TabIndex = 58;
            this.modrules_cAlarm.Text = "Alarm On Criteria Pass";
            this.modrules_cAlarm.UseVisualStyleBackColor = true;
            // 
            // modrules_tConstraint
            // 
            this.modrules_tConstraint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modrules_tConstraint.Location = new System.Drawing.Point(1193, 252);
            this.modrules_tConstraint.Name = "modrules_tConstraint";
            this.modrules_tConstraint.Size = new System.Drawing.Size(733, 55);
            this.modrules_tConstraint.TabIndex = 57;
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label76.Location = new System.Drawing.Point(769, 255);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(223, 48);
            this.label76.TabIndex = 56;
            this.label76.Text = "Constraint:";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label75.Location = new System.Drawing.Point(769, 193);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(222, 48);
            this.label75.TabIndex = 55;
            this.label75.Text = "Rule Type:";
            // 
            // modrules_cbRuleType
            // 
            this.modrules_cbRuleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modrules_cbRuleType.FormattingEnabled = true;
            this.modrules_cbRuleType.Location = new System.Drawing.Point(1193, 190);
            this.modrules_cbRuleType.Name = "modrules_cbRuleType";
            this.modrules_cbRuleType.Size = new System.Drawing.Size(733, 56);
            this.modrules_cbRuleType.TabIndex = 54;
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label74.Location = new System.Drawing.Point(769, 131);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(372, 48);
            this.label74.TabIndex = 53;
            this.label74.Text = "Check Value Type:";
            // 
            // modrules_cbValueType
            // 
            this.modrules_cbValueType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modrules_cbValueType.FormattingEnabled = true;
            this.modrules_cbValueType.Location = new System.Drawing.Point(1193, 128);
            this.modrules_cbValueType.Name = "modrules_cbValueType";
            this.modrules_cbValueType.Size = new System.Drawing.Size(733, 56);
            this.modrules_cbValueType.TabIndex = 52;
            this.modrules_cbValueType.SelectedIndexChanged += new System.EventHandler(this.modrules_cbValueType_SelectedIndexChanged);
            // 
            // modrules_tBack
            // 
            this.modrules_tBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modrules_tBack.BackColor = System.Drawing.Color.Gainsboro;
            this.modrules_tBack.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modrules_tBack.Location = new System.Drawing.Point(655, 785);
            this.modrules_tBack.Name = "modrules_tBack";
            this.modrules_tBack.Size = new System.Drawing.Size(612, 85);
            this.modrules_tBack.TabIndex = 51;
            this.modrules_tBack.Text = "GO BACK TO DEVICES";
            this.modrules_tBack.UseVisualStyleBackColor = false;
            this.modrules_tBack.Click += new System.EventHandler(this.modrules_tBack_Click);
            // 
            // modrules_tSave
            // 
            this.modrules_tSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modrules_tSave.BackColor = System.Drawing.Color.Gainsboro;
            this.modrules_tSave.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modrules_tSave.Location = new System.Drawing.Point(1273, 760);
            this.modrules_tSave.Name = "modrules_tSave";
            this.modrules_tSave.Size = new System.Drawing.Size(612, 110);
            this.modrules_tSave.TabIndex = 50;
            this.modrules_tSave.Text = "SAVE RULE INFORMATION";
            this.modrules_tSave.UseVisualStyleBackColor = false;
            this.modrules_tSave.Click += new System.EventHandler(this.modrules_tSave_Click);
            // 
            // modrules_Name
            // 
            this.modrules_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modrules_Name.Location = new System.Drawing.Point(1193, 67);
            this.modrules_Name.Name = "modrules_Name";
            this.modrules_Name.Size = new System.Drawing.Size(733, 55);
            this.modrules_Name.TabIndex = 49;
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label71.Location = new System.Drawing.Point(769, 70);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(143, 48);
            this.label71.TabIndex = 48;
            this.label71.Text = "Name:";
            // 
            // modrules_lbRules
            // 
            this.modrules_lbRules.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.modrules_lbRules.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modrules_lbRules.FormattingEnabled = true;
            this.modrules_lbRules.ItemHeight = 65;
            this.modrules_lbRules.Location = new System.Drawing.Point(50, 70);
            this.modrules_lbRules.Name = "modrules_lbRules";
            this.modrules_lbRules.Size = new System.Drawing.Size(713, 784);
            this.modrules_lbRules.TabIndex = 47;
            this.modrules_lbRules.SelectedIndexChanged += new System.EventHandler(this.modrules_lbRules_SelectedIndexChanged);
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label73.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label73.Location = new System.Drawing.Point(3, 0);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(276, 51);
            this.label73.TabIndex = 46;
            this.label73.Text = "Modify Rules";
            // 
            // pModifyActions
            // 
            this.pModifyActions.Controls.Add(this.modact_tComm);
            this.pModifyActions.Controls.Add(this.modact_bNewComm);
            this.pModifyActions.Controls.Add(this.label78);
            this.pModifyActions.Controls.Add(this.modact_cEnabled);
            this.pModifyActions.Controls.Add(this.modact_tValue);
            this.pModifyActions.Controls.Add(this.label79);
            this.pModifyActions.Controls.Add(this.label80);
            this.pModifyActions.Controls.Add(this.modact_bBack);
            this.pModifyActions.Controls.Add(this.modact_bSave);
            this.pModifyActions.Controls.Add(this.modact_tRule);
            this.pModifyActions.Controls.Add(this.label81);
            this.pModifyActions.Controls.Add(this.label82);
            this.pModifyActions.Location = new System.Drawing.Point(10, 47);
            this.pModifyActions.Name = "pModifyActions";
            this.pModifyActions.Size = new System.Drawing.Size(1929, 902);
            this.pModifyActions.TabIndex = 10;
            this.pModifyActions.Text = "ModifyActions";
            this.pModifyActions.UseVisualStyleBackColor = true;
            // 
            // modact_tComm
            // 
            this.modact_tComm.Enabled = false;
            this.modact_tComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modact_tComm.Location = new System.Drawing.Point(835, 244);
            this.modact_tComm.Name = "modact_tComm";
            this.modact_tComm.Size = new System.Drawing.Size(530, 55);
            this.modact_tComm.TabIndex = 72;
            // 
            // modact_bNewComm
            // 
            this.modact_bNewComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modact_bNewComm.Location = new System.Drawing.Point(1371, 244);
            this.modact_bNewComm.Name = "modact_bNewComm";
            this.modact_bNewComm.Size = new System.Drawing.Size(197, 56);
            this.modact_bNewComm.TabIndex = 71;
            this.modact_bNewComm.Text = "New";
            this.modact_bNewComm.UseVisualStyleBackColor = true;
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label78.Location = new System.Drawing.Point(411, 433);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(156, 48);
            this.label78.TabIndex = 70;
            this.label78.Text = "Option:";
            // 
            // modact_cEnabled
            // 
            this.modact_cEnabled.AutoSize = true;
            this.modact_cEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modact_cEnabled.Location = new System.Drawing.Point(835, 429);
            this.modact_cEnabled.Name = "modact_cEnabled";
            this.modact_cEnabled.Size = new System.Drawing.Size(205, 52);
            this.modact_cEnabled.TabIndex = 69;
            this.modact_cEnabled.Text = "Enabled";
            this.modact_cEnabled.UseVisualStyleBackColor = true;
            // 
            // modact_tValue
            // 
            this.modact_tValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modact_tValue.Location = new System.Drawing.Point(835, 368);
            this.modact_tValue.Name = "modact_tValue";
            this.modact_tValue.Size = new System.Drawing.Size(733, 55);
            this.modact_tValue.TabIndex = 68;
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label79.Location = new System.Drawing.Point(411, 371);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(276, 48);
            this.label79.TabIndex = 67;
            this.label79.Text = "Output Value:";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label80.Location = new System.Drawing.Point(411, 247);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(304, 48);
            this.label80.TabIndex = 66;
            this.label80.Text = "Communicator:";
            // 
            // modact_bBack
            // 
            this.modact_bBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modact_bBack.BackColor = System.Drawing.Color.Gainsboro;
            this.modact_bBack.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modact_bBack.Location = new System.Drawing.Point(655, 785);
            this.modact_bBack.Name = "modact_bBack";
            this.modact_bBack.Size = new System.Drawing.Size(612, 85);
            this.modact_bBack.TabIndex = 64;
            this.modact_bBack.Text = "GO BACK TO DEVICES";
            this.modact_bBack.UseVisualStyleBackColor = false;
            this.modact_bBack.Click += new System.EventHandler(this.modact_bBack_Click);
            // 
            // modact_bSave
            // 
            this.modact_bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.modact_bSave.BackColor = System.Drawing.Color.Gainsboro;
            this.modact_bSave.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modact_bSave.Location = new System.Drawing.Point(1273, 760);
            this.modact_bSave.Name = "modact_bSave";
            this.modact_bSave.Size = new System.Drawing.Size(612, 110);
            this.modact_bSave.TabIndex = 63;
            this.modact_bSave.Text = "SAVE RULE INFORMATION";
            this.modact_bSave.UseVisualStyleBackColor = false;
            this.modact_bSave.Click += new System.EventHandler(this.modact_bSave_Click);
            // 
            // modact_tRule
            // 
            this.modact_tRule.Enabled = false;
            this.modact_tRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.modact_tRule.Location = new System.Drawing.Point(835, 183);
            this.modact_tRule.Name = "modact_tRule";
            this.modact_tRule.Size = new System.Drawing.Size(733, 55);
            this.modact_tRule.TabIndex = 62;
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label81.Location = new System.Drawing.Point(411, 186);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(118, 48);
            this.label81.TabIndex = 61;
            this.label81.Text = "Rule:";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label82.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label82.Location = new System.Drawing.Point(3, 0);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(306, 51);
            this.label82.TabIndex = 60;
            this.label82.Text = "Modify Action";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SCIPA.UI.HMI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1972, 1221);
            this.Controls.Add(this.bTogglePanelSize_Status);
            this.Controls.Add(this.pTabPanel);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.pButtonPannel);
            this.Controls.Add(this.pHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCIPA Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AlarmsBindingSource)).EndInit();
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.pButtonPannel.ResumeLayout(false);
            this.pButtonPannel.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.pTabPanel.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.pStart.ResumeLayout(false);
            this.pStart.PerformLayout();
            this.pStop.ResumeLayout(false);
            this.pStop.PerformLayout();
            this.pAddNewDevice.ResumeLayout(false);
            this.pAddNewDevice.PerformLayout();
            this.pModifyDevice.ResumeLayout(false);
            this.pModifyDevice.PerformLayout();
            this.pReports.ResumeLayout(false);
            this.pReports.PerformLayout();
            this.pAlarms.ResumeLayout(false);
            this.pAlarms.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pSettings.ResumeLayout(false);
            this.pSettings.PerformLayout();
            this.pModifyCommunicators.ResumeLayout(false);
            this.pModifyCommunicators.PerformLayout();
            this.modcomms_tpCommType.ResumeLayout(false);
            this.pModFile.ResumeLayout(false);
            this.pModFile.PerformLayout();
            this.pModDatabase.ResumeLayout(false);
            this.pModDatabase.PerformLayout();
            this.pModSerial.ResumeLayout(false);
            this.pModSerial.PerformLayout();
            this.pModifyRules.ResumeLayout(false);
            this.pModifyRules.PerformLayout();
            this.pModifyActions.ResumeLayout(false);
            this.pModifyActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pHeader;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lScipa;
        private System.Windows.Forms.Label lHeaderAlarmCount;
        private System.Windows.Forms.Label lSeperator;
        private System.Windows.Forms.Button bStartProcess;
        private System.Windows.Forms.Button bStopProcess;
        private System.Windows.Forms.Button bAddNew;
        private System.Windows.Forms.Button bModify;
        private System.Windows.Forms.Button bReports;
        private System.Windows.Forms.Button bAlarms;
        private System.Windows.Forms.Panel pButtonPannel;
        private CustomTabControl pTabPanel;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel lStatusMessage;
        private System.Windows.Forms.TabPage pStart;
        private System.Windows.Forms.TabPage pStop;
        private System.Windows.Forms.TabPage pAddNewDevice;
        private System.Windows.Forms.TabPage pModifyDevice;
        private System.Windows.Forms.TabPage pReports;
        private System.Windows.Forms.TabPage pAlarms;
        private System.Windows.Forms.ToolStripStatusLabel lStaticMessage;
        private System.Windows.Forms.ToolStripStatusLabel lStatusPreceder;
        private System.Windows.Forms.Label lHeader_Add;
        private System.Windows.Forms.Button bTogglePanelSize_Status;
        private System.Windows.Forms.Label add_lRules;
        private System.Windows.Forms.Button add_bAddRule;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label add_lSource;
        private System.Windows.Forms.Button add_bAddSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton add_rbFalse;
        private System.Windows.Forms.RadioButton add_rbTrue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox add_tLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox add_tCustodian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox add_tName;
        private System.Windows.Forms.TextBox add_tId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Button bSettings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add_bClearNewDevice;
        private System.Windows.Forms.Button add_bSaveNewDevice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox modify_lbDeviceList;
        private System.Windows.Forms.Button modify_bRules;
        private System.Windows.Forms.Button modify_bComms;
        private System.Windows.Forms.Button modify_bClear;
        private System.Windows.Forms.Button modify_bSave;
        private System.Windows.Forms.RadioButton modify_rbFalse;
        private System.Windows.Forms.RadioButton modify_rbTrue;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox modify_tLocation;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox modify_tCustodian;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox modify_tDevName;
        private System.Windows.Forms.TextBox modify_tId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage pSettings;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tSettingsPassword;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button start_bStart;
        private System.Windows.Forms.ListBox start_lbDevice;
        private System.Windows.Forms.TextBox start_tDevName;
        private System.Windows.Forms.TextBox start_tId;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox stop_tDevName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListBox stop_lbDevice;
        private Microsoft.Reporting.WinForms.ReportViewer report_rvReportViewer;
        private System.Windows.Forms.ListBox report_lbReports;
        private System.Windows.Forms.ListBox alarm_lbAlarms;
        private System.Windows.Forms.RadioButton alarm_rbFalse;
        private System.Windows.Forms.RadioButton alarm_rbTrue;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox alarm_cbPeriod;
        private System.Windows.Forms.Button alarm_Acknowledge;
        private System.Windows.Forms.Button alarm_bRule;
        private System.Windows.Forms.Button alarm_bDevice;
        private System.Windows.Forms.TextBox alarm_tValue;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox alarm_tDateTime;
        private System.Windows.Forms.TextBox alarm_tDevice;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox start_tLocation;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.TextBox start_tCustodian;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox stop_tLocation;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox stop_tCustodian;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.BindingSource AlarmsBindingSource;
        private System.Windows.Forms.TabPage pModifyCommunicators;
        private System.Windows.Forms.ListBox modcomms_lbComms;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.TabPage pModifyRules;
        private System.Windows.Forms.TabPage pModifyActions;
        private CustomTabControl modcomms_tpCommType;
        private System.Windows.Forms.TabPage pModBlank;
        private System.Windows.Forms.TabPage pModFile;
        private System.Windows.Forms.TabPage pModDatabase;
        private System.Windows.Forms.TabPage pModSerial;
        private System.Windows.Forms.Button modcomms_bResetDate;
        private System.Windows.Forms.RadioButton modcomms_rbOutbound;
        private System.Windows.Forms.RadioButton modcomms_rbInbound;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.ComboBox modcomms_cbValueType;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.TextBox modcomms_tLastReadTime;
        private System.Windows.Forms.ComboBox modcomms_cbCommType;
        private System.Windows.Forms.TextBox modcomms_tEnd;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.TextBox modcomms_tStart;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.CheckBox modcomms_cbDtr;
        private System.Windows.Forms.CheckBox modcomms_cbRts;
        private System.Windows.Forms.TextBox modcomms_tDataBits;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.TextBox modcomms_tBaudRate;
        private System.Windows.Forms.ComboBox modcomms_cbComPort;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.TextBox modcomms_tQuery;
        private System.Windows.Forms.ComboBox modcomms_cbDatabaseType;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.TextBox modcomms_tConnectionString;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.TextBox modcomms_tFilePath;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Button modcomms_bSaveComm;
        private System.Windows.Forms.Button modcomms_bBack;
        private System.Windows.Forms.Label add_lActions;
        private System.Windows.Forms.Button add_bNewAction;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Button modrules_bSetAction;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.CheckBox modrules_cAlarm;
        private System.Windows.Forms.TextBox modrules_tConstraint;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.ComboBox modrules_cbRuleType;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.ComboBox modrules_cbValueType;
        private System.Windows.Forms.Button modrules_tBack;
        private System.Windows.Forms.Button modrules_tSave;
        private System.Windows.Forms.TextBox modrules_Name;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.ListBox modrules_lbRules;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.CheckBox modact_cEnabled;
        private System.Windows.Forms.TextBox modact_tValue;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Button modact_bBack;
        private System.Windows.Forms.Button modact_bSave;
        private System.Windows.Forms.TextBox modact_tRule;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Button modact_bNewComm;
        private System.Windows.Forms.TextBox modact_tComm;
        private System.Windows.Forms.ListBox stop_lbValues;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button modcomms_bAddNewComm;
    }
}

