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
                //Save image
                MemoryStream stream = new MemoryStream();
                pictureBoxImage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();

                //Adding movie into database
                Movie currentMovie = new Movie() { Title = txtBoxTitle.Text, Genre = comboBoxGenre.Text, Image = pic, YaerOfCreation = int.Parse(txtBoxYear.Text), Rate = double.Parse(txtBoxRate.Text) };
                movieBusiness.Add(currentMovie);
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
                if(int.TryParse(txtBoxYear.Text, out year))
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
        private void comboBoxGenre_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxGenre.Text.Equals("Add New Genre"))
            {
                AddNewGenre ang = new AddNewGenre();
                ang.Show();
            }
        }

        /// <summary>
        /// Reset all fields
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtBoxYear.Text = "Year";
            txtBoxYear.ForeColor = Color.DarkRed;
            panelYear.BackColor = Color.Black;
            lblYearExepction.Text = "";

            txtBoxTitle.Text = "Title";
            txtBoxTitle.ForeColor = Color.DarkRed;
            panelTitle.BackColor = Color.Black;
            lblUsrException.Text = "";

            txtBoxRate.Text = "Rate [1-10]";
            txtBoxRate.ForeColor = Color.DarkRed;
            panelRate.BackColor = Color.Black;
            lblRateException.Text = "";

            comboBoxGenre.Text = null;

            pictureBoxImage.Image = null;
        }
    }
}
