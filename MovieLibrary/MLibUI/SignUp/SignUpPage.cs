using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Model;
using Business;
using System.Runtime.InteropServices;

namespace MLibUI.SignUp
{
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        
        AccountBusiness accountBusiness = new AccountBusiness();

        /// <summary>
        /// Clears the text box and lblException and change the ForeColor of the textBox and the color of the underline
        /// </summary>
        private void txtBoxFirstName_Enter(object sender, EventArgs e)
        {
            if (txtBoxFirstName.Text.Equals("First Name"))
            {
                txtBoxFirstName.Clear();
            }
            panelFirstName.BackColor = Color.Goldenrod;
            txtBoxFirstName.ForeColor = Color.Black;
        }

        /// <summary>
        /// It will change the color of the underline, and if there is no text, it will set the watermark
        /// </summary>
        private void txtBoxFirstName_Leave(object sender, EventArgs e)
        {
            if (txtBoxFirstName.Text.Equals(""))
            {
                txtBoxFirstName.Text = "First Name";
                txtBoxFirstName.ForeColor = Color.DimGray;
                panelFirstName.BackColor = Color.Black;
            }
            else
            {
                panelFirstName.BackColor = Color.Green;
            }
        }

        /// <summary>
        /// Clears the text box and lblException and change the ForeColor of the textBox and the color of the underline
        /// </summary>
        private void txtBoxLastName_Enter(object sender, EventArgs e)
        {
            if (txtBoxLastName.Text.Equals("Last Name"))
            {
                txtBoxLastName.Clear();
            }
            panelLastName.BackColor = Color.Goldenrod;
            txtBoxLastName.ForeColor = Color.Black;
        }

        /// <summary>
        /// It will change the color of the underline, and if there is no text, it will set the watermark
        /// </summary>
        private void txtBoxLastName_Leave(object sender, EventArgs e)
        {
            if (txtBoxLastName.Text.Equals(""))
            {
                txtBoxLastName.Text = "Last Name";
                txtBoxLastName.ForeColor = Color.DimGray;
                panelLastName.BackColor = Color.Black;
            }
            else
            {
                panelLastName.BackColor = Color.Green;
            }
        }

        /// <summary>
        /// Close the Application
        /// </summary>
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Clears the text box and lblException and change the ForeColor of the textBox and the color of the underline
        /// </summary>
        private void txtBoxUsr_Enter(object sender, EventArgs e)
        {
            if (txtBoxUsr.Text.Equals("Username"))
            {
                txtBoxUsr.Clear();
            }
            lblUsrException.Text = "";
            panelUsr.BackColor = Color.Goldenrod;
            txtBoxUsr.ForeColor = Color.Black;
            
        }

        /// <summary>
        /// It will change the color of the underline, and if there is no text, it will set the watermark
        /// And set exception to the lblUsrExcpetion if username already exists
        /// </summary>
        private void txtBoxUsr_Leave(object sender, EventArgs e)
        {
            if (txtBoxUsr.Text.Equals(""))
            {
                txtBoxUsr.Text = "Username";
                txtBoxUsr.ForeColor = Color.DimGray;
                panelUsr.BackColor = Color.Black;
            }
            else
            {
                Account account = accountBusiness.Get(txtBoxUsr.Text);
                if(account == null)
                {
                    panelUsr.BackColor = Color.Green;
                }
                else
                {
                    panelUsr.BackColor = Color.Red;
                    lblUsrException.Text = "*Username already exists!*";
                }
                if(txtBoxUsr.Text.Length <= 4)
                {
                    panelUsr.BackColor = Color.Red;
                    lblUsrException.Text = "*Username must be at least 5 characters*";
                }
            }
        }

        /// <summary>
        /// Clears the text box and lblException and change the ForeColor of the textBox and the color of the underline
        /// </summary>
        private void txtBoxPass_Enter(object sender, EventArgs e)
        {
            if (txtBoxPass.Text.Equals("Password"))
            {
                txtBoxPass.Clear();
                txtBoxPass.UseSystemPasswordChar = true;
                txtBoxPass.ForeColor = Color.Black;

            }
            //If there is not exception then it will change panel color
            if (lblPassEx.Text.Equals(""))
            {
                panelPass.BackColor = Color.Goldenrod;
            }
            
        }

        /// <summary>
        /// It will change the color of the underline, and if there is no text, it will set the watermark
        /// And set exception to the lblUsrExcpetion if username already exists
        /// </summary>
        private void txtBoxPass_Leave(object sender, EventArgs e)
        {
            if (txtBoxPass.Text.Equals("") || txtBoxPass.Equals("Password"))
            {
                txtBoxPass.Text = "Password";
                txtBoxPass.UseSystemPasswordChar = false;
                txtBoxPass.ForeColor = Color.DimGray;
                panelPass.BackColor = Color.Black;
            }
            else
            {
                //if there is a no exception than it will change panel color
                if (lblPassEx.Text.Equals(""))
                {
                    panelPass.BackColor = Color.Green;
                }
            }
        }

        /// <summary>
        /// Clears the text box and lblException and change the ForeColor of the textBox and the color of the underline
        /// </summary>
        private void txtBoxReEnterPass_Enter(object sender, EventArgs e)
        {
            if (txtBoxReEnterPass.Text.Equals("Re-enter password"))
            {
                txtBoxReEnterPass.Clear();
                txtBoxReEnterPass.UseSystemPasswordChar = true;
            }
            lblPassEx.Text = "";
            panelReEnterPass.BackColor = Color.Goldenrod;
            txtBoxReEnterPass.ForeColor = Color.Black;
        }

        /// <summary>
        /// It will change the color of the underline, and if there is no text, it will set the watermark
        /// And set exception to the lblUsrExcpetion if username already exists
        /// </summary>
        private void txtBoxReEnterPass_Leave(object sender, EventArgs e)
        {
            if (txtBoxReEnterPass.Text.Equals("") || txtBoxReEnterPass.Equals("Re-enter password"))
            {
                txtBoxReEnterPass.Text = "Re-enter password";
                txtBoxReEnterPass.UseSystemPasswordChar = false;
                txtBoxReEnterPass.ForeColor = Color.DimGray;
                panelReEnterPass.BackColor = Color.Black;
            }
            else
            {
                if(txtBoxPass.Text == txtBoxReEnterPass.Text)
                {
                    panelReEnterPass.BackColor = Color.Green;
                    panelPass.BackColor = Color.Green;
                }
                else
                {
                    panelReEnterPass.BackColor = Color.Red;
                    panelPass.BackColor = Color.Red;
                    lblPassEx.Text = "*Passwords doesn't match*";
                }
            }
        }

        /// <summary>
        /// Change the SystemPassChar to oposite on txtBoxPass and txtBoxReEnterPass
        /// </summary>
        private void lblEye_Click(object sender, EventArgs e)
        {
            bool passStatus = txtBoxPass.UseSystemPasswordChar;
            if (!txtBoxPass.Text.Equals("Password"))
            {
                txtBoxPass.UseSystemPasswordChar = !passStatus;
            }
            if(!txtBoxReEnterPass.Text.Equals("Re-enter password"))
            {
                txtBoxReEnterPass.UseSystemPasswordChar = !passStatus;
            }
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
        /// Close current window, and opens login page
        /// </summary>
        private void linkLblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }

        /// <summary>
        /// If there are no Exception it will add the account into database, and will open RecoveryKeyPage
        /// </summary>
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if(lblUsrException.Text.Equals("") && lblPassEx.Text.Equals(""))
            {
                if (IsThereAEmptyTextBox())
                {
                    MessageBox.Show("The fields must not be empty!");
                }
                else
                {
                    Account account = new Account();
                    account.FirstName = txtBoxFirstName.Text;
                    account.LastName = txtBoxLastName.Text;
                    account.Username = txtBoxUsr.Text;
                    account.Password = txtBoxPass.Text;
                    account.RecoveryKey = 0;

                    //if the random recovery key already exists it will create new one
                    while (account.RecoveryKey == 0)
                    {
                        int recoveryKey = GenerateRandomKey();
                        if (!accountBusiness.DoesThisRecoveryKeyAlreadyExists(recoveryKey))
                        {
                            account.RecoveryKey = recoveryKey;
                            break;
                        }
                    }
                    accountBusiness.Add(account);
                    RecoveryKeyPage rkp = new RecoveryKeyPage();
                    rkp.currentAccountRecoveryKey = account.RecoveryKey;
                    rkp.Show();
                    this.Hide();
                }
            }
        }

        /// <summary>
        /// If there is empty text box it will change the panel color
        /// </summary>
        /// <returns>True(Yes)/False(No)</returns>
        private bool IsThereAEmptyTextBox()
        {
            bool isThere = false;
            if (txtBoxFirstName.Text.Equals("First Name"))
            {
                isThere = true;
                panelFirstName.BackColor = Color.Red;
            }
            if (txtBoxLastName.Text.Equals("Last Name"))
            {
                isThere = true;
                panelLastName.BackColor = Color.Red;
            }
            if (txtBoxUsr.Text.Equals("Username"))
            {
                isThere = true;
                panelUsr.BackColor = Color.Red;
            }
            if (txtBoxPass.Text.Equals("Password"))
            {
                isThere = true;
                panelPass.BackColor = Color.Red;
            }
            if (txtBoxReEnterPass.Text.Equals("Re-enter password"))
            {
                isThere = true;
                panelReEnterPass.BackColor = Color.Red;
            }
            return isThere;
        }

        /// <summary>
        /// If there is no exception and the check box is checked enables the button Sign up
        /// </summary>
        private void checkBoxTerms_CheckedChanged(object sender, EventArgs e)
        {
            btnSignUp.Enabled = !btnSignUp.Enabled;
        }

        /// <summary>
        /// Generate Random Key [100001-999999]
        /// </summary>
        /// <returns>key</returns>
        private int GenerateRandomKey()
        {
            Random rnd = new Random();
            return rnd.Next(100001,999999);
        }

        /// <summary>
        /// If the text in the pass box is changed, clear reEnter password txtbox 
        /// </summary>
        private void txtBoxPass_TextChanged(object sender, EventArgs e)
        {
            panelReEnterPass.BackColor = Color.Black;
            txtBoxReEnterPass.Text = "Re-enter password";
            txtBoxReEnterPass.UseSystemPasswordChar = false;
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
