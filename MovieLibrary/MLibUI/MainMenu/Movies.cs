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
using Data.Model;

namespace MLibUI.MainMenu
{
    public partial class Movies : Form
    {
        /// <summary>
        /// Movie Business
        /// </summary>
        MovieBusiness movieBusiness = new MovieBusiness();

        /// <summary>
        /// AccountMovies business
        /// </summary>
        AccountMoviesBusiness accountMoviesBusiness = new AccountMoviesBusiness();

        /// <summary>
        /// Genre Business
        /// </summary>
        GenreBusiness genreBusiness = new GenreBusiness();

        //Fields
        private Account CurrentAccount { get; set; }
        private List<Movie> MoviesList { get; set; }
        private int MoviesCount { get; set; }
        private int LastPrintedMovieIndex { get; set; }
        private int currentPageMovies { get; set; }
        private Movie SelectedMovie { get; set; }

        //False - Edit / True - Lock
        private bool btnEditStatus { get; set; }

        public Movies()
        {
            InitializeComponent();
            this.SelectedMovie = new Movie();
        }

        /// <summary>
        /// Starting load
        /// </summary>
        private void Movies_Load(object sender, EventArgs e)
        {
            this.MoviesList = movieBusiness.GetAll();
            this.MoviesCount = this.MoviesList.Count;
            this.LastPrintedMovieIndex = 0;
            this.btnEditStatus = false;
            FillThePage();
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
            if(!txtBoxSearch.Text.Equals(""))
            {
                btnSearch.Enabled = true;
            }
            else
            {
                btnPrev_Click(sender,e);
                btnSearch.Enabled = false;
            }
        }

        /// <summary>
        /// Reset all Fields and print the next 8 movies
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(this.LastPrintedMovieIndex != this.MoviesCount)
            {
                ResetAllFields();
                ResetSelection();
                FillThePage();
            }
        }

        /// <summary>
        /// Reset the fields and opens the first movies
        /// </summary>
        private void btnPrev_Click(object sender, EventArgs e)
        {
            ResetAllFields();
            ResetSelection();
            this.LastPrintedMovieIndex = 0;
            FillThePage();
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
                    ResetAllFields();
                    FillOneMovieField(searchedMovie, picBox1, txtBoxTitle1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        /// <summary>
        /// Add the selected Movie to Favourite
        /// </summary>
        private void btnAddToFavourite_Click(object sender, EventArgs e)
        {
            if(this.SelectedMovie != null)
            {
                try
                {
                    accountMoviesBusiness.Add(this.CurrentAccount.AId, this.SelectedMovie.MId);
                    MessageBox.Show("Successfully added!");
                }
                catch (Exception)
                {
                    MessageBox.Show("This Movie was added already!");
                }
            }
        }

        /// <summary>
        /// Select the movie in the current field
        /// </summary>
        private void picBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsTheFieldEmpty(picBox1))
            {
                ResetSelection();
                picBox1.BorderStyle = BorderStyle.Fixed3D;

                //Get the selected movie
                this.SelectedMovie = movieBusiness.GetByTitle(txtBoxTitle1.Text);
                btnAddToFavourite.Enabled = true;
                btnUpdate.Enabled = true;
                FillMovieInfo(this.SelectedMovie);
            }
        }

        /// <summary>
        /// Select the movie in the current field
        /// </summary>
        private void picBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsTheFieldEmpty(picBox2))
            {
                ResetSelection();
                picBox2.BorderStyle = BorderStyle.Fixed3D;

                //Get the selected movie
                this.SelectedMovie = movieBusiness.GetByTitle(txtBoxTitle2.Text);
                btnAddToFavourite.Enabled = true;
                btnUpdate.Enabled = true;
                FillMovieInfo(this.SelectedMovie);
            }
        }

        /// <summary>
        /// Select the movie in the current field
        /// </summary>
        private void picBox3_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsTheFieldEmpty(picBox3))
            {
                ResetSelection();
                picBox3.BorderStyle = BorderStyle.Fixed3D;

                //Get the selected movie
                this.SelectedMovie = movieBusiness.GetByTitle(txtBoxTitle3.Text);
                btnAddToFavourite.Enabled = true;
                btnUpdate.Enabled = true;
                FillMovieInfo(this.SelectedMovie);
            }
        }

        /// <summary>
        /// Select the movie in the current field
        /// </summary>
        private void picBox4_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsTheFieldEmpty(picBox1))
            {
                ResetSelection();
                picBox4.BorderStyle = BorderStyle.Fixed3D;

                //Get the selected movie
                this.SelectedMovie = movieBusiness.GetByTitle(txtBoxTitle4.Text);
                btnAddToFavourite.Enabled = true;
                btnUpdate.Enabled = true;
                FillMovieInfo(this.SelectedMovie);
            }
        }

        /// <summary>
        /// Select the movie in the current field
        /// </summary>
        private void picBox5_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsTheFieldEmpty(picBox5))
            {
                ResetSelection();
                picBox5.BorderStyle = BorderStyle.Fixed3D;

                //Get the selected movie
                this.SelectedMovie = movieBusiness.GetByTitle(txtBoxTitle5.Text);
                btnAddToFavourite.Enabled = true;
                btnUpdate.Enabled = true;
                FillMovieInfo(this.SelectedMovie);
            }
        }

        /// <summary>
        /// Select the movie in the current field
        /// </summary>
        private void picBox6_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsTheFieldEmpty(picBox6))
            {
                ResetSelection();
                picBox6.BorderStyle = BorderStyle.Fixed3D;

                //Get the selected movie
                this.SelectedMovie = movieBusiness.GetByTitle(txtBoxTitle6.Text);
                btnAddToFavourite.Enabled = true;
                btnUpdate.Enabled = true;
                FillMovieInfo(this.SelectedMovie);
            }
        }

        /// <summary>
        /// Select the movie in the current field
        /// </summary>
        private void picBox7_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsTheFieldEmpty(picBox7))
            {
                ResetSelection();
                picBox7.BorderStyle = BorderStyle.Fixed3D;

                //Get the selected movie
                this.SelectedMovie = movieBusiness.GetByTitle(txtBoxTitle7.Text);
                btnAddToFavourite.Enabled = true;
                btnUpdate.Enabled = true;
                FillMovieInfo(this.SelectedMovie);
            }
        }

        /// <summary>
        /// Select the movie in the current field
        /// </summary>
        private void picBox8_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsTheFieldEmpty(picBox8))
            {
                ResetSelection();
                picBox8.BorderStyle = BorderStyle.Fixed3D;

                //Get the selected movie
                this.SelectedMovie = movieBusiness.GetByTitle(txtBoxTitle8.Text);
                btnAddToFavourite.Enabled = true;
                btnUpdate.Enabled = true;
                FillMovieInfo(this.SelectedMovie);
            }

        }

        /// <summary>
        /// Set the information from the marked movie to the txtBoxMovieInfo 
        /// </summary>
        private void FillMovieInfo(Movie movie)
        {
            btnReset.Enabled = true;
            //txt boxes
            txtBoxTitle.Text = movie.Title;
            comboBoxGenre.Text = movie.Genre;
            txtBoxYear.Text = movie.YaerOfCreation.ToString();
            txtBoxRate.Text = movie.Rate.ToString();

            //image
            byte[] image = movie.Image;
            var imageMemoryStream = new MemoryStream(image);
            Image imgFromStream = Image.FromStream(imageMemoryStream);
            picBoxMovieInfo.Image = imgFromStream;

        }

        /// <summary>
        /// Sets the txtBoxMovieInfo to default values
        /// </summary>
        private void ResetMovieInfoTextBox()
        {
            txtBoxTitle.Text = "";
            comboBoxGenre.Text = "";
            txtBoxYear.Text = "";
            txtBoxRate.Text = "";
            picBoxMovieInfo.Image = null;
            btnReset.Enabled = false;

        }

        /// <summary>
        /// Reset the current selection
        /// </summary>
        private void ResetSelection()
        {
            picBox1.BorderStyle = BorderStyle.None;
            picBox2.BorderStyle = BorderStyle.None;
            picBox3.BorderStyle = BorderStyle.None;
            picBox4.BorderStyle = BorderStyle.None;
            picBox5.BorderStyle = BorderStyle.None;
            picBox6.BorderStyle = BorderStyle.None;
            picBox7.BorderStyle = BorderStyle.None;
            picBox8.BorderStyle = BorderStyle.None;
            this.SelectedMovie = new Movie();
            btnAddToFavourite.Enabled = false;
            btnUpdate.Enabled = false;
        }

        /// <summary>
        /// Fill all the fields with movies from database
        /// </summary>
        private void FillThePage()
        {
            bool addedMovie = false;
            this.currentPageMovies = 0;
            while (currentPageMovies != 8)
            {
                if (this.LastPrintedMovieIndex == this.MoviesCount)
                {
                    btnNext.Enabled = false;
                    break;
                }
                else
                {
                    if (currentPageMovies == 0)
                    {
                        FillOneMovieField(this.MoviesList[this.LastPrintedMovieIndex], picBox1, txtBoxTitle1);
                        addedMovie = true;
                    }
                    else if (currentPageMovies == 1)
                    {
                        FillOneMovieField(this.MoviesList[this.LastPrintedMovieIndex], picBox2, txtBoxTitle2);
                        addedMovie = true;
                    }
                    else if (currentPageMovies == 2)
                    {
                        FillOneMovieField(this.MoviesList[this.LastPrintedMovieIndex], picBox3, txtBoxTitle3);
                        addedMovie = true;
                    }
                    else if (currentPageMovies == 3)
                    {
                        FillOneMovieField(this.MoviesList[this.LastPrintedMovieIndex], picBox4, txtBoxTitle4);
                        addedMovie = true;
                    }
                    else if (currentPageMovies == 4)
                    {
                        FillOneMovieField(this.MoviesList[this.LastPrintedMovieIndex], picBox5, txtBoxTitle5);
                        addedMovie = true;
                    }
                    else if (currentPageMovies == 5)
                    {
                        FillOneMovieField(this.MoviesList[this.LastPrintedMovieIndex], picBox6, txtBoxTitle6);
                        addedMovie = true;
                    }
                    else if (currentPageMovies == 6)
                    {
                        FillOneMovieField(this.MoviesList[this.LastPrintedMovieIndex], picBox7, txtBoxTitle7);
                        addedMovie = true;
                    }
                    else if (currentPageMovies == 7)
                    {
                        FillOneMovieField(this.MoviesList[this.LastPrintedMovieIndex], picBox8, txtBoxTitle8);
                        addedMovie = true;

                    }
                }
                if (addedMovie)
                {
                    this.LastPrintedMovieIndex++;
                    currentPageMovies++;
                    addedMovie = false;
                }
            }
            //enable button next if the page is full
            if (this.currentPageMovies == 8)
            {
                btnNext.Enabled = true;
                btnPrev.Enabled = true;
            }
        }

        /// <summary>
        /// Reset all fields in the current window
        /// </summary>
        private void ResetAllFields()
        {
            picBox1.Image = null;
            picBox2.Image = null;
            picBox3.Image = null;
            picBox4.Image = null;
            picBox5.Image = null;
            picBox6.Image = null;
            picBox7.Image = null;
            picBox8.Image = null;
            txtBoxTitle1.Text = "";
            txtBoxTitle2.Text = "";
            txtBoxTitle3.Text = "";
            txtBoxTitle4.Text = "";
            txtBoxTitle5.Text = "";
            txtBoxTitle6.Text = "";
            txtBoxTitle7.Text = "";
            txtBoxTitle8.Text = "";
        }

        /// <summary>
        /// Fill one movie Field
        /// </summary>
        private void FillOneMovieField(Movie movie, PictureBox pictureBox, TextBox txtBox)
        {
            MemoryStream ms = new MemoryStream(movie.Image);
            pictureBox.Image = Image.FromStream(ms);
            txtBox.Text = movie.Title;
        }

        /// <summary>
        /// Check if the movie field is empty
        /// </summary>
        private bool IsTheFieldEmpty(PictureBox picBox)
        {
            if(picBox.Image == null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Set the current account
        /// </summary>
        public void SetCurrentAccount(Account account)
        {
            this.CurrentAccount = account;
        }

        /// <summary>
        /// Open updatePage and sets the value of the selected movie to the property
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string exceptions = IsThereExceptionsInTheMovieInfoPanel();

            if (exceptions == "")
            {
                Movie updatedMovie = this.SelectedMovie;
                
                if (!DoesTheMovieAlreadyExists(txtBoxTitle.Text))
                {
                    //Movie Image
                    MemoryStream stream = new MemoryStream();
                    picBoxMovieInfo.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();

                    updatedMovie.Title = txtBoxTitle.Text;
                    updatedMovie.YaerOfCreation = int.Parse(txtBoxYear.Text);
                    updatedMovie.Rate = double.Parse(txtBoxRate.Text);
                    updatedMovie.Image = pic;

                    movieBusiness.Update(updatedMovie);

                    ResetMovieInfoTextBox();
                    ResetSelection();
                    FillThePage();
                }
                else
                {
                    MessageBox.Show("Movie with this Title already exist!");
                }
                
            }
            else
            {
                MessageBox.Show(exceptions);
            }
        }

        /// <summary>
        /// Enables and Disables fields to allow movie update
        /// </summary>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //if its false(Edit)
            if(!this.btnEditStatus)
            {
                btnEdit.Text = "Lock";
                this.btnEditStatus = true;

                //Enable fields
                btnBrowse.Enabled = true;
                txtBoxTitle.ReadOnly = false;
                comboBoxGenre.Enabled = true;
                txtBoxYear.ReadOnly = false;
                txtBoxRate.ReadOnly = false;

                //ComboBoxGenreInfo

            }
            //If its true(Lock)
            else
            {
                this.btnEditStatus = false;
                btnEdit.Text = "Edit";

                //Disable fields
                btnBrowse.Enabled = false;
                txtBoxTitle.ReadOnly = true;
                comboBoxGenre.Enabled = false;
                txtBoxYear.ReadOnly = true;
                txtBoxRate.ReadOnly = true;
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image File(*.jpg; *.jpeg; *.bmp;) | *.jpg; *.jpeg; *.bmp";
            if (ofd.ShowDialog(this) == DialogResult.OK)
            {
                try
                {
                    if ((myStream = ofd.OpenFile()) != null)
                    {
                        string FileName = ofd.FileName;
                        if (myStream.Length > 512000)
                        {
                            MessageBox.Show("File Size limit exceeded");
                        }
                        else
                        {
                            picBoxMovieInfo.Load(FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summary>
        /// Resets the movie info field
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            FillMovieInfo(this.SelectedMovie);
        }

        /// <summary>
        /// Open new window to create new Genre
        /// </summary>
        private void comboBoxGenre_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxGenre.Text.Equals("Add New Genre"))
            {
                AddNewGenre ang = new AddNewGenre();
                ang.Show();
            }
        }

        /// <summary>
        /// Link Combobox with Database Genres values
        /// </summary>
        private void comboBoxGenre_MouseClick(object sender, MouseEventArgs e)
        {
            List<Genre> allGenres = genreBusiness.GetAllGenres();
            comboBoxGenre.Items.Clear();
            foreach (Genre genre in allGenres)
            {
                comboBoxGenre.Items.Add(genre.Name);
            }
        }

        private string IsThereExceptionsInTheMovieInfoPanel()
        {
            string exception = "";

            int year;
            int currentYear = DateTime.Now.Year;
            if (!int.TryParse(txtBoxYear.Text, out year) && int.Parse(txtBoxYear.Text) !<= currentYear)
            {
                return "Invalid Information!";
            }
            double rate;
            if (!double.TryParse(txtBoxRate.Text, out rate))
            {
                return "Invalid Information!";
            }
            if (rate < 0 && rate > 10)
            {
                return "Invalid Information!";
            }
            if(picBoxMovieInfo.Image == null || txtBoxTitle.Text.Equals("") || txtBoxYear.Text.Equals("") || txtBoxRate.Equals(""))
            {
                return "The Fields must not be empty";
            }
            return exception;
        }

        /// <summary>
        /// Check If the movie with this Title exists in the DataBase
        /// </summary>
        /// <returns>True/False</returns>
        private bool DoesTheMovieAlreadyExists(string title)
        {
            try
            {
                Movie movie = movieBusiness.GetByTitle(title);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
