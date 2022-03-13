namespace MLibUI
{
    partial class LoginPage
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
            this.lblEye = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblForgottenPass = new System.Windows.Forms.Label();
            this.txtBoxUsr = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelUsr = new System.Windows.Forms.Panel();
            this.panelPass = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtBoxPass = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLblCreateAcc = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsrException = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEye
            // 
            this.lblEye.AutoSize = true;
            this.lblEye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEye.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEye.Location = new System.Drawing.Point(326, 303);
            this.lblEye.Name = "lblEye";
            this.lblEye.Size = new System.Drawing.Size(32, 21);
            this.lblEye.TabIndex = 24;
            this.lblEye.Text = "👁‍🗨";
            this.lblEye.Click += new System.EventHandler(this.lblEye_Click);
            this.lblEye.MouseLeave += new System.EventHandler(this.lblEye_MouseLeave);
            this.lblEye.MouseHover += new System.EventHandler(this.lblEye_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(43, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(341, 17);
            this.label7.TabIndex = 22;
            this.label7.Text = "────────────────     or     ──────────────── ";
            // 
            // lblForgottenPass
            // 
            this.lblForgottenPass.AutoSize = true;
            this.lblForgottenPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgottenPass.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForgottenPass.Location = new System.Drawing.Point(60, 335);
            this.lblForgottenPass.Name = "lblForgottenPass";
            this.lblForgottenPass.Size = new System.Drawing.Size(95, 16);
            this.lblForgottenPass.TabIndex = 20;
            this.lblForgottenPass.Text = "Forgot password";
            this.lblForgottenPass.Click += new System.EventHandler(this.lblForgottenPass_Click);
            // 
            // txtBoxUsr
            // 
            this.txtBoxUsr.BackColor = System.Drawing.Color.White;
            this.txtBoxUsr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxUsr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxUsr.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxUsr.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxUsr.Location = new System.Drawing.Point(94, 240);
            this.txtBoxUsr.Name = "txtBoxUsr";
            this.txtBoxUsr.Size = new System.Drawing.Size(257, 20);
            this.txtBoxUsr.TabIndex = 17;
            this.txtBoxUsr.Text = "Username";
            this.txtBoxUsr.Enter += new System.EventHandler(this.txtBoxUsr_Enter);
            this.txtBoxUsr.Leave += new System.EventHandler(this.txtBoxUsr_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MLibUI.Properties.Resources.usrIcon;
            this.pictureBox1.Location = new System.Drawing.Point(60, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // panelUsr
            // 
            this.panelUsr.BackColor = System.Drawing.Color.Black;
            this.panelUsr.Location = new System.Drawing.Point(57, 266);
            this.panelUsr.Name = "panelUsr";
            this.panelUsr.Size = new System.Drawing.Size(307, 2);
            this.panelUsr.TabIndex = 26;
            // 
            // panelPass
            // 
            this.panelPass.BackColor = System.Drawing.Color.Black;
            this.panelPass.Location = new System.Drawing.Point(60, 331);
            this.panelPass.Name = "panelPass";
            this.panelPass.Size = new System.Drawing.Size(298, 2);
            this.panelPass.TabIndex = 29;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MLibUI.Properties.Resources.external_content2;
            this.pictureBox2.Location = new System.Drawing.Point(60, 298);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // txtBoxPass
            // 
            this.txtBoxPass.BackColor = System.Drawing.Color.White;
            this.txtBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxPass.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtBoxPass.Location = new System.Drawing.Point(94, 304);
            this.txtBoxPass.Name = "txtBoxPass";
            this.txtBoxPass.Size = new System.Drawing.Size(239, 20);
            this.txtBoxPass.TabIndex = 27;
            this.txtBoxPass.Text = "Password";
            this.txtBoxPass.Enter += new System.EventHandler(this.txtBoxPass_Enter);
            this.txtBoxPass.Leave += new System.EventHandler(this.txtBoxPass_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MLibUI.Properties.Resources.Logo;
            this.pictureBox3.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(428, 183);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 30;
            this.pictureBox3.TabStop = false;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Gold;
            this.btnSignIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.Goldenrod;
            this.btnSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Goldenrod;
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignIn.Location = new System.Drawing.Point(94, 379);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(236, 32);
            this.btnSignIn.TabIndex = 34;
            this.btnSignIn.Text = "Sign In";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(81, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 17);
            this.label3.TabIndex = 35;
            this.label3.Text = "Don\'t have an account ?";
            // 
            // linkLblCreateAcc
            // 
            this.linkLblCreateAcc.ActiveLinkColor = System.Drawing.Color.DarkGoldenrod;
            this.linkLblCreateAcc.AutoSize = true;
            this.linkLblCreateAcc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkLblCreateAcc.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.linkLblCreateAcc.LinkColor = System.Drawing.Color.Goldenrod;
            this.linkLblCreateAcc.Location = new System.Drawing.Point(233, 475);
            this.linkLblCreateAcc.Name = "linkLblCreateAcc";
            this.linkLblCreateAcc.Size = new System.Drawing.Size(100, 18);
            this.linkLblCreateAcc.TabIndex = 36;
            this.linkLblCreateAcc.TabStop = true;
            this.linkLblCreateAcc.Text = "Sign Up Now";
            this.linkLblCreateAcc.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblCreateAcc_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 36);
            this.label1.TabIndex = 37;
            this.label1.Text = "Sign In";
            // 
            // lblUsrException
            // 
            this.lblUsrException.AutoSize = true;
            this.lblUsrException.BackColor = System.Drawing.Color.White;
            this.lblUsrException.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsrException.ForeColor = System.Drawing.Color.Red;
            this.lblUsrException.Location = new System.Drawing.Point(94, 271);
            this.lblUsrException.Name = "lblUsrException";
            this.lblUsrException.Size = new System.Drawing.Size(0, 16);
            this.lblUsrException.TabIndex = 38;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Image = global::MLibUI.Properties.Resources.external_content5;
            this.pictureBox4.Location = new System.Drawing.Point(428, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(658, 511);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox4_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(423, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 523);
            this.panel1.TabIndex = 41;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(0, 479);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(431, 41);
            this.panel3.TabIndex = 46;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(3, 519);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(425, 4);
            this.panel2.TabIndex = 46;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.btnMinimize);
            this.panel4.Controls.Add(this.btnMaximize);
            this.panel4.Controls.Add(this.btnExit);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.pictureBox6);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1086, 24);
            this.panel4.TabIndex = 45;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Goldenrod;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 20;
            this.btnMinimize.Location = new System.Drawing.Point(993, 1);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(26, 23);
            this.btnMinimize.TabIndex = 45;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.Black;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Goldenrod;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 20;
            this.btnMaximize.Location = new System.Drawing.Point(1025, 1);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(26, 23);
            this.btnMaximize.TabIndex = 44;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Goldenrod;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btnExit.IconColor = System.Drawing.Color.Goldenrod;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 20;
            this.btnExit.Location = new System.Drawing.Point(1057, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(26, 23);
            this.btnExit.TabIndex = 43;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gainsboro;
            this.panel5.Location = new System.Drawing.Point(1083, 15);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(4, 520);
            this.panel5.TabIndex = 42;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gainsboro;
            this.panel7.Location = new System.Drawing.Point(1083, 16);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(4, 523);
            this.panel7.TabIndex = 42;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MLibUI.Properties.Resources.external_content3;
            this.pictureBox6.Location = new System.Drawing.Point(23, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(20, 17);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 34;
            this.pictureBox6.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(46, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sign In";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gainsboro;
            this.panel6.Location = new System.Drawing.Point(2, 531);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(425, 4);
            this.panel6.TabIndex = 46;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gainsboro;
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.panel10);
            this.panel8.Location = new System.Drawing.Point(-1, 16);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(4, 523);
            this.panel8.TabIndex = 47;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gainsboro;
            this.panel9.Location = new System.Drawing.Point(0, 479);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(431, 41);
            this.panel9.TabIndex = 46;
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(3, 519);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(425, 4);
            this.panel10.TabIndex = 46;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.pictureBox3);
            this.panel11.Controls.Add(this.txtBoxUsr);
            this.panel11.Controls.Add(this.lblForgottenPass);
            this.panel11.Controls.Add(this.label7);
            this.panel11.Controls.Add(this.lblUsrException);
            this.panel11.Controls.Add(this.lblEye);
            this.panel11.Controls.Add(this.label1);
            this.panel11.Controls.Add(this.txtBoxPass);
            this.panel11.Controls.Add(this.linkLblCreateAcc);
            this.panel11.Controls.Add(this.pictureBox1);
            this.panel11.Controls.Add(this.label3);
            this.panel11.Controls.Add(this.pictureBox2);
            this.panel11.Controls.Add(this.btnSignIn);
            this.panel11.Controls.Add(this.panelUsr);
            this.panel11.Controls.Add(this.panelPass);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel11.Location = new System.Drawing.Point(0, 24);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(422, 511);
            this.panel11.TabIndex = 47;
            this.panel11.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel11_MouseDown);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 535);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginPage_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Label lblEye;
        private Label label7;
        private Label lblForgottenPass;
        private TextBox txtBoxUsr;
        private PictureBox pictureBox1;
        private Panel panelUsr;
        private Panel panelPass;
        private PictureBox pictureBox2;
        private TextBox txtBoxPass;
        private PictureBox pictureBox3;
        private Button btnSignIn;
        private Label label3;
        private LinkLabel linkLblCreateAcc;
        private Label label1;
        private Label lblUsrException;
        private PictureBox pictureBox4;
        private Panel panel1;
        private Panel panel4;
        private Panel panel5;
        private Panel panel7;
        private PictureBox pictureBox6;
        private Label label4;
        private Panel panel2;
        private Panel panel3;
        private Panel panel6;
        private Panel panel8;
        private Panel panel9;
        private Panel panel10;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExit;
        private Panel panel11;
    }
}