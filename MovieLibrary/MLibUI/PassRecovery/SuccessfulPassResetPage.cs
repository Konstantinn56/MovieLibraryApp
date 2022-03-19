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
    public partial class SuccessfulPassResetPage : Form
    {
        public SuccessfulPassResetPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close this window, and opens new Login page
        /// </summary>
        private void btnDone_Click_1(object sender, EventArgs e)
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
        private void SuccessfulPassResetPage_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
