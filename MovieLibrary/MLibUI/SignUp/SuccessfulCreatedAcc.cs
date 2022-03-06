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
    }
}
