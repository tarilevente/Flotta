﻿using System;
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
    public partial class UjSzerviz : Form
    {
        public UjSzerviz()
        {
            InitializeComponent();
        }

        private void buttonVissza_Click(object sender, EventArgs e)
        {
            var szf = new SzervizekForm();
            Hide();
            szf.ShowDialog();
            Close();
        }
    }
}
