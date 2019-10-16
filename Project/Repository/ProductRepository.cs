using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Project;
using Project.Model;

namespace Project.Repository
{
   public class ProductRepository
    {
        //Add Operation Method
        public bool AddProductInfo(string catagory, string name, string code, string recordedLevel, string description)
        {
            bool isAdded = false;
            try
            { // SQL connection 
                string connectionString = @"Server=PC-301-05\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //Sql Command

                string commandString = "INSERT INTO Customer(CustomerName,CustomerAddress,CustomerContact) VALUES ('" + catagory + "','" + name + "','" + code + "','" + recordedLevel + "','" + description + "')";
                SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

                sqlConnection.Open();
                int isExecute = sqlCommand.ExecuteNonQuery();
                if (isExecute > 0)
                {
                    isAdded = true;
                }
                else
                {
                    //MessageBox.Show("Insertion Failed");
                }

                sqlConnection.Close();
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message);
            }
            return isAdded;
        }

        public bool IsNameExists(Product name)
        {
            bool exists = false;
            //Connection
            string connectionString = @"Server=PC-301-05\SQLEXPRESS; Database=CoffeeShop; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Product WHERE ProductName ='" + name + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();
            //Show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                exists = true;
            }
            //Close
            sqlConnection.Close();

            return exists;
        }

        public bool IsCodeExist(Product name)
        {
            bool exists = false;
            //Connection
            string connectionString = @"Server=PC-301-05\SQLEXPRESS; Database=Project; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Product WHERE ProductName ='" + name + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();
            //Show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                exists = true;
            }
            //Close
            sqlConnection.Close();

            return exists;
        }
    }
}
