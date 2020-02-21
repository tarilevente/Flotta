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
    public partial class UjAutoForm : Form, IUjAutoForm
    {
        private UjAutoPresenter presenter;

        public string rendszam => textBoxRendsz.Text;
        public string alvazszam => textBoxAlv.Text;
        public string km => textBoxKm.Text;
        public string gyartmany => textBoxGyart.Text;
        public string tipus => textBoxTipus.Text;
        public bool radio => checkBoxAutoR.Checked;
        public bool vontato => checkBoxVont.Checked;
        public bool bika => checkBoxBikak.Checked;
        public bool mento => checkBoxMento.Checked;

        public string errorRendsz { set => errorProviderRendszam.SetError(textBoxRendsz, value); }
        public string errorAlv { set => errorProviderAlvazszam.SetError(textBoxAlv, value); }
        public string errorGyart { set => errorProviderGyart.SetError(textBoxGyart, value); }
        public string errorTipus { set => errorProviderTipus.SetError(textBoxTipus, value); }
        public string errorKm { set => errorProviderTipus.SetError(textBoxKm,value); }
        public string errorDB { set => errorProviderDB.SetError(labelCimke,value); }

        public void reset()
        {
            textBoxAlv.Text = null;
            textBoxGyart.Text = null;
            textBoxKm.Text = null;
            textBoxRendsz.Text = null;
            textBoxTipus.Text = null;
            checkBoxAutoR.Checked = false;
            checkBoxBikak.Checked = false;
            checkBoxMento.Checked = false;
            checkBoxVont.Checked = false;
            errorProviderAlvazszam.Clear();
            errorProviderGyart.Clear();
            errorProviderKm.Clear();
            errorProviderRendszam.Clear();
            errorProviderTipus.Clear();   
        }

        public UjAutoForm()
        {
            InitializeComponent();
            presenter = new UjAutoPresenter(this);
        }

        private void buttonKilep_Click(object sender, EventArgs e)
        {
            var gf = new GepjarmuvekAdminForm();
            Hide();
            gf.ShowDialog();
            Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void buttonFelvitel_Click(object sender, EventArgs e)
        {
            if (presenter.Check())
            {
                presenter.Vegrehajt(); 
                reset();
            }
            
        }
    }
}
