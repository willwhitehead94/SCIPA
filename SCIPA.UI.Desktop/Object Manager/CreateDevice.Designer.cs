namespace SCIPA.UI
{
    partial class CreateDevice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDevice));
            this.lMessage = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tId = new System.Windows.Forms.TextBox();
            this.tName = new System.Windows.Forms.TextBox();
            this.tCustodian = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tLocation = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbTrue = new System.Windows.Forms.RadioButton();
            this.rbFalse = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.bAddSource = new System.Windows.Forms.Button();
            this.lSource = new System.Windows.Forms.Label();
            this.lDestination = new System.Windows.Forms.Label();
            this.bAddDestination = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lRules = new System.Windows.Forms.Label();
            this.bAddRule = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lMessage
            // 
            this.lMessage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lMessage.Location = new System.Drawing.Point(13, 13);
            this.lMessage.Name = "lMessage";
            this.lMessage.Size = new System.Drawing.Size(373, 59);
            this.lMessage.TabIndex = 0;
            this.lMessage.Text = resources.GetString("lMessage.Text");
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(12, 78);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(61, 13);
            this.lId.TabIndex = 1;
            this.lId.Text = "ID Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Device Name:";
            // 
            // tId
            // 
            this.tId.Enabled = false;
            this.tId.Location = new System.Drawing.Point(140, 75);
            this.tId.Name = "tId";
            this.tId.Size = new System.Drawing.Size(246, 20);
            this.tId.TabIndex = 3;
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(140, 101);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(246, 20);
            this.tName.TabIndex = 4;
            this.tName.Text = "Test Arduino";
            // 
            // tCustodian
            // 
            this.tCustodian.Location = new System.Drawing.Point(140, 153);
            this.tCustodian.Name = "tCustodian";
            this.tCustodian.Size = new System.Drawing.Size(246, 20);
            this.tCustodian.TabIndex = 6;
            this.tCustodian.Text = "W. Whitehead";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Custodian:";
            // 
            // tLocation
            // 
            this.tLocation.Location = new System.Drawing.Point(140, 127);
            this.tLocation.Name = "tLocation";
            this.tLocation.Size = new System.Drawing.Size(246, 20);
            this.tLocation.TabIndex = 8;
            this.tLocation.Text = "Under - Desk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Location:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Enabled:";
            // 
            // rbTrue
            // 
            this.rbTrue.AutoSize = true;
            this.rbTrue.Location = new System.Drawing.Point(140, 180);
            this.rbTrue.Name = "rbTrue";
            this.rbTrue.Size = new System.Drawing.Size(47, 17);
            this.rbTrue.TabIndex = 10;
            this.rbTrue.TabStop = true;
            this.rbTrue.Text = "True";
            this.rbTrue.UseVisualStyleBackColor = true;
            // 
            // rbFalse
            // 
            this.rbFalse.AutoSize = true;
            this.rbFalse.Location = new System.Drawing.Point(193, 180);
            this.rbFalse.Name = "rbFalse";
            this.rbFalse.Size = new System.Drawing.Size(50, 17);
            this.rbFalse.TabIndex = 11;
            this.rbFalse.TabStop = true;
            this.rbFalse.Text = "False";
            this.rbFalse.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Source:";
            // 
            // bAddSource
            // 
            this.bAddSource.Location = new System.Drawing.Point(140, 203);
            this.bAddSource.Name = "bAddSource";
            this.bAddSource.Size = new System.Drawing.Size(141, 23);
            this.bAddSource.TabIndex = 13;
            this.bAddSource.Text = "Add Inbound Source";
            this.bAddSource.UseVisualStyleBackColor = true;
            this.bAddSource.Click += new System.EventHandler(this.bAddSource_Click);
            // 
            // lSource
            // 
            this.lSource.AutoSize = true;
            this.lSource.Location = new System.Drawing.Point(287, 208);
            this.lSource.Name = "lSource";
            this.lSource.Size = new System.Drawing.Size(72, 13);
            this.lSource.TabIndex = 14;
            this.lSource.Text = "No Sources...";
            // 
            // lDestination
            // 
            this.lDestination.AutoSize = true;
            this.lDestination.Location = new System.Drawing.Point(287, 237);
            this.lDestination.Name = "lDestination";
            this.lDestination.Size = new System.Drawing.Size(86, 13);
            this.lDestination.TabIndex = 17;
            this.lDestination.Text = "No Destination...";
            // 
            // bAddDestination
            // 
            this.bAddDestination.Location = new System.Drawing.Point(140, 232);
            this.bAddDestination.Name = "bAddDestination";
            this.bAddDestination.Size = new System.Drawing.Size(141, 23);
            this.bAddDestination.TabIndex = 16;
            this.bAddDestination.Text = "Add Outbound Destination";
            this.bAddDestination.UseVisualStyleBackColor = true;
            this.bAddDestination.Click += new System.EventHandler(this.bAddDestination_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Destination:";
            // 
            // lRules
            // 
            this.lRules.AutoSize = true;
            this.lRules.Location = new System.Drawing.Point(287, 266);
            this.lRules.Name = "lRules";
            this.lRules.Size = new System.Drawing.Size(60, 13);
            this.lRules.TabIndex = 20;
            this.lRules.Text = "No Rules...";
            // 
            // bAddRule
            // 
            this.bAddRule.Location = new System.Drawing.Point(140, 261);
            this.bAddRule.Name = "bAddRule";
            this.bAddRule.Size = new System.Drawing.Size(141, 23);
            this.bAddRule.TabIndex = 19;
            this.bAddRule.Text = "Add Rule";
            this.bAddRule.UseVisualStyleBackColor = true;
            this.bAddRule.Click += new System.EventHandler(this.bAddRule_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Rules:";
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(245, 300);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(141, 45);
            this.bSave.TabIndex = 21;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(185, 300);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(54, 45);
            this.bCancel.TabIndex = 22;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // CreateDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 359);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.lRules);
            this.Controls.Add(this.bAddRule);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lDestination);
            this.Controls.Add(this.bAddDestination);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lSource);
            this.Controls.Add(this.bAddSource);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbFalse);
            this.Controls.Add(this.rbTrue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tLocation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tCustodian);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.tId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lId);
            this.Controls.Add(this.lMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreateDevice";
            this.Text = "Create New Device";
            this.Load += new System.EventHandler(this.CreateDevice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lMessage;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tId;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.TextBox tCustodian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbTrue;
        private System.Windows.Forms.RadioButton rbFalse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bAddSource;
        private System.Windows.Forms.Label lSource;
        private System.Windows.Forms.Label lDestination;
        private System.Windows.Forms.Button bAddDestination;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lRules;
        private System.Windows.Forms.Button bAddRule;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
    }
}