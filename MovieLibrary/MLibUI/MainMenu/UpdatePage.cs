using Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MLibUI.MainMenu
{
    public partial class UpdatePage : Form
    {
        public UpdatePage()
        {
            InitializeComponent();
            FillTheFields();
        }

        //Fields
        private Movie CurrentMovie { get; set; }


        /// <summary>
        /// Sets the value of the current account
        /// </summary>
        public void SetCurrentMovie(Movie movie)
        {
            this.CurrentMovie = movie;
        }

        /// <summary>
        /// It will fill all the fields with the current information for the selectedm movie
        /// </summary>
        private void FillTheFields()
        {
            txtBoxTitle.ForeColor = Color.Black;
            txtBoxTitle.Text = this.CurrentMovie.Title;
            txtBoxYear.ForeColor = Color.Black;
            txtBoxYear.Text = this.CurrentMovie.YaerOfCreation.ToString();
            txtBoxRate.ForeColor = Color.Black;
            txtBoxRate.Text = this.CurrentMovie.Rate.ToString();
            comboBoxGenre.Text = this.CurrentMovie.Genre;

            //Image converting
            byte[] image = this.CurrentMovie.Image;
            var imageMemoryStream = new MemoryStream(image);
            Image imgFromStream = Image.FromStream(imageMemoryStream);

            pictureBoxImage.Image = imgFromStream;
        }
    }
}
