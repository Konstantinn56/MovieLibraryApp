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
            this.btnAddToFavourite = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.lblUsrException = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelUsr = new System.Windows.Forms.Panel();
            this.sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnAddToFavourite);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtBoxSearch);
            this.panel1.Controls.Add(this.lblUsrException);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panelUsr);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 109);
            this.panel1.TabIndex = 3;
            // 
            // btnAddToFavourite
            // 
            this.btnAddToFavourite.BackColor = System.Drawing.Color.Gray;
            this.btnAddToFavourite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToFavourite.Location = new System.Drawing.Point(745, 74);
            this.btnAddToFavourite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddToFavourite.Name = "btnAddToFavourite";
            this.btnAddToFavourite.Size = new System.Drawing.Size(131, 32);
            this.btnAddToFavourite.TabIndex = 67;
            this.btnAddToFavourite.Text = "Add To Favourite";
            this.btnAddToFavourite.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(640, 74);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 32);
            this.btnAdd.TabIndex = 66;
            this.btnAdd.Text = "Add Movie";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Gray;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Location = new System.Drawing.Point(365, 73);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 32);
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
            this.txtBoxSearch.Location = new System.Drawing.Point(50, 68);
            this.txtBoxSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(294, 25);
            this.txtBoxSearch.TabIndex = 39;
            this.txtBoxSearch.Text = "Search";
            // 
            // lblUsrException
            // 
            this.lblUsrException.AutoSize = true;
            this.lblUsrException.BackColor = System.Drawing.Color.White;
            this.lblUsrException.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsrException.ForeColor = System.Drawing.Color.Red;
            this.lblUsrException.Location = new System.Drawing.Point(41, 97);
            this.lblUsrException.Name = "lblUsrException";
            this.lblUsrException.Size = new System.Drawing.Size(0, 19);
            this.lblUsrException.TabIndex = 42;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MLibUI.Properties.Resources.usrIcon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 59);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // panelUsr
            // 
            this.panelUsr.BackColor = System.Drawing.Color.Black;
            this.panelUsr.Location = new System.Drawing.Point(12, 106);
            this.panelUsr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelUsr.Name = "panelUsr";
            this.panelUsr.Size = new System.Drawing.Size(351, 3);
            this.panelUsr.TabIndex = 41;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.AccessToken = null;
            this.sqlConnection1.Credential = null;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            this.sqlConnection1.StatisticsEnabled = false;
            // 
            // Movies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(876, 600);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Movies";
            this.Text = "Movies";
            this.Load += new System.EventHandler(this.Movies_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
        private TextBox txtBoxSearch;
        private Label lblUsrException;
        private PictureBox pictureBox1;
        private Panel panelUsr;
        private Button btnSearch;
        private Button btnAddToFavourite;
        private Button btnAdd;
    }
}