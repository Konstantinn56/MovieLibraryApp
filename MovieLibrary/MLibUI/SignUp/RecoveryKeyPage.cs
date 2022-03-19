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
    public partial class RecoveryKeyPage : Form
    {
        public RecoveryKeyPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Timer seconds
        /// </summary>
        private int seconds = 0;

        /// <summary>
        /// Recovery key of the created Account
        /// </summary>
        public int currentAccountRecoveryKey { get; set; }

        /// <summary>
        /// Set the lblRecoveryKey to currentAccountRecoveryKey
        /// </summary>
        private void RecoveryKeyPage_Load(object sender, EventArgs e)
        {
            txtBoxRecoveryKey.Text = currentAccountRecoveryKey.ToString();
            seconds = 10;
            countdownTimer.Start();
        }

        /// <summary>
        /// Close current Window and opens Successful Created Acc Window
        /// </summary>
        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (btnContinue.Text.Equals("Continue"))
            {
                SuccessfulCreatedAcc sca = new SuccessfulCreatedAcc();
                sca.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Display the seconds on the buttonContinue
        /// </summary>
        private void countdownTimer_Tick(object sender, EventArgs e)
        {
            btnContinue.Text = seconds--.ToString();
            if(seconds < 0)
            {
                countdownTimer.Stop();
                btnContinue.Cursor = Cursors.Hand;
                btnContinue.Text = "Continue";
            }
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

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
