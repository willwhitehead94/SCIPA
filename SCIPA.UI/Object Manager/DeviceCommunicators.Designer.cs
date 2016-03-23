namespace SCIPA.UI.Object_Manager
{
    partial class DeviceCommunicators
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
            this.cbDevices = new System.Windows.Forms.ComboBox();
            this.bStart = new System.Windows.Forms.Button();
            this.cbCommunicators = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbValues = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbDevices
            // 
            this.cbDevices.FormattingEnabled = true;
            this.cbDevices.Location = new System.Drawing.Point(124, 83);
            this.cbDevices.Name = "cbDevices";
            this.cbDevices.Size = new System.Drawing.Size(799, 37);
            this.cbDevices.TabIndex = 0;
            this.cbDevices.SelectedIndexChanged += new System.EventHandler(this.cbDevices_SelectedIndexChanged);
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(421, 257);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(203, 154);
            this.bStart.TabIndex = 1;
            this.bStart.Text = "Start";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // cbCommunicators
            // 
            this.cbCommunicators.FormattingEnabled = true;
            this.cbCommunicators.Location = new System.Drawing.Point(124, 191);
            this.cbCommunicators.Name = "cbCommunicators";
            this.cbCommunicators.Size = new System.Drawing.Size(799, 37);
            this.cbCommunicators.TabIndex = 2;
            this.cbCommunicators.SelectedIndexChanged += new System.EventHandler(this.cbCommunicators_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select the Device:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select the Commuicator:";
            // 
            // lbValues
            // 
            this.lbValues.FormattingEnabled = true;
            this.lbValues.ItemHeight = 29;
            this.lbValues.Location = new System.Drawing.Point(38, 443);
            this.lbValues.Name = "lbValues";
            this.lbValues.Size = new System.Drawing.Size(948, 439);
            this.lbValues.TabIndex = 5;
            // 
            // DeviceCommunicators
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 911);
            this.Controls.Add(this.lbValues);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCommunicators);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.cbDevices);
            this.Name = "DeviceCommunicators";
            this.Text = "DeviceCommunicators";
            this.Load += new System.EventHandler(this.DeviceCommunicators_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDevices;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.ComboBox cbCommunicators;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbValues;
    }
}