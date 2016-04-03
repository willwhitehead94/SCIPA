namespace SCIPA.UI.HMI
{
    partial class AdminPanel
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
            this.bSqlClear = new System.Windows.Forms.Button();
            this.bMongoClear = new System.Windows.Forms.Button();
            this.bLogClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bSqlClear
            // 
            this.bSqlClear.Location = new System.Drawing.Point(32, 32);
            this.bSqlClear.Name = "bSqlClear";
            this.bSqlClear.Size = new System.Drawing.Size(649, 107);
            this.bSqlClear.TabIndex = 0;
            this.bSqlClear.Text = "Clear SQL Database";
            this.bSqlClear.UseVisualStyleBackColor = true;
            this.bSqlClear.Click += new System.EventHandler(this.bSqlClear_Click);
            // 
            // bMongoClear
            // 
            this.bMongoClear.Location = new System.Drawing.Point(32, 145);
            this.bMongoClear.Name = "bMongoClear";
            this.bMongoClear.Size = new System.Drawing.Size(649, 107);
            this.bMongoClear.TabIndex = 1;
            this.bMongoClear.Text = "Clear MongoDB";
            this.bMongoClear.UseVisualStyleBackColor = true;
            this.bMongoClear.Click += new System.EventHandler(this.bMongoClear_Click);
            // 
            // bLogClear
            // 
            this.bLogClear.Location = new System.Drawing.Point(32, 258);
            this.bLogClear.Name = "bLogClear";
            this.bLogClear.Size = new System.Drawing.Size(649, 107);
            this.bLogClear.TabIndex = 2;
            this.bLogClear.Text = "Clear Log";
            this.bLogClear.UseVisualStyleBackColor = true;
            this.bLogClear.Click += new System.EventHandler(this.bLogClear_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 497);
            this.Controls.Add(this.bLogClear);
            this.Controls.Add(this.bMongoClear);
            this.Controls.Add(this.bSqlClear);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration Panel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bSqlClear;
        private System.Windows.Forms.Button bMongoClear;
        private System.Windows.Forms.Button bLogClear;
    }
}