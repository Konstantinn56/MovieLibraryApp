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

        //Fields
        private List<Movie> MoviesList { get; set; }
        private int MoviesCount { get; set; }
        private int LastPrintedMovieIndex { get; set; }
        private int currentPageMovies { get; set; }
        private Movie SelectedMovie { get; set; }

        public Movies()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Starting load
        /// </summary>
        private void Movies_Load(object sender, EventArgs e)
        {
            this.MoviesList = movieBusiness.GetAll();
            this.MoviesCount = this.MoviesList.Count;
            this.LastPrintedMovieIndex = 0;
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
        /// Fill all the fields with movies from database
        /// </summary>
        private void FillThePage()
        {
            bool addedMovie = false;
            this.currentPageMovies = 0;
            while (currentPageMovies != 8)
            {
                if(this.LastPrintedMovieIndex == this.MoviesCount)
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
        /// Fill one movie Field
        /// </summary>
        private void FillOneMovieField(Movie movie,PictureBox pictureBox, TextBox txtBox)
        {
            MemoryStream ms = new MemoryStream(movie.Image);
            pictureBox.Image = Image.FromStream(ms);
            txtBox.Text = movie.Title;
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
            }
        }

        /// <summary>
        /// Search for movie by Title
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!txtBoxSearch.Text.Equals("Search"))
            {
                Movie searchedMovie = movieBusiness.GetByTitle(txtBoxSearch.Text.ToLower());
            }
        }
    }
}
