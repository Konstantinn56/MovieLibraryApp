using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;

namespace MLibUI.MainMenu
{
    public partial class Movies : Form
    {
        public Movies()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Movie Business
        /// </summary>
        MovieBusiness movieBusiness = new MovieBusiness();

        /// <summary>
        /// It will use the FillDataGridView method
        /// </summary>
        private void Movies_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// It will fill the dataGridView with the info from DB
        /// </summary>
        private void FiLLDataGridView()
        {
        }
    }
}
