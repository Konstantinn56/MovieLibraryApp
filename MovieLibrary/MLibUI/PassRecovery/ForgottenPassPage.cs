using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
    }
}
