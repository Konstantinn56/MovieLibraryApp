using Business;
using Data.Model;
using MLibUI.MainMenu;
using MLibUI.SignUp;
using MLibUI.PassRecovery;
using System.Runtime.InteropServices;

namespace MLibUI
{
    /// <summary>
    /// Login UI
    /// </summary>
    public partial class LoginPage : Form
    {
        /// <summary>
        /// Creates account business
        /// </summary>
        private AccountBusiness accountBusiness = new AccountBusiness();

        public LoginPage()
        {
            InitializeComponent();

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
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
        /// </summary>
        private void txtBoxUsr_Leave(object sender, EventArgs e)
        {
            if (txtBoxUsr.Text.Equals(""))
            {
                txtBoxUsr.Text = "Username";
                txtBoxUsr.ForeColor = Color.DimGray;
            }
            panelUsr.BackColor = Color.Black;
        }

        /// <summary>
        /// Clears the text box and change the ForeColor of the textBox and the color of the underline, and set systemPassChar
        /// </summary>
        private void txtBoxPass_Enter(object sender, EventArgs e)
        {
            if (txtBoxPass.Text.Equals("Password"))
            {
                txtBoxPass.Clear();
            }
            panelPass.BackColor = Color.Goldenrod;
            txtBoxPass.ForeColor = Color.Black;
            txtBoxPass.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// It will change the color of the underline, and if there is no text, it will set the watermark, and stop the SystemPassChar
        /// </summary>
        private void txtBoxPass_Leave(object sender, EventArgs e)
        {
            if (txtBoxPass.Text.Equals("") || txtBoxPass.Equals("Password"))
            {
                txtBoxPass.Text = "Password";
                txtBoxPass.ForeColor = Color.DimGray;
                txtBoxPass.UseSystemPasswordChar = false;
            }
            panelPass.BackColor = Color.Black;
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
        /// Change the SystemPassChar to oposite on txtBoxPass
        /// </summary>
        private void lblEye_Click(object sender, EventArgs e)
        {
            if (!txtBoxPass.Text.Equals("Password"))
            {
                bool currentStatus = txtBoxPass.UseSystemPasswordChar;
                txtBoxPass.UseSystemPasswordChar = !currentStatus;
            }
        }

        /// <summary>
        /// Identify the account, and login into application, throws MessageBow if the user or pass is incorrect
        /// </summary>
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Account currentAcc = accountBusiness.Get(txtBoxUsr.Text.ToString());
            if (currentAcc == null || !currentAcc.Password.Equals(txtBoxPass.Text))
            {
                lblUsrException.Text = "*Invalid username or password*";
                MessageBox.Show("Incorrect Username or Password!");
            }
            else
            {
                mainPage mp = new mainPage();
                mp.currentAccount = currentAcc;
                mp.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Close current Window, and open new SignUp Window
        /// </summary>
        private void linkLblCreateAcc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpPage sup = new SignUpPage();
            sup.Show();
            this.Hide();
        }

        /// <summary>
        /// Close current Window, and open new ForgottenPass page
        /// </summary>
        private void lblForgottenPass_Click(object sender, EventArgs e)
        {
            ForgottenPassPage fpp = new ForgottenPassPage();
            fpp.Show();
            this.Hide();
        }

        /// <summary>
        /// Close the application
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        /// <summary>
        /// Minimize the window
        /// </summary>
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// Make the window draggable
        /// </summary>
        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Make the window draggable
        /// </summary>
        private void LoginPage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Make the window draggable
        /// </summary>
        private void panel11_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        /// <summary>
        /// Make the window draggable
        /// </summary>
        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
