namespace MLibUI.SignUp
{
    partial class RecoveryKeyPage
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
            this.lblRecoveryKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRecoveryKey
            // 
            this.lblRecoveryKey.AutoSize = true;
            this.lblRecoveryKey.Location = new System.Drawing.Point(337, 209);
            this.lblRecoveryKey.Name = "lblRecoveryKey";
            this.lblRecoveryKey.Size = new System.Drawing.Size(43, 15);
            this.lblRecoveryKey.TabIndex = 0;
            this.lblRecoveryKey.Text = "123456";
            // 
            // RecoveryKeyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblRecoveryKey);
            this.Name = "RecoveryKeyPage";
            this.Text = "RecoveryKeyPage";
            this.Load += new System.EventHandler(this.RecoveryKeyPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRecoveryKey;
    }
}