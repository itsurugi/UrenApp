﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fun12UrenApp
{
    public partial class frmMenu : Form
    {
        frmInsertHours inserthours = new frmInsertHours();
        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnInsertHours_Click(object sender, EventArgs e)
        {
            this.Hide();
            inserthours.ShowDialog();
            this.Show();
        }
    }
}
