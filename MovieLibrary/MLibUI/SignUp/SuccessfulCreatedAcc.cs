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

namespace MLibUI.SignUp
{
    public partial class SuccessfulCreatedAcc : Form
    {
        public SuccessfulCreatedAcc()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close current widnows, and opens new Login page
        /// </summary>
        private void btnGetStarted_Click(object sender, EventArgs e)
        {
            LoginPage lp = new LoginPage();
            lp.Show();
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
        private void SuccessfulCreatedAcc_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
