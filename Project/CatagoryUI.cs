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
using Project.Model;
using Project.BLL;

namespace Project
{
    public partial class CatagoryUI : Form
    {
        CatagoryManager _catagoryManager = new CatagoryManager();
        Catagory catagory = new Catagory();
        public CatagoryUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //Checking Name UNIQUE
            catagory.Category_Name = nameTextBox.Text;
            if (_catagoryManager.IsNameExists(catagory))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exists!");
                return;
            }

            //Checking Code UNIQUE
            catagory.Category_Code = codeTextBox.Text;
            if (_catagoryManager.IsCodeExist(catagory))
            {
                MessageBox.Show(codeTextBox.Text + " Already Exists!");
                return;
            }

            if (_catagoryManager.AddCustomerInfo(catagory))
            {
                MessageBox.Show("Category Save");
                showDataGridView.DataSource = _catagoryManager.Display();
            }
            else
            {
                MessageBox.Show("Category Not Save");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void homeButton_Click(object sender, EventArgs e)
        {

        }

        private void logoutButton_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {

        }

        private void forwardButton_Click(object sender, EventArgs e)
        {

        }

        private void CatagoryUI_Load(object sender, EventArgs e)
        {
            showDataGridView.DataSource = _catagoryManager.Display();
        }
    }
}
