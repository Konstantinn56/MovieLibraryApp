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
    }
}
