﻿using Flotta.Presenters;
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
    public partial class SzervizekForm : Form,ISzervizekForm
    {
        private  SzervizekPresenter presenter;
  
        public string ErrorMessageDB { set => errorProviderErrorDB.SetError(label9, value); }

        public List<string> rendszamLista { set => listBoxRendszamok.DataSource = value; }
        public string selectedRendszam { get => listBoxRendszamok.SelectedValue.ToString(); }

        public string aktRendszam { set => textBoxRendszam.Text = value; }
        public string aktGyartmany { set => textBoxGyartmany.Text = value; }
        public string aktTipus { set => textBoxTipus.Text = value; }
        public string aktKm { set => textBoxKm.Text = value; }
        
        public string aktMuszaki { set => textBoxMuszaki.Text = value; }
        public string aktBizt { set => textBoxBizt.Text = value; }

        public string aktLeiras { set => textBoxLeiras.Text= value; }
        public string aktIdopont { get => textBoxIdopont.Text; set => textBoxIdopont.Text = comboBoxIdopont.Text = value; }

        public string comboBoxFelt { set => comboBoxIdopont.Items.Add(value); }

        public bool showHide { set => tableLayoutPanelNav.Visible = value; get => tableLayoutPanelNav.Visible; }


       
        public SzervizekForm()
        {
            InitializeComponent();
            try
            {
                presenter = new SzervizekPresenter(this);
            }
            catch (NullReferenceException)
            {
                errorProviderErrorDB.SetError(label9, "Nincs autó az adatbázisban. ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var mv = new MainWindow();
            Hide();
            mv.ShowDialog();
            this.Close();
        }

        private void buttonUj_Click(object sender, EventArgs e)
        {
            var usz = new UjSzerviz();
            Hide();
            usz.ShowDialog();
            Close();
        }

        private void listBoxRendszamok_MouseClick(object sender, MouseEventArgs e)
        {
            Frissit();
        }

        public void Frissit()
        {
            comboBoxIdopont.Items.Clear();
            presenter.LoadDetails();
            presenter.LoadLeiras();
        }

        private void listBoxRendszamok_KeyUp(object sender, KeyEventArgs e)
        {
            Frissit();
        }

        private void comboBoxIdopont_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxIdopont.Text = comboBoxIdopont.Text;
            presenter.LoadLeiras();
        }

        private void buttonFrissit_Click(object sender, EventArgs e)
        {
            Frissit();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            
            if (comboBoxIdopont.SelectedIndex<comboBoxIdopont.Items.Count-1)
            {
                comboBoxIdopont.SelectedIndex = comboBoxIdopont.SelectedIndex + 1;
            }
            presenter.LoadLeiras();
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            if (comboBoxIdopont.SelectedIndex < comboBoxIdopont.Items.Count - 1)
            {
                comboBoxIdopont.SelectedIndex = comboBoxIdopont.Items.Count-1;
            }
            presenter.LoadLeiras();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {

            if (comboBoxIdopont.SelectedIndex > 0)
            {
                comboBoxIdopont.SelectedIndex = comboBoxIdopont.SelectedIndex - 1;
            }
            presenter.LoadLeiras();
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            if (comboBoxIdopont.SelectedIndex > 0)
            {
                comboBoxIdopont.SelectedIndex = 0;
            }
            presenter.LoadLeiras();
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            presenter.AktTorl();
            Frissit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
