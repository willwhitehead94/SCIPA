namespace SCIPA.UI.HMI
{
    partial class DELETE
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
            this.pFile = new System.Windows.Forms.Panel();
            this.pDatabase = new System.Windows.Forms.Panel();
            this.pSerial = new System.Windows.Forms.Panel();
            this.cbDtr = new System.Windows.Forms.CheckBox();
            this.cbRts = new System.Windows.Forms.CheckBox();
            this.tDataBits = new System.Windows.Forms.TextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.tBaudRate = new System.Windows.Forms.TextBox();
            this.cbComPort = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.tQuery = new System.Windows.Forms.TextBox();
            this.cbDatabaseType = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.tConnectionString = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.tFilePath = new System.Windows.Forms.TextBox();
            this.label44 = new System.Windows.Forms.Label();
            this.pFile.SuspendLayout();
            this.pDatabase.SuspendLayout();
            this.pSerial.SuspendLayout();
            this.SuspendLayout();
            // 
            // pFile
            // 
            this.pFile.Controls.Add(this.tFilePath);
            this.pFile.Controls.Add(this.label44);
            this.pFile.Location = new System.Drawing.Point(954, 400);
            this.pFile.Name = "pFile";
            this.pFile.Size = new System.Drawing.Size(911, 259);
            this.pFile.TabIndex = 0;
            // 
            // pDatabase
            // 
            this.pDatabase.Controls.Add(this.label41);
            this.pDatabase.Controls.Add(this.tQuery);
            this.pDatabase.Controls.Add(this.cbDatabaseType);
            this.pDatabase.Controls.Add(this.label42);
            this.pDatabase.Controls.Add(this.tConnectionString);
            this.pDatabase.Controls.Add(this.label43);
            this.pDatabase.Location = new System.Drawing.Point(506, 822);
            this.pDatabase.Name = "pDatabase";
            this.pDatabase.Size = new System.Drawing.Size(911, 259);
            this.pDatabase.TabIndex = 25;
            // 
            // pSerial
            // 
            this.pSerial.Controls.Add(this.cbDtr);
            this.pSerial.Controls.Add(this.cbRts);
            this.pSerial.Controls.Add(this.tDataBits);
            this.pSerial.Controls.Add(this.label38);
            this.pSerial.Controls.Add(this.tBaudRate);
            this.pSerial.Controls.Add(this.cbComPort);
            this.pSerial.Controls.Add(this.label39);
            this.pSerial.Controls.Add(this.label40);
            this.pSerial.Location = new System.Drawing.Point(166, 62);
            this.pSerial.Name = "pSerial";
            this.pSerial.Size = new System.Drawing.Size(909, 699);
            this.pSerial.TabIndex = 27;
            // 
            // cbDtr
            // 
            this.cbDtr.AutoSize = true;
            this.cbDtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbDtr.Location = new System.Drawing.Point(21, 284);
            this.cbDtr.Name = "cbDtr";
            this.cbDtr.Size = new System.Drawing.Size(686, 52);
            this.cbDtr.TabIndex = 29;
            this.cbDtr.Text = "DTR (Data Terminal Ready) Mode";
            this.cbDtr.UseVisualStyleBackColor = true;
            // 
            // cbRts
            // 
            this.cbRts.AutoSize = true;
            this.cbRts.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbRts.Location = new System.Drawing.Point(48, 226);
            this.cbRts.Name = "cbRts";
            this.cbRts.Size = new System.Drawing.Size(613, 52);
            this.cbRts.TabIndex = 28;
            this.cbRts.Text = "RTS (Request To Send) Mode";
            this.cbRts.UseVisualStyleBackColor = true;
            // 
            // tDataBits
            // 
            this.tDataBits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tDataBits.Location = new System.Drawing.Point(257, 138);
            this.tDataBits.Name = "tDataBits";
            this.tDataBits.Size = new System.Drawing.Size(454, 55);
            this.tDataBits.TabIndex = 27;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label38.Location = new System.Drawing.Point(15, 141);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(202, 48);
            this.label38.TabIndex = 24;
            this.label38.Text = "Data Bits:";
            // 
            // tBaudRate
            // 
            this.tBaudRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tBaudRate.Location = new System.Drawing.Point(257, 77);
            this.tBaudRate.Name = "tBaudRate";
            this.tBaudRate.Size = new System.Drawing.Size(454, 55);
            this.tBaudRate.TabIndex = 26;
            // 
            // cbComPort
            // 
            this.cbComPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbComPort.FormattingEnabled = true;
            this.cbComPort.Location = new System.Drawing.Point(257, 15);
            this.cbComPort.Name = "cbComPort";
            this.cbComPort.Size = new System.Drawing.Size(454, 56);
            this.cbComPort.TabIndex = 23;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label39.Location = new System.Drawing.Point(15, 80);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(228, 48);
            this.label39.TabIndex = 25;
            this.label39.Text = "Baud Rate:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label40.Location = new System.Drawing.Point(23, 18);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(218, 48);
            this.label40.TabIndex = 23;
            this.label40.Text = "COM Port:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label41.Location = new System.Drawing.Point(23, 100);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(314, 48);
            this.label41.TabIndex = 24;
            this.label41.Text = "Database Type:";
            // 
            // tQuery
            // 
            this.tQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tQuery.Location = new System.Drawing.Point(267, 56);
            this.tQuery.Name = "tQuery";
            this.tQuery.Size = new System.Drawing.Size(344, 55);
            this.tQuery.TabIndex = 26;
            // 
            // cbDatabaseType
            // 
            this.cbDatabaseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.cbDatabaseType.FormattingEnabled = true;
            this.cbDatabaseType.Location = new System.Drawing.Point(267, 97);
            this.cbDatabaseType.Name = "cbDatabaseType";
            this.cbDatabaseType.Size = new System.Drawing.Size(344, 56);
            this.cbDatabaseType.TabIndex = 23;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label42.Location = new System.Drawing.Point(23, 59);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(146, 48);
            this.label42.TabIndex = 25;
            this.label42.Text = "Query:";
            // 
            // tConnectionString
            // 
            this.tConnectionString.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tConnectionString.Location = new System.Drawing.Point(267, 15);
            this.tConnectionString.Name = "tConnectionString";
            this.tConnectionString.Size = new System.Drawing.Size(344, 55);
            this.tConnectionString.TabIndex = 24;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label43.Location = new System.Drawing.Point(23, 18);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(364, 48);
            this.label43.TabIndex = 23;
            this.label43.Text = "Connection String:";
            // 
            // tFilePath
            // 
            this.tFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.tFilePath.Location = new System.Drawing.Point(267, 15);
            this.tFilePath.Name = "tFilePath";
            this.tFilePath.Size = new System.Drawing.Size(306, 55);
            this.tFilePath.TabIndex = 24;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label44.Location = new System.Drawing.Point(23, 18);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(198, 48);
            this.label44.TabIndex = 23;
            this.label44.Text = "File Path:";
            // 
            // DELETE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1890, 1151);
            this.Controls.Add(this.pFile);
            this.Controls.Add(this.pDatabase);
            this.Controls.Add(this.pSerial);
            this.Name = "DELETE";
            this.Text = "DELETE";
            this.pFile.ResumeLayout(false);
            this.pFile.PerformLayout();
            this.pDatabase.ResumeLayout(false);
            this.pDatabase.PerformLayout();
            this.pSerial.ResumeLayout(false);
            this.pSerial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pFile;
        private System.Windows.Forms.TextBox tFilePath;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Panel pDatabase;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox tQuery;
        private System.Windows.Forms.ComboBox cbDatabaseType;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox tConnectionString;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Panel pSerial;
        private System.Windows.Forms.CheckBox cbDtr;
        private System.Windows.Forms.CheckBox cbRts;
        private System.Windows.Forms.TextBox tDataBits;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox tBaudRate;
        private System.Windows.Forms.ComboBox cbComPort;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
    }
}