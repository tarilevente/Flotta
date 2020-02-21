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
    public partial class UjSzerviz : Form, IUjSzerviz
    {
        private UjSzervizPresenter presenter;

        public string rendszam => textBoxRendsz.Text;
        public bool casco => radioButtonCasco.Checked;
        public bool bizt => radioButtonKot.Checked;
        public DateTime idopont => dateTimePicker1.Value;
        public string leiras { get => textBoxLeiras.Text;  }//tesztelés
        

        public string errorRendszam { set => errorProviderRendsz.SetError(labelRendsz, value); }
        public string errorIdopont { set => errorProviderIdop.SetError(labelIdop,value); }
        public string errorLeiras { set => errorProviderLeir.SetError(labelLeiras,value); }
        public string errorDB { set => errorProviderDB.SetError(labelCimke,value); }

        public UjSzerviz()
        {
            InitializeComponent();
            presenter = new UjSzervizPresenter(this);
            dateTimePicker1.Value = DateTime.Now;
        }

        private void reset()
        {
            textBoxRendsz.Text = null;
            textBoxLeiras.Text = null;
            dateTimePicker1.Value = DateTime.Now;
            errorProviderDB.Clear();
            errorProviderIdop.Clear();
            errorProviderLeir.Clear();
            errorProviderRendsz.Clear();
        }

        private void buttonVissza_Click(object sender, EventArgs e)
        {
            var szf = new SzervizekForm();
            Hide();
            szf.ShowDialog();
            Close();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonFelv_Click(object sender, EventArgs e)
        {
            if(presenter.Check())
            {
                presenter.Vegrehajt(); //nem működik
                reset();
            }
        }
    }
}
