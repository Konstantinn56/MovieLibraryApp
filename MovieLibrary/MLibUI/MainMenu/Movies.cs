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
        /// It will align the text in the movie information
        /// </summary>
        private void LineUpTheText()
        {
            txtBoxMovie1.SelectAll();
            txtBoxMovie1.SelectionAlignment = HorizontalAlignment.Center;

            txtBoxMovie2.SelectAll();
            txtBoxMovie2.SelectionAlignment = HorizontalAlignment.Center;

            txtBoxMovie3.SelectAll();
            txtBoxMovie3.SelectionAlignment = HorizontalAlignment.Center;

            txtBoxMovie4.SelectAll();
            txtBoxMovie4.SelectionAlignment = HorizontalAlignment.Center;

            txtBoxMovie5.SelectAll();
            txtBoxMovie5.SelectionAlignment = HorizontalAlignment.Center;

            txtBoxMovie6.SelectAll();
            txtBoxMovie6.SelectionAlignment = HorizontalAlignment.Center;

            txtBoxMovie7.SelectAll();
            txtBoxMovie7.SelectionAlignment = HorizontalAlignment.Center;

            txtBoxMovie8.SelectAll();
            txtBoxMovie8.SelectionAlignment = HorizontalAlignment.Center;
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
                        FillOneMovieField(this.MoviesList[this.LastPrintedMovieIndex], picBox1, txtBoxMovie1);
                        addedMovie = true;
                    }
                    else if (currentPageMovies == 1)
                    {
                        FillOneMovieField(this.MoviesList[this.LastPrintedMovieIndex], picBox2, txtBoxMovie2);
                        addedMovie = true;
                    }
                    else if (currentPageMovies == 2)
                    {
                        FillOneMovieField(this.MoviesList[this.LastPrintedMovieIndex], picBox3, txtBoxMovie3);
                        addedMovie = true;
                    }
                    else if (currentPageMovies == 3)
                    {
                        FillOneMovieField(this.MoviesList[this.LastPrintedMovieIndex], picBox4, txtBoxMovie4);
                        addedMovie = true;
                    }
                    else if (currentPageMovies == 4)
                    {
                        FillOneMovieField(this.MoviesList[this.LastPrintedMovieIndex], picBox5, txtBoxMovie5);
                        addedMovie = true;
                    }
                    else if (currentPageMovies == 5)
                    {
                        FillOneMovieField(this.MoviesList[this.LastPrintedMovieIndex], picBox6, txtBoxMovie6);
                        addedMovie = true;
                    }
                    else if (currentPageMovies == 6)
                    {
                        FillOneMovieField(this.MoviesList[this.LastPrintedMovieIndex], picBox7, txtBoxMovie7);
                        addedMovie = true;
                    }
                    else if (currentPageMovies == 7)
                    {
                        FillOneMovieField(this.MoviesList[this.LastPrintedMovieIndex], picBox8, txtBoxMovie8);
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
        private void FillOneMovieField(Movie movie,PictureBox pictureBox, RichTextBox txtBox)
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
            txtBoxMovie1.Text = "";
            txtBoxMovie2.Text = "";
            txtBoxMovie3.Text = "";
            txtBoxMovie4.Text = "";
            txtBoxMovie5.Text = "";
            txtBoxMovie6.Text = "";
            txtBoxMovie7.Text = "";
            txtBoxMovie8.Text = "";
        }

        /// <summary>
        /// Reset all Fields and print the next 8 movies
        /// </summary>
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(this.LastPrintedMovieIndex != this.MoviesCount)
            {
                ResetAllFields();
                FillThePage();
            }
        }

        /// <summary>
        /// Reset the fields and opens the first movies
        /// </summary>
        private void btnPrev_Click(object sender, EventArgs e)
        {
            ResetAllFields();
            this.LastPrintedMovieIndex = 0;
            FillThePage();
            
        }
    }
}
