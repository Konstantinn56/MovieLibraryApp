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

namespace MLibUI.PassRecovery
{
    public partial class PassRecoveryStep1 : Form
    {
        public PassRecoveryStep1()
        {
            InitializeComponent();
        }
        AccountBusiness accountBusiness = new AccountBusiness();

        /// <summary>
        /// Clears the text box and lblException and change the ForeColor of the textBox and the color of the underline
        /// </summary>
        private void txtBoxUsr_Enter(object sender, EventArgs e)
        {
            if (txtBoxUsr.Text.Equals("Username"))
            {
                txtBoxUsr.Clear();
            }
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
        /// Clears the text box and change the ForeColor of the textBox and the color of the underline
        /// </summary>
        private void txtBoxResetKey_Enter(object sender, EventArgs e)
        {
            if (txtBoxResetKey.Text.Equals("Recovery Key"))
            {
                txtBoxResetKey.Clear();
            }
            panelResetKey.BackColor = Color.Goldenrod;
            txtBoxResetKey.ForeColor = Color.Black;
        }

        /// <summary>
        /// It will change the color of the underline, and if there is no text, it will set the watermark
        /// </summary>
        private void txtBoxResetKey_Leave(object sender, EventArgs e)
        {
            if (txtBoxResetKey.Text.Equals(""))
            {
                txtBoxResetKey.Text = "Recovery Key";
                txtBoxResetKey.ForeColor = Color.DimGray;
            }
            panelResetKey.BackColor = Color.Black;
        }

        /// <summary>
        /// Exit the application
        /// </summary>
        private void lblExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// If there are no exepsions, close current page and opens step2
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            
            if (!txtBoxUsr.Text.Equals("") || !txtBoxResetKey.Text.Equals(""))
            {
                Account currentAccount = accountBusiness.Get(txtBoxUsr.Text);
                if (currentAccount == null || !currentAccount.RecoveryKey.ToString().Equals(txtBoxResetKey.Text))
                {
                    MessageBox.Show("Incorrect Username or Recovery Key.");
                }
                else
                {
                    PassRecoveryStep2 prs2 = new PassRecoveryStep2();
                    prs2.Show();
                    prs2.currentAccount = currentAccount;
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("The Fields must not be empty!");
            }
        }
    }
}
