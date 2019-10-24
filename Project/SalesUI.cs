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
           productsComboBox.Text = "--Select Product--";
           //customerComboBox.Text = "--Select Product--";
           // loyalityPointTextBox.Text = "0";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //private void loyalityPointTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    double loyalityPoint = Convert.ToDouble(loyalityPointTextBox.Text);
        //    double discount = (loyalityPoint / 10);
        //    discountTextBox.Text = discount.ToString();
        //}
        private void totalMrpTextBox_TextChanged(object sender, EventArgs e)
        {
            double mrp = (Convert.ToInt32(quantityTextBox.Text) * (Convert.ToDouble(totalMrpTextBox.Text)));
            mrpTextBox.Text = mrp.ToString();
            double loyalityPoint = Convert.ToDouble(loyalityPointTextBox.Text);
            double discount = (loyalityPoint / 10);
            discountTextBox.Text = discount.ToString();
            double total = Convert.ToDouble(mrpTextBox.Text);
            //double discount = Convert.ToDouble(discountTextBox.Text);
            discountAmountTextBox.Text = ((total * discount) / 100).ToString();
            payebleAmountTextBox.Text = (total - Convert.ToDouble(discountAmountTextBox.Text)).ToString();
        }

        public void mrpTextBox_TextChanged(object sender, EventArgs e)
        {
            double grandTotal = Convert.ToDouble(mrpTextBox.Text);
            grandTotalTextBox.Text = grandTotal.ToString();
        }
        //private void discountTextBox_TextChanged(object sender, EventArgs e)
        //{
        //    //double total = Convert.ToDouble(mrpTextBox.Text);
        //    //double discount = Convert.ToDouble(discountTextBox.Text);
        //    //discountAmountTextBox.Text = ((total * discount) / 100).ToString();
        //    //payebleAmountTextBox.Text = (total - Convert.ToDouble(discountAmountTextBox.Text)).ToString();
        //}

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            loyalityPointTextBox.Text = (_salesManager.DisplayCustomerLoylityPoint(customerComboBox.Text)).ToString();
        }

        private void catagoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            productsComboBox.Items.Clear();
            List<Product> products = new List<Product>();
            products = _salesManager.DisplayProductByCategoryID(catagoryComboBox.Text);
            foreach (var product in products)
            {
                productsComboBox.Items.Add(product.Product_Name);
            }
        }
    }
}
