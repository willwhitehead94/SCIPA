namespace SCIPA.UI.HMI
{
    partial class DataBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBoard));
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
            this.bCancelAction = new System.Windows.Forms.Button();
            this.bSaveAction = new System.Windows.Forms.Button();
            this.add_cActionEnabled = new System.Windows.Forms.CheckBox();
            this.label55 = new System.Windows.Forms.Label();
            this.add_tOutputValue = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.add_cbCommunicatorDestination = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.add_cbRule = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.add_tcInnerPages.SuspendLayout();
            this.pDataConnection.SuspendLayout();
            this.add_tcInnerPagesSourceSetting.SuspendLayout();
            this.pFlatFile.SuspendLayout();
            this.pSerial.SuspendLayout();
            this.pDatabase.SuspendLayout();
            this.pRules.SuspendLayout();
            this.pActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // add_tcInnerPages
            // 
            this.add_tcInnerPages.Controls.Add(this.Blank);
            this.add_tcInnerPages.Controls.Add(this.pDataConnection);
            this.add_tcInnerPages.Controls.Add(this.pRules);
            this.add_tcInnerPages.Controls.Add(this.pActions);
            this.add_tcInnerPages.Location = new System.Drawing.Point(12, 12);
            this.add_tcInnerPages.Name = "add_tcInnerPages";
            this.add_tcInnerPages.SelectedIndex = 0;
            this.add_tcInnerPages.Size = new System.Drawing.Size(920, 875);
            this.add_tcInnerPages.TabIndex = 43;
            // 
            // Blank
            // 
            this.Blank.Location = new System.Drawing.Point(10, 47);
            this.Blank.Name = "Blank";
            this.Blank.Size = new System.Drawing.Size(900, 818);
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
            this.pDataConnection.Size = new System.Drawing.Size(900, 818);
            this.pDataConnection.TabIndex = 0;
            this.pDataConnection.Text = "Data Connections";
            this.pDataConnection.UseVisualStyleBackColor = true;
            // 
            // add_rbCommOutbound
            // 
            this.add_rbCommOutbound.AutoSize = true;
            this.add_rbCommOutbound.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_rbCommOutbound.Location = new System.Drawing.Point(435, 317);
            this.add_rbCommOutbound.Name = "add_rbCommOutbound";
            this.add_rbCommOutbound.Size = new System.Drawing.Size(333, 52);
            this.add_rbCommOutbound.TabIndex = 46;
            this.add_rbCommOutbound.Text = "Outbound Data";
            this.add_rbCommOutbound.UseVisualStyleBackColor = true;
            // 
            // add_rbCommInbound
            // 
            this.add_rbCommInbound.AutoSize = true;
            this.add_rbCommInbound.Checked = true;
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
            this.pRules.Size = new System.Drawing.Size(900, 818);
            this.pRules.TabIndex = 2;
            this.pRules.Text = "Rules";
            this.pRules.UseVisualStyleBackColor = true;
            // 
            // add_bAddAction
            // 
            this.add_bAddAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.add_bAddAction.Location = new System.Drawing.Point(257, 748);
            this.add_bAddAction.Name = "add_bAddAction";
            this.add_bAddAction.Size = new System.Drawing.Size(387, 38);
            this.add_bAddAction.TabIndex = 46;
            this.add_bAddAction.Text = "Add Device Action";
            this.add_bAddAction.UseVisualStyleBackColor = true;
            this.add_bAddAction.Click += new System.EventHandler(this.add_bAddAction_Click);
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
            this.add_bSaveRule.Click += new System.EventHandler(this.add_bSaveRule_Click);
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
            this.pActions.Controls.Add(this.bCancelAction);
            this.pActions.Controls.Add(this.bSaveAction);
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
            this.pActions.Size = new System.Drawing.Size(900, 818);
            this.pActions.TabIndex = 1;
            this.pActions.Text = "Actions";
            this.pActions.UseVisualStyleBackColor = true;
            // 
            // bCancelAction
            // 
            this.bCancelAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bCancelAction.Location = new System.Drawing.Point(267, 594);
            this.bCancelAction.Name = "bCancelAction";
            this.bCancelAction.Size = new System.Drawing.Size(387, 98);
            this.bCancelAction.TabIndex = 48;
            this.bCancelAction.Text = "Cancel and Return";
            this.bCancelAction.UseVisualStyleBackColor = true;
            // 
            // bSaveAction
            // 
            this.bSaveAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.bSaveAction.Location = new System.Drawing.Point(267, 410);
            this.bSaveAction.Name = "bSaveAction";
            this.bSaveAction.Size = new System.Drawing.Size(387, 98);
            this.bSaveAction.TabIndex = 47;
            this.bSaveAction.Text = "Save and Return";
            this.bSaveAction.UseVisualStyleBackColor = true;
            this.bSaveAction.Click += new System.EventHandler(this.bSaveAction_Click);
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
            this.add_cbRule.SelectedIndexChanged += new System.EventHandler(this.add_cbRule_SelectedIndexChanged);
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
            // DataBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 901);
            this.Controls.Add(this.add_tcInnerPages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connection Creation Manager";
            this.Load += new System.EventHandler(this.DataBoard_Load);
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
            this.ResumeLayout(false);

        }

        #endregion

        private CustomTabControl add_tcInnerPages;
        private System.Windows.Forms.TabPage Blank;
        private System.Windows.Forms.TabPage pDataConnection;
        private System.Windows.Forms.RadioButton add_rbCommOutbound;
        private System.Windows.Forms.RadioButton add_rbCommInbound;
        private System.Windows.Forms.Button add_bSaveSource;
        private CustomTabControl add_tcInnerPagesSourceSetting;
        private System.Windows.Forms.TabPage pFlatFile;
        private System.Windows.Forms.TextBox add_tFilePath;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TabPage pSerial;
        private System.Windows.Forms.Button add_bRefreshComPorts;
        private System.Windows.Forms.CheckBox add_cbDtr;
        private System.Windows.Forms.CheckBox add_cbRts;
        private System.Windows.Forms.TextBox add_tDataBits;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox add_tBaudRate;
        private System.Windows.Forms.ComboBox add_cbComPort;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TabPage pDatabase;
        private System.Windows.Forms.ComboBox add_cbDatabaseType;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox add_tQuery;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox add_tConnectionString;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ComboBox add_cbValueType;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ComboBox add_cbCommType;
        private System.Windows.Forms.TextBox add_tEnd;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox add_tStartChar;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TabPage pRules;
        private System.Windows.Forms.Button add_bAddAction;
        private System.Windows.Forms.Button add_bSaveRule;
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
        private System.Windows.Forms.TabPage pActions;
        private System.Windows.Forms.CheckBox add_cActionEnabled;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox add_tOutputValue;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.ComboBox add_cbCommunicatorDestination;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox add_cbRule;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Button bCancelAction;
        private System.Windows.Forms.Button bSaveAction;
    }
}