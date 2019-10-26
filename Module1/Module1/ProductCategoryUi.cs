using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Module1.Model;
using Module1.BLL;

namespace Module1
{
    public partial class ProductCategoryUi : Form
    {
        public ProductCategoryUi()
        {
            InitializeComponent();
        }

        private void ProductCategoryUi_Load(object sender, EventArgs e)
        {
            //int sr = 1;
            displayDataGridView.DataSource = _categoryManager.ShowAllInformation();
            //foreach (DataGridView row  in displayDataGridView.Rows)
            //{
            //    row.Cells["SL"].Value = sr++;
            //}

        }
        CategoryModel categoryModel = new CategoryModel();
        CategoryManager _categoryManager = new CategoryManager();
        private void saveButton_Click(object sender, EventArgs e)
        
            {
                if (String.IsNullOrEmpty(codeTextBox.Text))
                {
                    MessageBox.Show("Code Cant Be Empty");
                    return;
                }

                if (String.IsNullOrEmpty(nameTextBox.Text))
                {
                    MessageBox.Show("Name Cant Be Empty");
                    return;
                }

                if (codeTextBox.Text.Length != 4)
                {
                    MessageBox.Show("Code Lenght Must be 4");
                    return;
                }

                


                categoryModel.Code = codeTextBox.Text;
                categoryModel.Name = nameTextBox.Text;
                if (_categoryManager.IsCodeExist(categoryModel))
                {
                    MessageBox.Show("Code is Exist");
                    return;
                }

                if (_categoryManager.IsNameExist(categoryModel))
                {
                    MessageBox.Show("Name is Exist");
                    return;
                }


                if (codeTextBox.Text.Length == 4)
                {


                    if (_categoryManager.SaveData(categoryModel))
                    {
                        MessageBox.Show("save");
                        displayDataGridView.DataSource = _categoryManager.ShowAllInformation();
                      
                    }
                        
                 }

                //if (saveButton.Text == "Update")
                //{
                //    bool isUpadte = _categoryManager.UpdateInformation(categoryModel);
                //    if (isUpadte)
                //    {
                //        MessageBox.Show("Data Updated");
                //    }
                //    else
                //    {
                //        MessageBox.Show("Data Not Update");
                //    }
                //    displayDataGridView.DataSource = _categoryManager.ShowAllInformation();
                //}

              


            }

        private void serachCodeButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(codeTextBox.Text))
            {
                MessageBox.Show("Code Box is empty");
                return;
            }
            else
            {
                categoryModel.Code = codeTextBox.Text;
                //  MessageBox.Show("Code Match");
                displayDataGridView.DataSource = _categoryManager.SeachInformation(categoryModel);
            }
        }

        private void searchNameButton_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Code Box is empty");
                return;
            }
            else
            {
                categoryModel.Name = nameTextBox.Text;
                // MessageBox.Show("Name Match");
                displayDataGridView.DataSource = _categoryManager.SearchName(categoryModel);
            }
        }

        private void displayDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            displayDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void displayDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (displayDataGridView.Columns[e.ColumnIndex].Name == "EDIT")
            {
                 int  i = e.RowIndex;
                DataGridViewRow row = displayDataGridView.Rows[i];
                idTextBox.Text = row.Cells[1].Value.ToString();
                codeTextBox.Text= row.Cells[2].Value.ToString();
                nameTextBox.Text = row.Cells[3].Value.ToString();
                updateButton.Visible = true;





            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

                  categoryModel.Id =Convert.ToInt16(idTextBox.Text);
                  categoryModel.Code = codeTextBox.Text;
                  categoryModel.Name = nameTextBox.Text;
               //bool isUpadte = _categoryManager.UpdateInformation(categoryModel);
                if (_categoryManager.UpdateInformation(categoryModel))
                {
                    MessageBox.Show("Data Updated");
                }
                else
                {
                    MessageBox.Show("Data Not Update");
                }
                displayDataGridView.DataSource = _categoryManager.ShowAllInformation();
                updateButton.Visible = false;

        }
            }

        

       

        }

