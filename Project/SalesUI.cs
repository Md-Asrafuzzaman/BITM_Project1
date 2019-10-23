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
        Sales sales;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void totalMrpTextBox_TextChanged(object sender, EventArgs e)
        {
            double mrp = (Convert.ToInt32(quantityTextBox.Text) * (Convert.ToDouble(totalMrpTextBox.Text)));
            mrpTextBox.Text = mrp.ToString(); 
        }

        private void mrpTextBox_TextChanged(object sender, EventArgs e)
        {
            double grandTotal = Convert.ToDouble(mrpTextBox.Text);
            double loyality = (grandTotal / 1000);
            loyalityPointTextBox.Text = loyality.ToString();
            grandTotalTextBox.Text = grandTotal.ToString();
        }

        private void loyalityPointTextBox_TextChanged(object sender, EventArgs e)
        {
            double loyalityPoint = Convert.ToDouble(loyalityPointTextBox.Text);
            double discount = (loyalityPoint / 10);
            discountTextBox.Text = discount.ToString();
        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            double discount = Convert.ToDouble(discountTextBox.Text);
            double total = Convert.ToDouble(mrpTextBox.Text);
            discountAmountTextBox.Text = (( total * discount) / 100).ToString();
            payebleAmountTextBox.Text = (total - Convert.ToDouble(discountAmountTextBox.Text)).ToString();
        }
    }
}
