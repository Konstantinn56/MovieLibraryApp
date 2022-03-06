using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                btnContinue.Text = "Continue";
            }
        }
    }
}
