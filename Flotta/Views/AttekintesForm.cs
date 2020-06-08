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
    public partial class AttekintesForm : Form, IAttekintesForm
    {
        private AttekintesPresenter presenter;

        public string ErrorMessage { set => errorProviderDBError.SetError(labelAttekintes,value); }
        public string OsszAuto { set => textBoxOsszAuto.Text=value; }
        public string OsszSofor { set => textBoxOsszSof.Text = value; }
        public string OsszTeli { set => textBoxGumiT.Text = labelTeli.Text= value; }
        public string OsszNyari { set => textBoxGumiNy.Text =labelNyari.Text = value; }
        public string OsszRadio { set => textBoxAutoR.Text = value; }
        public string OsszVont { set => textBoxVont.Text = value; }
        public string OsszBika { set => textBoxBika.Text = value; }
        public string OsszMento { set => textBoxMento.Text = value; }
        public string legregebbiAuto { set => textBoxLegrAut.Text = value; }
        public string kovBizt { set => textBoxKovBizt.Text = value; }
        public string kovMusz { set => textBoxKovMuszaki.Text = value; }
        public string maxKm { set=>textBoxLegtKm.Text=value; }
        public List<string> teli { set => listBoxTeli.DataSource = value; }
        public List<string> nyari { set => listBoxNyari.DataSource = value; }

        public AttekintesForm()
        {
            InitializeComponent();
            presenter = new AttekintesPresenter(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mv = new MainWindow();
            Hide();
            mv.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void AttekintesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
