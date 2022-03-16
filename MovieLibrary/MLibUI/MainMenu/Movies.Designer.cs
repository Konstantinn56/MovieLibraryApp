namespace MLibUI.MainMenu
{
    partial class Movies
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movies));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddToFavourite = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.lblUsrException = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.picBox4 = new System.Windows.Forms.PictureBox();
            this.picBox8 = new System.Windows.Forms.PictureBox();
            this.picBox7 = new System.Windows.Forms.PictureBox();
            this.picBox6 = new System.Windows.Forms.PictureBox();
            this.picBox5 = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.txtBoxTitle1 = new System.Windows.Forms.TextBox();
            this.txtBoxTitle2 = new System.Windows.Forms.TextBox();
            this.txtBoxTitle3 = new System.Windows.Forms.TextBox();
            this.txtBoxTitle4 = new System.Windows.Forms.TextBox();
            this.txtBoxTitle5 = new System.Windows.Forms.TextBox();
            this.txtBoxTitle6 = new System.Windows.Forms.TextBox();
            this.txtBoxTitle7 = new System.Windows.Forms.TextBox();
            this.txtBoxTitle8 = new System.Windows.Forms.TextBox();
            this.txtBoxMovieInfo = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.btnAddToFavourite);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtBoxSearch);
            this.panel1.Controls.Add(this.lblUsrException);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panelSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 82);
            this.panel1.TabIndex = 3;
            // 
            // btnAddToFavourite
            // 
            this.btnAddToFavourite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToFavourite.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAddToFavourite.Enabled = false;
            this.btnAddToFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToFavourite.Location = new System.Drawing.Point(884, 52);
            this.btnAddToFavourite.Name = "btnAddToFavourite";
            this.btnAddToFavourite.Size = new System.Drawing.Size(115, 24);
            this.btnAddToFavourite.TabIndex = 67;
            this.btnAddToFavourite.Text = "Add To Favourite";
            this.btnAddToFavourite.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSearch.Enabled = false;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(348, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 24);
            this.btnSearch.TabIndex = 65;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSearch.Location = new System.Drawing.Point(69, 45);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(257, 20);
            this.txtBoxSearch.TabIndex = 39;
            this.txtBoxSearch.Text = "Search";
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            this.txtBoxSearch.Enter += new System.EventHandler(this.txtBoxSearch_Enter);
            this.txtBoxSearch.Leave += new System.EventHandler(this.txtBoxSearch_Leave);
            // 
            // lblUsrException
            // 
            this.lblUsrException.AutoSize = true;
            this.lblUsrException.BackColor = System.Drawing.Color.White;
            this.lblUsrException.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsrException.ForeColor = System.Drawing.Color.Red;
            this.lblUsrException.Location = new System.Drawing.Point(35, 67);
            this.lblUsrException.Name = "lblUsrException";
            this.lblUsrException.Size = new System.Drawing.Size(0, 16);
            this.lblUsrException.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MLibUI.Properties.Resources.usrIcon;
            this.pictureBox1.Location = new System.Drawing.Point(35, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Black;
            this.panelSearch.Location = new System.Drawing.Point(35, 74);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(307, 2);
            this.panelSearch.TabIndex = 41;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.AccessToken = null;
            this.sqlConnection1.Credential = null;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection1.StatisticsEnabled = false;
            // 
            // picBox1
            // 
            this.picBox1.BackColor = System.Drawing.Color.DimGray;
            this.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBox1.ErrorImage")));
            this.picBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBox1.InitialImage")));
            this.picBox1.Location = new System.Drawing.Point(69, 107);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(165, 146);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 4;
            this.picBox1.TabStop = false;
            this.picBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox1_MouseClick);
            this.picBox1.MouseLeave += new System.EventHandler(this.picBox1_MouseLeave);
            this.picBox1.MouseHover += new System.EventHandler(this.picBox1_MouseHover);
            // 
            // picBox2
            // 
            this.picBox2.BackColor = System.Drawing.Color.DimGray;
            this.picBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox2.Location = new System.Drawing.Point(296, 107);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(165, 146);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox2.TabIndex = 8;
            this.picBox2.TabStop = false;
            this.picBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox2_MouseClick);
            this.picBox2.MouseLeave += new System.EventHandler(this.picBox2_MouseLeave);
            this.picBox2.MouseHover += new System.EventHandler(this.picBox2_MouseHover);
            // 
            // picBox3
            // 
            this.picBox3.BackColor = System.Drawing.Color.DimGray;
            this.picBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox3.Location = new System.Drawing.Point(527, 107);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(165, 146);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox3.TabIndex = 10;
            this.picBox3.TabStop = false;
            this.picBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox3_MouseClick);
            this.picBox3.MouseLeave += new System.EventHandler(this.picBox3_MouseLeave);
            this.picBox3.MouseHover += new System.EventHandler(this.picBox3_MouseHover);
            // 
            // picBox4
            // 
            this.picBox4.BackColor = System.Drawing.Color.DimGray;
            this.picBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox4.Location = new System.Drawing.Point(752, 107);
            this.picBox4.Name = "picBox4";
            this.picBox4.Size = new System.Drawing.Size(165, 146);
            this.picBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox4.TabIndex = 12;
            this.picBox4.TabStop = false;
            this.picBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox4_MouseClick);
            this.picBox4.MouseLeave += new System.EventHandler(this.picBox4_MouseLeave);
            this.picBox4.MouseHover += new System.EventHandler(this.picBox4_MouseHover);
            // 
            // picBox8
            // 
            this.picBox8.BackColor = System.Drawing.Color.DimGray;
            this.picBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox8.Location = new System.Drawing.Point(752, 331);
            this.picBox8.Name = "picBox8";
            this.picBox8.Size = new System.Drawing.Size(165, 146);
            this.picBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox8.TabIndex = 22;
            this.picBox8.TabStop = false;
            this.picBox8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox8_MouseClick);
            this.picBox8.MouseLeave += new System.EventHandler(this.picBox8_MouseLeave);
            this.picBox8.MouseHover += new System.EventHandler(this.picBox8_MouseHover);
            // 
            // picBox7
            // 
            this.picBox7.BackColor = System.Drawing.Color.DimGray;
            this.picBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox7.Location = new System.Drawing.Point(527, 331);
            this.picBox7.Name = "picBox7";
            this.picBox7.Size = new System.Drawing.Size(165, 146);
            this.picBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox7.TabIndex = 20;
            this.picBox7.TabStop = false;
            this.picBox7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox7_MouseClick);
            this.picBox7.MouseLeave += new System.EventHandler(this.picBox7_MouseLeave);
            this.picBox7.MouseHover += new System.EventHandler(this.picBox7_MouseHover);
            // 
            // picBox6
            // 
            this.picBox6.BackColor = System.Drawing.Color.DimGray;
            this.picBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox6.Location = new System.Drawing.Point(296, 331);
            this.picBox6.Name = "picBox6";
            this.picBox6.Size = new System.Drawing.Size(165, 146);
            this.picBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox6.TabIndex = 18;
            this.picBox6.TabStop = false;
            this.picBox6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox6_MouseClick);
            this.picBox6.MouseLeave += new System.EventHandler(this.picBox6_MouseLeave);
            this.picBox6.MouseHover += new System.EventHandler(this.picBox6_MouseHover);
            // 
            // picBox5
            // 
            this.picBox5.BackColor = System.Drawing.Color.DimGray;
            this.picBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox5.Location = new System.Drawing.Point(69, 331);
            this.picBox5.Name = "picBox5";
            this.picBox5.Size = new System.Drawing.Size(165, 146);
            this.picBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox5.TabIndex = 16;
            this.picBox5.TabStop = false;
            this.picBox5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox5_MouseClick);
            this.picBox5.MouseLeave += new System.EventHandler(this.picBox5_MouseLeave);
            this.picBox5.MouseHover += new System.EventHandler(this.picBox5_MouseHover);
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Goldenrod;
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(938, 549);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(61, 24);
            this.btnNext.TabIndex = 69;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrev.BackColor = System.Drawing.Color.Goldenrod;
            this.btnPrev.Enabled = false;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(871, 549);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(61, 24);
            this.btnPrev.TabIndex = 70;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txtBoxTitle1
            // 
            this.txtBoxTitle1.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTitle1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle1.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTitle1.Location = new System.Drawing.Point(69, 259);
            this.txtBoxTitle1.Multiline = true;
            this.txtBoxTitle1.Name = "txtBoxTitle1";
            this.txtBoxTitle1.ReadOnly = true;
            this.txtBoxTitle1.Size = new System.Drawing.Size(165, 42);
            this.txtBoxTitle1.TabIndex = 72;
            this.txtBoxTitle1.Text = "Title";
            this.txtBoxTitle1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTitle2
            // 
            this.txtBoxTitle2.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTitle2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle2.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTitle2.Location = new System.Drawing.Point(296, 259);
            this.txtBoxTitle2.Multiline = true;
            this.txtBoxTitle2.Name = "txtBoxTitle2";
            this.txtBoxTitle2.ReadOnly = true;
            this.txtBoxTitle2.Size = new System.Drawing.Size(165, 42);
            this.txtBoxTitle2.TabIndex = 73;
            this.txtBoxTitle2.Text = "Title";
            this.txtBoxTitle2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTitle3
            // 
            this.txtBoxTitle3.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTitle3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle3.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTitle3.Location = new System.Drawing.Point(527, 259);
            this.txtBoxTitle3.Multiline = true;
            this.txtBoxTitle3.Name = "txtBoxTitle3";
            this.txtBoxTitle3.ReadOnly = true;
            this.txtBoxTitle3.Size = new System.Drawing.Size(165, 42);
            this.txtBoxTitle3.TabIndex = 74;
            this.txtBoxTitle3.Text = "Title";
            this.txtBoxTitle3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTitle4
            // 
            this.txtBoxTitle4.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTitle4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle4.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTitle4.Location = new System.Drawing.Point(752, 259);
            this.txtBoxTitle4.Multiline = true;
            this.txtBoxTitle4.Name = "txtBoxTitle4";
            this.txtBoxTitle4.ReadOnly = true;
            this.txtBoxTitle4.Size = new System.Drawing.Size(165, 42);
            this.txtBoxTitle4.TabIndex = 75;
            this.txtBoxTitle4.Text = "Title";
            this.txtBoxTitle4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTitle5
            // 
            this.txtBoxTitle5.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTitle5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle5.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTitle5.Location = new System.Drawing.Point(69, 483);
            this.txtBoxTitle5.Multiline = true;
            this.txtBoxTitle5.Name = "txtBoxTitle5";
            this.txtBoxTitle5.ReadOnly = true;
            this.txtBoxTitle5.Size = new System.Drawing.Size(165, 42);
            this.txtBoxTitle5.TabIndex = 76;
            this.txtBoxTitle5.Text = "Title";
            this.txtBoxTitle5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTitle6
            // 
            this.txtBoxTitle6.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTitle6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle6.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTitle6.Location = new System.Drawing.Point(296, 483);
            this.txtBoxTitle6.Multiline = true;
            this.txtBoxTitle6.Name = "txtBoxTitle6";
            this.txtBoxTitle6.ReadOnly = true;
            this.txtBoxTitle6.Size = new System.Drawing.Size(165, 42);
            this.txtBoxTitle6.TabIndex = 77;
            this.txtBoxTitle6.Text = "Title";
            this.txtBoxTitle6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTitle7
            // 
            this.txtBoxTitle7.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTitle7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle7.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTitle7.Location = new System.Drawing.Point(527, 483);
            this.txtBoxTitle7.Multiline = true;
            this.txtBoxTitle7.Name = "txtBoxTitle7";
            this.txtBoxTitle7.ReadOnly = true;
            this.txtBoxTitle7.Size = new System.Drawing.Size(165, 42);
            this.txtBoxTitle7.TabIndex = 78;
            this.txtBoxTitle7.Text = "Title";
            this.txtBoxTitle7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTitle8
            // 
            this.txtBoxTitle8.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTitle8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle8.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTitle8.Location = new System.Drawing.Point(752, 483);
            this.txtBoxTitle8.Multiline = true;
            this.txtBoxTitle8.Name = "txtBoxTitle8";
            this.txtBoxTitle8.ReadOnly = true;
            this.txtBoxTitle8.Size = new System.Drawing.Size(165, 42);
            this.txtBoxTitle8.TabIndex = 79;
            this.txtBoxTitle8.Text = "Title";
            this.txtBoxTitle8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxMovieInfo
            // 
            this.txtBoxMovieInfo.BackColor = System.Drawing.Color.Silver;
            this.txtBoxMovieInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxMovieInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtBoxMovieInfo.Location = new System.Drawing.Point(206, 519);
            this.txtBoxMovieInfo.Name = "txtBoxMovieInfo";
            this.txtBoxMovieInfo.ReadOnly = true;
            this.txtBoxMovieInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtBoxMovieInfo.Size = new System.Drawing.Size(548, 116);
            this.txtBoxMovieInfo.TabIndex = 80;
            this.txtBoxMovieInfo.Text = "Movie Information\n\nTitle:\nGenre:\nYear: \nRate:";
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1011, 639);
            this.Controls.Add(this.txtBoxMovieInfo);
            this.Controls.Add(this.txtBoxTitle8);
            this.Controls.Add(this.txtBoxTitle7);
            this.Controls.Add(this.txtBoxTitle6);
            this.Controls.Add(this.txtBoxTitle5);
            this.Controls.Add(this.txtBoxTitle4);
            this.Controls.Add(this.txtBoxTitle3);
            this.Controls.Add(this.txtBoxTitle2);
            this.Controls.Add(this.txtBoxTitle1);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.picBox8);
            this.Controls.Add(this.picBox7);
            this.Controls.Add(this.picBox6);
            this.Controls.Add(this.picBox5);
            this.Controls.Add(this.picBox4);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Movies";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Movies_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
        private TextBox txtBoxSearch;
        private Label lblUsrException;
        private PictureBox pictureBox1;
        private Panel panelSearch;
        private Button btnSearch;
        private Button btnAddToFavourite;
        private PictureBox picBox1;
        private PictureBox picBox2;
        private PictureBox picBox3;
        private PictureBox picBox4;
        private PictureBox picBox8;
        private PictureBox picBox7;
        private PictureBox picBox6;
        private PictureBox picBox5;
        private Button btnNext;
        private Button btnPrev;
        private TextBox txtBoxTitle1;
        private TextBox txtBoxTitle2;
        private TextBox txtBoxTitle3;
        private TextBox txtBoxTitle4;
        private TextBox txtBoxTitle5;
        private TextBox txtBoxTitle6;
        private TextBox txtBoxTitle7;
        private TextBox txtBoxTitle8;
        private RichTextBox txtBoxMovieInfo;
    }
}