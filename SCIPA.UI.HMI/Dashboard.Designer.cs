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
            this.pTabPanel = new SCIPA.UI.HMI.CustomTabControl();
            this.pStart = new System.Windows.Forms.TabPage();
            this.bTogglePanelSize_Start = new System.Windows.Forms.Button();
            this.pStop = new System.Windows.Forms.TabPage();
            this.bTogglePanelSize_Stop = new System.Windows.Forms.Button();
            this.pAddNewDevice = new System.Windows.Forms.TabPage();
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
            this.pAddNewDevice.Controls.Add(this.bTogglePanelSize_AddNew);
            this.pAddNewDevice.Location = new System.Drawing.Point(10, 47);
            this.pAddNewDevice.Name = "pAddNewDevice";
            this.pAddNewDevice.Size = new System.Drawing.Size(1295, 350);
            this.pAddNewDevice.TabIndex = 2;
            this.pAddNewDevice.Text = "AddDevice";
            this.pAddNewDevice.UseVisualStyleBackColor = true;
            // 
            // bTogglePanelSize_AddNew
            // 
            this.bTogglePanelSize_AddNew.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bTogglePanelSize_AddNew.Location = new System.Drawing.Point(1096, -1);
            this.bTogglePanelSize_AddNew.Name = "bTogglePanelSize_AddNew";
            this.bTogglePanelSize_AddNew.Size = new System.Drawing.Size(209, 45);
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
    }
}

