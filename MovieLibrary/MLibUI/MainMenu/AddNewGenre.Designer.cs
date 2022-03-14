namespace MLibUI.MainMenu
{
    partial class AddNewGenre
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxGenre = new System.Windows.Forms.TextBox();
            this.lblUsrException = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelGenre = new System.Windows.Forms.Panel();
            this.btnCancle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Gray;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(237, 84);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 24);
            this.btnAdd.TabIndex = 64;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtBoxGenre
            // 
            this.txtBoxGenre.BackColor = System.Drawing.Color.DarkGray;
            this.txtBoxGenre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxGenre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtBoxGenre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxGenre.ForeColor = System.Drawing.Color.DarkRed;
            this.txtBoxGenre.Location = new System.Drawing.Point(48, 39);
            this.txtBoxGenre.Name = "txtBoxGenre";
            this.txtBoxGenre.Size = new System.Drawing.Size(257, 20);
            this.txtBoxGenre.TabIndex = 65;
            this.txtBoxGenre.Text = "Genre";
            this.txtBoxGenre.TextChanged += new System.EventHandler(this.txtBoxGenre_TextChanged);
            this.txtBoxGenre.Enter += new System.EventHandler(this.txtBoxGenre_Enter);
            this.txtBoxGenre.Leave += new System.EventHandler(this.txtBoxGenre_Leave);
            // 
            // lblUsrException
            // 
            this.lblUsrException.AutoSize = true;
            this.lblUsrException.BackColor = System.Drawing.Color.White;
            this.lblUsrException.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUsrException.ForeColor = System.Drawing.Color.Red;
            this.lblUsrException.Location = new System.Drawing.Point(48, 70);
            this.lblUsrException.Name = "lblUsrException";
            this.lblUsrException.Size = new System.Drawing.Size(0, 16);
            this.lblUsrException.TabIndex = 68;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MLibUI.Properties.Resources.usrIcon;
            this.pictureBox1.Location = new System.Drawing.Point(14, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // panelGenre
            // 
            this.panelGenre.BackColor = System.Drawing.Color.Black;
            this.panelGenre.Location = new System.Drawing.Point(11, 65);
            this.panelGenre.Name = "panelGenre";
            this.panelGenre.Size = new System.Drawing.Size(307, 2);
            this.panelGenre.TabIndex = 67;
            // 
            // btnCancle
            // 
            this.btnCancle.BackColor = System.Drawing.Color.Gray;
            this.btnCancle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancle.Location = new System.Drawing.Point(169, 84);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(62, 24);
            this.btnCancle.TabIndex = 69;
            this.btnCancle.Text = "Cancle";
            this.btnCancle.UseVisualStyleBackColor = false;
            this.btnCancle.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.txtBoxGenre);
            this.panel1.Controls.Add(this.btnCancle);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.panelGenre);
            this.panel1.Controls.Add(this.lblUsrException);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 130);
            this.panel1.TabIndex = 70;
            // 
            // AddNewGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(331, 137);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewGenre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddNewGenre";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAdd;
        private TextBox txtBoxGenre;
        private Label lblUsrException;
        private PictureBox pictureBox1;
        private Panel panelGenre;
        private Button btnCancle;
        private Panel panel1;
    }
}