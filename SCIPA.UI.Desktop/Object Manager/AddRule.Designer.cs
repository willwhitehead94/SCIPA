namespace SCIPA.UI.Object_Manager
{
    partial class AddRule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRule));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lDevice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tConstraint = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbValueType = new System.Windows.Forms.ComboBox();
            this.cbRuleType = new System.Windows.Forms.ComboBox();
            this.cAlarm = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bSetAction = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.lAction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(931, 139);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device:";
            // 
            // lDevice
            // 
            this.lDevice.AutoSize = true;
            this.lDevice.Location = new System.Drawing.Point(295, 156);
            this.lDevice.Name = "lDevice";
            this.lDevice.Size = new System.Drawing.Size(271, 29);
            this.lDevice.TabIndex = 2;
            this.lDevice.Text = "Device Information Here";
            this.lDevice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rule Name:";
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(300, 188);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(542, 35);
            this.tName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Check Value Type:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 29);
            this.label5.TabIndex = 8;
            this.label5.Text = "Rule Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Constraint Value:";
            // 
            // tConstraint
            // 
            this.tConstraint.Location = new System.Drawing.Point(300, 311);
            this.tConstraint.Name = "tConstraint";
            this.tConstraint.Size = new System.Drawing.Size(542, 35);
            this.tConstraint.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 29);
            this.label8.TabIndex = 14;
            this.label8.Text = "Alarm Option:";
            // 
            // cbValueType
            // 
            this.cbValueType.FormattingEnabled = true;
            this.cbValueType.Location = new System.Drawing.Point(300, 227);
            this.cbValueType.Name = "cbValueType";
            this.cbValueType.Size = new System.Drawing.Size(542, 37);
            this.cbValueType.TabIndex = 15;
            this.cbValueType.SelectedIndexChanged += new System.EventHandler(this.cbValueType_SelectedIndexChanged);
            // 
            // cbRuleType
            // 
            this.cbRuleType.FormattingEnabled = true;
            this.cbRuleType.Location = new System.Drawing.Point(300, 270);
            this.cbRuleType.Name = "cbRuleType";
            this.cbRuleType.Size = new System.Drawing.Size(542, 37);
            this.cbRuleType.TabIndex = 16;
            // 
            // cAlarm
            // 
            this.cAlarm.AutoSize = true;
            this.cAlarm.Location = new System.Drawing.Point(300, 351);
            this.cAlarm.Name = "cAlarm";
            this.cAlarm.Size = new System.Drawing.Size(388, 33);
            this.cAlarm.TabIndex = 17;
            this.cAlarm.Text = "Raise Alarm Criterion Being Met";
            this.cAlarm.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 29);
            this.label7.TabIndex = 18;
            this.label7.Text = "Action To Take:";
            // 
            // bSetAction
            // 
            this.bSetAction.Location = new System.Drawing.Point(300, 390);
            this.bSetAction.Name = "bSetAction";
            this.bSetAction.Size = new System.Drawing.Size(235, 35);
            this.bSetAction.TabIndex = 19;
            this.bSetAction.Text = "Set Action";
            this.bSetAction.UseVisualStyleBackColor = true;
            this.bSetAction.Click += new System.EventHandler(this.bSetAction_Click);
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(300, 488);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(644, 71);
            this.bSave.TabIndex = 20;
            this.bSave.Text = "Save Rule";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(12, 488);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(278, 71);
            this.bCancel.TabIndex = 21;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            // 
            // lAction
            // 
            this.lAction.AutoSize = true;
            this.lAction.Location = new System.Drawing.Point(541, 393);
            this.lAction.Name = "lAction";
            this.lAction.Size = new System.Drawing.Size(171, 29);
            this.lAction.TabIndex = 22;
            this.lAction.Text = "No action set...";
            // 
            // AddRule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 855);
            this.Controls.Add(this.lAction);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.bSetAction);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cAlarm);
            this.Controls.Add(this.cbRuleType);
            this.Controls.Add(this.cbValueType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tConstraint);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lDevice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRule";
            this.Text = "AddRule";
            this.Load += new System.EventHandler(this.AddRule_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lDevice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tConstraint;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbValueType;
        private System.Windows.Forms.ComboBox cbRuleType;
        private System.Windows.Forms.CheckBox cAlarm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bSetAction;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.Label lAction;
    }
}