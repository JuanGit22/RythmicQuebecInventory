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
    public partial class createQRCode : Form
    {
        public createQRCode()
        {
            InitializeComponent();
            //insertComboItems();
            
        }

        private void selectBoxies_TextChanged(object sender, EventArgs e)
        {

        }

        private void creatQRCode_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            MAppWindow oform = new MAppWindow();
            oform.ShowDialog();


        }
    }
}
