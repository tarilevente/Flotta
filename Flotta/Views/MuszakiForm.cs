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
    public partial class MuszakiForm : Form,IMuszakiForm
    {
        private DataGridViewComboBoxColumn JkCol;
        private MuszakiPresenter presenter;
        public MuszakiForm()
        {
            InitializeComponent();
            presenter = new MuszakiPresenter(this);
            JkCol = new DataGridViewComboBoxColumn();
            if (presenter.ConnectionExists())
            {
                presenter.Load();
            } 
            else
            {
                errorProviderDB.SetError(labelCimke, "Nincs kapcsolat az adatbázissal. ");
            }
            Init();
        }

        public BindingList<muszakiallapottabla> bindingList { set => dataGridViewMuszaki.DataSource=value; }
        public string sofNev { set => textBoxSofNev.Text = value;}
        public string sofTel { set => textBoxSofTel.Text=value; }

        public muszakiallapottabla selectedMusz => (muszakiallapottabla)dataGridViewMuszaki.CurrentRow.DataBoundItem;

        public string errorDB { set => errorProviderDB.SetError(labelCimke,value); }
        public string errorKeres { set=>errorProviderKeres.SetError(toolStripButtonKeres,value); }
        public bool ascending { get; set; }

        public string search => toolStripTextBoxKeres.Text;

        private void button1_Click(object sender, EventArgs e)
        {
            var mv = new MainWindow();
            Hide();
            mv.ShowDialog();
            Close();
        }

        private void Init()
        {
            ascending = true;
        }

        private void Frissit()
        {
            presenter.Load();
            presenter.NevRendszamBetolt();
                dataGridViewMuszaki.Columns.Remove("idmuszakiAllapot");
                dataGridViewMuszaki.Columns.Remove("biztosErv");
                dataGridViewMuszaki.Columns.Remove("matricaMegyei");
                dataGridViewMuszaki.Columns.Remove("matricaOrszagos");
                dataGridViewMuszaki.Columns.Remove("teligumi");
                dataGridViewMuszaki.Columns.Remove("nyarigumi");
                dataGridViewMuszaki.Columns.Remove("evjarat");
                dataGridViewMuszaki.Columns.Remove("autoktabla");
            errorProviderDB.Clear();
            errorProviderKeres.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var mv = new MainWindow();
            Hide();
            mv.ShowDialog();
            Close();
        }

        private void MuszakiForm_Load(object sender, EventArgs e)
        {
            Frissit();

            //DataGridView design
            dataGridViewMuszaki.Columns[0].Width = 100;
            dataGridViewMuszaki.Columns[1].Width = 100;
            foreach (DataGridViewColumn c in dataGridViewMuszaki.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Segoe UI", 16F, GraphicsUnit.Pixel); //Segoe UI; 10,2pt
            }
            dataGridViewMuszaki.BorderStyle = BorderStyle.None;
            dataGridViewMuszaki.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewMuszaki.BackgroundColor = Color.FromArgb(64,64,64);

            dataGridViewMuszaki.EnableHeadersVisualStyles = false;
            dataGridViewMuszaki.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewMuszaki.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55, 55, 55);
            dataGridViewMuszaki.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
        }

        private void dataGridViewMuszaki_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ascending = !ascending;
            Frissit();
        }

        private void toolStripButtonKeres_Click(object sender, EventArgs e)
        {
            Frissit();
        }

        private void toolStripButtonVissza_Click(object sender, EventArgs e)
        {
            toolStripTextBoxKeres.Text = null;
            Frissit();
        }

        private void dataGridViewMuszaki_Click(object sender, EventArgs e)
        {
            presenter.NevRendszamBetolt();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
