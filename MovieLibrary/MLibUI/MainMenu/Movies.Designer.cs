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
            this.comboBoxGenre3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxGenre2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.btnReset = new System.Windows.Forms.Button();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1401, 109);
            this.panel1.TabIndex = 3;
            // 
            // btnAddToFavourite
            // 
            this.btnAddToFavourite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToFavourite.BackColor = System.Drawing.Color.Goldenrod;
            this.btnAddToFavourite.Enabled = false;
            this.btnAddToFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToFavourite.Location = new System.Drawing.Point(961, 69);
            this.btnAddToFavourite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddToFavourite.Name = "btnAddToFavourite";
            this.btnAddToFavourite.Size = new System.Drawing.Size(131, 32);
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
            this.btnSearch.Location = new System.Drawing.Point(398, 69);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 32);
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
            this.txtBoxSearch.Location = new System.Drawing.Point(79, 60);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(294, 25);
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
            this.lblUsrException.Location = new System.Drawing.Point(40, 89);
            this.lblUsrException.Name = "lblUsrException";
            this.lblUsrException.Size = new System.Drawing.Size(0, 19);
            this.lblUsrException.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MLibUI.Properties.Resources.Searching;
            this.pictureBox1.Location = new System.Drawing.Point(40, 55);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Black;
            this.panelSearch.Location = new System.Drawing.Point(40, 99);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(351, 3);
            this.panelSearch.TabIndex = 41;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.BackColor = System.Drawing.Color.Goldenrod;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.Location = new System.Drawing.Point(234, 8);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(49, 28);
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
            this.lblInfoBox.Location = new System.Drawing.Point(14, 29);
            this.lblInfoBox.Name = "lblInfoBox";
            this.lblInfoBox.Size = new System.Drawing.Size(222, 28);
            this.lblInfoBox.TabIndex = 89;
            this.lblInfoBox.Text = "Movie Information";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.Goldenrod;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(125, 697);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(144, 33);
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
            this.btnNext.Location = new System.Drawing.Point(952, 652);
            this.btnNext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(70, 32);
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
            this.btnPrev.Location = new System.Drawing.Point(875, 652);
            this.btnPrev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(70, 32);
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
            this.txtBoxTitle.Location = new System.Drawing.Point(71, 121);
            this.txtBoxTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.ReadOnly = true;
            this.txtBoxTitle.Size = new System.Drawing.Size(211, 25);
            this.txtBoxTitle.TabIndex = 81;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.comboBoxGenre3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.comboBoxGenre2);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBoxGenre);
            this.panel2.Controls.Add(this.btnReset);
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
            this.panel2.Location = new System.Drawing.Point(1104, 109);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 763);
            this.panel2.TabIndex = 82;
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
            this.comboBoxGenre3.Location = new System.Drawing.Point(71, 232);
            this.comboBoxGenre3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxGenre3.Name = "comboBoxGenre3";
            this.comboBoxGenre3.Size = new System.Drawing.Size(212, 28);
            this.comboBoxGenre3.TabIndex = 101;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(3, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 21);
            this.label7.TabIndex = 100;
            this.label7.Text = "Genre:";
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
            this.comboBoxGenre2.Location = new System.Drawing.Point(70, 193);
            this.comboBoxGenre2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxGenre2.Name = "comboBoxGenre2";
            this.comboBoxGenre2.Size = new System.Drawing.Size(212, 28);
            this.comboBoxGenre2.TabIndex = 99;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(0, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 98;
            this.label6.Text = "Genre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(70, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 19);
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
            this.comboBoxGenre.Location = new System.Drawing.Point(70, 156);
            this.comboBoxGenre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(212, 28);
            this.comboBoxGenre.TabIndex = 96;
            this.comboBoxGenre.TextChanged += new System.EventHandler(this.comboBoxGenre_TextChanged);
            this.comboBoxGenre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxGenre_MouseClick);
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.BackColor = System.Drawing.Color.Goldenrod;
            this.btnReset.Enabled = false;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(57, 697);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(63, 33);
            this.btnReset.TabIndex = 93;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Gray;
            this.btnBrowse.Enabled = false;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBrowse.Location = new System.Drawing.Point(216, 619);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(67, 29);
            this.btnBrowse.TabIndex = 91;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // picBoxMovieInfo
            // 
            this.picBoxMovieInfo.Location = new System.Drawing.Point(63, 367);
            this.picBoxMovieInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBoxMovieInfo.Name = "picBoxMovieInfo";
            this.picBoxMovieInfo.Size = new System.Drawing.Size(221, 244);
            this.picBoxMovieInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxMovieInfo.TabIndex = 90;
            this.picBoxMovieInfo.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 88;
            this.label4.Text = "Rate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(10, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 21);
            this.label3.TabIndex = 87;
            this.label3.Text = "Year:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 21);
            this.label2.TabIndex = 86;
            this.label2.Text = "Genre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 85;
            this.label1.Text = "Title:";
            // 
            // txtBoxRate
            // 
            this.txtBoxRate.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxRate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxRate.Location = new System.Drawing.Point(70, 304);
            this.txtBoxRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxRate.Name = "txtBoxRate";
            this.txtBoxRate.ReadOnly = true;
            this.txtBoxRate.Size = new System.Drawing.Size(211, 25);
            this.txtBoxRate.TabIndex = 84;
            // 
            // txtBoxYear
            // 
            this.txtBoxYear.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxYear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxYear.Location = new System.Drawing.Point(70, 273);
            this.txtBoxYear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxYear.Name = "txtBoxYear";
            this.txtBoxYear.ReadOnly = true;
            this.txtBoxYear.Size = new System.Drawing.Size(211, 25);
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
            this.panel3.Location = new System.Drawing.Point(-7, 109);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1111, 763);
            this.panel3.TabIndex = 83;
            // 
            // txtBoxTitle4
            // 
            this.txtBoxTitle4.BackColor = System.Drawing.Color.Silver;
            this.txtBoxTitle4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle4.ForeColor = System.Drawing.Color.Black;
            this.txtBoxTitle4.Location = new System.Drawing.Point(833, 255);
            this.txtBoxTitle4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTitle4.Multiline = true;
            this.txtBoxTitle4.Name = "txtBoxTitle4";
            this.txtBoxTitle4.ReadOnly = true;
            this.txtBoxTitle4.Size = new System.Drawing.Size(189, 56);
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
            this.txtBoxTitle3.Location = new System.Drawing.Point(576, 255);
            this.txtBoxTitle3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTitle3.Multiline = true;
            this.txtBoxTitle3.Name = "txtBoxTitle3";
            this.txtBoxTitle3.ReadOnly = true;
            this.txtBoxTitle3.Size = new System.Drawing.Size(189, 56);
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
            this.txtBoxTitle2.Location = new System.Drawing.Point(312, 255);
            this.txtBoxTitle2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTitle2.Multiline = true;
            this.txtBoxTitle2.Name = "txtBoxTitle2";
            this.txtBoxTitle2.ReadOnly = true;
            this.txtBoxTitle2.Size = new System.Drawing.Size(189, 56);
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
            this.txtBoxTitle1.Location = new System.Drawing.Point(53, 255);
            this.txtBoxTitle1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTitle1.Multiline = true;
            this.txtBoxTitle1.Name = "txtBoxTitle1";
            this.txtBoxTitle1.ReadOnly = true;
            this.txtBoxTitle1.Size = new System.Drawing.Size(189, 56);
            this.txtBoxTitle1.TabIndex = 92;
            this.txtBoxTitle1.Text = "Title";
            this.txtBoxTitle1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBox4
            // 
            this.picBox4.BackColor = System.Drawing.Color.DimGray;
            this.picBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox4.Location = new System.Drawing.Point(833, 52);
            this.picBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox4.Name = "picBox4";
            this.picBox4.Size = new System.Drawing.Size(189, 195);
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
            this.picBox3.Location = new System.Drawing.Point(576, 52);
            this.picBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(189, 195);
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
            this.picBox2.Location = new System.Drawing.Point(312, 52);
            this.picBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(189, 195);
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
            this.picBox1.Location = new System.Drawing.Point(53, 52);
            this.picBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(189, 195);
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
            this.txtBoxTitle8.Location = new System.Drawing.Point(833, 555);
            this.txtBoxTitle8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTitle8.Multiline = true;
            this.txtBoxTitle8.Name = "txtBoxTitle8";
            this.txtBoxTitle8.ReadOnly = true;
            this.txtBoxTitle8.Size = new System.Drawing.Size(189, 56);
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
            this.txtBoxTitle7.Location = new System.Drawing.Point(576, 555);
            this.txtBoxTitle7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTitle7.Multiline = true;
            this.txtBoxTitle7.Name = "txtBoxTitle7";
            this.txtBoxTitle7.ReadOnly = true;
            this.txtBoxTitle7.Size = new System.Drawing.Size(189, 56);
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
            this.txtBoxTitle6.Location = new System.Drawing.Point(312, 555);
            this.txtBoxTitle6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTitle6.Multiline = true;
            this.txtBoxTitle6.Name = "txtBoxTitle6";
            this.txtBoxTitle6.ReadOnly = true;
            this.txtBoxTitle6.Size = new System.Drawing.Size(189, 56);
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
            this.txtBoxTitle5.Location = new System.Drawing.Point(53, 555);
            this.txtBoxTitle5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTitle5.Multiline = true;
            this.txtBoxTitle5.Name = "txtBoxTitle5";
            this.txtBoxTitle5.ReadOnly = true;
            this.txtBoxTitle5.Size = new System.Drawing.Size(189, 56);
            this.txtBoxTitle5.TabIndex = 84;
            this.txtBoxTitle5.Text = "Title";
            this.txtBoxTitle5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // picBox8
            // 
            this.picBox8.BackColor = System.Drawing.Color.DimGray;
            this.picBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBox8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picBox8.Location = new System.Drawing.Point(833, 352);
            this.picBox8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox8.Name = "picBox8";
            this.picBox8.Size = new System.Drawing.Size(189, 195);
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
            this.picBox7.Location = new System.Drawing.Point(576, 352);
            this.picBox7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox7.Name = "picBox7";
            this.picBox7.Size = new System.Drawing.Size(189, 195);
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
            this.picBox6.Location = new System.Drawing.Point(312, 352);
            this.picBox6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox6.Name = "picBox6";
            this.picBox6.Size = new System.Drawing.Size(189, 195);
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
            this.picBox5.Location = new System.Drawing.Point(53, 352);
            this.picBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picBox5.Name = "picBox5";
            this.picBox5.Size = new System.Drawing.Size(189, 195);
            this.picBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox5.TabIndex = 80;
            this.picBox5.TabStop = false;
            this.picBox5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picBox5_MouseClick);
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1401, 872);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private Button btnReset;
        private ComboBox comboBoxGenre;
        private Label label5;
        private ComboBox comboBoxGenre3;
        private Label label7;
        private ComboBox comboBoxGenre2;
        private Label label6;
    }
}