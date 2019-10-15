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
            catagory.Name = nameTextBox.Text;
            if (_catagoryManager.IsNameExists(catagory))
            {
                MessageBox.Show(nameTextBox.Text + " Already Exists!");
                return;
            }

            //Checking Code UNIQUE
            catagory.Code = codeTextBox.Text;
            if (_catagoryManager.IsCodeExist(catagory))
            {
                MessageBox.Show(codeTextBox.Text + " Already Exists!");
                return;
            }
        }
    }
}
