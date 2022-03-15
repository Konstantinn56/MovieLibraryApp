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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAddToFavourite = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.lblUsrException = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.txtBoxMovie1 = new System.Windows.Forms.RichTextBox();
            this.txtBoxMovie2 = new System.Windows.Forms.RichTextBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.txtBoxMovie3 = new System.Windows.Forms.RichTextBox();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.txtBoxMovie4 = new System.Windows.Forms.RichTextBox();
            this.picBox4 = new System.Windows.Forms.PictureBox();
            this.txtBoxMovie8 = new System.Windows.Forms.RichTextBox();
            this.picBox8 = new System.Windows.Forms.PictureBox();
            this.txtBoxMovie7 = new System.Windows.Forms.RichTextBox();
            this.picBox7 = new System.Windows.Forms.PictureBox();
            this.txtBoxMovie6 = new System.Windows.Forms.RichTextBox();
            this.picBox6 = new System.Windows.Forms.PictureBox();
            this.txtBoxMovie5 = new System.Windows.Forms.RichTextBox();
            this.picBox5 = new System.Windows.Forms.PictureBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
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
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnView);
            this.panel1.Controls.Add(this.btnAddToFavourite);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtBoxSearch);
            this.panel1.Controls.Add(this.lblUsrException);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panelSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1068, 82);
            this.panel1.TabIndex = 3;
            // 
            // btnView
            // 
            this.btnView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnView.BackColor = System.Drawing.Color.Gray;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Location = new System.Drawing.Point(1001, 52);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(55, 24);
            this.btnView.TabIndex = 68;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = false;
            // 
            // btnAddToFavourite
            // 
            this.btnAddToFavourite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToFavourite.BackColor = System.Drawing.Color.Gray;
            this.btnAddToFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToFavourite.Location = new System.Drawing.Point(880, 52);
            this.btnAddToFavourite.Name = "btnAddToFavourite";
            this.btnAddToFavourite.Size = new System.Drawing.Size(115, 24);
            this.btnAddToFavourite.TabIndex = 67;
            this.btnAddToFavourite.Text = "Add To Favourite";
            this.btnAddToFavourite.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(787, 52);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 24);
            this.btnAdd.TabIndex = 66;
            this.btnAdd.Text = "Add Movie";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(348, 52);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(68, 24);
            this.btnSearch.TabIndex = 65;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.BackColor = System.Drawing.Color.Gray;
            this.txtBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxSearch.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxSearch.ForeColor = System.Drawing.Color.Black;
            this.txtBoxSearch.Location = new System.Drawing.Point(69, 45);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(257, 20);
            this.txtBoxSearch.TabIndex = 39;
            this.txtBoxSearch.Text = "Search";
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
            this.picBox1.BackColor = System.Drawing.Color.Black;
            this.picBox1.Location = new System.Drawing.Point(52, 108);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(161, 146);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox1.TabIndex = 4;
            this.picBox1.TabStop = false;
            // 
            // txtBoxMovie1
            // 
            this.txtBoxMovie1.BackColor = System.Drawing.Color.DimGray;
            this.txtBoxMovie1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMovie1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxMovie1.ForeColor = System.Drawing.Color.Black;
            this.txtBoxMovie1.Location = new System.Drawing.Point(52, 260);
            this.txtBoxMovie1.Name = "txtBoxMovie1";
            this.txtBoxMovie1.ReadOnly = true;
            this.txtBoxMovie1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtBoxMovie1.Size = new System.Drawing.Size(161, 39);
            this.txtBoxMovie1.TabIndex = 7;
            this.txtBoxMovie1.Text = "Title\nGenre\n";
            // 
            // txtBoxMovie2
            // 
            this.txtBoxMovie2.BackColor = System.Drawing.Color.DimGray;
            this.txtBoxMovie2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMovie2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxMovie2.ForeColor = System.Drawing.Color.Black;
            this.txtBoxMovie2.Location = new System.Drawing.Point(279, 260);
            this.txtBoxMovie2.Name = "txtBoxMovie2";
            this.txtBoxMovie2.ReadOnly = true;
            this.txtBoxMovie2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtBoxMovie2.Size = new System.Drawing.Size(161, 39);
            this.txtBoxMovie2.TabIndex = 9;
            this.txtBoxMovie2.Text = "Title\nGenre\n";
            // 
            // picBox2
            // 
            this.picBox2.BackColor = System.Drawing.Color.Black;
            this.picBox2.Location = new System.Drawing.Point(279, 108);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(161, 146);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox2.TabIndex = 8;
            this.picBox2.TabStop = false;
            // 
            // txtBoxMovie3
            // 
            this.txtBoxMovie3.BackColor = System.Drawing.Color.DimGray;
            this.txtBoxMovie3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMovie3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxMovie3.ForeColor = System.Drawing.Color.Black;
            this.txtBoxMovie3.Location = new System.Drawing.Point(510, 260);
            this.txtBoxMovie3.Name = "txtBoxMovie3";
            this.txtBoxMovie3.ReadOnly = true;
            this.txtBoxMovie3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtBoxMovie3.Size = new System.Drawing.Size(161, 39);
            this.txtBoxMovie3.TabIndex = 11;
            this.txtBoxMovie3.Text = "Title\nGenre\n";
            // 
            // picBox3
            // 
            this.picBox3.BackColor = System.Drawing.Color.Black;
            this.picBox3.Location = new System.Drawing.Point(510, 108);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(161, 146);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox3.TabIndex = 10;
            this.picBox3.TabStop = false;
            // 
            // txtBoxMovie4
            // 
            this.txtBoxMovie4.BackColor = System.Drawing.Color.DimGray;
            this.txtBoxMovie4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMovie4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxMovie4.ForeColor = System.Drawing.Color.Black;
            this.txtBoxMovie4.Location = new System.Drawing.Point(735, 260);
            this.txtBoxMovie4.Name = "txtBoxMovie4";
            this.txtBoxMovie4.ReadOnly = true;
            this.txtBoxMovie4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtBoxMovie4.Size = new System.Drawing.Size(161, 39);
            this.txtBoxMovie4.TabIndex = 13;
            this.txtBoxMovie4.Text = "Title\nGenre\n";
            // 
            // picBox4
            // 
            this.picBox4.BackColor = System.Drawing.Color.Black;
            this.picBox4.Location = new System.Drawing.Point(735, 108);
            this.picBox4.Name = "picBox4";
            this.picBox4.Size = new System.Drawing.Size(161, 146);
            this.picBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox4.TabIndex = 12;
            this.picBox4.TabStop = false;
            // 
            // txtBoxMovie8
            // 
            this.txtBoxMovie8.BackColor = System.Drawing.Color.DimGray;
            this.txtBoxMovie8.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMovie8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxMovie8.ForeColor = System.Drawing.Color.Black;
            this.txtBoxMovie8.Location = new System.Drawing.Point(735, 484);
            this.txtBoxMovie8.Name = "txtBoxMovie8";
            this.txtBoxMovie8.ReadOnly = true;
            this.txtBoxMovie8.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtBoxMovie8.Size = new System.Drawing.Size(161, 39);
            this.txtBoxMovie8.TabIndex = 23;
            this.txtBoxMovie8.Text = "Title\nGenre\n";
            // 
            // picBox8
            // 
            this.picBox8.BackColor = System.Drawing.Color.Black;
            this.picBox8.Location = new System.Drawing.Point(735, 332);
            this.picBox8.Name = "picBox8";
            this.picBox8.Size = new System.Drawing.Size(161, 146);
            this.picBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox8.TabIndex = 22;
            this.picBox8.TabStop = false;
            // 
            // txtBoxMovie7
            // 
            this.txtBoxMovie7.BackColor = System.Drawing.Color.DimGray;
            this.txtBoxMovie7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMovie7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxMovie7.ForeColor = System.Drawing.Color.Black;
            this.txtBoxMovie7.Location = new System.Drawing.Point(510, 484);
            this.txtBoxMovie7.Name = "txtBoxMovie7";
            this.txtBoxMovie7.ReadOnly = true;
            this.txtBoxMovie7.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtBoxMovie7.Size = new System.Drawing.Size(161, 39);
            this.txtBoxMovie7.TabIndex = 21;
            this.txtBoxMovie7.Text = "Title\nGenre\n";
            // 
            // picBox7
            // 
            this.picBox7.BackColor = System.Drawing.Color.Black;
            this.picBox7.Location = new System.Drawing.Point(510, 332);
            this.picBox7.Name = "picBox7";
            this.picBox7.Size = new System.Drawing.Size(161, 146);
            this.picBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox7.TabIndex = 20;
            this.picBox7.TabStop = false;
            // 
            // txtBoxMovie6
            // 
            this.txtBoxMovie6.BackColor = System.Drawing.Color.DimGray;
            this.txtBoxMovie6.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMovie6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxMovie6.ForeColor = System.Drawing.Color.Black;
            this.txtBoxMovie6.Location = new System.Drawing.Point(279, 484);
            this.txtBoxMovie6.Name = "txtBoxMovie6";
            this.txtBoxMovie6.ReadOnly = true;
            this.txtBoxMovie6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtBoxMovie6.Size = new System.Drawing.Size(161, 39);
            this.txtBoxMovie6.TabIndex = 19;
            this.txtBoxMovie6.Text = "Title\nGenre\n";
            // 
            // picBox6
            // 
            this.picBox6.BackColor = System.Drawing.Color.Black;
            this.picBox6.Location = new System.Drawing.Point(279, 332);
            this.picBox6.Name = "picBox6";
            this.picBox6.Size = new System.Drawing.Size(161, 146);
            this.picBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox6.TabIndex = 18;
            this.picBox6.TabStop = false;
            // 
            // txtBoxMovie5
            // 
            this.txtBoxMovie5.BackColor = System.Drawing.Color.DimGray;
            this.txtBoxMovie5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMovie5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxMovie5.ForeColor = System.Drawing.Color.Black;
            this.txtBoxMovie5.Location = new System.Drawing.Point(52, 484);
            this.txtBoxMovie5.Name = "txtBoxMovie5";
            this.txtBoxMovie5.ReadOnly = true;
            this.txtBoxMovie5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.txtBoxMovie5.Size = new System.Drawing.Size(161, 39);
            this.txtBoxMovie5.TabIndex = 17;
            this.txtBoxMovie5.Text = "Title\nGenre\n";
            // 
            // picBox5
            // 
            this.picBox5.BackColor = System.Drawing.Color.Black;
            this.picBox5.Location = new System.Drawing.Point(52, 332);
            this.picBox5.Name = "picBox5";
            this.picBox5.Size = new System.Drawing.Size(161, 146);
            this.picBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox5.TabIndex = 16;
            this.picBox5.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNext.BackColor = System.Drawing.Color.Gray;
            this.btnNext.Enabled = false;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(960, 550);
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
            this.btnPrev.BackColor = System.Drawing.Color.Gray;
            this.btnPrev.Enabled = false;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.Location = new System.Drawing.Point(893, 550);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(61, 24);
            this.btnPrev.TabIndex = 70;
            this.btnPrev.Text = "Prev";
            this.btnPrev.UseVisualStyleBackColor = false;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1068, 589);
            this.Controls.Add(this.btnPrev);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.txtBoxMovie8);
            this.Controls.Add(this.picBox8);
            this.Controls.Add(this.txtBoxMovie7);
            this.Controls.Add(this.picBox7);
            this.Controls.Add(this.txtBoxMovie6);
            this.Controls.Add(this.picBox6);
            this.Controls.Add(this.txtBoxMovie5);
            this.Controls.Add(this.picBox5);
            this.Controls.Add(this.txtBoxMovie4);
            this.Controls.Add(this.picBox4);
            this.Controls.Add(this.txtBoxMovie3);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.txtBoxMovie2);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.txtBoxMovie1);
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
        private Button btnAdd;
        private PictureBox picBox1;
        private RichTextBox txtBoxMovie1;
        private Button btnView;
        private RichTextBox txtBoxMovie2;
        private PictureBox picBox2;
        private RichTextBox txtBoxMovie3;
        private PictureBox picBox3;
        private RichTextBox txtBoxMovie4;
        private PictureBox picBox4;
        private RichTextBox txtBoxMovie8;
        private PictureBox picBox8;
        private RichTextBox txtBoxMovie7;
        private PictureBox picBox7;
        private RichTextBox txtBoxMovie6;
        private PictureBox picBox6;
        private RichTextBox txtBoxMovie5;
        private PictureBox picBox5;
        private Button btnNext;
        private Button btnPrev;
    }
}