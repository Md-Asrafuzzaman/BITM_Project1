using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Model;
using Project.BLL;


namespace Project
{
    public partial class ProductUI : Form
    {

        ProductManager _productManager = new ProductManager();
        Product product = new Product();
        public ProductUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Checking Name UNIQUE
            product.Product_Name = nameTextBox.Text;
            if (_productManager.IsNameExists(product))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exists!");
                return;
            }

            //Checking Code UNIQUE
            product.Product_Code = codeTextBox.Text;
            if (_productManager.IsCodeExist(product))
            {
                MessageBox.Show(codeTextBox.Text + " Already Exists!");
                return;
            }
            product.Product_Category = catagoryComboBox.Text;
            product.Product_RecordedLevel = recordedTextBox.Text;
            product.Product_Description = descriptionTextBox.Text;
            bool isAdded = _productManager.AddProductInfo(product);
            if (isAdded)
            {
                MessageBox.Show("Saved");
                //showDataGridView.DataSource = _productManager.Display();
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
        }

        private void ProductUI_Load(object sender, EventArgs e)
        {
           catagoryComboBox.DataSource = _productManager.Display();
        }
    }
    
}
