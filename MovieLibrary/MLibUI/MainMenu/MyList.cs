using Business;
using Data;
using Data.Model;
using System.Data;
using System.Data.SqlClient;

namespace MLibUI.MainMenu
{
    public partial class MyList : Form
    {
        /// <summary>
        /// Account Business
        /// </summary>
        AccountBusiness accountBusiness = new AccountBusiness();

        /// <summary>
        /// Movie business
        /// </summary>
        MovieBusiness movieBusiness = new MovieBusiness();

        //Fields
        private Account CurrentAccount { get; set; }

        public MyList()
        {
            InitializeComponent();
            this.CurrentAccount = new Account();
        }

        private void MyList_Load(object sender, EventArgs e)
        {
            FillDataGridView();
        }

        /// <summary>
        /// It will set all values from database to the DGV
        /// </summary>
        private void FillDataGridView()
        {
            
        }
        /// <summary>
        /// Set the logged account into currentAccount
        /// </summary>
        public void SetCurrentAccount(Account account)
        {
            this.CurrentAccount = account;
        }
    }
}
