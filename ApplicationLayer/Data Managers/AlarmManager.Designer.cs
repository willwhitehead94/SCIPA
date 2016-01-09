namespace ApplicationLayer.DataManagers
{
    partial class AlarmManager
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
            this.tcManager = new System.Windows.Forms.TabControl();
            this.tpExisting = new System.Windows.Forms.TabPage();
            this.bTopHundred = new System.Windows.Forms.Button();
            this.bAll = new System.Windows.Forms.Button();
            this.pData = new System.Windows.Forms.Panel();
            this.lId = new System.Windows.Forms.Label();
            this.lIdData = new System.Windows.Forms.Label();
            this.lDeviceId = new System.Windows.Forms.Label();
            this.lDeviceData = new System.Windows.Forms.Label();
            this.lTypeId = new System.Windows.Forms.Label();
            this.lAlarmTypeData = new System.Windows.Forms.Label();
            this.lLatest = new System.Windows.Forms.Label();
            this.lLatestData = new System.Windows.Forms.Label();
            this.lEnabled = new System.Windows.Forms.Label();
            this.lEnabledData = new System.Windows.Forms.Label();
            this.lbExisting = new System.Windows.Forms.ListBox();
            this.tpNew = new System.Windows.Forms.TabPage();
            this.bOffline = new System.Windows.Forms.Button();
            this.tcManager.SuspendLayout();
            this.tpExisting.SuspendLayout();
            this.pData.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcManager
            // 
            this.tcManager.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcManager.Controls.Add(this.tpExisting);
            this.tcManager.Controls.Add(this.tpNew);
            this.tcManager.Location = new System.Drawing.Point(12, 12);
            this.tcManager.Name = "tcManager";
            this.tcManager.SelectedIndex = 0;
            this.tcManager.Size = new System.Drawing.Size(649, 288);
            this.tcManager.TabIndex = 0;
            // 
            // tpExisting
            // 
            this.tpExisting.Controls.Add(this.bOffline);
            this.tpExisting.Controls.Add(this.bTopHundred);
            this.tpExisting.Controls.Add(this.bAll);
            this.tpExisting.Controls.Add(this.pData);
            this.tpExisting.Controls.Add(this.lbExisting);
            this.tpExisting.Location = new System.Drawing.Point(4, 22);
            this.tpExisting.Name = "tpExisting";
            this.tpExisting.Padding = new System.Windows.Forms.Padding(3);
            this.tpExisting.Size = new System.Drawing.Size(641, 262);
            this.tpExisting.TabIndex = 0;
            this.tpExisting.Text = "Existing Objects";
            this.tpExisting.UseVisualStyleBackColor = true;
            // 
            // bTopHundred
            // 
            this.bTopHundred.Location = new System.Drawing.Point(447, 7);
            this.bTopHundred.Name = "bTopHundred";
            this.bTopHundred.Size = new System.Drawing.Size(91, 23);
            this.bTopHundred.TabIndex = 15;
            this.bTopHundred.Text = "Get Top 100";
            this.bTopHundred.UseVisualStyleBackColor = true;
            this.bTopHundred.Click += new System.EventHandler(this.bTopHundred_Click);
            // 
            // bAll
            // 
            this.bAll.Location = new System.Drawing.Point(274, 7);
            this.bAll.Name = "bAll";
            this.bAll.Size = new System.Drawing.Size(167, 23);
            this.bAll.TabIndex = 12;
            this.bAll.Text = "Get All";
            this.bAll.UseVisualStyleBackColor = true;
            this.bAll.Click += new System.EventHandler(this.bAll_Click);
            // 
            // pData
            // 
            this.pData.Controls.Add(this.lId);
            this.pData.Controls.Add(this.lIdData);
            this.pData.Controls.Add(this.lDeviceId);
            this.pData.Controls.Add(this.lDeviceData);
            this.pData.Controls.Add(this.lTypeId);
            this.pData.Controls.Add(this.lAlarmTypeData);
            this.pData.Controls.Add(this.lLatest);
            this.pData.Controls.Add(this.lLatestData);
            this.pData.Controls.Add(this.lEnabled);
            this.pData.Controls.Add(this.lEnabledData);
            this.pData.Location = new System.Drawing.Point(322, 112);
            this.pData.Name = "pData";
            this.pData.Size = new System.Drawing.Size(267, 131);
            this.pData.TabIndex = 11;
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(7, 9);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(21, 13);
            this.lId.TabIndex = 1;
            this.lId.Text = "ID:";
            // 
            // lIdData
            // 
            this.lIdData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lIdData.AutoSize = true;
            this.lIdData.Location = new System.Drawing.Point(82, 9);
            this.lIdData.Name = "lIdData";
            this.lIdData.Size = new System.Drawing.Size(53, 13);
            this.lIdData.TabIndex = 10;
            this.lIdData.Text = "Unknown";
            // 
            // lDeviceId
            // 
            this.lDeviceId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lDeviceId.AutoSize = true;
            this.lDeviceId.Location = new System.Drawing.Point(7, 32);
            this.lDeviceId.Name = "lDeviceId";
            this.lDeviceId.Size = new System.Drawing.Size(44, 13);
            this.lDeviceId.TabIndex = 2;
            this.lDeviceId.Text = "Device:";
            // 
            // lDeviceData
            // 
            this.lDeviceData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lDeviceData.AutoSize = true;
            this.lDeviceData.Location = new System.Drawing.Point(82, 32);
            this.lDeviceData.Name = "lDeviceData";
            this.lDeviceData.Size = new System.Drawing.Size(53, 13);
            this.lDeviceData.TabIndex = 9;
            this.lDeviceData.Text = "Unknown";
            // 
            // lTypeId
            // 
            this.lTypeId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lTypeId.AutoSize = true;
            this.lTypeId.Location = new System.Drawing.Point(6, 56);
            this.lTypeId.Name = "lTypeId";
            this.lTypeId.Size = new System.Drawing.Size(63, 13);
            this.lTypeId.TabIndex = 3;
            this.lTypeId.Text = "Alarm Type:";
            // 
            // lAlarmTypeData
            // 
            this.lAlarmTypeData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lAlarmTypeData.AutoSize = true;
            this.lAlarmTypeData.Location = new System.Drawing.Point(82, 56);
            this.lAlarmTypeData.Name = "lAlarmTypeData";
            this.lAlarmTypeData.Size = new System.Drawing.Size(53, 13);
            this.lAlarmTypeData.TabIndex = 8;
            this.lAlarmTypeData.Text = "Unknown";
            // 
            // lLatest
            // 
            this.lLatest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lLatest.AutoSize = true;
            this.lLatest.Location = new System.Drawing.Point(6, 80);
            this.lLatest.Name = "lLatest";
            this.lLatest.Size = new System.Drawing.Size(69, 13);
            this.lLatest.TabIndex = 4;
            this.lLatest.Text = "Latest Value:";
            // 
            // lLatestData
            // 
            this.lLatestData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lLatestData.AutoSize = true;
            this.lLatestData.Location = new System.Drawing.Point(82, 80);
            this.lLatestData.Name = "lLatestData";
            this.lLatestData.Size = new System.Drawing.Size(53, 13);
            this.lLatestData.TabIndex = 7;
            this.lLatestData.Text = "Unknown";
            // 
            // lEnabled
            // 
            this.lEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lEnabled.AutoSize = true;
            this.lEnabled.Location = new System.Drawing.Point(6, 106);
            this.lEnabled.Name = "lEnabled";
            this.lEnabled.Size = new System.Drawing.Size(49, 13);
            this.lEnabled.TabIndex = 5;
            this.lEnabled.Text = "Enabled:";
            // 
            // lEnabledData
            // 
            this.lEnabledData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lEnabledData.AutoSize = true;
            this.lEnabledData.Location = new System.Drawing.Point(82, 106);
            this.lEnabledData.Name = "lEnabledData";
            this.lEnabledData.Size = new System.Drawing.Size(53, 13);
            this.lEnabledData.TabIndex = 6;
            this.lEnabledData.Text = "Unknown";
            // 
            // lbExisting
            // 
            this.lbExisting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbExisting.FormattingEnabled = true;
            this.lbExisting.Location = new System.Drawing.Point(6, 6);
            this.lbExisting.Name = "lbExisting";
            this.lbExisting.Size = new System.Drawing.Size(261, 251);
            this.lbExisting.TabIndex = 0;
            this.lbExisting.SelectedIndexChanged += new System.EventHandler(this.lbExisting_SelectedIndexChanged);
            // 
            // tpNew
            // 
            this.tpNew.Location = new System.Drawing.Point(4, 22);
            this.tpNew.Name = "tpNew";
            this.tpNew.Padding = new System.Windows.Forms.Padding(3);
            this.tpNew.Size = new System.Drawing.Size(641, 262);
            this.tpNew.TabIndex = 1;
            this.tpNew.Text = "Create New";
            this.tpNew.UseVisualStyleBackColor = true;
            // 
            // bOffline
            // 
            this.bOffline.Location = new System.Drawing.Point(544, 7);
            this.bOffline.Name = "bOffline";
            this.bOffline.Size = new System.Drawing.Size(91, 23);
            this.bOffline.TabIndex = 16;
            this.bOffline.Text = "Offline Load";
            this.bOffline.UseVisualStyleBackColor = true;
            this.bOffline.Click += new System.EventHandler(this.bOffline_Click);
            // 
            // AlarmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 312);
            this.Controls.Add(this.tcManager);
            this.Name = "AlarmManager";
            this.Text = "AlarmManager";
            this.tcManager.ResumeLayout(false);
            this.tpExisting.ResumeLayout(false);
            this.pData.ResumeLayout(false);
            this.pData.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcManager;
        private System.Windows.Forms.TabPage tpExisting;
        private System.Windows.Forms.TabPage tpNew;
        private System.Windows.Forms.ListBox lbExisting;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label lLatest;
        private System.Windows.Forms.Label lTypeId;
        private System.Windows.Forms.Label lDeviceId;
        private System.Windows.Forms.Button bTopHundred;
        private System.Windows.Forms.Button bAll;
        private System.Windows.Forms.Panel pData;
        private System.Windows.Forms.Label lIdData;
        private System.Windows.Forms.Label lDeviceData;
        private System.Windows.Forms.Label lAlarmTypeData;
        private System.Windows.Forms.Label lLatestData;
        private System.Windows.Forms.Label lEnabled;
        private System.Windows.Forms.Label lEnabledData;
        private System.Windows.Forms.Button bOffline;
    }
}