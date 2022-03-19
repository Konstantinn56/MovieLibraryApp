namespace MLibUI.SignUp
{
    partial class SuccessfulCreatedAcc
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnGetStarted = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MLibUI.Properties.Resources.GreenTick;
            this.pictureBox1.Location = new System.Drawing.Point(139, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(38, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 21);
            this.label1.TabIndex = 52;
            this.label1.Text = "Your account has been created successfully!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 5);
            this.panel1.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Location = new System.Drawing.Point(0, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 4);
            this.panel2.TabIndex = 54;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(0, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 223);
            this.panel3.TabIndex = 55;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Location = new System.Drawing.Point(436, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(4, 225);
            this.panel4.TabIndex = 56;
            // 
            // btnGetStarted
            // 
            this.btnGetStarted.BackColor = System.Drawing.Color.LimeGreen;
            this.btnGetStarted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGetStarted.FlatAppearance.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnGetStarted.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnGetStarted.FlatAppearance.MouseOverBackColor = System.Drawing.Color.ForestGreen;
            this.btnGetStarted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetStarted.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGetStarted.ForeColor = System.Drawing.Color.White;
            this.btnGetStarted.Location = new System.Drawing.Point(123, 175);
            this.btnGetStarted.Name = "btnGetStarted";
            this.btnGetStarted.Size = new System.Drawing.Size(185, 34);
            this.btnGetStarted.TabIndex = 57;
            this.btnGetStarted.Text = "GET STARTED ->";
            this.btnGetStarted.UseVisualStyleBackColor = false;
            this.btnGetStarted.Click += new System.EventHandler(this.btnGetStarted_Click);
            // 
            // SuccessfulCreatedAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(440, 230);
            this.Controls.Add(this.btnGetStarted);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SuccessfulCreatedAcc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuccessfulCreatedAcc";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SuccessfulCreatedAcc_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnGetStarted;
    }
}