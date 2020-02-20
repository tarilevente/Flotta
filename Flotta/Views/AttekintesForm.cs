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
        public string OsszTeli { set => textBoxGumiT.Text = value; }
        public string OsszNyari { set => textBoxGumiNy.Text = value; }
        public string OsszRadio { set => textBoxAutoR.Text = value; }
        public string OsszVont { set => textBoxVont.Text = value; }
        public string OsszBika { set => textBoxBika.Text = value; }
        public string OsszMento { set => textBoxMento.Text = value; }


        public AttekintesForm()
        {
            InitializeComponent();
            presenter = new AttekintesPresenter(this);
        }

        

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mv = new MainWindow();
            Hide();
            mv.ShowDialog();
            Close();
        }

        private void AttekintesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
