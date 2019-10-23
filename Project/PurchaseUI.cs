using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class PurchaseUI : Form
    {
        public PurchaseUI()
        {
            InitializeComponent();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            SalesUI salesUI = new SalesUI();
            salesUI.Show();
            Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            CatagoryUI catagoryUI = new CatagoryUI();
            catagoryUI.Show();
            Hide();
        }
    }
}
