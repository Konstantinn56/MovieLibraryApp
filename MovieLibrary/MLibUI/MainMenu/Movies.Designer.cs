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
            this.btnEdit = new System.Windows.Forms.Button();
            this.lblInfoBox = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblCloseGenre3 = new System.Windows.Forms.Label();
            this.lblAddGenre3 = new System.Windows.Forms.Label();
            this.lblCloseGenre2 = new System.Windows.Forms.Label();
            this.lblAddGenre2 = new System.Windows.Forms.Label();
            this.comboBoxGenre3 = new System.Windows.Forms.ComboBox();
            this.lblGenre3 = new System.Windows.Forms.Label();
            this.comboBoxGenre2 = new System.Windows.Forms.ComboBox();
            this.lblGenre2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picBoxMovieInfo = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxRate = new System.Windows.Forms.TextBox();
            this.txtBoxYear = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBoxTitle4 = new System.Windows.Forms.TextBox();
            this.txtBoxTitle3 = new System.Windows.Forms.TextBox();
            this.txtBoxTitle2 = new System.Windows.Forms.TextBox();
            this.txtBoxTitle1 = new System.Windows.Forms.TextBox();
            this.picBox4 = new System.Windows.Forms.PictureBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxTitle8 = new System.Windows.Forms.TextBox();
            this.txtBoxTitle7 = new System.Windows.Forms.TextBox();
            this.txtBoxTitle6 = new System.Windows.Forms.TextBox();
            this.txtBoxTitle5 = new System.Windows.Forms.TextBox();
            this.picBox8 = new System.Windows.Forms.PictureBox();
            this.picBox7 = new System.Windows.Forms.PictureBox();
            this.picBox6 = new System.Windows.Forms.PictureBox();
            this.picBox5 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMovieInfo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1226, 82);
            this.panel1.TabIndex = 3;
            // 
            // btnAddToFavourite
            // 
            this.btnAddToFavourite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToFavourite.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAddToFavourite.Enabled = false;
            this.btnAddToFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToFavourite.Location = new System.Drawing.Point(841, 52);
            this.btnAddToFavourite.Name = "btnAddToFavourite";
            this.btnAddToFavourite.Size = new System.Drawing.Size(115, 24);
            this.btnAddToFavourite.TabIndex = 67;
            this.btnAddToFavourite.Text = "Add To Favourite";
            this.btnAddToFavourite.UseVisualStyleBackColor = false;
            this.btnAddToFavourite.Click += new System.EventHandler(this.btnAddToFavourite_Click);
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
            this.txtBoxSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBoxSearch_MouseClick);
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
            this.pictureBox1.Image = global::MLibUI.Properties.Resources.Searching;
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
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(218, 6);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(43, 21);
            this.btnEdit.TabIndex = 92;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblInfoBox
            // 
            this.lblInfoBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfoBox.AutoSize = true;
            this.lblInfoBox.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblInfoBox.Location = new System.Drawing.Point(25, 22);
            this.lblInfoBox.Name = "lblInfoBox";
            this.lblInfoBox.Size = new System.Drawing.Size(176, 23);
            this.lblInfoBox.TabIndex = 89;
            this.lblInfoBox.Text = "Movie Information";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(70, 557);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(168, 25);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.AccessToken = null;
            this.sqlConnection1.Credential = null;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection1.StatisticsEnabled = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Goldenrod;
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(833, 489);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(61, 24);
            this.btnNext.TabIndex = 69;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.Goldenrod;
            this.btnPrev.Enabled = false;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(766, 489);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(61, 24);
            this.btnPrev.TabIndex = 70;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle.Location = new System.Drawing.Point(65, 85);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.ReadOnly = true;
            this.txtBoxTitle.Size = new System.Drawing.Size(185, 20);
            this.txtBoxTitle.TabIndex = 81;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.lblCloseGenre3);
            this.panel2.Controls.Add(this.lblAddGenre3);
            this.panel2.Controls.Add(this.lblCloseGenre2);
            this.panel2.Controls.Add(this.lblAddGenre2);
            this.panel2.Controls.Add(this.comboBoxGenre3);
            this.panel2.Controls.Add(this.lblGenre3);
            this.panel2.Controls.Add(this.comboBoxGenre2);
            this.panel2.Controls.Add(this.lblGenre2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBoxGenre);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.btnBrowse);
            this.panel2.Controls.Add(this.picBoxMovieInfo);
            this.panel2.Controls.Add(this.lblInfoBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtBoxRate);
            this.panel2.Controls.Add(this.txtBoxYear);
            this.panel2.Controls.Add(this.txtBoxTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(953, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 594);
            this.panel2.TabIndex = 82;
            // 
            // lblCloseGenre3
            // 
            this.lblCloseGenre3.AutoSize = true;
            this.lblCloseGenre3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseGenre3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCloseGenre3.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCloseGenre3.Location = new System.Drawing.Point(256, 224);
            this.lblCloseGenre3.Name = "lblCloseGenre3";
            this.lblCloseGenre3.Size = new System.Drawing.Size(15, 17);
            this.lblCloseGenre3.TabIndex = 105;
            this.lblCloseGenre3.Text = "X";
            this.lblCloseGenre3.Visible = false;
            this.lblCloseGenre3.Click += new System.EventHandler(this.lblCloseGenre3_Click);
            // 
            // lblAddGenre3
            // 
            this.lblAddGenre3.AutoSize = true;
            this.lblAddGenre3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddGenre3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAddGenre3.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAddGenre3.ForeColor = System.Drawing.Color.Black;
            this.lblAddGenre3.Location = new System.Drawing.Point(189, 203);
            this.lblAddGenre3.Name = "lblAddGenre3";
            this.lblAddGenre3.Size = new System.Drawing.Size(66, 15);
            this.lblAddGenre3.TabIndex = 104;
            this.lblAddGenre3.Text = "Add Genre";
            this.lblAddGenre3.Visible = false;
            this.lblAddGenre3.Click += new System.EventHandler(this.lblAddGenre3_Click);
            // 
            // lblCloseGenre2
            // 
            this.lblCloseGenre2.AutoSize = true;
            this.lblCloseGenre2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCloseGenre2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCloseGenre2.ForeColor = System.Drawing.Color.DarkRed;
            this.lblCloseGenre2.Location = new System.Drawing.Point(256, 176);
            this.lblCloseGenre2.Name = "lblCloseGenre2";
            this.lblCloseGenre2.Size = new System.Drawing.Size(15, 17);
            this.lblCloseGenre2.TabIndex = 103;
            this.lblCloseGenre2.Text = "X";
            this.lblCloseGenre2.Visible = false;
            this.lblCloseGenre2.Click += new System.EventHandler(this.lblCloseGenre2_Click);
            // 
            // lblAddGenre2
            // 
            this.lblAddGenre2.AutoSize = true;
            this.lblAddGenre2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAddGenre2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAddGenre2.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblAddGenre2.ForeColor = System.Drawing.Color.Black;
            this.lblAddGenre2.Location = new System.Drawing.Point(189, 152);
            this.lblAddGenre2.Name = "lblAddGenre2";
            this.lblAddGenre2.Size = new System.Drawing.Size(66, 15);
            this.lblAddGenre2.TabIndex = 102;
            this.lblAddGenre2.Text = "Add Genre";
            this.lblAddGenre2.Visible = false;
            this.lblAddGenre2.Click += new System.EventHandler(this.lblAddGenre2_Click);
            // 
            // comboBoxGenre3
            // 
            this.comboBoxGenre3.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxGenre3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre3.Enabled = false;
            this.comboBoxGenre3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGenre3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGenre3.ForeColor = System.Drawing.Color.Black;
            this.comboBoxGenre3.FormattingEnabled = true;
            this.comboBoxGenre3.Items.AddRange(new object[] {
            " "});
            this.comboBoxGenre3.Location = new System.Drawing.Point(70, 221);
            this.comboBoxGenre3.Name = "comboBoxGenre3";
            this.comboBoxGenre3.Size = new System.Drawing.Size(186, 25);
            this.comboBoxGenre3.TabIndex = 101;
            this.comboBoxGenre3.TextChanged += new System.EventHandler(this.comboBoxGenre3_TextChanged);
            this.comboBoxGenre3.Leave += new System.EventHandler(this.comboBoxGenre3_Leave);
            this.comboBoxGenre3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxGenre3_MouseClick);
            // 
            // lblGenre3
            // 
            this.lblGenre3.AutoSize = true;
            this.lblGenre3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenre3.Location = new System.Drawing.Point(11, 223);
            this.lblGenre3.Name = "lblGenre3";
            this.lblGenre3.Size = new System.Drawing.Size(51, 17);
            this.lblGenre3.TabIndex = 100;
            this.lblGenre3.Text = "Genre:";
            // 
            // comboBoxGenre2
            // 
            this.comboBoxGenre2.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxGenre2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre2.Enabled = false;
            this.comboBoxGenre2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGenre2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGenre2.ForeColor = System.Drawing.Color.Black;
            this.comboBoxGenre2.FormattingEnabled = true;
            this.comboBoxGenre2.Items.AddRange(new object[] {
            " "});
            this.comboBoxGenre2.Location = new System.Drawing.Point(69, 173);
            this.comboBoxGenre2.Name = "comboBoxGenre2";
            this.comboBoxGenre2.Size = new System.Drawing.Size(186, 25);
            this.comboBoxGenre2.TabIndex = 99;
            this.comboBoxGenre2.TextChanged += new System.EventHandler(this.comboBoxGenre2_TextChanged);
            this.comboBoxGenre2.Leave += new System.EventHandler(this.comboBoxGenre2_Leave);
            this.comboBoxGenre2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxGenre2_MouseClick);
            // 
            // lblGenre2
            // 
            this.lblGenre2.AutoSize = true;
            this.lblGenre2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGenre2.Location = new System.Drawing.Point(8, 174);
            this.lblGenre2.Name = "lblGenre2";
            this.lblGenre2.Size = new System.Drawing.Size(51, 17);
            this.lblGenre2.TabIndex = 98;
            this.lblGenre2.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(68, 326);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 16);
            this.label5.TabIndex = 97;
            this.label5.Text = "[1-10]";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.Enabled = false;
            this.comboBoxGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGenre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGenre.ForeColor = System.Drawing.Color.Black;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Items.AddRange(new object[] {
            " "});
            this.comboBoxGenre.Location = new System.Drawing.Point(66, 124);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(186, 25);
            this.comboBoxGenre.TabIndex = 96;
            this.comboBoxGenre.TextChanged += new System.EventHandler(this.comboBoxGenre_TextChanged);
            this.comboBoxGenre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxGenre_MouseClick);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Gray;
            this.btnBrowse.Enabled = false;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrowse.Location = new System.Drawing.Point(202, 519);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(59, 22);
            this.btnBrowse.TabIndex = 91;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picBoxMovieInfo
            // 
            this.picBoxMovieInfo.Location = new System.Drawing.Point(69, 345);
            this.picBoxMovieInfo.Name = "picBoxMovieInfo";
            this.picBoxMovieInfo.Size = new System.Drawing.Size(193, 168);
            this.picBoxMovieInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMovieInfo.TabIndex = 90;
            this.picBoxMovieInfo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(17, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 88;
            this.label4.Text = "Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 87;
            this.label3.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(8, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 86;
            this.label2.Text = "Genre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 85;
            this.label1.Text = "Title:";
            // 
            // txtBoxRate
            // 
            this.txtBoxRate.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxRate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxRate.Location = new System.Drawing.Point(68, 303);
            this.txtBoxRate.Name = "txtBoxRate";
            this.txtBoxRate.ReadOnly = true;
            this.txtBoxRate.Size = new System.Drawing.Size(185, 20);
            this.txtBoxRate.TabIndex = 84;
            // 
            // txtBoxYear
            // 
            this.txtBoxYear.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxYear.Location = new System.Drawing.Point(68, 265);
            this.txtBoxYear.Name = "txtBoxYear";
            this.txtBoxYear.ReadOnly = true;
            this.txtBoxYear.Size = new System.Drawing.Size(185, 20);
            this.txtBoxYear.TabIndex = 83;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.txtBoxTitle4);
            this.panel3.Controls.Add(this.txtBoxTitle3);
            this.panel3.Controls.Add(this.txtBoxTitle2);
            this.panel3.Controls.Add(this.txtBoxTitle1);
            this.panel3.Controls.Add(this.picBox4);
            this.panel3.Controls.Add(this.picBox3);
            this.panel3.Controls.Add(this.picBox2);
            this.panel3.Controls.Add(this.picBox1);
            this.panel3.Controls.Add(this.txtBoxTitle8);
            this.panel3.Controls.Add(this.txtBoxTitle7);
            this.panel3.Controls.Add(this.txtBoxTitle6);
            this.panel3.Controls.Add(this.txtBoxTitle5);
            this.panel3.Controls.Add(this.picBox8);
            this.panel3.Controls.Add(this.picBox7);
            this.panel3.Controls.Add(this.picBox6);
            this.panel3.Controls.Add(this.picBox5);
            this.panel3.Controls.Add(this.btnNext);
            this.panel3.Controls.Add(this.btnPrev);
            this.panel3.Location = new System.Drawing.Point(-6, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(961, 572);
            this.panel3.TabIndex = 83;
            // 
            // txtBoxTitle4
            // 
            this.txtBoxTitle4.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTitle4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle4.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTitle4.Location = new System.Drawing.Point(729, 191);
            this.txtBoxTitle4.Multiline = true;
            this.txtBoxTitle4.Name = "txtBoxTitle4";
            this.txtBoxTitle4.ReadOnly = true;
            this.txtBoxTitle4.Size = new System.Drawing.Size(165, 42);
            this.txtBoxTitle4.TabIndex = 95;
            this.txtBoxTitle4.Text = "Title";
            this.txtBoxTitle4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTitle3
            // 
            this.txtBoxTitle3.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTitle3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle3.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTitle3.Location = new System.Drawing.Point(504, 191);
            this.txtBoxTitle3.Multiline = true;
            this.txtBoxTitle3.Name = "txtBoxTitle3";
            this.txtBoxTitle3.ReadOnly = true;
            this.txtBoxTitle3.Size = new System.Drawing.Size(165, 42);
            this.txtBoxTitle3.TabIndex = 94;
            this.txtBoxTitle3.Text = "Title";
            this.txtBoxTitle3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTitle2
            // 
            this.txtBoxTitle2.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTitle2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle2.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTitle2.Location = new System.Drawing.Point(273, 191);
            this.txtBoxTitle2.Multiline = true;
            this.txtBoxTitle2.Name = "txtBoxTitle2";
            this.txtBoxTitle2.ReadOnly = true;
            this.txtBoxTitle2.Size = new System.Drawing.Size(165, 42);
            this.txtBoxTitle2.TabIndex = 93;
            this.txtBoxTitle2.Text = "Title";
            this.txtBoxTitle2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTitle1
            // 
            this.txtBoxTitle1.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTitle1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle1.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTitle1.Location = new System.Drawing.Point(46, 191);
            this.txtBoxTitle1.Multiline = true;
            this.txtBoxTitle1.Name = "txtBoxTitle1";
            this.txtBoxTitle1.ReadOnly = true;
            this.txtBoxTitle1.Size = new System.Drawing.Size(165, 42);
            this.txtBoxTitle1.TabIndex = 92;
            this.txtBoxTitle1.Text = "Title";
            this.txtBoxTitle1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBox4
            // 
            this.picBox4.BackColor = System.Drawing.Color.DimGray;
            this.picBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox4.Location = new System.Drawing.Point(729, 39);
            this.picBox4.Name = "picBox4";
            this.picBox4.Size = new System.Drawing.Size(165, 146);
            this.picBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox4.TabIndex = 91;
            this.picBox4.TabStop = false;
            this.picBox4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox4_MouseClick);
            // 
            // picBox3
            // 
            this.picBox3.BackColor = System.Drawing.Color.DimGray;
            this.picBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox3.Location = new System.Drawing.Point(504, 39);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(165, 146);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox3.TabIndex = 90;
            this.picBox3.TabStop = false;
            this.picBox3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox3_MouseClick);
            // 
            // picBox2
            // 
            this.picBox2.BackColor = System.Drawing.Color.DimGray;
            this.picBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox2.Location = new System.Drawing.Point(273, 39);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(165, 146);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 89;
            this.picBox2.TabStop = false;
            this.picBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox2_MouseClick);
            // 
            // picBox1
            // 
            this.picBox1.BackColor = System.Drawing.Color.DimGray;
            this.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("picBox1.ErrorImage")));
            this.picBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("picBox1.InitialImage")));
            this.picBox1.Location = new System.Drawing.Point(46, 39);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(165, 146);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 88;
            this.picBox1.TabStop = false;
            this.picBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox1_MouseClick);
            // 
            // txtBoxTitle8
            // 
            this.txtBoxTitle8.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTitle8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle8.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTitle8.Location = new System.Drawing.Point(729, 416);
            this.txtBoxTitle8.Multiline = true;
            this.txtBoxTitle8.Name = "txtBoxTitle8";
            this.txtBoxTitle8.ReadOnly = true;
            this.txtBoxTitle8.Size = new System.Drawing.Size(165, 42);
            this.txtBoxTitle8.TabIndex = 87;
            this.txtBoxTitle8.Text = "Title";
            this.txtBoxTitle8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTitle7
            // 
            this.txtBoxTitle7.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTitle7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle7.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTitle7.Location = new System.Drawing.Point(504, 416);
            this.txtBoxTitle7.Multiline = true;
            this.txtBoxTitle7.Name = "txtBoxTitle7";
            this.txtBoxTitle7.ReadOnly = true;
            this.txtBoxTitle7.Size = new System.Drawing.Size(165, 42);
            this.txtBoxTitle7.TabIndex = 86;
            this.txtBoxTitle7.Text = "Title";
            this.txtBoxTitle7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTitle6
            // 
            this.txtBoxTitle6.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTitle6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle6.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTitle6.Location = new System.Drawing.Point(273, 416);
            this.txtBoxTitle6.Multiline = true;
            this.txtBoxTitle6.Name = "txtBoxTitle6";
            this.txtBoxTitle6.ReadOnly = true;
            this.txtBoxTitle6.Size = new System.Drawing.Size(165, 42);
            this.txtBoxTitle6.TabIndex = 85;
            this.txtBoxTitle6.Text = "Title";
            this.txtBoxTitle6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxTitle5
            // 
            this.txtBoxTitle5.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTitle5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle5.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTitle5.Location = new System.Drawing.Point(46, 416);
            this.txtBoxTitle5.Multiline = true;
            this.txtBoxTitle5.Name = "txtBoxTitle5";
            this.txtBoxTitle5.ReadOnly = true;
            this.txtBoxTitle5.Size = new System.Drawing.Size(165, 42);
            this.txtBoxTitle5.TabIndex = 84;
            this.txtBoxTitle5.Text = "Title";
            this.txtBoxTitle5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBox8
            // 
            this.picBox8.BackColor = System.Drawing.Color.DimGray;
            this.picBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox8.Location = new System.Drawing.Point(729, 264);
            this.picBox8.Name = "picBox8";
            this.picBox8.Size = new System.Drawing.Size(165, 146);
            this.picBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox8.TabIndex = 83;
            this.picBox8.TabStop = false;
            this.picBox8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox8_MouseClick);
            // 
            // picBox7
            // 
            this.picBox7.BackColor = System.Drawing.Color.DimGray;
            this.picBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox7.Location = new System.Drawing.Point(504, 264);
            this.picBox7.Name = "picBox7";
            this.picBox7.Size = new System.Drawing.Size(165, 146);
            this.picBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox7.TabIndex = 82;
            this.picBox7.TabStop = false;
            this.picBox7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox7_MouseClick);
            // 
            // picBox6
            // 
            this.picBox6.BackColor = System.Drawing.Color.DimGray;
            this.picBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox6.Location = new System.Drawing.Point(273, 264);
            this.picBox6.Name = "picBox6";
            this.picBox6.Size = new System.Drawing.Size(165, 146);
            this.picBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox6.TabIndex = 81;
            this.picBox6.TabStop = false;
            this.picBox6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox6_MouseClick);
            // 
            // picBox5
            // 
            this.picBox5.BackColor = System.Drawing.Color.DimGray;
            this.picBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox5.Location = new System.Drawing.Point(46, 264);
            this.picBox5.Name = "picBox5";
            this.picBox5.Size = new System.Drawing.Size(165, 146);
            this.picBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox5.TabIndex = 80;
            this.picBox5.TabStop = false;
            this.picBox5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox5_MouseClick);
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1226, 676);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Movies";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Movies_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMovieInfo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox5)).EndInit();
            this.ResumeLayout(false);

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
        private Button btnNext;
        private Button btnPrev;
        private Button btnUpdate;
        private TextBox txtBoxTitle;
        private Panel panel2;
        private PictureBox picBoxMovieInfo;
        private Label lblInfoBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtBoxRate;
        private TextBox txtBoxYear;
        private Button btnBrowse;
        private Button btnEdit;
        private Panel panel3;
        private TextBox txtBoxTitle4;
        private TextBox txtBoxTitle3;
        private TextBox txtBoxTitle2;
        private TextBox txtBoxTitle1;
        private PictureBox picBox4;
        private PictureBox picBox3;
        private PictureBox picBox2;
        private PictureBox picBox1;
        private TextBox txtBoxTitle8;
        private TextBox txtBoxTitle7;
        private TextBox txtBoxTitle6;
        private TextBox txtBoxTitle5;
        private PictureBox picBox8;
        private PictureBox picBox7;
        private PictureBox picBox6;
        private PictureBox picBox5;
        private ComboBox comboBoxGenre;
        private Label label5;
        private ComboBox comboBoxGenre3;
        private Label lblGenre3;
        private ComboBox comboBoxGenre2;
        private Label lblGenre2;
        private Label lblCloseGenre3;
        private Label lblAddGenre3;
        private Label lblCloseGenre2;
        private Label lblAddGenre2;
    }
}