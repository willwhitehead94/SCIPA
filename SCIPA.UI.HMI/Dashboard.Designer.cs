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
            this.SCIPAAlarmDataSet = new SCIPA.UI.HMI.SCIPAAlarmDataSet();
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
            this.AlarmsTableAdapter = new SCIPA.UI.HMI.SCIPAAlarmDataSetTableAdapters.AlarmsTableAdapter();
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
            this.stop_tLocation = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.stop_tCustodian = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.stop_tDevName = new System.Windows.Forms.TextBox();
            this.stop_tId = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.stop_bStop = new System.Windows.Forms.Button();
            this.stop_lbDevice = new System.Windows.Forms.ListBox();
            this.label18 = new System.Windows.Forms.Label();
            this.pAddNewDevice = new System.Windows.Forms.TabPage();
            this.add_tcInnerPages = new SCIPA.UI.HMI.CustomTabControl();
            this.Blank = new System.Windows.Forms.TabPage();
            this.pDataConnection = new System.Windows.Forms.TabPage();
            this.add_rbCommOutbound = new System.Windows.Forms.RadioButton();
            this.add_rbCommInbound = new System.Windows.Forms.RadioButton();
            this.add_bSaveSource = new System.Windows.Forms.Button();
            this.add_tcInnerPagesSourceSetting = new SCIPA.UI.HMI.CustomTabControl();
            this.pFlatFile = new System.Windows.Forms.TabPage();
            this.add_tFilePath = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.pSerial = new System.Windows.Forms.TabPage();
            this.add_bRefreshComPorts = new System.Windows.Forms.Button();
            this.add_cbDtr = new System.Windows.Forms.CheckBox();
            this.add_cbRts = new System.Windows.Forms.CheckBox();
            this.add_tDataBits = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.add_tBaudRate = new System.Windows.Forms.TextBox();
            this.add_cbComPort = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.pDatabase = new System.Windows.Forms.TabPage();
            this.add_cbDatabaseType = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.add_tQuery = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.add_tConnectionString = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.add_cbValueType = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.add_cbCommType = new System.Windows.Forms.ComboBox();
            this.add_tEnd = new System.Windows.Forms.TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.add_tStartChar = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.pRules = new System.Windows.Forms.TabPage();
            this.add_bAddAction = new System.Windows.Forms.Button();
            this.add_bSaveRule = new System.Windows.Forms.Button();
            this.add_cbRuleCheckValue = new System.Windows.Forms.ComboBox();
            this.label53 = new System.Windows.Forms.Label();
            this.add_cAlarm = new System.Windows.Forms.CheckBox();
            this.add_cbRuleType = new System.Windows.Forms.ComboBox();
            this.label45 = new System.Windows.Forms.Label();
            this.add_tConstraint = new System.Windows.Forms.TextBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.add_tRuleName = new System.Windows.Forms.TextBox();
            this.label52 = new System.Windows.Forms.Label();
            this.pActions = new System.Windows.Forms.TabPage();
            this.add_cActionEnabled = new System.Windows.Forms.CheckBox();
            this.label55 = new System.Windows.Forms.Label();
            this.add_tOutputValue = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.add_cbCommunicatorDestination = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.add_cbRule = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
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
            this.modify_bActions = new System.Windows.Forms.Button();
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
            this.label28 = new System.Windows.Forms.Label();
            this.alarm_cbPeriod = new System.Windows.Forms.ComboBox();
            this.alarm_Acknowledge = new System.Windows.Forms.Button();
            this.alarm_Rule = new System.Windows.Forms.Button();
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
            this.pModifyActions = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.AlarmsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SCIPAAlarmDataSet)).BeginInit();
            this.pHeader.SuspendLayout();
            this.pButtonPannel.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.pTabPanel.SuspendLayout();
            this.Home.SuspendLayout();
            this.pStart.SuspendLayout();
            this.pStop.SuspendLayout();
            this.pAddNewDevice.SuspendLayout();
            this.add_tcInnerPages.SuspendLayout();
            this.pDataConnection.SuspendLayout();
            this.add_tcInnerPagesSourceSetting.SuspendLayout();
            this.pFlatFile.SuspendLayout();
            this.pSerial.SuspendLayout();
            this.pDatabase.SuspendLayout();
            this.pRules.SuspendLayout();
            this.pActions.SuspendLayout();
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
            this.SuspendLayout();
            // 
            // AlarmsBindingSource
            // 
            this.AlarmsBindingSource.DataMember = "Alarms";
            this.AlarmsBindingSource.DataSource = this.SCIPAAlarmDataSet;
            // 
            // SCIPAAlarmDataSet
            // 
            this.SCIPAAlarmDataSet.DataSetName = "SCIPAAlarmDataSet";
            this.SCIPAAlarmDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.bStopProcess.Text = "STOP DEVICE PROCESSES";
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
            // AlarmsTableAdapter
            // 
            this.AlarmsTableAdapter.ClearBeforeFill = true;
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
            this.pStop.Controls.Add(this.stop_tLocation);
            this.pStop.Controls.Add(this.label33);
            this.pStop.Controls.Add(this.stop_tCustodian);
            this.pStop.Controls.Add(this.label34);
            this.pStop.Controls.Add(this.stop_tDevName);
            this.pStop.Controls.Add(this.stop_tId);
            this.pStop.Controls.Add(this.label23);
            this.pStop.Controls.Add(this.label24);
            this.pStop.Controls.Add(this.stop_bStop);
            this.pStop.Controls.Add(this.stop_lbDevice);
            this.pStop.Controls.Add(this.label18);
            this.pStop.Location = new System.Drawing.Point(10, 47);
            this.pStop.Name = "pStop";
            this.pStop.Size = new System.Drawing.Size(1929, 902);
            this.pStop.TabIndex = 1;
            this.pStop.Text = "StopProcess";
            this.pStop.UseVisualStyleBackColor = true;
            // 
            // stop_tLocation
            // 
            this.stop_tLocation.Enabled = false;
            this.stop_tLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_tLocation.Location = new System.Drawing.Point(1099, 203);
            this.stop_tLocation.Margin = new System.Windows.Forms.Padding(7);
            this.stop_tLocation.Name = "stop_tLocation";
            this.stop_tLocation.Size = new System.Drawing.Size(799, 55);
            this.stop_tLocation.TabIndex = 48;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(800, 210);
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
            this.stop_tCustodian.Location = new System.Drawing.Point(1099, 272);
            this.stop_tCustodian.Margin = new System.Windows.Forms.Padding(7);
            this.stop_tCustodian.Name = "stop_tCustodian";
            this.stop_tCustodian.Size = new System.Drawing.Size(799, 55);
            this.stop_tCustodian.TabIndex = 46;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(800, 279);
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
            this.stop_tDevName.Location = new System.Drawing.Point(1099, 134);
            this.stop_tDevName.Margin = new System.Windows.Forms.Padding(7);
            this.stop_tDevName.Name = "stop_tDevName";
            this.stop_tDevName.Size = new System.Drawing.Size(799, 55);
            this.stop_tDevName.TabIndex = 44;
            // 
            // stop_tId
            // 
            this.stop_tId.Enabled = false;
            this.stop_tId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_tId.Location = new System.Drawing.Point(1099, 65);
            this.stop_tId.Margin = new System.Windows.Forms.Padding(7);
            this.stop_tId.Name = "stop_tId";
            this.stop_tId.Size = new System.Drawing.Size(799, 55);
            this.stop_tId.TabIndex = 43;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(800, 141);
            this.label23.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(282, 48);
            this.label23.TabIndex = 42;
            this.label23.Text = "Device Name:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(800, 72);
            this.label24.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(233, 48);
            this.label24.TabIndex = 41;
            this.label24.Text = "ID Number:";
            // 
            // stop_bStop
            // 
            this.stop_bStop.Enabled = false;
            this.stop_bStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop_bStop.Location = new System.Drawing.Point(876, 393);
            this.stop_bStop.Margin = new System.Windows.Forms.Padding(7);
            this.stop_bStop.Name = "stop_bStop";
            this.stop_bStop.Size = new System.Drawing.Size(960, 128);
            this.stop_bStop.TabIndex = 40;
            this.stop_bStop.Text = "Stop Selected Device";
            this.stop_bStop.UseVisualStyleBackColor = true;
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
            this.label18.Size = new System.Drawing.Size(729, 51);
            this.label18.TabIndex = 4;
            this.label18.Text = "Stop Process Monitoring by Device";
            // 
            // pAddNewDevice
            // 
            this.pAddNewDevice.AutoScroll = true;
            this.pAddNewDevice.Controls.Add(this.add_tcInnerPages);
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
            // add_tcInnerPages
            // 
            this.add_tcInnerPages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.add_tcInnerPages.Controls.Add(this.Blank);
            this.add_tcInnerPages.Controls.Add(this.pDataConnection);
            this.add_tcInnerPages.Controls.Add(this.pRules);
            this.add_tcInnerPages.Controls.Add(this.pActions);
            this.add_tcInnerPages.Location = new System.Drawing.Point(1006, 3);
            this.add_tcInnerPages.Name = "add_tcInnerPages";
            this.add_tcInnerPages.SelectedIndex = 0;
            this.add_tcInnerPages.Size = new System.Drawing.Size(920, 739);
            this.add_tcInnerPages.TabIndex = 42;
            // 
            // Blank
            // 
            this.Blank.Location = new System.Drawing.Point(10, 47);
            this.Blank.Name = "Blank";
            this.Blank.Size = new System.Drawing.Size(900, 682);
            this.Blank.TabIndex = 3;
            this.Blank.Text = "tBlank";
            this.Blank.UseVisualStyleBackColor = true;
            // 
            // pDataConnection
            // 
            this.pDataConnection.AutoScroll = true;
            this.pDataConnection.Controls.Add(this.add_rbCommOutbound);
            this.pDataConnection.Controls.Add(this.add_rbCommInbound);
            this.pDataConnection.Controls.Add(this.add_bSaveSource);
            this.pDataConnection.Controls.Add(this.add_tcInnerPagesSourceSetting);
            this.pDataConnection.Controls.Add(this.label46);
            this.pDataConnection.Controls.Add(this.add_cbValueType);
            this.pDataConnection.Controls.Add(this.label47);
            this.pDataConnection.Controls.Add(this.add_cbCommType);
            this.pDataConnection.Controls.Add(this.add_tEnd);
            this.pDataConnection.Controls.Add(this.label49);
            this.pDataConnection.Controls.Add(this.add_tStartChar);
            this.pDataConnection.Controls.Add(this.label50);
            this.pDataConnection.Controls.Add(this.label36);
            this.pDataConnection.Location = new System.Drawing.Point(10, 47);
            this.pDataConnection.Name = "pDataConnection";
            this.pDataConnection.Size = new System.Drawing.Size(900, 682);
            this.pDataConnection.TabIndex = 0;
            this.pDataConnection.Text = "Data Connections";
            this.pDataConnection.UseVisualStyleBackColor = true;
            this.pDataConnection.Click += new System.EventHandler(this.pSources_Click);
            // 
            // add_rbCommOutbound
            // 
            this.add_rbCommOutbound.AutoSize = true;
            this.add_rbCommOutbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_rbCommOutbound.Location = new System.Drawing.Point(435, 317);
            this.add_rbCommOutbound.Name = "add_rbCommOutbound";
            this.add_rbCommOutbound.Size = new System.Drawing.Size(333, 52);
            this.add_rbCommOutbound.TabIndex = 46;
            this.add_rbCommOutbound.TabStop = true;
            this.add_rbCommOutbound.Text = "Outbound Data";
            this.add_rbCommOutbound.UseVisualStyleBackColor = true;
            // 
            // add_rbCommInbound
            // 
            this.add_rbCommInbound.AutoSize = true;
            this.add_rbCommInbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_rbCommInbound.Location = new System.Drawing.Point(117, 317);
            this.add_rbCommInbound.Name = "add_rbCommInbound";
            this.add_rbCommInbound.Size = new System.Drawing.Size(300, 52);
            this.add_rbCommInbound.TabIndex = 45;
            this.add_rbCommInbound.TabStop = true;
            this.add_rbCommInbound.Text = "Inbound Data";
            this.add_rbCommInbound.UseVisualStyleBackColor = true;
            // 
            // add_bSaveSource
            // 
            this.add_bSaveSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_bSaveSource.Location = new System.Drawing.Point(321, 653);
            this.add_bSaveSource.Name = "add_bSaveSource";
            this.add_bSaveSource.Size = new System.Drawing.Size(295, 98);
            this.add_bSaveSource.TabIndex = 44;
            this.add_bSaveSource.Text = "Save Source";
            this.add_bSaveSource.UseVisualStyleBackColor = true;
            this.add_bSaveSource.Click += new System.EventHandler(this.add_bSaveSource_Click);
            // 
            // add_tcInnerPagesSourceSetting
            // 
            this.add_tcInnerPagesSourceSetting.Controls.Add(this.pFlatFile);
            this.add_tcInnerPagesSourceSetting.Controls.Add(this.pSerial);
            this.add_tcInnerPagesSourceSetting.Controls.Add(this.pDatabase);
            this.add_tcInnerPagesSourceSetting.Location = new System.Drawing.Point(21, 377);
            this.add_tcInnerPagesSourceSetting.Name = "add_tcInnerPagesSourceSetting";
            this.add_tcInnerPagesSourceSetting.SelectedIndex = 0;
            this.add_tcInnerPagesSourceSetting.Size = new System.Drawing.Size(847, 390);
            this.add_tcInnerPagesSourceSetting.TabIndex = 35;
            // 
            // pFlatFile
            // 
            this.pFlatFile.Controls.Add(this.add_tFilePath);
            this.pFlatFile.Controls.Add(this.label44);
            this.pFlatFile.Location = new System.Drawing.Point(10, 47);
            this.pFlatFile.Name = "pFlatFile";
            this.pFlatFile.Size = new System.Drawing.Size(827, 333);
            this.pFlatFile.TabIndex = 0;
            this.pFlatFile.Text = "Flat File";
            this.pFlatFile.UseVisualStyleBackColor = true;
            // 
            // add_tFilePath
            // 
            this.add_tFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_tFilePath.Location = new System.Drawing.Point(241, 3);
            this.add_tFilePath.Name = "add_tFilePath";
            this.add_tFilePath.Size = new System.Drawing.Size(596, 55);
            this.add_tFilePath.TabIndex = 26;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label44.Location = new System.Drawing.Point(-3, 6);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(198, 48);
            this.label44.TabIndex = 25;
            this.label44.Text = "File Path:";
            // 
            // pSerial
            // 
            this.pSerial.Controls.Add(this.add_bRefreshComPorts);
            this.pSerial.Controls.Add(this.add_cbDtr);
            this.pSerial.Controls.Add(this.add_cbRts);
            this.pSerial.Controls.Add(this.add_tDataBits);
            this.pSerial.Controls.Add(this.label38);
            this.pSerial.Controls.Add(this.add_tBaudRate);
            this.pSerial.Controls.Add(this.add_cbComPort);
            this.pSerial.Controls.Add(this.label39);
            this.pSerial.Controls.Add(this.label40);
            this.pSerial.Location = new System.Drawing.Point(10, 47);
            this.pSerial.Name = "pSerial";
            this.pSerial.Size = new System.Drawing.Size(827, 333);
            this.pSerial.TabIndex = 1;
            this.pSerial.Text = "Serial";
            this.pSerial.UseVisualStyleBackColor = true;
            // 
            // add_bRefreshComPorts
            // 
            this.add_bRefreshComPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.add_bRefreshComPorts.Location = new System.Drawing.Point(743, 13);
            this.add_bRefreshComPorts.Margin = new System.Windows.Forms.Padding(7);
            this.add_bRefreshComPorts.Name = "add_bRefreshComPorts";
            this.add_bRefreshComPorts.Size = new System.Drawing.Size(96, 56);
            this.add_bRefreshComPorts.TabIndex = 43;
            this.add_bRefreshComPorts.Text = "Load";
            this.add_bRefreshComPorts.UseVisualStyleBackColor = true;
            this.add_bRefreshComPorts.Click += new System.EventHandler(this.add_bRefreshComPorts_Click);
            // 
            // add_cbDtr
            // 
            this.add_cbDtr.AutoSize = true;
            this.add_cbDtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_cbDtr.Location = new System.Drawing.Point(6, 255);
            this.add_cbDtr.Name = "add_cbDtr";
            this.add_cbDtr.Size = new System.Drawing.Size(686, 52);
            this.add_cbDtr.TabIndex = 37;
            this.add_cbDtr.Text = "DTR (Data Terminal Ready) Mode";
            this.add_cbDtr.UseVisualStyleBackColor = true;
            // 
            // add_cbRts
            // 
            this.add_cbRts.AutoSize = true;
            this.add_cbRts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_cbRts.Location = new System.Drawing.Point(5, 197);
            this.add_cbRts.Name = "add_cbRts";
            this.add_cbRts.Size = new System.Drawing.Size(613, 52);
            this.add_cbRts.TabIndex = 36;
            this.add_cbRts.Text = "RTS (Request To Send) Mode";
            this.add_cbRts.UseVisualStyleBackColor = true;
            // 
            // add_tDataBits
            // 
            this.add_tDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_tDataBits.Location = new System.Drawing.Point(241, 136);
            this.add_tDataBits.Name = "add_tDataBits";
            this.add_tDataBits.Size = new System.Drawing.Size(596, 55);
            this.add_tDataBits.TabIndex = 35;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label38.Location = new System.Drawing.Point(-1, 139);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(202, 48);
            this.label38.TabIndex = 32;
            this.label38.Text = "Data Bits:";
            // 
            // add_tBaudRate
            // 
            this.add_tBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_tBaudRate.Location = new System.Drawing.Point(241, 75);
            this.add_tBaudRate.Name = "add_tBaudRate";
            this.add_tBaudRate.Size = new System.Drawing.Size(596, 55);
            this.add_tBaudRate.TabIndex = 34;
            // 
            // add_cbComPort
            // 
            this.add_cbComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_cbComPort.FormattingEnabled = true;
            this.add_cbComPort.Location = new System.Drawing.Point(241, 13);
            this.add_cbComPort.Name = "add_cbComPort";
            this.add_cbComPort.Size = new System.Drawing.Size(492, 56);
            this.add_cbComPort.TabIndex = 30;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label39.Location = new System.Drawing.Point(-1, 78);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(228, 48);
            this.label39.TabIndex = 33;
            this.label39.Text = "Baud Rate:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label40.Location = new System.Drawing.Point(-3, 16);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(218, 48);
            this.label40.TabIndex = 31;
            this.label40.Text = "COM Port:";
            // 
            // pDatabase
            // 
            this.pDatabase.Controls.Add(this.add_cbDatabaseType);
            this.pDatabase.Controls.Add(this.label41);
            this.pDatabase.Controls.Add(this.add_tQuery);
            this.pDatabase.Controls.Add(this.label42);
            this.pDatabase.Controls.Add(this.add_tConnectionString);
            this.pDatabase.Controls.Add(this.label43);
            this.pDatabase.Location = new System.Drawing.Point(10, 47);
            this.pDatabase.Name = "pDatabase";
            this.pDatabase.Size = new System.Drawing.Size(827, 333);
            this.pDatabase.TabIndex = 2;
            this.pDatabase.Text = "Database";
            this.pDatabase.UseVisualStyleBackColor = true;
            // 
            // add_cbDatabaseType
            // 
            this.add_cbDatabaseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_cbDatabaseType.FormattingEnabled = true;
            this.add_cbDatabaseType.Location = new System.Drawing.Point(241, 134);
            this.add_cbDatabaseType.Name = "add_cbDatabaseType";
            this.add_cbDatabaseType.Size = new System.Drawing.Size(596, 56);
            this.add_cbDatabaseType.TabIndex = 27;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label41.Location = new System.Drawing.Point(-3, 137);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(248, 48);
            this.label41.TabIndex = 29;
            this.label41.Text = "Technology:";
            // 
            // add_tQuery
            // 
            this.add_tQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_tQuery.Location = new System.Drawing.Point(241, 73);
            this.add_tQuery.Name = "add_tQuery";
            this.add_tQuery.Size = new System.Drawing.Size(596, 55);
            this.add_tQuery.TabIndex = 32;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label42.Location = new System.Drawing.Point(-3, 76);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(146, 48);
            this.label42.TabIndex = 31;
            this.label42.Text = "Query:";
            // 
            // add_tConnectionString
            // 
            this.add_tConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_tConnectionString.Location = new System.Drawing.Point(241, 12);
            this.add_tConnectionString.Name = "add_tConnectionString";
            this.add_tConnectionString.Size = new System.Drawing.Size(596, 55);
            this.add_tConnectionString.TabIndex = 30;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label43.Location = new System.Drawing.Point(-3, 15);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(208, 48);
            this.label43.TabIndex = 28;
            this.label43.Text = "Conn. Str:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label46.Location = new System.Drawing.Point(13, 252);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(243, 48);
            this.label46.TabIndex = 34;
            this.label46.Text = "Value Type:";
            // 
            // add_cbValueType
            // 
            this.add_cbValueType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_cbValueType.FormattingEnabled = true;
            this.add_cbValueType.Location = new System.Drawing.Point(257, 249);
            this.add_cbValueType.Name = "add_cbValueType";
            this.add_cbValueType.Size = new System.Drawing.Size(596, 56);
            this.add_cbValueType.TabIndex = 33;
            this.add_cbValueType.SelectedIndexChanged += new System.EventHandler(this.add_cbValueType_SelectedIndexChanged);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label47.Location = new System.Drawing.Point(13, 190);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(125, 48);
            this.label47.TabIndex = 32;
            this.label47.Text = "Type:";
            // 
            // add_cbCommType
            // 
            this.add_cbCommType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_cbCommType.FormattingEnabled = true;
            this.add_cbCommType.Location = new System.Drawing.Point(257, 187);
            this.add_cbCommType.Name = "add_cbCommType";
            this.add_cbCommType.Size = new System.Drawing.Size(596, 56);
            this.add_cbCommType.TabIndex = 29;
            this.add_cbCommType.SelectedIndexChanged += new System.EventHandler(this.add_cbCommType_SelectedIndexChanged);
            // 
            // add_tEnd
            // 
            this.add_tEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_tEnd.Location = new System.Drawing.Point(257, 126);
            this.add_tEnd.Name = "add_tEnd";
            this.add_tEnd.Size = new System.Drawing.Size(596, 55);
            this.add_tEnd.TabIndex = 28;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label49.Location = new System.Drawing.Point(13, 129);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(207, 48);
            this.label49.TabIndex = 27;
            this.label49.Text = "End Char:";
            // 
            // add_tStartChar
            // 
            this.add_tStartChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_tStartChar.Location = new System.Drawing.Point(257, 65);
            this.add_tStartChar.Name = "add_tStartChar";
            this.add_tStartChar.Size = new System.Drawing.Size(596, 55);
            this.add_tStartChar.TabIndex = 26;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label50.Location = new System.Drawing.Point(13, 68);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(222, 48);
            this.label50.TabIndex = 25;
            this.label50.Text = "Start Char:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label36.Location = new System.Drawing.Point(3, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(585, 51);
            this.label36.TabIndex = 3;
            this.label36.Text = "Add New Data Connection";
            // 
            // pRules
            // 
            this.pRules.Controls.Add(this.add_bAddAction);
            this.pRules.Controls.Add(this.add_bSaveRule);
            this.pRules.Controls.Add(this.add_cbRuleCheckValue);
            this.pRules.Controls.Add(this.label53);
            this.pRules.Controls.Add(this.add_cAlarm);
            this.pRules.Controls.Add(this.add_cbRuleType);
            this.pRules.Controls.Add(this.label45);
            this.pRules.Controls.Add(this.add_tConstraint);
            this.pRules.Controls.Add(this.label48);
            this.pRules.Controls.Add(this.label51);
            this.pRules.Controls.Add(this.add_tRuleName);
            this.pRules.Controls.Add(this.label52);
            this.pRules.Location = new System.Drawing.Point(10, 47);
            this.pRules.Name = "pRules";
            this.pRules.Size = new System.Drawing.Size(900, 682);
            this.pRules.TabIndex = 2;
            this.pRules.Text = "Rules";
            this.pRules.UseVisualStyleBackColor = true;
            // 
            // add_bAddAction
            // 
            this.add_bAddAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_bAddAction.Location = new System.Drawing.Point(267, 410);
            this.add_bAddAction.Name = "add_bAddAction";
            this.add_bAddAction.Size = new System.Drawing.Size(387, 98);
            this.add_bAddAction.TabIndex = 46;
            this.add_bAddAction.Text = "Add Action";
            this.add_bAddAction.UseVisualStyleBackColor = true;
            // 
            // add_bSaveRule
            // 
            this.add_bSaveRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_bSaveRule.Location = new System.Drawing.Point(311, 538);
            this.add_bSaveRule.Name = "add_bSaveRule";
            this.add_bSaveRule.Size = new System.Drawing.Size(295, 98);
            this.add_bSaveRule.TabIndex = 45;
            this.add_bSaveRule.Text = "Save Rule";
            this.add_bSaveRule.UseVisualStyleBackColor = true;
            // 
            // add_cbRuleCheckValue
            // 
            this.add_cbRuleCheckValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_cbRuleCheckValue.FormattingEnabled = true;
            this.add_cbRuleCheckValue.Location = new System.Drawing.Point(257, 124);
            this.add_cbRuleCheckValue.Name = "add_cbRuleCheckValue";
            this.add_cbRuleCheckValue.Size = new System.Drawing.Size(628, 56);
            this.add_cbRuleCheckValue.TabIndex = 25;
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label53.Location = new System.Drawing.Point(3, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(312, 51);
            this.label53.TabIndex = 28;
            this.label53.Text = "Add New Rule";
            // 
            // add_cAlarm
            // 
            this.add_cAlarm.AutoSize = true;
            this.add_cAlarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_cAlarm.Location = new System.Drawing.Point(149, 335);
            this.add_cAlarm.Name = "add_cAlarm";
            this.add_cAlarm.Size = new System.Drawing.Size(649, 52);
            this.add_cAlarm.TabIndex = 27;
            this.add_cAlarm.Text = "Raise Alarm Criterion Being Met";
            this.add_cAlarm.UseVisualStyleBackColor = true;
            // 
            // add_cbRuleType
            // 
            this.add_cbRuleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_cbRuleType.FormattingEnabled = true;
            this.add_cbRuleType.Location = new System.Drawing.Point(257, 186);
            this.add_cbRuleType.Name = "add_cbRuleType";
            this.add_cbRuleType.Size = new System.Drawing.Size(628, 56);
            this.add_cbRuleType.TabIndex = 26;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label45.Location = new System.Drawing.Point(11, 251);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(223, 48);
            this.label45.TabIndex = 23;
            this.label45.Text = "Constraint:";
            // 
            // add_tConstraint
            // 
            this.add_tConstraint.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_tConstraint.Location = new System.Drawing.Point(257, 248);
            this.add_tConstraint.Name = "add_tConstraint";
            this.add_tConstraint.Size = new System.Drawing.Size(628, 55);
            this.add_tConstraint.TabIndex = 22;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label48.Location = new System.Drawing.Point(11, 189);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(222, 48);
            this.label48.TabIndex = 21;
            this.label48.Text = "Rule Type:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label51.Location = new System.Drawing.Point(11, 127);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(254, 48);
            this.label51.TabIndex = 20;
            this.label51.Text = "Check Type:";
            // 
            // add_tRuleName
            // 
            this.add_tRuleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_tRuleName.Location = new System.Drawing.Point(257, 63);
            this.add_tRuleName.Name = "add_tRuleName";
            this.add_tRuleName.Size = new System.Drawing.Size(628, 55);
            this.add_tRuleName.TabIndex = 19;
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label52.Location = new System.Drawing.Point(11, 66);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(240, 48);
            this.label52.TabIndex = 18;
            this.label52.Text = "Rule Name:";
            // 
            // pActions
            // 
            this.pActions.Controls.Add(this.add_cActionEnabled);
            this.pActions.Controls.Add(this.label55);
            this.pActions.Controls.Add(this.add_tOutputValue);
            this.pActions.Controls.Add(this.label54);
            this.pActions.Controls.Add(this.add_cbCommunicatorDestination);
            this.pActions.Controls.Add(this.label8);
            this.pActions.Controls.Add(this.add_cbRule);
            this.pActions.Controls.Add(this.label37);
            this.pActions.Location = new System.Drawing.Point(10, 47);
            this.pActions.Name = "pActions";
            this.pActions.Size = new System.Drawing.Size(900, 682);
            this.pActions.TabIndex = 1;
            this.pActions.Text = "Actions";
            this.pActions.UseVisualStyleBackColor = true;
            // 
            // add_cActionEnabled
            // 
            this.add_cActionEnabled.AutoSize = true;
            this.add_cActionEnabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_cActionEnabled.Location = new System.Drawing.Point(341, 274);
            this.add_cActionEnabled.Name = "add_cActionEnabled";
            this.add_cActionEnabled.Size = new System.Drawing.Size(205, 52);
            this.add_cActionEnabled.TabIndex = 39;
            this.add_cActionEnabled.Text = "Enabled";
            this.add_cActionEnabled.UseVisualStyleBackColor = true;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label55.Location = new System.Drawing.Point(17, 186);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(158, 48);
            this.label55.TabIndex = 38;
            this.label55.Text = "Output:";
            // 
            // add_tOutputValue
            // 
            this.add_tOutputValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_tOutputValue.Location = new System.Drawing.Point(263, 183);
            this.add_tOutputValue.Name = "add_tOutputValue";
            this.add_tOutputValue.Size = new System.Drawing.Size(628, 55);
            this.add_tOutputValue.TabIndex = 37;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label54.Location = new System.Drawing.Point(19, 124);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(242, 48);
            this.label54.TabIndex = 36;
            this.label54.Text = "Destination:";
            // 
            // add_cbCommunicatorDestination
            // 
            this.add_cbCommunicatorDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_cbCommunicatorDestination.FormattingEnabled = true;
            this.add_cbCommunicatorDestination.Location = new System.Drawing.Point(263, 121);
            this.add_cbCommunicatorDestination.Name = "add_cbCommunicatorDestination";
            this.add_cbCommunicatorDestination.Size = new System.Drawing.Size(627, 56);
            this.add_cbCommunicatorDestination.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label8.Location = new System.Drawing.Point(19, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 48);
            this.label8.TabIndex = 34;
            this.label8.Text = "Rule:";
            // 
            // add_cbRule
            // 
            this.add_cbRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_cbRule.FormattingEnabled = true;
            this.add_cbRule.Location = new System.Drawing.Point(263, 59);
            this.add_cbRule.Name = "add_cbRule";
            this.add_cbRule.Size = new System.Drawing.Size(627, 56);
            this.add_cbRule.TabIndex = 33;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label37.Location = new System.Drawing.Point(-9, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(254, 51);
            this.label37.TabIndex = 29;
            this.label37.Text = "Add Action";
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
            this.pModifyDevice.Controls.Add(this.modify_bActions);
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
            // modify_bActions
            // 
            this.modify_bActions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_bActions.Location = new System.Drawing.Point(1569, 431);
            this.modify_bActions.Margin = new System.Windows.Forms.Padding(7);
            this.modify_bActions.Name = "modify_bActions";
            this.modify_bActions.Size = new System.Drawing.Size(316, 85);
            this.modify_bActions.TabIndex = 47;
            this.modify_bActions.Text = "Modify Actions";
            this.modify_bActions.UseVisualStyleBackColor = true;
            // 
            // modify_bRules
            // 
            this.modify_bRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_bRules.Location = new System.Drawing.Point(1273, 431);
            this.modify_bRules.Margin = new System.Windows.Forms.Padding(7);
            this.modify_bRules.Name = "modify_bRules";
            this.modify_bRules.Size = new System.Drawing.Size(282, 85);
            this.modify_bRules.TabIndex = 46;
            this.modify_bRules.Text = "Modify Rules";
            this.modify_bRules.UseVisualStyleBackColor = true;
            // 
            // modify_bComms
            // 
            this.modify_bComms.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_bComms.Location = new System.Drawing.Point(800, 431);
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
            this.report_rvReportViewer.LocalReport.ReportEmbeddedResource = "SCIPA.UI.HMI.Report1.rdlc";
            this.report_rvReportViewer.Location = new System.Drawing.Point(772, 72);
            this.report_rvReportViewer.Name = "report_rvReportViewer";
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
            "Device",
            "Device",
            "Device",
            "Device",
            "Device",
            "Device",
            "Device",
            "Device"});
            this.report_lbReports.Location = new System.Drawing.Point(53, 72);
            this.report_lbReports.Name = "report_lbReports";
            this.report_lbReports.Size = new System.Drawing.Size(713, 784);
            this.report_lbReports.TabIndex = 40;
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
            this.pAlarms.Controls.Add(this.alarm_Rule);
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
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.alarm_cbPeriod);
            this.groupBox1.Location = new System.Drawing.Point(788, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1119, 114);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Settings";
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
            "1 hour",
            "2 hours",
            "6 hours",
            "24 hours",
            "72 hours"});
            this.alarm_cbPeriod.Location = new System.Drawing.Point(440, 32);
            this.alarm_cbPeriod.Name = "alarm_cbPeriod";
            this.alarm_cbPeriod.Size = new System.Drawing.Size(660, 59);
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
            // 
            // alarm_Rule
            // 
            this.alarm_Rule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alarm_Rule.Location = new System.Drawing.Point(1528, 513);
            this.alarm_Rule.Margin = new System.Windows.Forms.Padding(7);
            this.alarm_Rule.Name = "alarm_Rule";
            this.alarm_Rule.Size = new System.Drawing.Size(361, 85);
            this.alarm_Rule.TabIndex = 49;
            this.alarm_Rule.Text = "View Rule";
            this.alarm_Rule.UseVisualStyleBackColor = true;
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
            this.pModifyRules.Location = new System.Drawing.Point(10, 47);
            this.pModifyRules.Name = "pModifyRules";
            this.pModifyRules.Size = new System.Drawing.Size(1929, 902);
            this.pModifyRules.TabIndex = 9;
            this.pModifyRules.Text = "Modify Rules";
            this.pModifyRules.UseVisualStyleBackColor = true;
            // 
            // pModifyActions
            // 
            this.pModifyActions.Location = new System.Drawing.Point(10, 47);
            this.pModifyActions.Name = "pModifyActions";
            this.pModifyActions.Size = new System.Drawing.Size(1929, 902);
            this.pModifyActions.TabIndex = 10;
            this.pModifyActions.Text = "ModifyActions";
            this.pModifyActions.UseVisualStyleBackColor = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.SCIPAAlarmDataSet)).EndInit();
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
            this.add_tcInnerPages.ResumeLayout(false);
            this.pDataConnection.ResumeLayout(false);
            this.pDataConnection.PerformLayout();
            this.add_tcInnerPagesSourceSetting.ResumeLayout(false);
            this.pFlatFile.ResumeLayout(false);
            this.pFlatFile.PerformLayout();
            this.pSerial.ResumeLayout(false);
            this.pSerial.PerformLayout();
            this.pDatabase.ResumeLayout(false);
            this.pDatabase.PerformLayout();
            this.pRules.ResumeLayout(false);
            this.pRules.PerformLayout();
            this.pActions.ResumeLayout(false);
            this.pActions.PerformLayout();
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
        private System.Windows.Forms.Button modify_bActions;
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
        private System.Windows.Forms.TextBox stop_tId;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button stop_bStop;
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
        private System.Windows.Forms.Button alarm_Rule;
        private System.Windows.Forms.Button alarm_bDevice;
        private System.Windows.Forms.TextBox alarm_tValue;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox alarm_tDateTime;
        private System.Windows.Forms.TextBox alarm_tDevice;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private CustomTabControl add_tcInnerPages;
        private System.Windows.Forms.TabPage pDataConnection;
        private System.Windows.Forms.TabPage pActions;
        private System.Windows.Forms.TabPage pRules;
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
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ComboBox add_cbValueType;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ComboBox add_cbCommType;
        private System.Windows.Forms.TextBox add_tEnd;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox add_tStartChar;
        private System.Windows.Forms.Label label50;
        private CustomTabControl add_tcInnerPagesSourceSetting;
        private System.Windows.Forms.TabPage pFlatFile;
        private System.Windows.Forms.TabPage pSerial;
        private System.Windows.Forms.TabPage pDatabase;
        private System.Windows.Forms.CheckBox add_cbDtr;
        private System.Windows.Forms.CheckBox add_cbRts;
        private System.Windows.Forms.TextBox add_tDataBits;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox add_tBaudRate;
        private System.Windows.Forms.ComboBox add_cbComPort;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox add_tFilePath;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox add_tQuery;
        private System.Windows.Forms.ComboBox add_cbDatabaseType;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox add_tConnectionString;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.TabPage Blank;
        private System.Windows.Forms.Button add_bRefreshComPorts;
        private System.Windows.Forms.Button add_bSaveSource;
        private System.Windows.Forms.ComboBox add_cbRuleCheckValue;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.CheckBox add_cAlarm;
        private System.Windows.Forms.ComboBox add_cbRuleType;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox add_tConstraint;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.TextBox add_tRuleName;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Button add_bSaveRule;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button add_bAddAction;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.ComboBox add_cbCommunicatorDestination;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox add_cbRule;
        private System.Windows.Forms.CheckBox add_cActionEnabled;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox add_tOutputValue;
        private System.Windows.Forms.RadioButton add_rbCommOutbound;
        private System.Windows.Forms.RadioButton add_rbCommInbound;
        private System.Windows.Forms.BindingSource AlarmsBindingSource;
        private SCIPAAlarmDataSet SCIPAAlarmDataSet;
        private SCIPAAlarmDataSetTableAdapters.AlarmsTableAdapter AlarmsTableAdapter;
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
    }
}

