using Flotta.Models;
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
    public partial class RegForm : Form, IRegForm
    {
        private autokContext db = new autokContext();
        private RegFormPresenter presenter;

        public RegForm()
        {
            InitializeComponent();
            presenter = new RegFormPresenter(this);
        }


        public string ErrorMessage
        { //ezek a változók az interface-ben is szerepelnek SET/GET-el
            set => errorProviderFelh.SetError(textBoxFelh, value);
        } // errort kiküldi az Errorprovidernek

        public void clear()
        {
            textBoxVez.Text = null;
            textBoxKer.Text = null;
            textBoxVaros.Text = null;
            textBoxUtca.Text = null;
            textBoxTel.Text = null;
            textBoxFelh.Text = null;
            textBoxJeszo.Text = null;
            textBoxConfirm.Text = null;
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            clear();
            textBoxFelh.Focus();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            presenter.Authenticate();

        }

        private void buttonKilep_Click(object sender, EventArgs e)
        {
            var logF = new loginForm();
            Hide();
            logF.ShowDialog();
            this.Close();
        }
    }

    
}
