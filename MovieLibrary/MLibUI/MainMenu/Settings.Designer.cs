namespace MLibUI.MainMenu
{
    partial class Settings
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
            this.btnUsrText = new FontAwesome.Sharp.IconButton();
            this.lblFullName = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // btnUsrText
            // 
            this.btnUsrText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUsrText.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsrText.FlatAppearance.BorderSize = 0;
            this.btnUsrText.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnUsrText.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnUsrText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsrText.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUsrText.ForeColor = System.Drawing.Color.Crimson;
            this.btnUsrText.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnUsrText.IconColor = System.Drawing.Color.Crimson;
            this.btnUsrText.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsrText.IconSize = 120;
            this.btnUsrText.Location = new System.Drawing.Point(303, 78);
            this.btnUsrText.Name = "btnUsrText";
            this.btnUsrText.Size = new System.Drawing.Size(220, 162);
            this.btnUsrText.TabIndex = 5;
            this.btnUsrText.Text = "Username";
            this.btnUsrText.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUsrText.UseVisualStyleBackColor = true;
            // 
            // lblFullName
            // 
            this.lblFullName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFullName.ForeColor = System.Drawing.Color.Red;
            this.lblFullName.Location = new System.Drawing.Point(316, 233);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(195, 22);
            this.lblFullName.TabIndex = 6;
            this.lblFullName.Text = "FirstName LastName";
            // 
            // iconButton1
            // 
            this.iconButton1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButton1.BackColor = System.Drawing.Color.Gray;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(303, 351);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(220, 29);
            this.iconButton1.TabIndex = 7;
            this.iconButton1.Text = "Change Password";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconButton2.BackColor = System.Drawing.Color.Gray;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(303, 386);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(220, 29);
            this.iconButton2.TabIndex = 8;
            this.iconButton2.Text = "Reset My List";
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(812, 483);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnUsrText);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnUsrText;
        private Label lblFullName;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}