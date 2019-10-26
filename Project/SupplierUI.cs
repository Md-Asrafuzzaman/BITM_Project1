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
    public partial class SupplierUI : Form
    {
        SupplierManager _supplierManager = new SupplierManager();
        Supplier supplier=new Supplier();

        public SupplierUI()
        {
            InitializeComponent();
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {
            PurchaseUI purchaseUI = new PurchaseUI();
            purchaseUI.Show();
            Hide();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Checking Name UNIQUE
            supplier.Supplier_Name = nameTextBox.Text;
            if (_supplierManager.IsNameExists(supplier))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exists!");
                return;
            }

            //Checking Code UNIQUE

            supplier.Supplier_Code = codeTextBox.Text;
            if (_supplierManager.IsCodeExist(supplier))
            {
                MessageBox.Show(codeTextBox.Text + " Already Exists!");
                return;
            }
            supplier.Supplier_Address = addressTextBox.Text;
            supplier.Supplier_Contact = contactTextBox.Text;
            supplier.Contact_Person = Convert.ToInt32(contactPersonTextBox.Text);

            //Checking Email UNIQUE
            supplier.Supplier_Email = emailTextBox.Text;
            if (_supplierManager.IsCodeExist(supplier))
            {
                MessageBox.Show(codeTextBox.Text + " Already Exists!");
                return;
            }
            if (_supplierManager.AddSupplierInfo(supplier))
            {
                MessageBox.Show("Supplier Save");
                showDataGridView.DataSource = _supplierManager.Display();
            }
            else
            {
                MessageBox.Show("Supplier Not Save");
            }

        }

        private void SupplierUI_Load(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _supplierManager.Display();
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
                contactPersonTextBox.Text = showDataGridView.Rows[i].Cells[6].Value.ToString();
                saveButton.Text = button;
            }

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            CatagoryUI catagoryUI = new CatagoryUI();
            catagoryUI.Show();
            Hide();
        }
    }
  
}
