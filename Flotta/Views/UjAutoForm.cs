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
        public void reset()
        {
            textBoxAlv.Text = null;
            textBoxGyart.Text = null;
            textBoxKm.Text = null;
            textBoxRendsz.Text = null;
            textBoxTipus.Text = null;
            checkBoxAutoR.Checked = false;
            checkBoxBikak.Checked = false;
            checkBoxMento.Checked = false;
            checkBoxVont.Checked = false;
        }

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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            reset();
        }
    }
}
