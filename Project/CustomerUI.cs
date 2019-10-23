using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project;
using Project.BLL;
using Project.Model;


namespace Project
{
    public partial class CustomerUI : Form
    {
        CustomerManager _customerManager = new CustomerManager();
        Customer customer = new Customer();

        public CustomerUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Checking Name UNIQUE
            customer.Customer_Name = nameTextBox.Text;
            if (_customerManager.IsNameExists(customer))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exists!");
                return;
            }

            //Checking Code UNIQUE

            customer.Customer_Code = codeTextBox.Text;
            if (_customerManager.IsCodeExist(customer))
            {
                MessageBox.Show(codeTextBox.Text + " Already Exists!");
                return;
            }
            customer.Customer_Address = addressTextBox.Text;
            customer.Customer_Contact = contactTextBox.Text;
            customer.Customer_LoyalityPoint = Convert.ToInt32(loyalityNumericUpDown.Text);
            
            //Checking Email UNIQUE
            customer.Customer_Email = emailTextBox.Text;
            if (_customerManager.IsCodeExist(customer))
            {
                MessageBox.Show(codeTextBox.Text + " Already Exists!");
                return;
            }
            if (_customerManager.AddCustomerInfo(customer))
            {
                MessageBox.Show("Category Save");
                showDataGridView.DataSource = _customerManager.Display();
            }
            else
            {
                MessageBox.Show("Category Not Save");
            }

        }

        private void CustomerUI_Load(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _customerManager.Display();
        }

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (showDataGridView.Columns[e.ColumnIndex].Name.Equals("Edit"))
            {
                int i;
                string button = "Update";
                i = showDataGridView.SelectedCells[0].RowIndex;
                codeTextBox.Text = showDataGridView.Rows[i].Cells[1].Value.ToString();
                nameTextBox.Text = showDataGridView.Rows[i].Cells[2].Value.ToString();
                addressTextBox.Text = showDataGridView.Rows[i].Cells[3].Value.ToString();
                emailTextBox.Text = showDataGridView.Rows[i].Cells[4].Value.ToString();
                contactTextBox.Text = showDataGridView.Rows[i].Cells[5].Value.ToString();
                loyalityNumericUpDown.Text = showDataGridView.Rows[i].Cells[6].Value.ToString();
                saveButton.Text = button;
            }
            
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            CatagoryUI catagoryUI = new CatagoryUI();
            catagoryUI.Show();
            Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            ProductUI productUI = new ProductUI();
            productUI.Show();
            Hide();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            SupplierUI supplierUI = new SupplierUI();
            supplierUI.Show();
            Hide();
        }
    }
}
