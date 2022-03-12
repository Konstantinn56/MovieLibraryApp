using Business;
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
    public partial class mainPage : Form
    {
        bool mouseDown;
        private Point offset;

        public mainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Account business
        /// </summary>
        private AccountBusiness accountBusiness = new AccountBusiness();

        /// <summary>
        /// Set the current Location of the Screen and Set the mouseDown to true
        /// </summary>
        private void mainPage_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        /// <summary>
        /// Change the location of the screen
        /// </summary>
        private void mainPage_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        /// <summary>
        /// Change the mouseDown boolean to false
        /// </summary>
        private void mainPage_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        /// <summary>
        /// Current account
        /// </summary>
        public Account currentAccount { get; set; }

        /// <summary>
        /// Set the lblUsr to Account Username
        /// </summary>
        private void mainPage_Load(object sender, EventArgs e)
        {
            lblUsername.Text = $"{currentAccount.FirstName} {currentAccount.LastName}";
        }

        
    }
}
