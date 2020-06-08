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
    public partial class LoginForm : Form, ILoginForm
    {
        private LoginPresenter presenter; 

        public LoginForm() 
        {
            InitializeComponent();
            presenter = new LoginPresenter(this);
        }
        
        public string ErrorMessageLogin { 
            set => errorProviderLogin.SetError(textBoxFelh, value); } 
        public string ErrorMessageDB {
            set => errorProviderDBError.SetError(buttonBelep, value); }
        public string UserName { get => textBoxFelh.Text; }
        int szamlalo = 0;
        public static string felhnev = "";
        private void buttonKilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxFelh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                this.textBoxFelh.Focus();
            }
        }

        private void Reset()
        {
            errorProviderDBError.Clear();
            errorProviderLogin.Clear();
        }

        private void ButtonBelep_Click_2(object sender, EventArgs e)
        {
            LoginForm2 form2 = new LoginForm2();
            felhnev = textBoxFelh.Text;
            presenter.Authenticate();
            if (presenter.toLogin2Form)
            {
                var mv = new LoginForm2();
                Hide();
                mv.ShowDialog();
                //Close();
            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            var regf = new RegForm();
            Hide();
            regf.ShowDialog();
            Close();
        }

        private void textBoxFelh_TextChanged(object sender, EventArgs e)
        {
            Reset();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            Visible = true;
        }

        private void pictureBox4_MouseHover_1(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox4.BackColor = Color.Beige;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
            pictureBox4.BackColor = Color.Beige;
        }

        private void pictureBox4_MouseHover_2(object sender, EventArgs e)
        {
            labelInn.Visible = true;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            labelIdo.Visible = true;
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            labelSta.Visible = true;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            labelCsap.Visible = true;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            labelMulti.Visible = true;
        }

        private void pictureBox9_MouseHover(object sender, EventArgs e)
        {
            labelUtem.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void textBoxFelh_MouseClick(object sender, MouseEventArgs e)
        {
            if (szamlalo==0)
            {
                szamlalo++;
                textBoxFelh.Text = null;
            }
        }

        private void textBoxFelh_Click(object sender, EventArgs e)
        {
            errorProviderDBError.Clear();
            errorProviderLogin.Clear();
        }
    }
}
