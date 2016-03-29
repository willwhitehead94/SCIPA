namespace SCIPA.UI.Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
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
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lStaticMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.lStatusPreceder = new System.Windows.Forms.ToolStripStatusLabel();
            this.lStatusMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.pBackPanel = new System.Windows.Forms.Panel();
            this.bTogglePanelSize_Status = new System.Windows.Forms.Button();
            this.pTabPanel = new SCIPA.UI.HMI.CustomTabControl();
            this.pStart = new System.Windows.Forms.TabPage();
            this.bTogglePanelSize_Start = new System.Windows.Forms.Button();
            this.pStop = new System.Windows.Forms.TabPage();
            this.bTogglePanelSize_Stop = new System.Windows.Forms.Button();
            this.pAddNewDevice = new System.Windows.Forms.TabPage();
            this.lRules = new System.Windows.Forms.Label();
            this.bAddRule = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lDestination = new System.Windows.Forms.Label();
            this.bAddDestination = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lSource = new System.Windows.Forms.Label();
            this.bAddSource = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rbFalse = new System.Windows.Forms.RadioButton();
            this.rbTrue = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tCustodian = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.tId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.lHeader_Add = new System.Windows.Forms.Label();
            this.bTogglePanelSize_AddNew = new System.Windows.Forms.Button();
            this.pModifyDevice = new System.Windows.Forms.TabPage();
            this.bTogglePanelSize_Modify = new System.Windows.Forms.Button();
            this.pReports = new System.Windows.Forms.TabPage();
            this.bTogglePanelSize_Reports = new System.Windows.Forms.Button();
            this.pAlarms = new System.Windows.Forms.TabPage();
            this.bTogglePanelSize_Alarms = new System.Windows.Forms.Button();
            this.pHeader.SuspendLayout();
            this.pButtonPannel.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.pTabPanel.SuspendLayout();
            this.pStart.SuspendLayout();
            this.pStop.SuspendLayout();
            this.pAddNewDevice.SuspendLayout();
            this.pModifyDevice.SuspendLayout();
            this.pReports.SuspendLayout();
            this.pAlarms.SuspendLayout();
            this.SuspendLayout();
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
            this.pHeader.Size = new System.Drawing.Size(1314, 106);
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
            this.bStartProcess.Location = new System.Drawing.Point(0, 0);
            this.bStartProcess.Name = "bStartProcess";
            this.bStartProcess.Size = new System.Drawing.Size(214, 85);
            this.bStartProcess.TabIndex = 7;
            this.bStartProcess.Text = "START DEVICE PROCESSES";
            this.bStartProcess.UseVisualStyleBackColor = false;
            this.bStartProcess.Click += new System.EventHandler(this.bStartProcess_Click);
            // 
            // bStopProcess
            // 
            this.bStopProcess.BackColor = System.Drawing.Color.Gainsboro;
            this.bStopProcess.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStopProcess.Location = new System.Drawing.Point(220, 0);
            this.bStopProcess.Name = "bStopProcess";
            this.bStopProcess.Size = new System.Drawing.Size(214, 85);
            this.bStopProcess.TabIndex = 8;
            this.bStopProcess.Text = "STOP DEVICE PROCESSES";
            this.bStopProcess.UseVisualStyleBackColor = false;
            this.bStopProcess.Click += new System.EventHandler(this.bStopProcess_Click);
            // 
            // bAddNew
            // 
            this.bAddNew.BackColor = System.Drawing.Color.Gainsboro;
            this.bAddNew.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddNew.Location = new System.Drawing.Point(440, 0);
            this.bAddNew.Name = "bAddNew";
            this.bAddNew.Size = new System.Drawing.Size(214, 85);
            this.bAddNew.TabIndex = 9;
            this.bAddNew.Text = "ADD NEW DEVICE";
            this.bAddNew.UseVisualStyleBackColor = false;
            this.bAddNew.Click += new System.EventHandler(this.bAddNew_Click);
            // 
            // bModify
            // 
            this.bModify.BackColor = System.Drawing.Color.Gainsboro;
            this.bModify.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModify.Location = new System.Drawing.Point(660, 0);
            this.bModify.Name = "bModify";
            this.bModify.Size = new System.Drawing.Size(214, 85);
            this.bModify.TabIndex = 10;
            this.bModify.Text = "MODIFY DEVICE";
            this.bModify.UseVisualStyleBackColor = false;
            this.bModify.Click += new System.EventHandler(this.bModify_Click);
            // 
            // bReports
            // 
            this.bReports.BackColor = System.Drawing.Color.Gainsboro;
            this.bReports.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bReports.Location = new System.Drawing.Point(880, 0);
            this.bReports.Name = "bReports";
            this.bReports.Size = new System.Drawing.Size(214, 85);
            this.bReports.TabIndex = 11;
            this.bReports.Text = "PROCESS REPORTS";
            this.bReports.UseVisualStyleBackColor = false;
            this.bReports.Click += new System.EventHandler(this.bReports_Click);
            // 
            // bAlarms
            // 
            this.bAlarms.BackColor = System.Drawing.Color.Gainsboro;
            this.bAlarms.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAlarms.Location = new System.Drawing.Point(1100, 0);
            this.bAlarms.Name = "bAlarms";
            this.bAlarms.Size = new System.Drawing.Size(214, 85);
            this.bAlarms.TabIndex = 12;
            this.bAlarms.Text = "ALARMS";
            this.bAlarms.UseVisualStyleBackColor = false;
            this.bAlarms.Click += new System.EventHandler(this.bAlarms_Click);
            // 
            // pButtonPannel
            // 
            this.pButtonPannel.BackColor = System.Drawing.Color.Transparent;
            this.pButtonPannel.Controls.Add(this.bStopProcess);
            this.pButtonPannel.Controls.Add(this.bAlarms);
            this.pButtonPannel.Controls.Add(this.bStartProcess);
            this.pButtonPannel.Controls.Add(this.bReports);
            this.pButtonPannel.Controls.Add(this.bAddNew);
            this.pButtonPannel.Controls.Add(this.bModify);
            this.pButtonPannel.Location = new System.Drawing.Point(11, 130);
            this.pButtonPannel.Name = "pButtonPannel";
            this.pButtonPannel.Size = new System.Drawing.Size(1314, 85);
            this.pButtonPannel.TabIndex = 13;
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStaticMessage,
            this.lStatusPreceder,
            this.lStatusMessage});
            this.statusBar.Location = new System.Drawing.Point(0, 651);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(1338, 38);
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
            // pBackPanel
            // 
            this.pBackPanel.BackColor = System.Drawing.Color.Transparent;
            this.pBackPanel.Location = new System.Drawing.Point(12, 129);
            this.pBackPanel.Name = "pBackPanel";
            this.pBackPanel.Size = new System.Drawing.Size(1314, 502);
            this.pBackPanel.TabIndex = 16;
            // 
            // bTogglePanelSize_Status
            // 
            this.bTogglePanelSize_Status.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bTogglePanelSize_Status.Location = new System.Drawing.Point(1118, 616);
            this.bTogglePanelSize_Status.Name = "bTogglePanelSize_Status";
            this.bTogglePanelSize_Status.Size = new System.Drawing.Size(209, 65);
            this.bTogglePanelSize_Status.TabIndex = 1;
            this.bTogglePanelSize_Status.Text = "Fullscreen";
            this.bTogglePanelSize_Status.UseVisualStyleBackColor = true;
            this.bTogglePanelSize_Status.Click += new System.EventHandler(this.bTogglePanelSize_Click);
            // 
            // pTabPanel
            // 
            this.pTabPanel.Controls.Add(this.pStart);
            this.pTabPanel.Controls.Add(this.pStop);
            this.pTabPanel.Controls.Add(this.pAddNewDevice);
            this.pTabPanel.Controls.Add(this.pModifyDevice);
            this.pTabPanel.Controls.Add(this.pReports);
            this.pTabPanel.Controls.Add(this.pAlarms);
            this.pTabPanel.Location = new System.Drawing.Point(11, 221);
            this.pTabPanel.Name = "pTabPanel";
            this.pTabPanel.SelectedIndex = 0;
            this.pTabPanel.Size = new System.Drawing.Size(1315, 407);
            this.pTabPanel.TabIndex = 14;
            // 
            // pStart
            // 
            this.pStart.Controls.Add(this.bTogglePanelSize_Start);
            this.pStart.Location = new System.Drawing.Point(10, 47);
            this.pStart.Name = "pStart";
            this.pStart.Size = new System.Drawing.Size(1295, 350);
            this.pStart.TabIndex = 0;
            this.pStart.Text = "StartProcess";
            this.pStart.UseVisualStyleBackColor = true;
            // 
            // bTogglePanelSize_Start
            // 
            this.bTogglePanelSize_Start.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bTogglePanelSize_Start.Location = new System.Drawing.Point(1096, -1);
            this.bTogglePanelSize_Start.Name = "bTogglePanelSize_Start";
            this.bTogglePanelSize_Start.Size = new System.Drawing.Size(209, 45);
            this.bTogglePanelSize_Start.TabIndex = 0;
            this.bTogglePanelSize_Start.Text = "Fullscreen";
            this.bTogglePanelSize_Start.UseVisualStyleBackColor = true;
            this.bTogglePanelSize_Start.Click += new System.EventHandler(this.bTogglePanelSize_Click);
            // 
            // pStop
            // 
            this.pStop.Controls.Add(this.bTogglePanelSize_Stop);
            this.pStop.Location = new System.Drawing.Point(10, 47);
            this.pStop.Name = "pStop";
            this.pStop.Size = new System.Drawing.Size(1295, 350);
            this.pStop.TabIndex = 1;
            this.pStop.Text = "StopProcess";
            this.pStop.UseVisualStyleBackColor = true;
            // 
            // bTogglePanelSize_Stop
            // 
            this.bTogglePanelSize_Stop.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bTogglePanelSize_Stop.Location = new System.Drawing.Point(1096, -1);
            this.bTogglePanelSize_Stop.Name = "bTogglePanelSize_Stop";
            this.bTogglePanelSize_Stop.Size = new System.Drawing.Size(209, 45);
            this.bTogglePanelSize_Stop.TabIndex = 1;
            this.bTogglePanelSize_Stop.Text = "Fullscreen";
            this.bTogglePanelSize_Stop.UseVisualStyleBackColor = true;
            this.bTogglePanelSize_Stop.Click += new System.EventHandler(this.bTogglePanelSize_Click);
            // 
            // pAddNewDevice
            // 
            this.pAddNewDevice.AutoScroll = true;
            this.pAddNewDevice.Controls.Add(this.lRules);
            this.pAddNewDevice.Controls.Add(this.bAddRule);
            this.pAddNewDevice.Controls.Add(this.label10);
            this.pAddNewDevice.Controls.Add(this.lDestination);
            this.pAddNewDevice.Controls.Add(this.bAddDestination);
            this.pAddNewDevice.Controls.Add(this.label8);
            this.pAddNewDevice.Controls.Add(this.lSource);
            this.pAddNewDevice.Controls.Add(this.bAddSource);
            this.pAddNewDevice.Controls.Add(this.label5);
            this.pAddNewDevice.Controls.Add(this.rbFalse);
            this.pAddNewDevice.Controls.Add(this.rbTrue);
            this.pAddNewDevice.Controls.Add(this.label4);
            this.pAddNewDevice.Controls.Add(this.tLocation);
            this.pAddNewDevice.Controls.Add(this.label3);
            this.pAddNewDevice.Controls.Add(this.tCustodian);
            this.pAddNewDevice.Controls.Add(this.label2);
            this.pAddNewDevice.Controls.Add(this.tName);
            this.pAddNewDevice.Controls.Add(this.tId);
            this.pAddNewDevice.Controls.Add(this.label1);
            this.pAddNewDevice.Controls.Add(this.lId);
            this.pAddNewDevice.Controls.Add(this.lHeader_Add);
            this.pAddNewDevice.Controls.Add(this.bTogglePanelSize_AddNew);
            this.pAddNewDevice.Location = new System.Drawing.Point(10, 47);
            this.pAddNewDevice.Name = "pAddNewDevice";
            this.pAddNewDevice.Size = new System.Drawing.Size(1295, 350);
            this.pAddNewDevice.TabIndex = 2;
            this.pAddNewDevice.Text = "AddDevice";
            this.pAddNewDevice.UseVisualStyleBackColor = true;
            // 
            // lRules
            // 
            this.lRules.AutoSize = true;
            this.lRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRules.Location = new System.Drawing.Point(692, 498);
            this.lRules.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lRules.Name = "lRules";
            this.lRules.Size = new System.Drawing.Size(227, 48);
            this.lRules.TabIndex = 40;
            this.lRules.Text = "No Rules...";
            // 
            // bAddRule
            // 
            this.bAddRule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddRule.Location = new System.Drawing.Point(349, 487);
            this.bAddRule.Margin = new System.Windows.Forms.Padding(7);
            this.bAddRule.Name = "bAddRule";
            this.bAddRule.Size = new System.Drawing.Size(329, 51);
            this.bAddRule.TabIndex = 39;
            this.bAddRule.Text = "Add Rule";
            this.bAddRule.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(50, 498);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 48);
            this.label10.TabIndex = 38;
            this.label10.Text = "Rules:";
            // 
            // lDestination
            // 
            this.lDestination.AutoSize = true;
            this.lDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDestination.Location = new System.Drawing.Point(692, 434);
            this.lDestination.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lDestination.Name = "lDestination";
            this.lDestination.Size = new System.Drawing.Size(330, 48);
            this.lDestination.TabIndex = 37;
            this.lDestination.Text = "No Destination...";
            // 
            // bAddDestination
            // 
            this.bAddDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddDestination.Location = new System.Drawing.Point(349, 423);
            this.bAddDestination.Margin = new System.Windows.Forms.Padding(7);
            this.bAddDestination.Name = "bAddDestination";
            this.bAddDestination.Size = new System.Drawing.Size(329, 51);
            this.bAddDestination.TabIndex = 36;
            this.bAddDestination.Text = "Add Outbound Destination";
            this.bAddDestination.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(50, 434);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(242, 48);
            this.label8.TabIndex = 35;
            this.label8.Text = "Destination:";
            // 
            // lSource
            // 
            this.lSource.AutoSize = true;
            this.lSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lSource.Location = new System.Drawing.Point(692, 369);
            this.lSource.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lSource.Name = "lSource";
            this.lSource.Size = new System.Drawing.Size(273, 48);
            this.lSource.TabIndex = 34;
            this.lSource.Text = "No Sources...";
            // 
            // bAddSource
            // 
            this.bAddSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddSource.Location = new System.Drawing.Point(349, 358);
            this.bAddSource.Margin = new System.Windows.Forms.Padding(7);
            this.bAddSource.Name = "bAddSource";
            this.bAddSource.Size = new System.Drawing.Size(329, 51);
            this.bAddSource.TabIndex = 33;
            this.bAddSource.Text = "Add Inbound Source";
            this.bAddSource.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 369);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 48);
            this.label5.TabIndex = 32;
            this.label5.Text = "Source:";
            // 
            // rbFalse
            // 
            this.rbFalse.AutoSize = true;
            this.rbFalse.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFalse.Location = new System.Drawing.Point(472, 307);
            this.rbFalse.Margin = new System.Windows.Forms.Padding(7);
            this.rbFalse.Name = "rbFalse";
            this.rbFalse.Size = new System.Drawing.Size(154, 52);
            this.rbFalse.TabIndex = 31;
            this.rbFalse.TabStop = true;
            this.rbFalse.Text = "False";
            this.rbFalse.UseVisualStyleBackColor = true;
            // 
            // rbTrue
            // 
            this.rbTrue.AutoSize = true;
            this.rbTrue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTrue.Location = new System.Drawing.Point(349, 307);
            this.rbTrue.Margin = new System.Windows.Forms.Padding(7);
            this.rbTrue.Name = "rbTrue";
            this.rbTrue.Size = new System.Drawing.Size(137, 52);
            this.rbTrue.TabIndex = 30;
            this.rbTrue.TabStop = true;
            this.rbTrue.Text = "True";
            this.rbTrue.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(50, 311);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 48);
            this.label4.TabIndex = 29;
            this.label4.Text = "Enabled:";
            // 
            // tLocation
            // 
            this.tLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tLocation.Location = new System.Drawing.Point(349, 188);
            this.tLocation.Margin = new System.Windows.Forms.Padding(7);
            this.tLocation.Name = "tLocation";
            this.tLocation.Size = new System.Drawing.Size(569, 55);
            this.tLocation.TabIndex = 28;
            this.tLocation.Text = "Under - Desk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 48);
            this.label3.TabIndex = 27;
            this.label3.Text = "Location:";
            // 
            // tCustodian
            // 
            this.tCustodian.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCustodian.Location = new System.Drawing.Point(349, 246);
            this.tCustodian.Margin = new System.Windows.Forms.Padding(7);
            this.tCustodian.Name = "tCustodian";
            this.tCustodian.Size = new System.Drawing.Size(569, 55);
            this.tCustodian.TabIndex = 26;
            this.tCustodian.Text = "W. Whitehead";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 253);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 48);
            this.label2.TabIndex = 25;
            this.label2.Text = "Custodian:";
            // 
            // tName
            // 
            this.tName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tName.Location = new System.Drawing.Point(349, 130);
            this.tName.Margin = new System.Windows.Forms.Padding(7);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(569, 55);
            this.tName.TabIndex = 24;
            this.tName.Text = "Test Arduino";
            // 
            // tId
            // 
            this.tId.Enabled = false;
            this.tId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tId.Location = new System.Drawing.Point(349, 72);
            this.tId.Margin = new System.Windows.Forms.Padding(7);
            this.tId.Name = "tId";
            this.tId.Size = new System.Drawing.Size(569, 55);
            this.tId.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 137);
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
            // bTogglePanelSize_AddNew
            // 
            this.bTogglePanelSize_AddNew.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bTogglePanelSize_AddNew.Location = new System.Drawing.Point(1040, 0);
            this.bTogglePanelSize_AddNew.Name = "bTogglePanelSize_AddNew";
            this.bTogglePanelSize_AddNew.Size = new System.Drawing.Size(214, 85);
            this.bTogglePanelSize_AddNew.TabIndex = 1;
            this.bTogglePanelSize_AddNew.Text = "Fullscreen";
            this.bTogglePanelSize_AddNew.UseVisualStyleBackColor = true;
            this.bTogglePanelSize_AddNew.Click += new System.EventHandler(this.bTogglePanelSize_Click);
            // 
            // pModifyDevice
            // 
            this.pModifyDevice.Controls.Add(this.bTogglePanelSize_Modify);
            this.pModifyDevice.Location = new System.Drawing.Point(10, 47);
            this.pModifyDevice.Name = "pModifyDevice";
            this.pModifyDevice.Size = new System.Drawing.Size(1295, 350);
            this.pModifyDevice.TabIndex = 3;
            this.pModifyDevice.Text = "ModifyDevice";
            this.pModifyDevice.UseVisualStyleBackColor = true;
            // 
            // bTogglePanelSize_Modify
            // 
            this.bTogglePanelSize_Modify.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bTogglePanelSize_Modify.Location = new System.Drawing.Point(1096, -1);
            this.bTogglePanelSize_Modify.Name = "bTogglePanelSize_Modify";
            this.bTogglePanelSize_Modify.Size = new System.Drawing.Size(209, 45);
            this.bTogglePanelSize_Modify.TabIndex = 1;
            this.bTogglePanelSize_Modify.Text = "Fullscreen";
            this.bTogglePanelSize_Modify.UseVisualStyleBackColor = true;
            this.bTogglePanelSize_Modify.Click += new System.EventHandler(this.bTogglePanelSize_Click);
            // 
            // pReports
            // 
            this.pReports.Controls.Add(this.bTogglePanelSize_Reports);
            this.pReports.Location = new System.Drawing.Point(10, 47);
            this.pReports.Name = "pReports";
            this.pReports.Size = new System.Drawing.Size(1295, 350);
            this.pReports.TabIndex = 4;
            this.pReports.Text = "Reports";
            this.pReports.UseVisualStyleBackColor = true;
            // 
            // bTogglePanelSize_Reports
            // 
            this.bTogglePanelSize_Reports.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bTogglePanelSize_Reports.Location = new System.Drawing.Point(1096, -1);
            this.bTogglePanelSize_Reports.Name = "bTogglePanelSize_Reports";
            this.bTogglePanelSize_Reports.Size = new System.Drawing.Size(209, 45);
            this.bTogglePanelSize_Reports.TabIndex = 1;
            this.bTogglePanelSize_Reports.Text = "Fullscreen";
            this.bTogglePanelSize_Reports.UseVisualStyleBackColor = true;
            this.bTogglePanelSize_Reports.Click += new System.EventHandler(this.bTogglePanelSize_Click);
            // 
            // pAlarms
            // 
            this.pAlarms.Controls.Add(this.bTogglePanelSize_Alarms);
            this.pAlarms.Location = new System.Drawing.Point(10, 47);
            this.pAlarms.Name = "pAlarms";
            this.pAlarms.Size = new System.Drawing.Size(1295, 350);
            this.pAlarms.TabIndex = 5;
            this.pAlarms.Text = "Alarms";
            this.pAlarms.UseVisualStyleBackColor = true;
            // 
            // bTogglePanelSize_Alarms
            // 
            this.bTogglePanelSize_Alarms.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bTogglePanelSize_Alarms.Location = new System.Drawing.Point(1096, -1);
            this.bTogglePanelSize_Alarms.Name = "bTogglePanelSize_Alarms";
            this.bTogglePanelSize_Alarms.Size = new System.Drawing.Size(209, 45);
            this.bTogglePanelSize_Alarms.TabIndex = 1;
            this.bTogglePanelSize_Alarms.Text = "Fullscreen";
            this.bTogglePanelSize_Alarms.UseVisualStyleBackColor = true;
            this.bTogglePanelSize_Alarms.Click += new System.EventHandler(this.bTogglePanelSize_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SCIPA.UI.HMI.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1338, 689);
            this.Controls.Add(this.bTogglePanelSize_Status);
            this.Controls.Add(this.pTabPanel);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.pButtonPannel);
            this.Controls.Add(this.pHeader);
            this.Controls.Add(this.pBackPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SCIPA Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.pButtonPannel.ResumeLayout(false);
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.pTabPanel.ResumeLayout(false);
            this.pStart.ResumeLayout(false);
            this.pStop.ResumeLayout(false);
            this.pAddNewDevice.ResumeLayout(false);
            this.pAddNewDevice.PerformLayout();
            this.pModifyDevice.ResumeLayout(false);
            this.pReports.ResumeLayout(false);
            this.pAlarms.ResumeLayout(false);
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
        private System.Windows.Forms.Button bTogglePanelSize_Start;
        private System.Windows.Forms.ToolStripStatusLabel lStatusPreceder;
        private System.Windows.Forms.Panel pBackPanel;
        private System.Windows.Forms.Button bTogglePanelSize_Stop;
        private System.Windows.Forms.Button bTogglePanelSize_AddNew;
        private System.Windows.Forms.Button bTogglePanelSize_Modify;
        private System.Windows.Forms.Button bTogglePanelSize_Reports;
        private System.Windows.Forms.Button bTogglePanelSize_Alarms;
        private System.Windows.Forms.Label lHeader_Add;
        private System.Windows.Forms.Button bTogglePanelSize_Status;
        private System.Windows.Forms.Label lRules;
        private System.Windows.Forms.Button bAddRule;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lDestination;
        private System.Windows.Forms.Button bAddDestination;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lSource;
        private System.Windows.Forms.Button bAddSource;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbFalse;
        private System.Windows.Forms.RadioButton rbTrue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tCustodian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lId;
    }
}

