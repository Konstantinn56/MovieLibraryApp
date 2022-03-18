using System.IO;
using System.Data.SqlClient;
using Business;
using Data.Model;

namespace MLibUI.MainMenu
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Movie Business
        /// </summary>
        MovieBusiness movieBusiness = new MovieBusiness();

        /// <summary>
        /// Genre Business
        /// </summary>
        GenreBusiness genreBusiness = new GenreBusiness();

        private void btnBrowse_Click_1(object sender, EventArgs e)
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
                            pictureBoxImage.Load(FileName);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (txtBoxTitle.Text.Equals("Title") || txtBoxYear.Equals("Year") || txtBoxRate.Equals("Rate") || comboBoxGenre.Text.Equals("") || pictureBoxImage.Image == null)
            {
                MessageBox.Show("The Fields must not be empty!");
            }
            else
            {
                if (lblTitleException.Text.Equals("") && lblYearExepction.Text.Equals("") && lblRateException.Text.Equals(""))
                {
                    //Save image
                    MemoryStream stream = new MemoryStream();
                    pictureBoxImage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] pic = stream.ToArray();

                    //Genres
                    string genre2 = "";
                    string genre3 = "";
                    if(comboBoxGenre2.Text != "")
                    {
                        genre2 = comboBoxGenre2.Text;
                    }
                    if(comboBoxGenre3.Text != "")
                    {
                        genre3 = comboBoxGenre3.Text;
                    }

                    //Adding movie into database
                    Movie currentMovie = new Movie() { Title = txtBoxTitle.Text, Genre = comboBoxGenre.Text , Genre2 = genre2, Genre3 =genre3, Image = pic, YaerOfCreation = int.Parse(txtBoxYear.Text), Rate = double.Parse(txtBoxRate.Text) };
                    movieBusiness.Add(currentMovie);

                    SuccessfulAddedMovie successfulAddedMovie = new SuccessfulAddedMovie();
                    successfulAddedMovie.Show();

                    //Reset the fields
                    ResetFields();
                }
            }
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

        /// <summary>
        /// Clears the text box and lblException and change the ForeColor of the textBox and the color of the underline
        /// </summary>
        private void txtBoxTitle_Enter(object sender, EventArgs e)
        {
            if (txtBoxTitle.Text.Equals("Title"))
            {
                txtBoxTitle.Clear();
            }
            panelTitle.BackColor = Color.Goldenrod;
            txtBoxTitle.ForeColor = Color.Black;
        }

        /// <summary>
        /// It will change the color of the underline, and if there is no text, it will set the watermark
        /// </summary>
        private void txtBoxTitle_Leave(object sender, EventArgs e)
        {
            if (txtBoxTitle.Text.Equals(""))
            {
                txtBoxTitle.Text = "Title";
                txtBoxTitle.ForeColor = Color.DarkRed;
                panelTitle.BackColor = Color.Black;
            }
            else
            {
                if (lblTitleException.Text.Equals(""))
                {
                    panelTitle.BackColor = Color.Green;
                }
            }
        }

        /// <summary>
        /// Check if the movie already exists
        /// </summary>
        private void txtBoxTitle_TextChanged(object sender, EventArgs e)
        {
            if (DoesTheMovieAlreadyExists(txtBoxTitle.Text))
            {
                lblTitleException.Text = "*Already exists*";
                panelTitle.BackColor = Color.Red;
            }
            else
            {
                lblTitleException.Text = "";
                panelTitle.BackColor = Color.Green;
            }
        }

        /// <summary>
        /// Clears the text box and lblException and change the ForeColor of the textBox and the color of the underline
        /// </summary>
        private void txtBoxYear_Enter(object sender, EventArgs e)
        {
            if (txtBoxYear.Text.Equals("Year"))
            {
                txtBoxYear.Clear();
            }
            panelYear.BackColor = Color.Goldenrod;
            txtBoxYear.ForeColor = Color.Black;
        }

        /// <summary>
        /// It will change the color of the underline, and if there is no text, it will set the watermark
        /// </summary>
        private void txtBoxYear_Leave(object sender, EventArgs e)
        {
            //Test if the information is number or text
            if (txtBoxYear.Text.Equals(""))
            {
                txtBoxYear.Text = "Year";
                txtBoxYear.ForeColor = Color.DarkRed;
                panelYear.BackColor = Color.Black;
            }
            else
            {
                int year;
                int currentYear = DateTime.Now.Year;
                if (int.TryParse(txtBoxYear.Text, out year) && int.Parse(txtBoxYear.Text) <= currentYear)
                {
                    panelYear.BackColor = Color.Green;
                    lblYearExepction.Text = "";
                }
                else
                {
                    panelYear.BackColor = Color.Red;
                    lblYearExepction.Text = "*Invalid Information*";
                }
            }
        }

        /// <summary>
        /// Clears the text box and lblException and change the ForeColor of the textBox and the color of the underline
        /// </summary>
        private void txtBoxRate_Enter(object sender, EventArgs e)
        {
            if (txtBoxRate.Text.Equals("Rate [1-10]"))
            {
                txtBoxRate.Clear();
            }
            panelRate.BackColor = Color.Goldenrod;
            txtBoxRate.ForeColor = Color.Black;
        }

        /// <summary>
        /// It will change the color of the underline, and if there is no text, it will set the watermark
        /// </summary>
        private void txtBoxRate_Leave(object sender, EventArgs e)
        {
            if (txtBoxRate.Text.Equals(""))
            {
                txtBoxRate.Text = "Rate [1-10]";
                txtBoxRate.ForeColor = Color.DarkRed;
                panelRate.BackColor = Color.Black;
            }
            else
            {
                double rate;
                if (double.TryParse(txtBoxRate.Text, out rate))
                {
                    rate = double.Parse(txtBoxRate.Text);
                    if (rate >= 0 && rate <= 10)
                    {
                        panelRate.BackColor = Color.Green;
                        lblRateException.Text = "";
                    }
                    else
                    {
                        panelRate.BackColor = Color.Red;
                        lblRateException.Text = "*The Number must be in range [1-10]*";
                    }
                }
                else
                {
                    panelRate.BackColor = Color.Red;
                    lblRateException.Text = "*Invalid Information*";
                }
                
            }
        }

        /// <summary>
        /// Opens window to create new Genre
        /// </summary>
        private void comboBoxGenre_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxGenre.Text.Equals("Add New Genre"))
            {
                AddNewGenre ang = new AddNewGenre();
                FillGenresComboBoxes(comboBoxGenre);
                lblAddGenre2.Visible = false;
                ang.Show();
            }
            else
            {
                lblAddGenre2.Visible = true;
            }
        }

        /// <summary>
        /// Opens window to create new Genre
        /// </summary>
        private void comboBoxGenre2_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxGenre2.Text.Equals("Add New Genre"))
            {
                AddNewGenre ang = new AddNewGenre();
                FillGenresComboBoxes(comboBoxGenre2);
                lblAddGenre2.Visible = false;
                ang.Show();
            }
            else
            {
                lblAddGenre3.Visible = true;
            }
        }

        private void comboBoxGenre3_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxGenre3.Text.Equals("Add New Genre"))
            {
                AddNewGenre ang = new AddNewGenre();
                FillGenresComboBoxes(comboBoxGenre3);
                ang.Show();
            }
        }

        /// <summary>
        /// Reset all fields
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetFields();
        }

        /// <summary>
        /// This will reset all fields
        /// </summary>
        public void ResetFields()
        {
            txtBoxYear.Text = "Year";
            txtBoxYear.ForeColor = Color.DarkRed;
            panelYear.BackColor = Color.Black;
            lblYearExepction.Text = "";

            txtBoxTitle.Text = "Title";
            txtBoxTitle.ForeColor = Color.DarkRed;
            panelTitle.BackColor = Color.Black;
            lblTitleException.Text = "";

            txtBoxRate.Text = "Rate [1-10]";
            txtBoxRate.ForeColor = Color.DarkRed;
            panelRate.BackColor = Color.Black;
            lblRateException.Text = "";

            comboBoxGenre.Text = null;
            comboBoxGenre2.Text = null;
            comboBoxGenre3.Text = null;

            pictureBoxImage.Image = null;

            //ComboBoxGenre1
            comboBoxGenre.Enabled = true;
            lblAddGenre2.Visible = true;

            //ComboBoxGenre2
            comboBoxGenre2.Text = null;
            comboBoxGenre2.Visible = false;
            comboBoxGenre2.Enabled = false;
            lblGenre2.Visible = false;
            lblCloseGenre2.Visible = false;
            lblAddGenre3.Visible = false;

            //ComboBoxGenre3
            comboBoxGenre3.Text = null;
            comboBoxGenre3.Visible = false;
            comboBoxGenre3.Enabled = false;
            lblGenre3.Visible = false;
            lblCloseGenre3.Visible = false;

        }
        /// <summary>
        /// Link Combobox with Database Genres values
        /// </summary>
        private void comboBoxGenre_MouseClick(object sender, MouseEventArgs e)
        {
            FillGenresComboBoxes(comboBoxGenre);
        }

        /// <summary>
        /// Link Combobox with Database Genres values
        /// </summary>
        private void FillGenresComboBoxes(ComboBox combobox)
        {
            List<Genre> allGenres = genreBusiness.GetAllGenres();
            combobox.Items.Clear();
            foreach (Genre genre in allGenres)
            {
                combobox.Items.Add(genre.Name);
            }
        }

        /// <summary>
        /// Add new Genre field
        /// </summary>
        private void lblAddGenre2_Click(object sender, EventArgs e)
        {
            if(comboBoxGenre.Text != "")
            {
                //ComboBoxGenre1
                comboBoxGenre.Enabled = false;
                lblAddGenre2.Visible = false;
                lblCloseGenre2.Visible = false;

                //ComboBoxGenre2
                comboBoxGenre2.Visible = true;
                comboBoxGenre2.Enabled = true;
                lblGenre2.Visible = true;
                lblCloseGenre2.Visible = true;

                
            }
        }

        /// <summary>
        /// Add new Genre field
        /// </summary>
        private void lblAddGenre3_Click(object sender, EventArgs e)
        {
            if (comboBoxGenre2.Text != "")
            {
                if (!comboBoxGenre2.Text.Equals(comboBoxGenre.Text))
                {
                    //ComboBoxGenre2
                    comboBoxGenre2.Enabled = false;
                    lblAddGenre3.Visible = false;
                    lblCloseGenre2.Visible = false;

                    //ComboBoxGenre3
                    comboBoxGenre3.Visible = true;
                    comboBoxGenre3.Enabled = true;
                    lblGenre3.Visible = true;
                    lblCloseGenre3.Visible = true;
                }
                else
                {
                    MessageBox.Show("The Genres must not be same!");
                    comboBoxGenre2.Text = null;
                    lblCloseGenre3_Click(sender, e);
                    lblCloseGenre2_Click(sender, e);
                }
            }
        }

        /// <summary>
        /// Fill the genre field
        /// </summary>
        private void comboBoxGenre2_Enter(object sender, EventArgs e)
        {
            FillGenresComboBoxes(comboBoxGenre2);
        }

        /// <summary>
        /// Fill the genre field
        /// </summary>
        private void comboBoxGenre3_Enter(object sender, EventArgs e)
        {
            FillGenresComboBoxes(comboBoxGenre3);
        }

        /// <summary>
        /// Disable current genre field
        /// </summary>
        private void lblCloseGenre2_Click(object sender, EventArgs e)
        {
            //ComboBoxGenre1
            comboBoxGenre.Enabled = true;
            lblAddGenre2.Visible = true;

            //ComboBoxGenre2
            comboBoxGenre2.Text = null;
            comboBoxGenre2.Visible = false;
            comboBoxGenre2.Enabled = false;
            lblGenre2.Visible = false;
            lblCloseGenre2.Visible = false;
            lblAddGenre3.Visible = false;
        }

        /// <summary>
        /// Disable current genre field
        /// </summary>
        private void lblCloseGenre3_Click(object sender, EventArgs e)
        {
            //ComboBoxGenre2
            comboBoxGenre2.Enabled = true;
            lblAddGenre3.Visible = true;
            lblCloseGenre2.Visible = true;

            //ComboBoxGenre3
            comboBoxGenre3.Text = null;
            comboBoxGenre3.Visible = false;
            comboBoxGenre3.Enabled = false;
            lblGenre3.Visible = false;
            lblCloseGenre3.Visible = false;
        }

        /// <summary>
        /// If the genres are euqal give exception
        /// </summary>
        private void comboBoxGenre2_Leave(object sender, EventArgs e)
        {
            if (comboBoxGenre2.Text.Equals(comboBoxGenre.Text))
            {
                MessageBox.Show("The Genres must not be same!");
                comboBoxGenre2.Text = null;
                lblCloseGenre3_Click(sender,e);
                lblCloseGenre2_Click(sender, e);
            }
        }

        /// <summary>
        /// If the genres are euqal give exception
        /// </summary>
        private void comboBoxGenre3_Leave(object sender, EventArgs e)
        {
            if (comboBoxGenre3.Text.Equals(comboBoxGenre.Text) || comboBoxGenre3.Text.Equals(comboBoxGenre2.Text))
            {
                MessageBox.Show("The Genres must not be same!");
                comboBoxGenre3.Text = null;
                lblCloseGenre3_Click(sender, e);
            }
        }
    }
}
