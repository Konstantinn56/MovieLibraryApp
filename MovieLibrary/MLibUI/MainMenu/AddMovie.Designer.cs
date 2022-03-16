namespace MLibUI.MainMenu
{
    partial class AddMovie
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
            this.txtBoxTitle = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.txtBoxYear = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelYear = new System.Windows.Forms.Panel();
            this.txtBoxRate = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panelRate = new System.Windows.Forms.Panel();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblYearExepction = new System.Windows.Forms.Label();
            this.lblRateException = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTitleException = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxTitle
            // 
            this.txtBoxTitle.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxTitle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.txtBoxTitle.Location = new System.Drawing.Point(70, 90);
            this.txtBoxTitle.Name = "txtBoxTitle";
            this.txtBoxTitle.Size = new System.Drawing.Size(257, 20);
            this.txtBoxTitle.TabIndex = 39;
            this.txtBoxTitle.Text = "Title";
            this.txtBoxTitle.TextChanged += new System.EventHandler(this.txtBoxTitle_TextChanged);
            this.txtBoxTitle.Enter += new System.EventHandler(this.txtBoxTitle_Enter);
            this.txtBoxTitle.Leave += new System.EventHandler(this.txtBoxTitle_Leave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MLibUI.Properties.Resources.usrIcon;
            this.pictureBox1.Location = new System.Drawing.Point(36, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.Black;
            this.panelTitle.Location = new System.Drawing.Point(33, 116);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(307, 2);
            this.panelTitle.TabIndex = 43;
            // 
            // txtBoxYear
            // 
            this.txtBoxYear.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxYear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxYear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxYear.ForeColor = System.Drawing.Color.DarkRed;
            this.txtBoxYear.Location = new System.Drawing.Point(70, 165);
            this.txtBoxYear.Name = "txtBoxYear";
            this.txtBoxYear.Size = new System.Drawing.Size(257, 20);
            this.txtBoxYear.TabIndex = 49;
            this.txtBoxYear.Text = "Year";
            this.txtBoxYear.Enter += new System.EventHandler(this.txtBoxYear_Enter);
            this.txtBoxYear.Leave += new System.EventHandler(this.txtBoxYear_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MLibUI.Properties.Resources.usrIcon;
            this.pictureBox2.Location = new System.Drawing.Point(36, 158);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // panelYear
            // 
            this.panelYear.BackColor = System.Drawing.Color.Black;
            this.panelYear.Location = new System.Drawing.Point(33, 191);
            this.panelYear.Name = "panelYear";
            this.panelYear.Size = new System.Drawing.Size(307, 2);
            this.panelYear.TabIndex = 51;
            // 
            // txtBoxRate
            // 
            this.txtBoxRate.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxRate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxRate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxRate.ForeColor = System.Drawing.Color.DarkRed;
            this.txtBoxRate.Location = new System.Drawing.Point(70, 243);
            this.txtBoxRate.Name = "txtBoxRate";
            this.txtBoxRate.Size = new System.Drawing.Size(257, 20);
            this.txtBoxRate.TabIndex = 53;
            this.txtBoxRate.Text = "Rate [1-10]";
            this.txtBoxRate.Enter += new System.EventHandler(this.txtBoxRate_Enter);
            this.txtBoxRate.Leave += new System.EventHandler(this.txtBoxRate_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::MLibUI.Properties.Resources.usrIcon;
            this.pictureBox3.Location = new System.Drawing.Point(36, 236);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(28, 27);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 54;
            this.pictureBox3.TabStop = false;
            // 
            // panelRate
            // 
            this.panelRate.BackColor = System.Drawing.Color.Black;
            this.panelRate.Location = new System.Drawing.Point(33, 269);
            this.panelRate.Name = "panelRate";
            this.panelRate.Size = new System.Drawing.Size(307, 2);
            this.panelRate.TabIndex = 55;
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxImage.Location = new System.Drawing.Point(475, 34);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(350, 371);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxImage.TabIndex = 57;
            this.pictureBoxImage.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(475, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 16);
            this.label4.TabIndex = 58;
            this.label4.Text = "Image";
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.BackColor = System.Drawing.Color.DarkGray;
            this.comboBoxGenre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenre.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxGenre.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxGenre.ForeColor = System.Drawing.Color.DarkRed;
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(36, 352);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(304, 28);
            this.comboBoxGenre.TabIndex = 60;
            this.comboBoxGenre.TextChanged += new System.EventHandler(this.comboBoxGenre_TextChanged);
            this.comboBoxGenre.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxGenre_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(33, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Genre";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.Gray;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowse.Location = new System.Drawing.Point(731, 411);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 27);
            this.btnBrowse.TabIndex = 62;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(172, 411);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 27);
            this.btnAdd.TabIndex = 63;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(70, 411);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(96, 27);
            this.btnReset.TabIndex = 64;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblYearExepction
            // 
            this.lblYearExepction.AutoSize = true;
            this.lblYearExepction.BackColor = System.Drawing.Color.DarkGray;
            this.lblYearExepction.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYearExepction.ForeColor = System.Drawing.Color.Red;
            this.lblYearExepction.Location = new System.Drawing.Point(70, 196);
            this.lblYearExepction.Name = "lblYearExepction";
            this.lblYearExepction.Size = new System.Drawing.Size(0, 16);
            this.lblYearExepction.TabIndex = 65;
            // 
            // lblRateException
            // 
            this.lblRateException.AutoSize = true;
            this.lblRateException.BackColor = System.Drawing.Color.DarkGray;
            this.lblRateException.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRateException.ForeColor = System.Drawing.Color.Red;
            this.lblRateException.Location = new System.Drawing.Point(70, 274);
            this.lblRateException.Name = "lblRateException";
            this.lblRateException.Size = new System.Drawing.Size(0, 16);
            this.lblRateException.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "Movie Information";
            // 
            // lblTitleException
            // 
            this.lblTitleException.AutoSize = true;
            this.lblTitleException.BackColor = System.Drawing.Color.DarkGray;
            this.lblTitleException.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleException.ForeColor = System.Drawing.Color.Red;
            this.lblTitleException.Location = new System.Drawing.Point(70, 121);
            this.lblTitleException.Name = "lblTitleException";
            this.lblTitleException.Size = new System.Drawing.Size(0, 16);
            this.lblTitleException.TabIndex = 68;
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(837, 485);
            this.Controls.Add(this.lblTitleException);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRateException);
            this.Controls.Add(this.lblYearExepction);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.txtBoxRate);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panelRate);
            this.Controls.Add(this.txtBoxYear);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelYear);
            this.Controls.Add(this.txtBoxTitle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelTitle);
            this.Name = "AddMovie";
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox txtBoxTitle;
        private PictureBox pictureBox1;
        private Panel panelTitle;
        private TextBox txtBoxYear;
        private PictureBox pictureBox2;
        private Panel panelYear;
        private TextBox txtBoxRate;
        private PictureBox pictureBox3;
        private Panel panelRate;
        private PictureBox pictureBoxImage;
        private Label label4;
        private ComboBox comboBoxGenre;
        private Label label2;
        private Button btnBrowse;
        private Button btnAdd;
        private Button btnReset;
        private Label lblYearExepction;
        private Label lblRateException;
        private Label label1;
        private Label lblTitleException;
    }
}