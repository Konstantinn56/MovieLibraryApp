using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business;
using Data.Model;

namespace MLibUI.PassRecovery
{
    public partial class PassRecoveryStep2 : Form
    {
        public PassRecoveryStep2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creating account business
        /// </summary>
        AccountBusiness accountBusiness = new AccountBusiness();
        
        /// <summary>
        /// Current account
        /// </summary>
        public Account currentAccount { get; set; }

        /// <summary>
        /// Clears the text box and lblException and change the ForeColor of the textBox and the color of the underline
        /// </summary>
        private void txtBoxNewPass_Enter(object sender, EventArgs e)
        {
            if(txtBoxNewPass.Text.Equals("New Password"))
            {
                txtBoxNewPass.Clear();
                txtBoxNewPass.ForeColor = Color.Black;
                txtBoxNewPass.UseSystemPasswordChar = true;
                panelPass.BackColor = Color.Goldenrod;
            }
            else if (!lblPassEx.Text.Equals("*Password doesn't match*"))
            {
                lblPassEx.Text = "";
            }
        }

        /// <summary>
        /// It will change the color of the underline, and if there is no text, it will set the watermark
        /// And set exception to the lblUsrExcpetion if username already exists
        /// </summary>
        private void txtBoxNewPass_Leave(object sender, EventArgs e)
        {
            if(txtBoxNewPass.Text.Equals("") || txtBoxNewPass.Text.Equals("New Password"))
            {
                txtBoxNewPass.Text = "New Password";
                txtBoxNewPass.ForeColor = Color.DimGray;
                txtBoxNewPass.UseSystemPasswordChar = false;
                panelPass.BackColor = Color.Black;
            }
            else
            {
                if(txtBoxNewPass.Text.Length <= 4)
                {
                    panelPass.BackColor = Color.Red;
                    lblPassEx.Text = "*Password must be at least 5 characters*";
                }
                else
                {
                    panelPass.BackColor = Color.Green;                   
                }
            }
        }

        /// <summary>
        /// Clears the text box and lblException and change the ForeColor of the textBox and the color of the underline
        /// </summary>
        private void txtBoxReEnterNewPass_Enter(object sender, EventArgs e)
        {
            if (txtBoxReEnterNewPass.Text.Equals("Re-enter password"))
            {
                txtBoxReEnterNewPass.Clear();
                txtBoxReEnterNewPass.ForeColor = Color.Black;
                txtBoxReEnterNewPass.UseSystemPasswordChar = true;
                panelReEnterPass.BackColor = Color.Goldenrod;
            }
            else if (!lblPassEx.Text.Equals("*Password must be at least 5 characters*"))
            {
                lblPassEx.Text = "";
            }
        }

        /// <summary>
        /// It will change the color of the underline, and if there is no text, it will set the watermark
        /// </summary>
        private void txtBoxReEnterNewPass_Leave(object sender, EventArgs e)
        {
            if (txtBoxReEnterNewPass.Text.Equals("") || txtBoxReEnterNewPass.Text.Equals("Re-enter password"))
            {
                txtBoxReEnterNewPass.Text = "Re-enter password";
                txtBoxReEnterNewPass.ForeColor = Color.DimGray;
                txtBoxReEnterNewPass.UseSystemPasswordChar = false;
                panelReEnterPass.BackColor = Color.Black;
            }
            else
            {
                if (lblPassEx.Text.Equals("") && txtBoxNewPass.Text.Equals(txtBoxReEnterNewPass.Text))
                {
                    panelReEnterPass.BackColor = Color.Green;
                }
                else if (lblPassEx.Text.Equals(""))
                {
                    lblPassEx.Text = "*Password doesn't match*";
                    panelPass.BackColor = Color.Red;
                    panelReEnterPass.BackColor = Color.Red;
                }
            }
        }
        /// <summary>
        /// Closes the application
        /// </summary>
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Change eye color to Goldenrod
        /// </summary>
        private void lblEye_MouseHover(object sender, EventArgs e)
        {
            lblEye.ForeColor = Color.Goldenrod;
        }

        /// <summary>
        /// Change eye color to Black
        /// </summary>
        private void lblEye_MouseLeave(object sender, EventArgs e)
        {
            lblEye.ForeColor = Color.Black;
        }

        /// <summary>
        /// Change the SystemPassChar to oposite on txtBoxPass and txtBoxReEnterPass
        /// </summary>
        private void lblEye_Click(object sender, EventArgs e)
        {
            bool txtBoxPassStatus = txtBoxNewPass.UseSystemPasswordChar;
            if (!txtBoxNewPass.Text.Equals("New Password"))
            {
                txtBoxNewPass.UseSystemPasswordChar = !txtBoxPassStatus;
            }
            if (!txtBoxReEnterNewPass.Text.Equals("Re-enter password"))
            {
                txtBoxReEnterNewPass.UseSystemPasswordChar = !txtBoxPassStatus;
            }
        }

        /// <summary>
        /// If there is no exeptions it will change the password and will open Done page
        /// </summary>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtBoxNewPass.Text.Equals("New Password") || txtBoxReEnterNewPass.Text.Equals("Re-enter password"))
            {
                MessageBox.Show("The Fields must not be empty!");
            }
            else
            {
                if (!lblPassEx.Text.Equals(""))
                {
                    MessageBox.Show("Incorrect passwords");
                }
                else
                {
                    Account updatedAccount = currentAccount;
                    updatedAccount.Password = txtBoxNewPass.Text;
                    accountBusiness.Update(updatedAccount);
                    SuccessfulPassResetPage sprp = new SuccessfulPassResetPage();
                    sprp.Show();
                    this.Hide();
                }
            }
        }

        /// <summary>
        /// If the text in the pass box is changed, clear reEnter password txtbox 
        /// </summary>
        private void txtBoxNewPass_TextChanged(object sender, EventArgs e)
        {
            panelReEnterPass.BackColor = Color.Black;
            txtBoxReEnterNewPass.Text = "Re-enter password";
            txtBoxReEnterNewPass.UseSystemPasswordChar = false;
        }
        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// Make the window draggable
        /// </summary>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /// <summary>
        /// Make the window draggable
        /// </summary>
        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
