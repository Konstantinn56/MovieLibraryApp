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
        /// Recovery key of the created Account
        /// </summary>
        public int currentAccountRecoveryKey { get; set; }

        /// <summary>
        /// Set the lblRecoveryKey to currentAccountRecoveryKey
        /// </summary>
        private void RecoveryKeyPage_Load(object sender, EventArgs e)
        {
            lblRecoveryKey.Text = currentAccountRecoveryKey.ToString();
        }
    }
}
