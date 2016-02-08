namespace ApplicationLayer.Connection_Managers
{
    partial class FlatFileManager
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
            this.tDeviceName = new System.Windows.Forms.TextBox();
            this.tFilePath = new System.Windows.Forms.TextBox();
            this.tFileName = new System.Windows.Forms.TextBox();
            this.tStartChar = new System.Windows.Forms.TextBox();
            this.tEndChar = new System.Windows.Forms.TextBox();
            this.tCheckEvery = new System.Windows.Forms.TextBox();
            this.tLastUpdate = new System.Windows.Forms.TextBox();
            this.cbReadOnly = new System.Windows.Forms.CheckBox();
            this.tDefaultValue = new System.Windows.Forms.TextBox();
            this.cbReadUpdateOnly = new System.Windows.Forms.CheckBox();
            this.cbNullable = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdPathFinder = new System.Windows.Forms.OpenFileDialog();
            this.bGetPath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gbExample = new System.Windows.Forms.GroupBox();
            this.fswExample = new System.IO.FileSystemWatcher();
            this.bQuestion = new System.Windows.Forms.Button();
            this.bQuestionTwo = new System.Windows.Forms.Button();
            this.bQuestionThree = new System.Windows.Forms.Button();
            this.bQuestionFour = new System.Windows.Forms.Button();
            this.bStartTest = new System.Windows.Forms.Button();
            this.cbValueType = new System.Windows.Forms.ComboBox();
            this.lDeviceId = new System.Windows.Forms.Label();
            this.tLastValue = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbFileAccessible = new System.Windows.Forms.CheckBox();
            this.cbInRange = new System.Windows.Forms.CheckBox();
            this.cbValueTypeOkay = new System.Windows.Forms.CheckBox();
            this.bSave = new System.Windows.Forms.Button();
            this.lWarning = new System.Windows.Forms.Label();
            this.gbExample.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fswExample)).BeginInit();
            this.SuspendLayout();
            // 
            // tDeviceName
            // 
            this.tDeviceName.Enabled = false;
            this.tDeviceName.Location = new System.Drawing.Point(117, 12);
            this.tDeviceName.Name = "tDeviceName";
            this.tDeviceName.Size = new System.Drawing.Size(325, 20);
            this.tDeviceName.TabIndex = 0;
            // 
            // tFilePath
            // 
            this.tFilePath.Enabled = false;
            this.tFilePath.Location = new System.Drawing.Point(198, 38);
            this.tFilePath.Name = "tFilePath";
            this.tFilePath.Size = new System.Drawing.Size(311, 20);
            this.tFilePath.TabIndex = 1;
            // 
            // tFileName
            // 
            this.tFileName.Enabled = false;
            this.tFileName.Location = new System.Drawing.Point(198, 64);
            this.tFileName.Name = "tFileName";
            this.tFileName.Size = new System.Drawing.Size(311, 20);
            this.tFileName.TabIndex = 2;
            // 
            // tStartChar
            // 
            this.tStartChar.Location = new System.Drawing.Point(117, 90);
            this.tStartChar.Name = "tStartChar";
            this.tStartChar.Size = new System.Drawing.Size(370, 20);
            this.tStartChar.TabIndex = 3;
            this.tStartChar.Text = "0";
            this.tStartChar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyAllowDigits_KeyPress);
            // 
            // tEndChar
            // 
            this.tEndChar.Location = new System.Drawing.Point(117, 116);
            this.tEndChar.Name = "tEndChar";
            this.tEndChar.Size = new System.Drawing.Size(370, 20);
            this.tEndChar.TabIndex = 4;
            this.tEndChar.Text = "0";
            this.tEndChar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyAllowDigits_KeyPress);
            // 
            // tCheckEvery
            // 
            this.tCheckEvery.Location = new System.Drawing.Point(117, 191);
            this.tCheckEvery.Name = "tCheckEvery";
            this.tCheckEvery.Size = new System.Drawing.Size(370, 20);
            this.tCheckEvery.TabIndex = 6;
            this.tCheckEvery.Text = "5";
            this.tCheckEvery.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyAllowDigits_KeyPress);
            // 
            // tLastUpdate
            // 
            this.tLastUpdate.Enabled = false;
            this.tLastUpdate.Location = new System.Drawing.Point(105, 19);
            this.tLastUpdate.Name = "tLastUpdate";
            this.tLastUpdate.Size = new System.Drawing.Size(370, 20);
            this.tLastUpdate.TabIndex = 7;
            // 
            // cbReadOnly
            // 
            this.cbReadOnly.AutoSize = true;
            this.cbReadOnly.Location = new System.Drawing.Point(117, 168);
            this.cbReadOnly.Name = "cbReadOnly";
            this.cbReadOnly.Size = new System.Drawing.Size(213, 17);
            this.cbReadOnly.TabIndex = 8;
            this.cbReadOnly.Text = "Always open the file in \'read only\' mode.";
            this.cbReadOnly.UseVisualStyleBackColor = true;
            this.cbReadOnly.CheckedChanged += new System.EventHandler(this.cbReadOnly_CheckedChanged);
            // 
            // tDefaultValue
            // 
            this.tDefaultValue.Location = new System.Drawing.Point(117, 240);
            this.tDefaultValue.Name = "tDefaultValue";
            this.tDefaultValue.Size = new System.Drawing.Size(392, 20);
            this.tDefaultValue.TabIndex = 9;
            this.tDefaultValue.Text = "null";
            // 
            // cbReadUpdateOnly
            // 
            this.cbReadUpdateOnly.AutoSize = true;
            this.cbReadUpdateOnly.Location = new System.Drawing.Point(117, 217);
            this.cbReadUpdateOnly.Name = "cbReadUpdateOnly";
            this.cbReadUpdateOnly.Size = new System.Drawing.Size(246, 17);
            this.cbReadUpdateOnly.TabIndex = 10;
            this.cbReadUpdateOnly.Text = "Only read the file if the timestamp has updated.";
            this.cbReadUpdateOnly.UseVisualStyleBackColor = true;
            this.cbReadUpdateOnly.CheckedChanged += new System.EventHandler(this.cbReadUpdateOnly_CheckedChanged);
            // 
            // cbNullable
            // 
            this.cbNullable.AutoSize = true;
            this.cbNullable.Checked = true;
            this.cbNullable.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbNullable.Location = new System.Drawing.Point(117, 266);
            this.cbNullable.Name = "cbNullable";
            this.cbNullable.Size = new System.Drawing.Size(133, 17);
            this.cbNullable.TabIndex = 11;
            this.cbNullable.Text = "This value can be null.";
            this.cbNullable.UseVisualStyleBackColor = true;
            this.cbNullable.CheckedChanged += new System.EventHandler(this.cbNullable_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Associated Device:";
            // 
            // ofdPathFinder
            // 
            this.ofdPathFinder.FileName = "openFileDialog1";
            // 
            // bGetPath
            // 
            this.bGetPath.Location = new System.Drawing.Point(117, 35);
            this.bGetPath.Name = "bGetPath";
            this.bGetPath.Size = new System.Drawing.Size(75, 49);
            this.bGetPath.TabIndex = 13;
            this.bGetPath.Text = "Find File";
            this.bGetPath.UseVisualStyleBackColor = true;
            this.bGetPath.Click += new System.EventHandler(this.bGetPath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "File Path:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "File Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Value Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "End Char:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Start Char:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Last Update:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Check Interval:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 169);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Read Only:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 270);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Nullable:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 244);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Default Value:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Read Updates Only:";
            // 
            // gbExample
            // 
            this.gbExample.Controls.Add(this.label13);
            this.gbExample.Controls.Add(this.tLastValue);
            this.gbExample.Controls.Add(this.tLastUpdate);
            this.gbExample.Controls.Add(this.label7);
            this.gbExample.Controls.Add(this.bQuestionFour);
            this.gbExample.Location = new System.Drawing.Point(12, 318);
            this.gbExample.Name = "gbExample";
            this.gbExample.Size = new System.Drawing.Size(503, 75);
            this.gbExample.TabIndex = 25;
            this.gbExample.TabStop = false;
            this.gbExample.Text = "System Recieved Values";
            // 
            // fswExample
            // 
            this.fswExample.EnableRaisingEvents = true;
            this.fswExample.SynchronizingObject = this;
            // 
            // bQuestion
            // 
            this.bQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuestion.Location = new System.Drawing.Point(493, 90);
            this.bQuestion.Name = "bQuestion";
            this.bQuestion.Size = new System.Drawing.Size(16, 23);
            this.bQuestion.TabIndex = 26;
            this.bQuestion.Text = "?";
            this.bQuestion.UseVisualStyleBackColor = true;
            this.bQuestion.Click += new System.EventHandler(this.bQuestion_Click);
            // 
            // bQuestionTwo
            // 
            this.bQuestionTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuestionTwo.Location = new System.Drawing.Point(493, 116);
            this.bQuestionTwo.Name = "bQuestionTwo";
            this.bQuestionTwo.Size = new System.Drawing.Size(16, 23);
            this.bQuestionTwo.TabIndex = 27;
            this.bQuestionTwo.Text = "?";
            this.bQuestionTwo.UseVisualStyleBackColor = true;
            this.bQuestionTwo.Click += new System.EventHandler(this.bQuestion_Click);
            // 
            // bQuestionThree
            // 
            this.bQuestionThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuestionThree.Location = new System.Drawing.Point(493, 189);
            this.bQuestionThree.Name = "bQuestionThree";
            this.bQuestionThree.Size = new System.Drawing.Size(16, 23);
            this.bQuestionThree.TabIndex = 28;
            this.bQuestionThree.Text = "?";
            this.bQuestionThree.UseVisualStyleBackColor = true;
            this.bQuestionThree.Click += new System.EventHandler(this.bQuestion_Click);
            // 
            // bQuestionFour
            // 
            this.bQuestionFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuestionFour.Location = new System.Drawing.Point(481, 17);
            this.bQuestionFour.Name = "bQuestionFour";
            this.bQuestionFour.Size = new System.Drawing.Size(16, 23);
            this.bQuestionFour.TabIndex = 29;
            this.bQuestionFour.Text = "?";
            this.bQuestionFour.UseVisualStyleBackColor = true;
            this.bQuestionFour.Click += new System.EventHandler(this.bQuestion_Click);
            // 
            // bStartTest
            // 
            this.bStartTest.Location = new System.Drawing.Point(15, 289);
            this.bStartTest.Name = "bStartTest";
            this.bStartTest.Size = new System.Drawing.Size(501, 23);
            this.bStartTest.TabIndex = 30;
            this.bStartTest.Text = "Begin Reading File";
            this.bStartTest.UseVisualStyleBackColor = true;
            this.bStartTest.Click += new System.EventHandler(this.bStartTest_Click);
            // 
            // cbValueType
            // 
            this.cbValueType.FormattingEnabled = true;
            this.cbValueType.Location = new System.Drawing.Point(117, 142);
            this.cbValueType.Name = "cbValueType";
            this.cbValueType.Size = new System.Drawing.Size(392, 21);
            this.cbValueType.TabIndex = 31;
            // 
            // lDeviceId
            // 
            this.lDeviceId.AutoSize = true;
            this.lDeviceId.Location = new System.Drawing.Point(448, 15);
            this.lDeviceId.Name = "lDeviceId";
            this.lDeviceId.Size = new System.Drawing.Size(68, 13);
            this.lDeviceId.TabIndex = 32;
            this.lDeviceId.Text = "#[Device ID]";
            // 
            // tLastValue
            // 
            this.tLastValue.Enabled = false;
            this.tLastValue.Location = new System.Drawing.Point(105, 45);
            this.tLastValue.Name = "tLastValue";
            this.tLastValue.Size = new System.Drawing.Size(370, 20);
            this.tLastValue.TabIndex = 33;
            this.tLastValue.TextChanged += new System.EventHandler(this.tLastValue_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 48);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Last Value:";
            // 
            // cbFileAccessible
            // 
            this.cbFileAccessible.AutoSize = true;
            this.cbFileAccessible.Enabled = false;
            this.cbFileAccessible.Location = new System.Drawing.Point(12, 399);
            this.cbFileAccessible.Name = "cbFileAccessible";
            this.cbFileAccessible.Size = new System.Drawing.Size(96, 17);
            this.cbFileAccessible.TabIndex = 33;
            this.cbFileAccessible.Text = "File Accessible";
            this.cbFileAccessible.UseVisualStyleBackColor = true;
            // 
            // cbInRange
            // 
            this.cbInRange.AutoSize = true;
            this.cbInRange.Enabled = false;
            this.cbInRange.Location = new System.Drawing.Point(117, 399);
            this.cbInRange.Name = "cbInRange";
            this.cbInRange.Size = new System.Drawing.Size(124, 17);
            this.cbInRange.TabIndex = 34;
            this.cbInRange.Text = "Characters In Range";
            this.cbInRange.UseVisualStyleBackColor = true;
            // 
            // cbValueTypeOkay
            // 
            this.cbValueTypeOkay.AutoSize = true;
            this.cbValueTypeOkay.Enabled = false;
            this.cbValueTypeOkay.Location = new System.Drawing.Point(247, 399);
            this.cbValueTypeOkay.Name = "cbValueTypeOkay";
            this.cbValueTypeOkay.Size = new System.Drawing.Size(117, 17);
            this.cbValueTypeOkay.TabIndex = 35;
            this.cbValueTypeOkay.Text = "Value Type Correct";
            this.cbValueTypeOkay.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(370, 395);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(145, 23);
            this.bSave.TabIndex = 36;
            this.bSave.Text = "Save Device";
            this.bSave.UseVisualStyleBackColor = true;
            // 
            // lWarning
            // 
            this.lWarning.AutoSize = true;
            this.lWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWarning.Location = new System.Drawing.Point(9, 428);
            this.lWarning.Name = "lWarning";
            this.lWarning.Size = new System.Drawing.Size(101, 15);
            this.lWarning.TabIndex = 37;
            this.lWarning.Text = "No Warnings...";
            // 
            // FlatFileManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 454);
            this.Controls.Add(this.lWarning);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.cbValueTypeOkay);
            this.Controls.Add(this.cbInRange);
            this.Controls.Add(this.cbFileAccessible);
            this.Controls.Add(this.lDeviceId);
            this.Controls.Add(this.cbValueType);
            this.Controls.Add(this.bStartTest);
            this.Controls.Add(this.bQuestionThree);
            this.Controls.Add(this.bQuestionTwo);
            this.Controls.Add(this.bQuestion);
            this.Controls.Add(this.gbExample);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bGetPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbNullable);
            this.Controls.Add(this.cbReadUpdateOnly);
            this.Controls.Add(this.tDefaultValue);
            this.Controls.Add(this.cbReadOnly);
            this.Controls.Add(this.tCheckEvery);
            this.Controls.Add(this.tEndChar);
            this.Controls.Add(this.tStartChar);
            this.Controls.Add(this.tFileName);
            this.Controls.Add(this.tFilePath);
            this.Controls.Add(this.tDeviceName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlatFileManager";
            this.Text = "FlatFileManager";
            this.Load += new System.EventHandler(this.FlatFileManager_Load);
            this.gbExample.ResumeLayout(false);
            this.gbExample.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fswExample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tDeviceName;
        private System.Windows.Forms.TextBox tFilePath;
        private System.Windows.Forms.TextBox tFileName;
        private System.Windows.Forms.TextBox tStartChar;
        private System.Windows.Forms.TextBox tEndChar;
        private System.Windows.Forms.TextBox tCheckEvery;
        private System.Windows.Forms.TextBox tLastUpdate;
        private System.Windows.Forms.CheckBox cbReadOnly;
        private System.Windows.Forms.TextBox tDefaultValue;
        private System.Windows.Forms.CheckBox cbReadUpdateOnly;
        private System.Windows.Forms.CheckBox cbNullable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdPathFinder;
        private System.Windows.Forms.Button bGetPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbExample;
        private System.IO.FileSystemWatcher fswExample;
        private System.Windows.Forms.Button bQuestion;
        private System.Windows.Forms.Button bQuestionFour;
        private System.Windows.Forms.Button bQuestionThree;
        private System.Windows.Forms.Button bQuestionTwo;
        private System.Windows.Forms.Button bStartTest;
        private System.Windows.Forms.ComboBox cbValueType;
        private System.Windows.Forms.Label lDeviceId;
        private System.Windows.Forms.TextBox tLastValue;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbFileAccessible;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.CheckBox cbValueTypeOkay;
        private System.Windows.Forms.CheckBox cbInRange;
        private System.Windows.Forms.Label lWarning;
    }
}