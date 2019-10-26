using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Project.Model;
namespace Project.Repository
{
    class SalesReportRepository
    {

        public List<SalesItems> DisplayProfit(SalesReport salesReport)
        {
            //Connection
            string connectionString = @"Server=DESKTOP-FJFQ4S2\SQLSERVER; Database=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT Product,Date,Quantity,MRP,SUM(MRP - 100) AS Profit FROM SalesItems inner join Sales on Sales.Sales_Id = SalesItems.Sales_Id Where Date Between '" + salesReport.SrartDate + "' AND '" + salesReport.EndDate + "' GROUP BY Product,Date,Quantity,MRP";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            //Open
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<SalesItems> salesItems = new List<SalesItems>();
            while (sqlDataReader.Read())
            {
                SalesItems sales = new SalesItems();
                sales.MRP = Convert.ToInt32(sqlDataReader["MRP"]);
                sales.Product = sqlDataReader["Product"].ToString();
                sales.Quantity = Convert.ToInt32(sqlDataReader["Quantity"]);
                salesItems.Add(sales);
            }
            sqlConnection.Close();
            return salesItems;
        }
    }
}
