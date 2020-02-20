using Flotta.Presenters;
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
        private LoginPresenter presenter; //Presentert példányosít!!

        public LoginForm() //ki fogja példányosítani a loginForm-ot?  -- háát a presenter!
        {
            InitializeComponent();
            presenter = new LoginPresenter(this); //ez miért kell? -- Ha létrehozol egy view-t, akkor a prezentert is példányosítja, és a létrehozott view lesz a prezenter konstruktorában
        }


        //ez az Interface létrehozásakor generálódik, melyet később átírtunk. Ha módosítom az interface-t, akkor újra implementáljuk.
        public string ErrorMessageLogin { //ezek a változók az interface-ben is szerepelnek SET/GET-el
            set => errorProviderLogin.SetError(textBoxJelsz, value); } // errort kiküldi az Errorprovidernek
        public string ErrorMessageDB {
            set => errorProviderDBError.SetError(buttonBelep, value); }
        public string UserName { get => textBoxFelh.Text; } //kiolvassa a username-et
        public string Password {get => textBoxJelsz.Text; } //kiolvassa a Passwordot

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
            //ha hamis, akkor a prezenter false ágba fut, akkor a view errorMessage-et beállítja hibára.  De honnan tudja, hogy ki kell írni?
        }

        private void textBoxJelszo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonReg.PerformClick();
            }
        }

        private void buttonKilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBelep_Click_1(object sender, EventArgs e)
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

        private void textBoxFelh_KeyDown(object sender, KeyEventArgs e)
        {
     
        }

        private void textBoxFelh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                this.textBoxJelsz.Focus();
            }
        }

        private void buttonKilep_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonBelep_Click_2(object sender, EventArgs e)
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

        private void buttonReg_Click(object sender, EventArgs e)
        {
            var regf = new RegForm();
            Hide();
            regf.ShowDialog();
            Close();
        }
    }
}
