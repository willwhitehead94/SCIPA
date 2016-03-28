namespace SCIPA.UI.Object_Manager
{
    partial class AddAction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAction));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bCommunicator = new System.Windows.Forms.Button();
            this.lRule = new System.Windows.Forms.Label();
            this.cEnabled = new System.Windows.Forms.CheckBox();
            this.bSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(946, 109);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rule:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Communicator:";
            // 
            // tOutput
            // 
            this.tOutput.Location = new System.Drawing.Point(296, 244);
            this.tOutput.Name = "tOutput";
            this.tOutput.Size = new System.Drawing.Size(598, 35);
            this.tOutput.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Output Value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Enabled:";
            // 
            // bCommunicator
            // 
            this.bCommunicator.Location = new System.Drawing.Point(296, 203);
            this.bCommunicator.Name = "bCommunicator";
            this.bCommunicator.Size = new System.Drawing.Size(598, 35);
            this.bCommunicator.TabIndex = 9;
            this.bCommunicator.Text = "Set Communicator";
            this.bCommunicator.UseVisualStyleBackColor = true;
            this.bCommunicator.Click += new System.EventHandler(this.bCommunicator_Click);
            // 
            // lRule
            // 
            this.lRule.AutoSize = true;
            this.lRule.Location = new System.Drawing.Point(291, 165);
            this.lRule.Name = "lRule";
            this.lRule.Size = new System.Drawing.Size(247, 29);
            this.lRule.TabIndex = 10;
            this.lRule.Text = "Rule Information Here";
            // 
            // cEnabled
            // 
            this.cEnabled.AutoSize = true;
            this.cEnabled.Checked = true;
            this.cEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cEnabled.Location = new System.Drawing.Point(296, 285);
            this.cEnabled.Name = "cEnabled";
            this.cEnabled.Size = new System.Drawing.Size(377, 33);
            this.cEnabled.TabIndex = 11;
            this.cEnabled.Text = "Perform Action When Required";
            this.cEnabled.UseVisualStyleBackColor = true;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(395, 411);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(589, 105);
            this.bSave.TabIndex = 12;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // AddAction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 533);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.cEnabled);
            this.Controls.Add(this.lRule);
            this.Controls.Add(this.bCommunicator);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAction";
            this.Text = "AddAction";
            this.Load += new System.EventHandler(this.AddAction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bCommunicator;
        private System.Windows.Forms.Label lRule;
        private System.Windows.Forms.CheckBox cEnabled;
        private System.Windows.Forms.Button bSave;
    }
}