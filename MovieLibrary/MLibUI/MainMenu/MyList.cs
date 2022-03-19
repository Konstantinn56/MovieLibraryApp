using Business;
using Data;
using Data.Model;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

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

        /// <summary>
        /// AccountMoviesBusiness
        /// </summary>
        AccountMoviesBusiness accountMoviesBusiness = new AccountMoviesBusiness();

        //Fields
        private Account CurrentAccount { get; set; }
        private Movie SelectedMovie { get; set; }

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
            SqlConnection con = DataBase.GetConnection();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT image,title,genre,year,rate FROM Movies WHERE id_movie IN(SELECT movie_id FROM AccountsMovies WHERE account_id = {this.CurrentAccount.AId})", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            MyListDGV.DataSource = dt;
            con.Close();
        }

        /// <summary>
        /// It will set the values of the movie from database to the DGV
        /// </summary>
        private void FillDataGirdViewWithSearchedMovie(Movie movie)
        {
            SqlConnection con = DataBase.GetConnection();
            con.Open();
            SqlDataAdapter adapter = new SqlDataAdapter($"SELECT image,title,genre,year,rate FROM Movies WHERE id_movie = {movie.MId}", con);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            MyListDGV.DataSource = dt;
            con.Close();
        }
        /// <summary>
        /// Set the logged account into currentAccount
        /// </summary>
        public void SetCurrentAccount(Account account)
        {
            this.CurrentAccount = account;
        }

        /// <summary>
        /// Set the selectedMovie property to current DGV Selection
        /// </summary>
        private void MyListDGV_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            btnRemove.Enabled = true;
            MyListDGV.CurrentRow.Selected = true;
            string selectionMovieTitle = MyListDGV.Rows[e.RowIndex].Cells["title"].Value.ToString();
            this.SelectedMovie = movieBusiness.GetByTitle(selectionMovieTitle);
        }

        /// <summary>
        /// Disables the button remove
        /// </summary>
        private void MyListDGV_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectedMovie = new Movie();
            btnRemove.Enabled = false;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                accountMoviesBusiness.Delete(this.CurrentAccount.AId, this.SelectedMovie.MId);
                MessageBox.Show("Movie has been removed successfully!");
                FillDataGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("Please slelect a movie!");
            } 
        }

        /// <summary>
        /// Clears the text box and lblException and change the ForeColor of the textBox and the color of the underline
        /// </summary>
        private void txtBoxSearch_Enter(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text.Equals("Search"))
            {
                txtBoxSearch.Clear();
            }
            panelSearch.BackColor = Color.Goldenrod;
            txtBoxSearch.ForeColor = Color.Black;
        }

        /// <summary>
        /// It will change the color of the underline, and if there is no text, it will set the watermark
        /// </summary>
        private void txtBoxSearch_Leave(object sender, EventArgs e)
        {
            if (txtBoxSearch.Text.Equals(""))
            {
                txtBoxSearch.Text = "Search";
                txtBoxSearch.ForeColor = Color.DimGray;
            }
            panelSearch.BackColor = Color.Black;
        }

        /// <summary>
        /// Enables and Disables button
        /// </summary>
        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (!txtBoxSearch.Text.Equals(""))
            {
                btnSearch.Enabled = true;
            }
            else
            {
                FillDataGridView();
                btnSearch.Enabled = false;
            }
        }

        /// <summary>
        /// Search for movie by Title
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //If there is movie that is called "Search"... idk
            if (!txtBoxSearch.Text.Equals("Search"))
            {
                try
                {
                    Movie searchedMovie = movieBusiness.GetByTitle(txtBoxSearch.Text.ToLower());
                    FillDataGirdViewWithSearchedMovie(searchedMovie);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
       
    }
}
