using Flotta.Presenters;
using Flotta.Properties;
using Flotta.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flotta.Views
{
    public partial class LoginForm2 : Form, ILogin2Form
    {
        Login2Presenter presenter;

        public string ErrorDB { set => errorProviderDB.SetError(label4, value); }
        public string ErrorBelep { set => errorProviderBelep.SetError(textBoxJelsz, value); }
        public string jelszo => textBoxJelsz.Text;
        public string ErrorBelepes { set => errorProviderBelep.SetError(buttonBelep, value); }
        public string felhnev;
        public string GetFelhnev { get => felhnev; }

        private bool LogoVis = false;


        public LoginForm2()
        {
            InitializeComponent();
            presenter = new Login2Presenter(this);
            felhnev = LoginForm.felhnev;
            AssignIconsToSquares();
        }

        public LoginForm2(string Felhnev)
        {
            InitializeComponent();
            this.felhnev = Felhnev;
        }

        private void buttonVissza_Click(object sender, EventArgs e)
        {
            var mv = new LoginForm();
            Hide();
            mv.ShowDialog();
            Close();
        }

        private void buttonBelep_Click(object sender, EventArgs e)
        {
            presenter.Authenticate();
            if (presenter.loginSuccess)
            {
                var mv = new MainWindow();
                Hide();
                mv.ShowDialog();
                Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void LoginForm2_Load(object sender, EventArgs e)
        {

        }

        //step 2
        // Use this Random object to choose random icons for the squares
        Random random = new Random();

        // Each of these letters is an interesting icon
        // in the Webdings font,
        // and each icon appears twice in this list
        List<string> icons = new List<string>()
            {
                "!", "!", "N", "N", ",", ",",
                "b", "b", "v", "v", "w", "w"
            };

        //step3
        /// <summary>
        /// Assign each icon from the list of icons to a random square
        /// </summary>
        private void AssignIconsToSquares()
        {
            // The TableLayoutPanel has 16 labels,
            // and the icon list has 16 icons,
            // so an icon is pulled at random from the list
            // and added to each label
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    // iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                    iconLabel.ForeColor = iconLabel.BackColor;
                }
            }
        }

        /// <summary>
        /// Every label's Click event is handled by this event handler
        /// </summary>
        /// <param name="sender">The label that was clicked</param>
        /// <param name="e"></param>
        private void label_Click(object sender, EventArgs e)
        {
            // The timer is only on after two non-matching 
            // icons have been shown to the player, 
            // so ignore any clicks if the timer is running
            if (timer1.Enabled == true)
                return;

            Label clickedLabel = sender as Label;

            if (clickedLabel != null)
            {
                // If the clicked label is black, the player clicked
                // an icon that's already been revealed --
                // ignore the click
                if (clickedLabel.ForeColor == Color.Black)
                    return;


                // If firstClicked is null, this is the first icon
                // in the pair that the player clicked, 
                // so set firstClicked to the label that the player 
                // clicked, change its color to black, and return
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }

                // If the player gets this far, the timer isn't
                // running and firstClicked isn't null,
                // so this must be the second icon the player clicked
                // Set its color to black
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;


                // Check to see if the player won
                CheckForWinner();
                // If the player clicked two matching icons, keep them 
                // black and reset firstClicked and secondClicked 
                // so the player can click another icon
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }
                
                
                // If the player gets this far, the player 
                // clicked two different icons, so start the 
                // timer (which will wait three quarters of 
                // a second, and then hide the icons)
                timer1.Start();
            }
        }
        // firstClicked points to the first Label control 
        // that the player clicks, but it will be null 
        // if the player hasn't clicked a label yet
        Label firstClicked = null;

        // secondClicked points to the second Label control 
        // that the player clicks
        Label secondClicked = null;

        /// <summary>
        /// This timer is started when the player clicks 
        /// two icons that don't match,
        /// so it counts three quarters of a second 
        /// and then turns itself off and hides both icons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            timer1.Stop();

            // Hide both icons
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;

            // Reset firstClicked and secondClicked 
            // so the next time a label is
            // clicked, the program knows it's the first click
            firstClicked = null;
            secondClicked = null;
        }

        private void CheckForWinner()
        {
            // Go through all of the labels in the TableLayoutPanel, 
            // checking each one to see if its icon is matched
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }

            // If the loop didn't return, it didn't find
            // any unmatched icons
            // That means the user won. Show a message and close the form
            tableLayoutPanel1.Visible = false;
        }

        private void pictureBox11_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox11.Image = Resources.image_part_001;
        }
        private void pictureBox12_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox12.Image = Resources.image_part_002;
        }
        private void pictureBox21_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox21.Image = Resources.image_part_003;
        }
        private void pictureBox22_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox22.Image = Resources.image_part_004;
        }
        private void pictureBox31_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox31.Image = Resources.image_part_005;
        }
        private void pictureBox32_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox32.Image = Resources.image_part_006;
        }
        private void pictureBox41_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox41.Image = Resources.image_part_011;
        }
        private void pictureBox42_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox42.Image = Resources.image_part_012;
        }
        private void pictureBox51_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox51.Image = Resources.image_part_007;
        }
        private void pictureBox52_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox52.Image = Resources.image_part_008;
        }
        private void pictureBox61_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox61.Image = Resources.image_part_009;
        }
        private void pictureBox62_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox62.Image = Resources.image_part_010;
        }

        private void buttonHalado_Click(object sender, EventArgs e)
        {
            tableLayoutPanel1.Visible = true;
        }

        private void textBoxJelsz_TextChanged(object sender, EventArgs e)
        {
            errorProviderBelep.Clear();
            errorProviderDB.Clear();
        }

        private void textBoxJelsz_Click(object sender, EventArgs e)
        {
            textBoxJelsz.Text = null;
        }
    }
}
