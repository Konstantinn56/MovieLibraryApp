namespace MLibUI.MainMenu
{
    partial class mainPage
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnMovies = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnMyList = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUsrText = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelTitleBarr = new System.Windows.Forms.Panel();
            this.lblChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelTitleBarr.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelMenu.Controls.Add(this.btnMovies);
            this.panelMenu.Controls.Add(this.panelTitleBar);
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnMyList);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 631);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            // 
            // btnMovies
            // 
            this.btnMovies.FlatAppearance.BorderSize = 0;
            this.btnMovies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMovies.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMovies.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMovies.IconChar = FontAwesome.Sharp.IconChar.Film;
            this.btnMovies.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMovies.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMovies.IconSize = 50;
            this.btnMovies.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovies.Location = new System.Drawing.Point(0, 246);
            this.btnMovies.Name = "btnMovies";
            this.btnMovies.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMovies.Size = new System.Drawing.Size(220, 60);
            this.btnMovies.TabIndex = 4;
            this.btnMovies.Text = "Movies";
            this.btnMovies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMovies.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMovies.UseVisualStyleBackColor = true;
            this.btnMovies.Click += new System.EventHandler(this.btnMovies_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelTitleBar.Location = new System.Drawing.Point(219, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(200, 100);
            this.panelTitleBar.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Bars;
            this.btnSettings.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 50;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 559);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSettings.Size = new System.Drawing.Size(220, 60);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnMyList
            // 
            this.btnMyList.FlatAppearance.BorderSize = 0;
            this.btnMyList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyList.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMyList.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMyList.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnMyList.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMyList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMyList.IconSize = 50;
            this.btnMyList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyList.Location = new System.Drawing.Point(0, 312);
            this.btnMyList.Name = "btnMyList";
            this.btnMyList.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMyList.Size = new System.Drawing.Size(220, 60);
            this.btnMyList.TabIndex = 2;
            this.btnMyList.Text = "My List";
            this.btnMyList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMyList.UseVisualStyleBackColor = true;
            this.btnMyList.Click += new System.EventHandler(this.btnMyList_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUsrText);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 162);
            this.panel2.TabIndex = 0;
            // 
            // btnUsrText
            // 
            this.btnUsrText.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsrText.FlatAppearance.BorderSize = 0;
            this.btnUsrText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsrText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnUsrText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUsrText.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUsrText.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsrText.IconColor = System.Drawing.Color.DarkGoldenrod;
            this.btnUsrText.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsrText.IconSize = 120;
            this.btnUsrText.Location = new System.Drawing.Point(0, 0);
            this.btnUsrText.Name = "btnUsrText";
            this.btnUsrText.Size = new System.Drawing.Size(220, 162);
            this.btnUsrText.TabIndex = 4;
            this.btnUsrText.Text = "Username";
            this.btnUsrText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsrText.UseVisualStyleBackColor = true;
            this.btnUsrText.Click += new System.EventHandler(this.btnUsrText_Click);
            // 
            // btnHome
            // 
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnHome.IconColor = System.Drawing.Color.Gainsboro;
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 50;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 180);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnHome.Size = new System.Drawing.Size(220, 60);
            this.btnHome.TabIndex = 1;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelTitleBarr
            // 
            this.panelTitleBarr.BackColor = System.Drawing.Color.DimGray;
            this.panelTitleBarr.Controls.Add(this.lblChildForm);
            this.panelTitleBarr.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBarr.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBarr.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBarr.Name = "panelTitleBarr";
            this.panelTitleBarr.Size = new System.Drawing.Size(916, 70);
            this.panelTitleBarr.TabIndex = 0;
            this.panelTitleBarr.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBarr_MouseDown);
            // 
            // lblChildForm
            // 
            this.lblChildForm.AutoSize = true;
            this.lblChildForm.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblChildForm.Location = new System.Drawing.Point(44, 26);
            this.lblChildForm.Name = "lblChildForm";
            this.lblChildForm.Size = new System.Drawing.Size(44, 16);
            this.lblChildForm.TabIndex = 2;
            this.lblChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.Transparent;
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.Gainsboro;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 36;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(7, 17);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(42, 36);
            this.iconCurrentChildForm.TabIndex = 1;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.Gray;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 70);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(916, 11);
            this.panelShadow.TabIndex = 1;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.DarkGray;
            this.panelDesktop.Controls.Add(this.label1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 70);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(916, 561);
            this.panelDesktop.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(399, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "HomePage";
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1136, 631);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBarr);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "mainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPage_MouseDown);
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelTitleBarr.ResumeLayout(false);
            this.panelTitleBarr.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnMyList;
        private FontAwesome.Sharp.IconButton btnHome;
        private Panel panel2;
        private Panel panelTitleBar;
        private Panel panelTitleBarr;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private Label lblChildForm;
        private FontAwesome.Sharp.IconButton btnUsrText;
        private Panel panelShadow;
        private Panel panelDesktop;
        private FontAwesome.Sharp.IconButton btnMovies;
        private Label label1;
    }
}