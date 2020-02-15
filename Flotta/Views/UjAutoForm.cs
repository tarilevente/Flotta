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
    public partial class UjAutoForm : Form
    {
        public UjAutoForm()
        {
            InitializeComponent();
        }

        private void buttonKilep_Click(object sender, EventArgs e)
        {
            var gf = new GepjarmuvekAdminForm();
            Hide();
            gf.ShowDialog();
            Close();
        }
    }
}
