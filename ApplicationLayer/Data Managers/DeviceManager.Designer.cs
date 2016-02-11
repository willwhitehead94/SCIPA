namespace ApplicationLayer.DataManagers
{
    partial class DeviceManager
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
            this.lHeaderMessage = new System.Windows.Forms.Label();
            this.gbHeader = new System.Windows.Forms.GroupBox();
            this.lName = new System.Windows.Forms.Label();
            this.tDeviceName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tLocation = new System.Windows.Forms.TextBox();
            this.tOwner = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbInput = new System.Windows.Forms.RadioButton();
            this.rbOutput = new System.Windows.Forms.RadioButton();
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.bTestConnection = new System.Windows.Forms.Button();
            this.lConnectionInformation = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bNewConnection = new System.Windows.Forms.Button();
            this.rbFlat = new System.Windows.Forms.RadioButton();
            this.rbSerial = new System.Windows.Forms.RadioButton();
            this.rbDatabase = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.gbRules = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbCommands = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lNameCheck = new System.Windows.Forms.Label();
            this.lLocationCheck = new System.Windows.Forms.Label();
            this.lOwnerCheck = new System.Windows.Forms.Label();
            this.bLoad = new System.Windows.Forms.Button();
            this.cbDeviceList = new System.Windows.Forms.ComboBox();
            this.gbHeader.SuspendLayout();
            this.gbConnection.SuspendLayout();
            this.gbRules.SuspendLayout();
            this.gbCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // lHeaderMessage
            // 
            this.lHeaderMessage.Location = new System.Drawing.Point(6, 16);
            this.lHeaderMessage.Name = "lHeaderMessage";
            this.lHeaderMessage.Size = new System.Drawing.Size(404, 38);
            this.lHeaderMessage.TabIndex = 0;
            this.lHeaderMessage.Text = "label1";
            // 
            // gbHeader
            // 
            this.gbHeader.Controls.Add(this.cbDeviceList);
            this.gbHeader.Controls.Add(this.bLoad);
            this.gbHeader.Controls.Add(this.lHeaderMessage);
            this.gbHeader.Location = new System.Drawing.Point(12, 12);
            this.gbHeader.Name = "gbHeader";
            this.gbHeader.Size = new System.Drawing.Size(416, 100);
            this.gbHeader.TabIndex = 1;
            this.gbHeader.TabStop = false;
            this.gbHeader.Text = "groupBox1";
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(13, 119);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(75, 13);
            this.lName.TabIndex = 2;
            this.lName.Text = "Device Name:";
            // 
            // tDeviceName
            // 
            this.tDeviceName.Location = new System.Drawing.Point(111, 116);
            this.tDeviceName.Name = "tDeviceName";
            this.tDeviceName.Size = new System.Drawing.Size(234, 20);
            this.tDeviceName.TabIndex = 3;
            this.tDeviceName.Leave += new System.EventHandler(this.tDeviceName_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Location:";
            // 
            // tLocation
            // 
            this.tLocation.Location = new System.Drawing.Point(111, 142);
            this.tLocation.Name = "tLocation";
            this.tLocation.Size = new System.Drawing.Size(234, 20);
            this.tLocation.TabIndex = 5;
            // 
            // tOwner
            // 
            this.tOwner.Location = new System.Drawing.Point(111, 168);
            this.tOwner.Name = "tOwner";
            this.tOwner.Size = new System.Drawing.Size(234, 20);
            this.tOwner.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Owner/Supervisor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Device Type:";
            // 
            // rbInput
            // 
            this.rbInput.AutoSize = true;
            this.rbInput.Location = new System.Drawing.Point(111, 195);
            this.rbInput.Name = "rbInput";
            this.rbInput.Size = new System.Drawing.Size(91, 17);
            this.rbInput.TabIndex = 9;
            this.rbInput.TabStop = true;
            this.rbInput.Text = "Sensor (Input)";
            this.rbInput.UseVisualStyleBackColor = true;
            this.rbInput.CheckedChanged += new System.EventHandler(this.rbInput_CheckedChanged);
            // 
            // rbOutput
            // 
            this.rbOutput.AutoSize = true;
            this.rbOutput.Location = new System.Drawing.Point(208, 195);
            this.rbOutput.Name = "rbOutput";
            this.rbOutput.Size = new System.Drawing.Size(106, 17);
            this.rbOutput.TabIndex = 10;
            this.rbOutput.TabStop = true;
            this.rbOutput.Text = "Actuator (Output)";
            this.rbOutput.UseVisualStyleBackColor = true;
            this.rbOutput.CheckedChanged += new System.EventHandler(this.rbOutput_CheckedChanged);
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.bTestConnection);
            this.gbConnection.Controls.Add(this.lConnectionInformation);
            this.gbConnection.Controls.Add(this.label7);
            this.gbConnection.Controls.Add(this.bNewConnection);
            this.gbConnection.Controls.Add(this.rbFlat);
            this.gbConnection.Controls.Add(this.rbSerial);
            this.gbConnection.Controls.Add(this.rbDatabase);
            this.gbConnection.Controls.Add(this.label4);
            this.gbConnection.Location = new System.Drawing.Point(12, 237);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Size = new System.Drawing.Size(416, 153);
            this.gbConnection.TabIndex = 2;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection Settings";
            this.gbConnection.Enter += new System.EventHandler(this.gbConnection_Enter);
            // 
            // bTestConnection
            // 
            this.bTestConnection.Location = new System.Drawing.Point(10, 124);
            this.bTestConnection.Name = "bTestConnection";
            this.bTestConnection.Size = new System.Drawing.Size(116, 23);
            this.bTestConnection.TabIndex = 7;
            this.bTestConnection.Text = "Test Connection";
            this.bTestConnection.UseVisualStyleBackColor = true;
            // 
            // lConnectionInformation
            // 
            this.lConnectionInformation.Location = new System.Drawing.Point(7, 88);
            this.lConnectionInformation.Name = "lConnectionInformation";
            this.lConnectionInformation.Size = new System.Drawing.Size(403, 33);
            this.lConnectionInformation.TabIndex = 6;
            this.lConnectionInformation.Text = "No information to show...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Current connection information:";
            // 
            // bNewConnection
            // 
            this.bNewConnection.Location = new System.Drawing.Point(10, 46);
            this.bNewConnection.Name = "bNewConnection";
            this.bNewConnection.Size = new System.Drawing.Size(400, 23);
            this.bNewConnection.TabIndex = 4;
            this.bNewConnection.Text = "Create New Connection";
            this.bNewConnection.UseVisualStyleBackColor = true;
            this.bNewConnection.Click += new System.EventHandler(this.bNewConnection_Click);
            // 
            // rbFlat
            // 
            this.rbFlat.AutoSize = true;
            this.rbFlat.Location = new System.Drawing.Point(304, 18);
            this.rbFlat.Name = "rbFlat";
            this.rbFlat.Size = new System.Drawing.Size(61, 17);
            this.rbFlat.TabIndex = 3;
            this.rbFlat.TabStop = true;
            this.rbFlat.Text = "Flat File";
            this.rbFlat.UseVisualStyleBackColor = true;
            // 
            // rbSerial
            // 
            this.rbSerial.AutoSize = true;
            this.rbSerial.Location = new System.Drawing.Point(196, 18);
            this.rbSerial.Name = "rbSerial";
            this.rbSerial.Size = new System.Drawing.Size(51, 17);
            this.rbSerial.TabIndex = 2;
            this.rbSerial.TabStop = true;
            this.rbSerial.Text = "Serial";
            this.rbSerial.UseVisualStyleBackColor = true;
            // 
            // rbDatabase
            // 
            this.rbDatabase.AutoSize = true;
            this.rbDatabase.Location = new System.Drawing.Point(99, 18);
            this.rbDatabase.Name = "rbDatabase";
            this.rbDatabase.Size = new System.Drawing.Size(71, 17);
            this.rbDatabase.TabIndex = 1;
            this.rbDatabase.TabStop = true;
            this.rbDatabase.Text = "Database";
            this.rbDatabase.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Connection Type:";
            // 
            // gbRules
            // 
            this.gbRules.Controls.Add(this.label5);
            this.gbRules.Location = new System.Drawing.Point(12, 396);
            this.gbRules.Name = "gbRules";
            this.gbRules.Size = new System.Drawing.Size(416, 153);
            this.gbRules.TabIndex = 11;
            this.gbRules.TabStop = false;
            this.gbRules.Text = "Rules / Alarms";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "label5";
            // 
            // gbCommands
            // 
            this.gbCommands.Controls.Add(this.label6);
            this.gbCommands.Location = new System.Drawing.Point(12, 555);
            this.gbCommands.Name = "gbCommands";
            this.gbCommands.Size = new System.Drawing.Size(416, 153);
            this.gbCommands.TabIndex = 12;
            this.gbCommands.TabStop = false;
            this.gbCommands.Text = "Commands (Output only)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "label6";
            // 
            // lNameCheck
            // 
            this.lNameCheck.AutoSize = true;
            this.lNameCheck.Location = new System.Drawing.Point(351, 119);
            this.lNameCheck.Name = "lNameCheck";
            this.lNameCheck.Size = new System.Drawing.Size(33, 13);
            this.lNameCheck.TabIndex = 13;
            this.lNameCheck.Text = "Label";
            this.lNameCheck.Visible = false;
            // 
            // lLocationCheck
            // 
            this.lLocationCheck.AutoSize = true;
            this.lLocationCheck.Location = new System.Drawing.Point(351, 145);
            this.lLocationCheck.Name = "lLocationCheck";
            this.lLocationCheck.Size = new System.Drawing.Size(33, 13);
            this.lLocationCheck.TabIndex = 14;
            this.lLocationCheck.Text = "Label";
            this.lLocationCheck.Visible = false;
            // 
            // lOwnerCheck
            // 
            this.lOwnerCheck.AutoSize = true;
            this.lOwnerCheck.Location = new System.Drawing.Point(351, 171);
            this.lOwnerCheck.Name = "lOwnerCheck";
            this.lOwnerCheck.Size = new System.Drawing.Size(33, 13);
            this.lOwnerCheck.TabIndex = 15;
            this.lOwnerCheck.Text = "Label";
            this.lOwnerCheck.Visible = false;
            // 
            // bLoad
            // 
            this.bLoad.Location = new System.Drawing.Point(335, 71);
            this.bLoad.Name = "bLoad";
            this.bLoad.Size = new System.Drawing.Size(75, 23);
            this.bLoad.TabIndex = 1;
            this.bLoad.Text = "Load";
            this.bLoad.UseVisualStyleBackColor = true;
            // 
            // cbDeviceList
            // 
            this.cbDeviceList.FormattingEnabled = true;
            this.cbDeviceList.Location = new System.Drawing.Point(6, 71);
            this.cbDeviceList.Name = "cbDeviceList";
            this.cbDeviceList.Size = new System.Drawing.Size(323, 21);
            this.cbDeviceList.TabIndex = 2;
            this.cbDeviceList.SelectedIndexChanged += new System.EventHandler(this.cbDeviceList_SelectedIndexChanged);
            // 
            // DeviceManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 115);
            this.Controls.Add(this.lOwnerCheck);
            this.Controls.Add(this.lLocationCheck);
            this.Controls.Add(this.lNameCheck);
            this.Controls.Add(this.gbCommands);
            this.Controls.Add(this.gbRules);
            this.Controls.Add(this.gbConnection);
            this.Controls.Add(this.rbOutput);
            this.Controls.Add(this.rbInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tOwner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tLocation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tDeviceName);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.gbHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviceManager";
            this.Text = "DeviceManager";
            this.Load += new System.EventHandler(this.DeviceManager_Load);
            this.gbHeader.ResumeLayout(false);
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.gbRules.ResumeLayout(false);
            this.gbRules.PerformLayout();
            this.gbCommands.ResumeLayout(false);
            this.gbCommands.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lHeaderMessage;
        private System.Windows.Forms.GroupBox gbHeader;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.TextBox tDeviceName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tLocation;
        private System.Windows.Forms.TextBox tOwner;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbInput;
        private System.Windows.Forms.RadioButton rbOutput;
        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbRules;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbCommands;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbFlat;
        private System.Windows.Forms.RadioButton rbSerial;
        private System.Windows.Forms.RadioButton rbDatabase;
        private System.Windows.Forms.Label lNameCheck;
        private System.Windows.Forms.Label lLocationCheck;
        private System.Windows.Forms.Label lOwnerCheck;
        private System.Windows.Forms.Button bNewConnection;
        private System.Windows.Forms.Button bTestConnection;
        private System.Windows.Forms.Label lConnectionInformation;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDeviceList;
        private System.Windows.Forms.Button bLoad;
    }
}