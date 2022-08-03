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
    public partial class admOptions : Form
    {
        public admOptions()
        {
            InitializeComponent();
        }

        private void addItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void modiDeleItems_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackUpDatabase_Click(object sender, EventArgs e)
        {
            backupDatabase oform = new backupDatabase();
            oform.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddNewItems oform = new AddNewItems();
            oform.ShowDialog();
        }

        private void ModifyDeleteItems_Click(object sender, EventArgs e)
        {
            FormModifyDelete oform = new FormModifyDelete();
            oform.ShowDialog();
        }

        private void AddDeleteCoaches_Click(object sender, EventArgs e)
        {
            ModifyCoach oform = new ModifyCoach();
            oform.ShowDialog();
        }

        private void ViewAddBoxes_Click(object sender, EventArgs e)
        {
            ViewBoxes oform = new ViewBoxes();
            oform.ShowDialog();
        }

        private void ItemsControl_Click(object sender, EventArgs e)
        {
            Item_Control oform = new Item_Control();
            oform.ShowDialog();
        }

        private void CreateQRCodes_Click(object sender, EventArgs e)
        {
            createQRCode oform = new createQRCode();
            oform.ShowDialog();
        }

        private void logOut_Click(object sender, EventArgs e)
        {
            admLogin oform = new admLogin();
                    oform.ShowDialog();
        }
    }
}
