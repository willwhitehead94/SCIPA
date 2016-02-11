namespace ApplicationLayer
{
    partial class Boot
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbControls = new System.Windows.Forms.GroupBox();
            this.bShutdown = new System.Windows.Forms.Button();
            this.bStatus = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "SCIPA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 48);
            this.label2.TabIndex = 1;
            this.label2.Text = "Software Controller Industrial\r\nProcess Automation";
            // 
            // gbControls
            // 
            this.gbControls.Location = new System.Drawing.Point(12, 71);
            this.gbControls.Name = "gbControls";
            this.gbControls.Size = new System.Drawing.Size(431, 178);
            this.gbControls.TabIndex = 2;
            this.gbControls.TabStop = false;
            // 
            // bShutdown
            // 
            this.bShutdown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bShutdown.Location = new System.Drawing.Point(288, 255);
            this.bShutdown.Name = "bShutdown";
            this.bShutdown.Size = new System.Drawing.Size(155, 23);
            this.bShutdown.TabIndex = 3;
            this.bShutdown.Text = "Shutdown";
            this.bShutdown.UseVisualStyleBackColor = false;
            // 
            // bStatus
            // 
            this.bStatus.Location = new System.Drawing.Point(222, 255);
            this.bStatus.Name = "bStatus";
            this.bStatus.Size = new System.Drawing.Size(60, 23);
            this.bStatus.TabIndex = 4;
            this.bStatus.Text = "Status";
            this.bStatus.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "W. Whitehead (M2006199)";
            // 
            // Boot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 294);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bStatus);
            this.Controls.Add(this.bShutdown);
            this.Controls.Add(this.gbControls);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Boot";
            this.Text = "Software Controller Industrial Process Automation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbControls;
        private System.Windows.Forms.Button bShutdown;
        private System.Windows.Forms.Button bStatus;
        private System.Windows.Forms.Label label3;
    }
}