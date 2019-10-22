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
                showDataGridView.DataSource = _productManager.DisplayProduct();
            }
            else
            {
                MessageBox.Show("Not Saved");
            }
        }

        private void ProductUI_Load(object sender, EventArgs e)
        {
           catagoryComboBox.DataSource = _productManager.Display();
           showDataGridView.DataSource = _productManager.DisplayProduct();

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            CatagoryUI catagoryUI = new CatagoryUI();
            catagoryUI.Show();
            Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            CatagoryUI catagoryUI = new CatagoryUI();
            catagoryUI.Show();
            Hide();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            CustomerUI customerUI = new CustomerUI();
            customerUI.Show();
            Hide();
        }

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showDataGridView.Columns[e.ColumnIndex].Name.Equals("Edit"))
            {
                int i;
                string button = "Update";
                i = showDataGridView.SelectedCells[0].RowIndex;
                catagoryComboBox.Text = showDataGridView.Rows[i].Cells[1].Value.ToString();
                codeTextBox.Text = showDataGridView.Rows[i].Cells[2].Value.ToString();
                nameTextBox.Text = showDataGridView.Rows[i].Cells[3].Value.ToString();
                recordedTextBox.Text = showDataGridView.Rows[i].Cells[4].Value.ToString();
                descriptionTextBox.Text = showDataGridView.Rows[i].Cells[5].Value.ToString();
                saveButton.Text = button;
            }
        }
    }
    
}
