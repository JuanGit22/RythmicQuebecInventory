﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RythmicQuebecInventory
{
    public partial class ModifyCoach : Form
    {
        public ModifyCoach()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admOptions oform = new admOptions();
            oform.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            MAppWindow oform = new MAppWindow();
            oform.ShowDialog();
        }
    }
}