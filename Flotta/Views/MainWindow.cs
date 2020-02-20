using Flotta.Presenters;
using Flotta.Properties;
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
    public partial class MainWindow : Form, IMainWindow
    {
        private MainPresenter presenter;

        public string ErrorMessageDB { set => errorProviderDBError.SetError(buttonKilepes,value) ; }
        private int childFormNumber = 0;

        public MainWindow()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
            //háttérkép beállítása
            Image myImage = new Bitmap(Flotta.Properties.Resources.MainImage);
            pictureBox1.Image = myImage;
            this.pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
        }

        private void ShowNewForm(object sender, EventArgs e) //ez mi?
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
           

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonKilepes_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(0);
        }

        private void toolStripMenuItemFooldal_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemSzervizek_Click(object sender, EventArgs e)
        {
            if (presenter.ConnectionExists())
            {
                var szf = new SzervizekForm();
                Hide();
                szf.ShowDialog();
                Close();
            }
            else
            {
                errorProviderDBError2.SetError(buttonKilepes, Resources.DBError);
            }
        }

        private void toolStripMenuItemMuszaki_Click(object sender, EventArgs e)
        {
            if (presenter.ConnectionExists())
            {
                var me = new MuszakiForm();
                Hide();
                me.ShowDialog();
                Close();
            }
            else
            {
                errorProviderDBError2.SetError(buttonKilepes, Resources.DBError);
            }
        }

        private void toolStripMenuItemGepjarmuvek_Click(object sender, EventArgs e)
        {
            if (presenter.ConnectionExists())
            {
                var gf = new GepjarmuvekAdminForm();
                Hide();
                gf.ShowDialog();
                Close();
            }
            else
            {
                errorProviderDBError2.SetError(buttonKilepes, Resources.DBError);
            }
        }

        private void toolStripMenuItemFelszerelesek_Click(object sender, EventArgs e)
        {
            if (presenter.ConnectionExists())
            {
                var fe = new AttekintesForm();
                Hide();
                fe.ShowDialog();
                Close();
            }
            else
            {
                errorProviderDBError2.SetError(buttonKilepes, Resources.DBError);
            }
        }

        private void toolStripMenuItemProfilom_Click(object sender, EventArgs e)
        {
            if (presenter.ConnectionExists())
            {
                var pk = new ProfilAdminForm();
                Hide();
                pk.ShowDialog();
                Close();
            }
            else
            {
                errorProviderDBError2.SetError(buttonKilepes, Resources.DBError);
            }

        }
    }
}
