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
            SqlConnection conn = DataBase.GetConnection();

            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter($"SELECT * FROM Movies WHERE id_movie IN(SELECT movie_id FROM AccountsMovies WHERE account_id = {this.CurrentAccount.AId})", conn);
            conn.Close();

            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataTable dt = new DataTable();
            da.Fill(dt);
            
            MyListDGV.DataSource = dt;
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
