using System;
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
    public partial class ViewBoxes : Form
    {
        public ViewBoxes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void AddBoxbutton_Click(object sender, EventArgs e)
        {
            AddBoxes oform = new AddBoxes();
                oform.ShowDialog();
        }

        private void ModifyBoxesbutton_Click(object sender, EventArgs e)
        {
            ModifyBoxes oform = new ModifyBoxes();
            oform.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            admOptions oform = new admOptions();
            oform.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            admLogin oform = new admLogin();
            oform.ShowDialog();


        }
    }
}
