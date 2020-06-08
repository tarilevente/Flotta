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

    public partial class ProfilAdminForm : Form,IProfilAdminForm
    {
        private ProfilAdminPresenter presenter;
        private DataGridViewComboBoxColumn jkCol;
        private int colIndex;

        public string selectedFelh { get => labelID.Text;  }
        public string aktAuto { get => comboBoxAutoja.SelectedItem.ToString(); }
        public string aktAutoKI { set => textBoxAutoja.Text = value; }
        public string comboboxFelt {set => comboBoxAutoja.Items.Add(value); }

        public string errorDB { set=>errorProviderDB.SetError(labelCimke,value); }
        public string errorKapcsMent { set => errorProviderMentKapcs.SetError(buttonSofAutMent,value); }
        public string errorTorles { set=>errorProviderTorles.SetError(buttonTorlesVegl,value); }

        public string aktFelhKIIR { set => textBoxSof.Text = value; }
        public bool ascending { get; set; }
        public string sortBy { get; set; }
        public string search  => textBoxKeres.Text;
        public string searchCat => comboBoxKeres.SelectedItem.ToString();

        public felhtabla aktKijelolt { get => (felhtabla)dataGridViewNevek.CurrentRow.DataBoundItem; }

        public BindingList<felhtabla> BindingList
        {
            set => dataGridViewNevek.DataSource=value;
        }
        public felhtabla selectedItem { get => (felhtabla)dataGridViewNevek.CurrentRow.DataBoundItem; }

        public bool showhideTorles=false;

        public ProfilAdminForm()
        {
            InitializeComponent();
            try
            {
                presenter = new ProfilAdminPresenter(this);
                jkCol = new DataGridViewComboBoxColumn();

                if (presenter.ConnectionExists())
                {
                    FrissitFelh();
                }
                else
                {
                    errorProviderDB.SetError(labelCimke, "Nincs kapcsolat az adatbázissal. ");
                }

                Init();
            }
            catch (NullReferenceException)
            {
                errorProviderDB.SetError(labelCimke,"Az adatbázis nem tartalmaz egy felhasználót sem");
            }
        }

        private void Init()
        {
            sortBy = "idFelh";
            ascending = true;
            colIndex = 0;

            comboBoxKeres.Items.Add("Válassz!");
            comboBoxKeres.Items.Add("Vezetéknév");
            comboBoxKeres.Items.Add("Keresztnév");
            comboBoxKeres.Items.Add("Város");
            comboBoxKeres.Items.Add("Utca, házszám");
            comboBoxKeres.Items.Add("Telefon");
            comboBoxKeres.Items.Add("Felhasználónév");
            comboBoxKeres.Items.Add("Jelszó");
            comboBoxKeres.SelectedIndex=0;
        }
        private void Frissit()
        {
            try
            {
                errorProviderDB.Clear();
                errorProviderMentKapcs.Clear();
                errorProviderTorles.Clear();
                errorProviderKeres.Clear();

                presenter.LoadData();

                comboBoxAutoja.Items.Clear();
                presenter.ComboboxFeltolt();

                presenter.kiirTextBoxAktFelhNev();
                presenter.kiirTextbeRendszam();

                dataGridViewNevek.Columns.Remove("soforautojatabla");
                dataGridViewNevek.Columns.Remove("idFelh");
                ShowHide();
                buttonTorlesVegl.Visible = false;
            }
            catch (NullReferenceException e)
            {
                errorProviderKeres.SetError(buttonKeres, "A keresés nem adott eredményt. "); 
            }
            catch (Exception e)
            {
                errorProviderKeres.SetError(buttonKeres,"egyéb hiba "+e.Message);
            }
 
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Frissit();
        }
        
        private void buttonKilep_Click(object sender, EventArgs e)
        {
            var mv = new MainWindow();
            Hide();
            mv.ShowDialog();
            Close();
        }

        private void ProfilAdminForm_Load(object sender, EventArgs e)
        {
            presenter.LoadData();

            presenter.kiirTextBoxAktFelhNev();
            presenter.kiirTextbeRendszam();

            dataGridViewNevek.Columns.Remove("idFelh");
            dataGridViewNevek.Columns.Remove("soforautojatabla");

            ShowHide();
            //DataGridView design
            foreach (DataGridViewColumn c in dataGridViewNevek.Columns)
            {
                c.DefaultCellStyle.Font = new Font("Segoe UI", 12F, GraphicsUnit.Pixel); //Segoe UI; 10,2pt
            }

            dataGridViewNevek.Columns[0].Width=80;
            dataGridViewNevek.Columns[1].Width=80;
            dataGridViewNevek.Columns[2].Width=80;
            dataGridViewNevek.Columns[3].Width=140;
            dataGridViewNevek.Columns[4].Width=80;
            dataGridViewNevek.Columns[5].Width=110;
            dataGridViewNevek.Columns[6].Width=120;
            dataGridViewNevek.Columns[7].Width=40;
            dataGridViewNevek.Columns[8].Width=40;
            dataGridViewNevek.BorderStyle = BorderStyle.None;
            dataGridViewNevek.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(64,64,64);
            dataGridViewNevek.AlternatingRowsDefaultCellStyle.ForeColor = Color.WhiteSmoke;
            dataGridViewNevek.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewNevek.DefaultCellStyle.SelectionBackColor = Color.PeachPuff;
            dataGridViewNevek.DefaultCellStyle.SelectionForeColor = Color.FromArgb(55,55,55);
            dataGridViewNevek.BackgroundColor = Color.FromArgb(64,64,64);

            dataGridViewNevek.EnableHeadersVisualStyles = false;
            dataGridViewNevek.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewNevek.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(55,55,55);
            dataGridViewNevek.ColumnHeadersDefaultCellStyle.ForeColor = Color.WhiteSmoke;
        }

        private void FrissitFelh()
        {
            presenter.LoadData();
        }

        private void buttonMod_Click(object sender, EventArgs e)
        {
            presenter.Update(selectedItem);
            presenter.Save();
            Frissit();
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            presenter.Delete(selectedItem);

            if (presenter.Delete(selectedItem))
            {
                try
                {
                    presenter.Save();
                    Frissit();
                }
                catch (NullReferenceException)
                {
                    errorTorles = "Nincs felhasználó kijelölve. ";
                }
            }
        }

        private void buttonSofAutMent_Click(object sender, EventArgs e)
        {
            presenter.MentKapcsolat();
            presenter.Save();
            Frissit();
        }

        private void dataGridViewNevek_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            presenter.kiirTextBoxAktFelhNev();
            presenter.kiirTextbeRendszam();
            ShowHide();
        }

        private void buttonTorlesKapcs_Click(object sender, EventArgs e)
        {
            presenter.DeleteKapcs();
            presenter.Save();
            Frissit();
        }

        public List<felhtabla> felhasznalokListaja
        {
            get => (List<felhtabla>)jkCol.DataSource;
            set
            {
                value.Insert(0, new felhtabla() { idFelh = 0 });
                jkCol.DataSource = value;
            }
        }

        private void dataGridViewNevek_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (colIndex == e.ColumnIndex)
            {
                ascending = !ascending;
            }

            switch (e.ColumnIndex)
            {
                default:
                    sortBy = "idFelh";
                    break;
                case 0:
                    sortBy = "vezetekNev";
                    break;
                case 1:
                    sortBy = "keresztNev";
                    break;
                case 2:
                    sortBy = "varos";
                    break;
                case 3:
                    sortBy = "utcaHsz";
                    break;
                case 4:
                    sortBy = "telefon";
                    break;
                case 5:
                    sortBy = "belepesNev";
                    break;
                case 6:
                    sortBy = "belepesJelszo";
                    break;
                case 7:
                    sortBy = "soforE";
                    break;
                case 8:
                    sortBy = "adminE";
                    break;
            }

            colIndex = e.ColumnIndex;
            
            Frissit();
        }

        private void buttonFriss_Click(object sender, EventArgs e)
        {
            Frissit();
        }

        private void buttonKeres_Click(object sender, EventArgs e)
        {
             Frissit();
        }

        private void buttonVissza_Click(object sender, EventArgs e)
        {
            textBoxKeres.Text = "";
            comboBoxKeres.SelectedItem = "Vezetéknév";
            Frissit();
        }

        private void dataGridViewNevek_KeyUp(object sender, KeyEventArgs e)
        {
            presenter.kiirTextBoxAktFelhNev();
            presenter.kiirTextbeRendszam();
            ShowHide();
        }

        public void ShowHide()
        {
            if (textBoxAutoja.Text.Equals("Nincs autója"))
            {
                showhideTorles = true;
                comboBoxAutoja.Visible = true;
                buttonTorlesKapcs.Visible = false;
                comboBoxAutoja.Text = "Válassz!";
                buttonSofAutMent.Visible = true;
            }
            else
            {
                showhideTorles = false;
                comboBoxAutoja.Visible = false;
                buttonTorlesKapcs.Visible = true;
                buttonSofAutMent.Visible = false;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonTorles_Click_1(object sender, EventArgs e)
        {
            buttonTorlesVegl.Visible = true;
        }
        
    }
}
