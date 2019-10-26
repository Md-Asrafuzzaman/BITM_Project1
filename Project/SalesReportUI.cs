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
    public partial class SalesReportUI : Form
    {
        public SalesReportUI()
        {
            InitializeComponent();
        }
        SalesReportManager _salesReportManager = new SalesReportManager();
        SalesReport salesReport = new SalesReport();
        private void searchButton_Click(object sender, EventArgs e)
        {
            salesReport.SrartDate = startDateTimePicker.Text;
            salesReport.EndDate = endDateTimePicker.Text;
           showDataGridView.DataSource = _salesReportManager.DisplayProfit(salesReport);
        }
    }
}
