using Business;
using Data.Model;
using System.Runtime.InteropServices;

namespace MLibUI.MainMenu
{
    public partial class AddNewGenre : Form
    {
        public AddNewGenre()
        {
            InitializeComponent();
        }
        GenreBusiness gb = new GenreBusiness();

        /// <summary>
        /// Hide current window
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /// <summary>
        /// Create new genre and add it to the database
        /// </summary>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtBoxGenre.Text.Equals("Genre"))
            {
                MessageBox.Show("The Field must not me empty!");
            }
            else
            {
                Genre genre = new Genre() { Name = txtBoxGenre.Text };
                if (gb.Get(genre.Name) == null)
                {
                    gb.Add(genre);
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Genre already exists!");
                    panelGenre.BackColor = Color.Red;
                }
            }
        }

        /// <summary>
        /// Clears the text box and lblException and change the ForeColor of the textBox and the color of the underline
        /// </summary>
        private void txtBoxGenre_Enter(object sender, EventArgs e)
        {
            if (txtBoxGenre.Text.Equals("Genre"))
            {
                txtBoxGenre.Clear();
            }
            txtBoxGenre.BackColor = Color.DarkGray;
            txtBoxGenre.ForeColor = Color.Black;
        }

        /// <summary>
        /// It will change the color of the underline, and if there is no text, it will set the watermark
        /// </summary>
        private void txtBoxGenre_Leave(object sender, EventArgs e)
        {
            if (txtBoxGenre.Text.Equals(""))
            {
                txtBoxGenre.Text = "Genre";
                txtBoxGenre.ForeColor = Color.DarkRed;
                panelGenre.BackColor = Color.Black;
            }
        }

        /// <summary>
        /// Change panelGenre color to black
        /// </summary>
        private void txtBoxGenre_TextChanged(object sender, EventArgs e)
        {
            panelGenre.BackColor = Color.Black;
        }

        //Drag Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /// <summary>
        /// Make the window draggable
        /// </summary>
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
