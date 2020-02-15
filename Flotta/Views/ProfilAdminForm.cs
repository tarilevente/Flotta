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
    public partial class ProfilAdminForm : Form
    {
        public ProfilAdminForm()
        {
            InitializeComponent();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonKilep_Click(object sender, EventArgs e)
        {
            var mv = new MainWindow();
            Hide();
            mv.ShowDialog();
            Close();
        }
    }
}
