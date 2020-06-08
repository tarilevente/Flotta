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

        public string vezetekNev => textBoxVez.Text ;

        public string keresztnev => textBoxKer.Text;

        public string varos => textBoxVaros.Text;

        public string utcaHsz => textBoxUtca.Text;

        public string telefon => textBoxTel.Text;

        public string felhNev => textBoxFelh.Text;

        public string jelsz => textBoxJeszo.Text;

        public string confirm => textBoxConfirm.Text;

        public string errorDB { set => errorProviderVez.SetError(textBoxVez, value); }
        public string errorVez { set => errorProviderVez.SetError(textBoxVez,value); }
        public string errorKer { set => errorProviderKer.SetError(textBoxKer,value); }
        public string errorVar { set => errorProviderVar.SetError(textBoxVaros,value); }
        public string errorUtc { set =>errorProviderUtc.SetError(textBoxUtca,value); }
        public string errorTel { set => errorProviderTel.SetError(textBoxTel,value); }
        public string errorFelh { set => errorProviderFelh.SetError(textBoxFelh,value); }
        public string errorJelsz { set =>errorProviderJel.SetError(textBoxJeszo,value); }
        public string errorConf { set => errorProviderCon.SetError(textBoxConfirm,value); }
        public string errorButt { set =>errorProviderButt.SetError(buttonReg,value); }

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
            errorProviderButt.Clear();
            errorProviderCon.Clear();
            errorProviderFelh.Clear();
            errorProviderJel.Clear();
            errorProviderKer.Clear();
            errorProviderTel.Clear();
            errorProviderUtc.Clear();
            errorProviderVar.Clear();
            errorProviderVez.Clear();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            clear();
            textBoxFelh.Focus();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (presenter.Authenticate())
            {
                presenter.Insert();
                clear();
            }
        }

        private void buttonKilep_Click(object sender, EventArgs e)
        {
            var logF = new LoginForm();
            Hide();
            logF.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
