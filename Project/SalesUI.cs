using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.BLL;
using Project.Model;
namespace Project
{
    public partial class SalesUI : Form
    {
        SalesManager _salesManager = new SalesManager();
        public SalesUI()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            PurchaseUI purchase = new PurchaseUI();
            purchase.Show();
            Hide();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            CatagoryUI catagoryUI = new CatagoryUI();
            catagoryUI.Show();
            Hide();
        }

        private void SalesUI_Load(object sender, EventArgs e)
        {
           catagoryComboBox.DataSource = _salesManager.DisplayCategory();
           customerComboBox.DataSource = _salesManager.DisplayCustomer();
           productsComboBox.DataSource = _salesManager.DisplayProduct();
        }    
    }
}
