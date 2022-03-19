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

namespace MLibUI.PassRecovery
{
    public partial class ForgottenPassPage : Form
    {
        public ForgottenPassPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close current window and opens Login page
        /// </summary>
        private void lblBack_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
            this.Hide();
        }

        /// <summary>
        /// Close the application
        /// </summary>
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Close current window and opens Step1 of Password reseting
        /// </summary>
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            PassRecoveryStep1 prs1 = new PassRecoveryStep1();
            prs1.Show();
            this.Hide();
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
        private void ForgottenPassPage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
