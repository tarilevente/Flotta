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
    public partial class GepjarmuvekAdminForm : Form, IGepjarmuvekAdminForm
    {
        private GepjarmuvekAdminPresenter presenter;

        public List<string> rendszamLista { set=>listBoxRendszamok.DataSource=value; }
        public string selectedRendszam => listBoxRendszamok.SelectedItem.ToString();

        public string rendszam { get => textBoxRendsz.Text; set => textBoxRendsz.Text=value; }
        public string gyartmany { get => textBoxGyart.Text; set => textBoxGyart.Text=value; }
        public string tipus { get => textBoxTipus.Text; set => textBoxTipus.Text=value; }
        public string alvaz { get => textBoxAlvaz.Text; set => textBoxAlvaz.Text=value; }
        public string km { get => textBoxKm.Text; set => textBoxKm.Text=value; }
        public DateTime muszaki { get => dateTimePickerMuszaki.Value; set => dateTimePickerMuszaki.Value=value; }
        public DateTime bizt { get => dateTimePickerBizt.Value; set => dateTimePickerBizt.Value=value; }
        public string aktSofor { get => comboBoxSofor.SelectedItem.ToString(); set => comboBoxSofor.Items.Add(value); }
        public string evjarat { get =>textBoxEvjarat.Text; set=>textBoxEvjarat.Text=value; }

        public bool mMegyei { get => checkBoxMegyei.Checked; set => checkBoxMegyei.Checked=value; }
        public bool mOrszagos { get => checkBoxOrszagos.Checked; set => checkBoxOrszagos.Checked=value; }
        public bool autoR { get => checkBoxAutoRadio.Checked; set => checkBoxAutoRadio.Checked=value; }
        public bool vont { get => checkBoxVontato.Checked; set => checkBoxVontato.Checked=value; }
        public bool mentod { get => checkBoxMento.Checked; set => checkBoxVontato.Checked=value; }
        public bool bikak { get => checkBoxBika.Checked; set => checkBoxBika.Checked=value; }
        public bool teligumi { get => radioButtonTeli.Checked; set => radioButtonTeli.Checked=value; }
        public bool nyarigumi { get => radioButtonNyari.Checked; set => radioButtonNyari.Checked=value; }

        public string errorDB { set=>errorProviderDB.SetError(labelCimke,value); }
        public string errorRendszam { set=>errorProviderRend.SetError(labelRend,value); }
        public string errorGyart { set=> errorProviderGy.SetError(labelGy,value); }
        public string errorTip { set=>errorProviderTip.SetError(textBoxTipus,value); }
        public string errorAlv { set=>errorProviderAlv.SetError(textBoxAlvaz,value); }
        public string errorKm { set=>errorProviderKm.SetError(textBoxKm,value); }
        public string errorMuszaki { set=>errorProviderMusz.SetError(dateTimePickerMuszaki,value); }
        public string errorBizt { set=>errorProviderBizt.SetError(dateTimePickerBizt,value); }
        public string errorSofor { set=>errorProviderSof.SetError(comboBoxSofor,value); }

        public GepjarmuvekAdminForm()
        {
            InitializeComponent();
            presenter = new GepjarmuvekAdminPresenter(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mv = new MainWindow();
            Hide();
            mv.ShowDialog();
            Close();
        }

        private void buttonUjauto_Click(object sender, EventArgs e)
        {
            var ua = new UjAutoForm();
            Hide();
            ua.ShowDialog();
            Close();
        }

        private void buttonModosit_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            presenter.Load();
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {

        }

        private void buttonKeres_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxOrszagos_CheckedChanged(object sender, EventArgs e)
        {
          

        }

        private void listBoxRendszamok_MouseClick(object sender, MouseEventArgs e)
        {
            presenter.Load();
        }

        private void listBoxRendszamok_MouseUp(object sender, MouseEventArgs e)
        {
            presenter.Load();
        }

        private void listBoxRendszamok_KeyUp(object sender, KeyEventArgs e)
        {
            presenter.Load();
        }
    }
}
