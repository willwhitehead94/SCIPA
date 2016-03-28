namespace SCIPA.UI
{
    partial class AddCommunicator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddInbound));
            this.lHeader = new System.Windows.Forms.Label();
            this.tcSourceType = new System.Windows.Forms.TabControl();
            this.tpDatabase = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.cbDBType = new System.Windows.Forms.ComboBox();
            this.tQuery = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tConnString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lDBMessage = new System.Windows.Forms.Label();
            this.tpFile = new System.Windows.Forms.TabPage();
            this.tFilePath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lFFMessage = new System.Windows.Forms.Label();
            this.tpSerial = new System.Windows.Forms.TabPage();
            this.bReloadSerialCommList = new System.Windows.Forms.Button();
            this.cDTR = new System.Windows.Forms.CheckBox();
            this.cRTS = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tBaud = new System.Windows.Forms.TextBox();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tBit = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lSMessage = new System.Windows.Forms.Label();
            this.bCancel = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbValueType = new System.Windows.Forms.ComboBox();
            this.tStartChar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tEndChar = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bStartEndHelp = new System.Windows.Forms.Button();
            this.tcSourceType.SuspendLayout();
            this.tpDatabase.SuspendLayout();
            this.tpFile.SuspendLayout();
            this.tpSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lHeader
            // 
            this.lHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lHeader.Location = new System.Drawing.Point(28, 20);
            this.lHeader.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lHeader.Name = "lHeader";
            this.lHeader.Size = new System.Drawing.Size(887, 51);
            this.lHeader.TabIndex = 0;
            this.lHeader.Text = "Adding a data source for device {0}, \"{1}\".";
            this.lHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tcSourceType
            // 
            this.tcSourceType.Controls.Add(this.tpDatabase);
            this.tcSourceType.Controls.Add(this.tpFile);
            this.tcSourceType.Controls.Add(this.tpSerial);
            this.tcSourceType.Location = new System.Drawing.Point(28, 78);
            this.tcSourceType.Margin = new System.Windows.Forms.Padding(7);
            this.tcSourceType.Name = "tcSourceType";
            this.tcSourceType.SelectedIndex = 0;
            this.tcSourceType.Size = new System.Drawing.Size(887, 446);
            this.tcSourceType.TabIndex = 1;
            // 
            // tpDatabase
            // 
            this.tpDatabase.Controls.Add(this.label7);
            this.tpDatabase.Controls.Add(this.cbDBType);
            this.tpDatabase.Controls.Add(this.tQuery);
            this.tpDatabase.Controls.Add(this.label2);
            this.tpDatabase.Controls.Add(this.tConnString);
            this.tpDatabase.Controls.Add(this.label1);
            this.tpDatabase.Controls.Add(this.lDBMessage);
            this.tpDatabase.Location = new System.Drawing.Point(10, 47);
            this.tpDatabase.Margin = new System.Windows.Forms.Padding(7);
            this.tpDatabase.Name = "tpDatabase";
            this.tpDatabase.Padding = new System.Windows.Forms.Padding(7);
            this.tpDatabase.Size = new System.Drawing.Size(867, 389);
            this.tpDatabase.TabIndex = 0;
            this.tpDatabase.Text = "Database";
            this.tpDatabase.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 310);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 29);
            this.label7.TabIndex = 28;
            this.label7.Text = "Database Type:";
            // 
            // cbDBType
            // 
            this.cbDBType.FormattingEnabled = true;
            this.cbDBType.Location = new System.Drawing.Point(292, 303);
            this.cbDBType.Margin = new System.Windows.Forms.Padding(7);
            this.cbDBType.Name = "cbDBType";
            this.cbDBType.Size = new System.Drawing.Size(557, 37);
            this.cbDBType.TabIndex = 27;
            this.cbDBType.SelectedIndexChanged += new System.EventHandler(this.cbDBType_SelectedIndexChanged);
            // 
            // tQuery
            // 
            this.tQuery.Location = new System.Drawing.Point(292, 245);
            this.tQuery.Margin = new System.Windows.Forms.Padding(7);
            this.tQuery.Name = "tQuery";
            this.tQuery.Size = new System.Drawing.Size(557, 35);
            this.tQuery.TabIndex = 4;
            this.tQuery.TextChanged += new System.EventHandler(this.tQuery_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 252);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Query:";
            // 
            // tConnString
            // 
            this.tConnString.Location = new System.Drawing.Point(292, 187);
            this.tConnString.Margin = new System.Windows.Forms.Padding(7);
            this.tConnString.Name = "tConnString";
            this.tConnString.Size = new System.Drawing.Size(557, 35);
            this.tConnString.TabIndex = 2;
            this.tConnString.TextChanged += new System.EventHandler(this.tConnString_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String:";
            // 
            // lDBMessage
            // 
            this.lDBMessage.Location = new System.Drawing.Point(14, 11);
            this.lDBMessage.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lDBMessage.Name = "lDBMessage";
            this.lDBMessage.Size = new System.Drawing.Size(840, 176);
            this.lDBMessage.TabIndex = 0;
            this.lDBMessage.Text = resources.GetString("lDBMessage.Text");
            // 
            // tpFile
            // 
            this.tpFile.Controls.Add(this.tFilePath);
            this.tpFile.Controls.Add(this.label9);
            this.tpFile.Controls.Add(this.lFFMessage);
            this.tpFile.Location = new System.Drawing.Point(10, 47);
            this.tpFile.Margin = new System.Windows.Forms.Padding(7);
            this.tpFile.Name = "tpFile";
            this.tpFile.Padding = new System.Windows.Forms.Padding(7);
            this.tpFile.Size = new System.Drawing.Size(867, 389);
            this.tpFile.TabIndex = 1;
            this.tpFile.Text = "Flat File";
            this.tpFile.UseVisualStyleBackColor = true;
            // 
            // tFilePath
            // 
            this.tFilePath.Location = new System.Drawing.Point(292, 174);
            this.tFilePath.Margin = new System.Windows.Forms.Padding(7);
            this.tFilePath.Name = "tFilePath";
            this.tFilePath.Size = new System.Drawing.Size(557, 35);
            this.tFilePath.TabIndex = 31;
            this.tFilePath.TextChanged += new System.EventHandler(this.tFilePath_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 181);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 29);
            this.label9.TabIndex = 30;
            this.label9.Text = "File Path:";
            // 
            // lFFMessage
            // 
            this.lFFMessage.Location = new System.Drawing.Point(14, 11);
            this.lFFMessage.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lFFMessage.Name = "lFFMessage";
            this.lFFMessage.Size = new System.Drawing.Size(840, 163);
            this.lFFMessage.TabIndex = 29;
            this.lFFMessage.Text = resources.GetString("lFFMessage.Text");
            // 
            // tpSerial
            // 
            this.tpSerial.Controls.Add(this.bReloadSerialCommList);
            this.tpSerial.Controls.Add(this.cDTR);
            this.tpSerial.Controls.Add(this.cRTS);
            this.tpSerial.Controls.Add(this.label4);
            this.tpSerial.Controls.Add(this.tBaud);
            this.tpSerial.Controls.Add(this.cbComPort);
            this.tpSerial.Controls.Add(this.label11);
            this.tpSerial.Controls.Add(this.tBit);
            this.tpSerial.Controls.Add(this.label12);
            this.tpSerial.Controls.Add(this.label13);
            this.tpSerial.Controls.Add(this.lSMessage);
            this.tpSerial.Location = new System.Drawing.Point(10, 47);
            this.tpSerial.Margin = new System.Windows.Forms.Padding(7);
            this.tpSerial.Name = "tpSerial";
            this.tpSerial.Size = new System.Drawing.Size(867, 389);
            this.tpSerial.TabIndex = 2;
            this.tpSerial.Text = "Serial";
            this.tpSerial.UseVisualStyleBackColor = true;
            // 
            // bReloadSerialCommList
            // 
            this.bReloadSerialCommList.BackColor = System.Drawing.Color.White;
            this.bReloadSerialCommList.Location = new System.Drawing.Point(815, 152);
            this.bReloadSerialCommList.Margin = new System.Windows.Forms.Padding(7);
            this.bReloadSerialCommList.Name = "bReloadSerialCommList";
            this.bReloadSerialCommList.Size = new System.Drawing.Size(34, 37);
            this.bReloadSerialCommList.TabIndex = 34;
            this.bReloadSerialCommList.Text = "⟳";
            this.bReloadSerialCommList.UseVisualStyleBackColor = false;
            this.bReloadSerialCommList.Click += new System.EventHandler(this.bReloadSerialCommList_Click);
            // 
            // cDTR
            // 
            this.cDTR.AutoSize = true;
            this.cDTR.Location = new System.Drawing.Point(516, 332);
            this.cDTR.Margin = new System.Windows.Forms.Padding(7);
            this.cDTR.Name = "cDTR";
            this.cDTR.Size = new System.Drawing.Size(191, 33);
            this.cDTR.TabIndex = 40;
            this.cDTR.Text = "DTR Enabled";
            this.cDTR.UseVisualStyleBackColor = true;
            this.cDTR.CheckedChanged += new System.EventHandler(this.cDTR_CheckedChanged);
            // 
            // cRTS
            // 
            this.cRTS.AutoSize = true;
            this.cRTS.Location = new System.Drawing.Point(292, 332);
            this.cRTS.Margin = new System.Windows.Forms.Padding(7);
            this.cRTS.Name = "cRTS";
            this.cRTS.Size = new System.Drawing.Size(190, 33);
            this.cRTS.TabIndex = 39;
            this.cRTS.Text = "RTS Enabled";
            this.cRTS.UseVisualStyleBackColor = true;
            this.cRTS.CheckedChanged += new System.EventHandler(this.cRTS_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 335);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 29);
            this.label4.TabIndex = 38;
            this.label4.Text = "Options:";
            // 
            // tBaud
            // 
            this.tBaud.Location = new System.Drawing.Point(292, 270);
            this.tBaud.Margin = new System.Windows.Forms.Padding(7);
            this.tBaud.Name = "tBaud";
            this.tBaud.Size = new System.Drawing.Size(557, 35);
            this.tBaud.TabIndex = 37;
            this.tBaud.TextChanged += new System.EventHandler(this.tBaud_TextChanged);
            // 
            // cbComPort
            // 
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(292, 152);
            this.cbComPort.Margin = new System.Windows.Forms.Padding(7);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(509, 37);
            this.cbComPort.TabIndex = 36;
            this.cbComPort.SelectedIndexChanged += new System.EventHandler(this.cbComPort_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 277);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 29);
            this.label11.TabIndex = 35;
            this.label11.Text = "Baud Rate:";
            // 
            // tBit
            // 
            this.tBit.Location = new System.Drawing.Point(292, 212);
            this.tBit.Margin = new System.Windows.Forms.Padding(7);
            this.tBit.Name = "tBit";
            this.tBit.Size = new System.Drawing.Size(557, 35);
            this.tBit.TabIndex = 33;
            this.tBit.TextChanged += new System.EventHandler(this.tBit_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 219);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 29);
            this.label12.TabIndex = 32;
            this.label12.Text = "Bits:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 161);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(125, 29);
            this.label13.TabIndex = 30;
            this.label13.Text = "COM Port:";
            // 
            // lSMessage
            // 
            this.lSMessage.Location = new System.Drawing.Point(14, 11);
            this.lSMessage.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lSMessage.Name = "lSMessage";
            this.lSMessage.Size = new System.Drawing.Size(840, 176);
            this.lSMessage.TabIndex = 29;
            this.lSMessage.Text = resources.GetString("lSMessage.Text");
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(436, 743);
            this.bCancel.Margin = new System.Windows.Forms.Padding(7);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(126, 100);
            this.bCancel.TabIndex = 24;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(576, 743);
            this.bSave.Margin = new System.Windows.Forms.Padding(7);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(329, 100);
            this.bSave.TabIndex = 23;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 544);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 26;
            this.label3.Text = "Value Type:";
            // 
            // cbValueType
            // 
            this.cbValueType.FormattingEnabled = true;
            this.cbValueType.Location = new System.Drawing.Point(329, 538);
            this.cbValueType.Margin = new System.Windows.Forms.Padding(7);
            this.cbValueType.Name = "cbValueType";
            this.cbValueType.Size = new System.Drawing.Size(557, 37);
            this.cbValueType.TabIndex = 25;
            // 
            // tStartChar
            // 
            this.tStartChar.Location = new System.Drawing.Point(329, 598);
            this.tStartChar.Margin = new System.Windows.Forms.Padding(7);
            this.tStartChar.Name = "tStartChar";
            this.tStartChar.Size = new System.Drawing.Size(478, 35);
            this.tStartChar.TabIndex = 30;
            this.tStartChar.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 605);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 29);
            this.label5.TabIndex = 29;
            this.label5.Text = "Start Reading From:";
            // 
            // tEndChar
            // 
            this.tEndChar.Location = new System.Drawing.Point(329, 656);
            this.tEndChar.Margin = new System.Windows.Forms.Padding(7);
            this.tEndChar.Name = "tEndChar";
            this.tEndChar.Size = new System.Drawing.Size(478, 35);
            this.tEndChar.TabIndex = 32;
            this.tEndChar.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 663);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(236, 29);
            this.label6.TabIndex = 31;
            this.label6.Text = "Charectors To Read:";
            // 
            // bStartEndHelp
            // 
            this.bStartEndHelp.Location = new System.Drawing.Point(826, 598);
            this.bStartEndHelp.Margin = new System.Windows.Forms.Padding(7);
            this.bStartEndHelp.Name = "bStartEndHelp";
            this.bStartEndHelp.Size = new System.Drawing.Size(65, 103);
            this.bStartEndHelp.TabIndex = 33;
            this.bStartEndHelp.Text = "?";
            this.bStartEndHelp.UseVisualStyleBackColor = true;
            this.bStartEndHelp.Click += new System.EventHandler(this.bStartEndHelp_Click);
            // 
            // AddInbound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 872);
            this.Controls.Add(this.bStartEndHelp);
            this.Controls.Add(this.tEndChar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tStartChar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbValueType);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.tcSourceType);
            this.Controls.Add(this.lHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddInbound";
            this.Text = "Add Data Source";
            this.Load += new System.EventHandler(this.AddInbound_Load);
            this.tcSourceType.ResumeLayout(false);
            this.tpDatabase.ResumeLayout(false);
            this.tpDatabase.PerformLayout();
            this.tpFile.ResumeLayout(false);
            this.tpFile.PerformLayout();
            this.tpSerial.ResumeLayout(false);
            this.tpSerial.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lHeader;
        private System.Windows.Forms.TabControl tcSourceType;
        private System.Windows.Forms.TabPage tpDatabase;
        private System.Windows.Forms.TabPage tpFile;
        private System.Windows.Forms.TabPage tpSerial;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.TextBox tQuery;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tConnString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lDBMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbValueType;
        private System.Windows.Forms.TextBox tStartChar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tEndChar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button bStartEndHelp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbDBType;
        private System.Windows.Forms.TextBox tFilePath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lFFMessage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tBit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lSMessage;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.CheckBox cDTR;
        private System.Windows.Forms.CheckBox cRTS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBaud;
        private System.Windows.Forms.Button bReloadSerialCommList;
    }
}