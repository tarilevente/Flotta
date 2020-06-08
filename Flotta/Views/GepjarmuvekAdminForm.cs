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
        public string evjarat { get =>textBoxEvjarat.Text; set=>textBoxEvjarat.Text=value; }
        public string sofor { set=> textBoxSofor.Text = value ; }

        public bool mMegyei { get => checkBoxMegyei.Checked; set => checkBoxMegyei.Checked=value; }
        public bool mOrszagos { get => checkBoxOrszagos.Checked; set => checkBoxOrszagos.Checked=value; }
        public bool autoR { get => checkBoxAutoRadio.Checked; set => checkBoxAutoRadio.Checked=value; }
        public bool vont { get => checkBoxVontato.Checked; set => checkBoxVontato.Checked=value; }
        public bool mentod { get => checkBoxMento.Checked; set => checkBoxMento.Checked=value; }
        public bool bikak { get => checkBoxBika.Checked; set => checkBoxBika.Checked=value; }
        public bool teligumi { get => radioButtonTeli.Checked; set => radioButtonTeli.Checked=value; }
        public bool nyarigumi { get => radioButtonNyari.Checked; set => radioButtonNyari.Checked=value; }

        public string errorDB { set=>errorProviderDB.SetError(labelCimke,value); }
        public string errorRendszam { set=>errorProviderRend.SetError(textBoxRendsz,value); }
        public string errorGyart { set=> errorProviderGy.SetError(textBoxGyart,value); }
        public string errorTip { set=>errorProviderTip.SetError(textBoxTipus,value); }
        public string errorAlv { set=>errorProviderAlv.SetError(textBoxAlvaz,value); }
        public string errorKm { set=>errorProviderKm.SetError(textBoxKm,value); }
        public string errorMuszaki { set=>errorProviderMusz.SetError(dateTimePickerMuszaki,value); }
        public string errorBizt { set=>errorProviderBizt.SetError(dateTimePickerBizt,value); }
        public string errorMegyei { set => errorProviderMegyei.SetError(checkBoxMegyei, value); }
        public string errorTorol { set=>errorProviderTorol.SetError(buttonTorlesVegl,value); }


        public GepjarmuvekAdminForm()
        {
            InitializeComponent();
            try
            {
                presenter = new GepjarmuvekAdminPresenter(this);
            }
            catch (NullReferenceException e)
            {
                errorProviderDB.SetError(labelCimke, "Nincs autó.  ");
            }
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

        public void reset()
        {
            errorProviderAlv.Clear();
            errorProviderBizt.Clear();
            errorProviderDB.Clear();
            errorProviderEvjarat.Clear();
            errorProviderGy.Clear();
            errorProviderKm.Clear();
            errorProviderMusz.Clear();
            errorProviderRend.Clear();
            errorProviderTip.Clear();
            errorProviderTorol.Clear();
            errorProviderMegyei.Clear();
            buttonTorlesVegl.Visible = false;
            presenter.Load();
        }

        private void buttonModosit_Click(object sender, EventArgs e)
        {
            try
            { 
                if (presenter.Check())
                {
                    presenter.Modosit();
                    presenter.getRendszamList();
                    reset();
                }
            }
            catch (NullReferenceException)
            {
                errorProviderDB.SetError(labelCimke, "Nincs autó.  ");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                reset();
            }
            catch (NullReferenceException)
            {
                errorProviderDB.SetError(labelCimke, "Nincs autó.  ");
            }
}
        
        private void listBoxRendszamok_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                reset();
            }
            catch (NullReferenceException)
            {
                errorProviderDB.SetError(labelCimke, "Nincs autó.  ");
            }
        }

        private void listBoxRendszamok_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                reset();
            }
            catch (NullReferenceException)
            {
                errorProviderDB.SetError(labelCimke, "Nincs autó.  ");
            }
        }
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonTorlesVegl.Visible = true;
        }

        private void buttonTorlesVegl_Click(object sender, EventArgs e)
        {
            try
            {
                if (presenter.CheckTorol())
                {
                    presenter.Torol();
                    presenter.getRendszamList();
                    reset();
                    reset();
                }
            }
            catch (NullReferenceException)
            {
                errorProviderDB.SetError(labelCimke, "Nincs autó.  ");
            }
        }
    }
}
