namespace SCIPA.UI
{
    partial class AddInbound
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
            this.lDeviceId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lDeviceId
            // 
            this.lDeviceId.AutoSize = true;
            this.lDeviceId.Location = new System.Drawing.Point(145, 13);
            this.lDeviceId.Name = "lDeviceId";
            this.lDeviceId.Size = new System.Drawing.Size(35, 13);
            this.lDeviceId.TabIndex = 0;
            this.lDeviceId.Text = "label1";
            // 
            // AddInbound
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 261);
            this.Controls.Add(this.lDeviceId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddInbound";
            this.Text = "Add Data Source";
            this.Load += new System.EventHandler(this.AddInbound_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDeviceId;
    }
}