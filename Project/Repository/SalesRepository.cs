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
    public class SalesRepository
    {
        //Add Operation Method
        public int AddSales(Sales sales)
        {
            int isAdded = 0;
            // SQL connection 
            string connectionString = @"Server=DESKTOP-FJFQ4S2\SQLSERVER; DataBase=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //Sql Command

            string commandString = "INSERT INTO Sales(Customer_Name,Date,Customer_Loyality,GrandTotal) VALUES ('" + sales.Customer_Name + "','" + sales.Date + "','" + sales.Customer_Loyality + "','" + sales.GrandTotal + "');SELECT SCOPE_IDENTITY()";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            int isExecute = sqlCommand.ExecuteNonQuery();
            if (isExecute > 0)
            {
                isAdded = Convert.ToInt32(sqlCommand.ExecuteScalar());
            }
            else
            {
                //MessageBox.Show("Insertion Failed");
            }

            sqlConnection.Close();

            return isAdded;
        }

        //Add Operation Method
        public bool AddSalesItem(SalesItems salesItems)
        {
            bool isAdded = false;
            // SQL connection 
            string connectionString = @"Server=DESKTOP-FJFQ4S2\SQLSERVER; DataBase=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //Sql Command

            string commandString = "INSERT INTO SalesItems(Sales_Id,Product,Quantity,MRP,TotalMrp) VALUES ('" + salesItems.Sales_Id + "','" + salesItems.Product + "','" + salesItems.Quantity + "','" + salesItems.MRP+ "','" + salesItems.Total_MRP + "');SELECT SCOPE_IDENTITY()";
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

            return isAdded;
        }
        public List<Catagory> DisplayCategory()
        {
            //Connection
            string connectionString = @"Server=DESKTOP-FJFQ4S2\SQLSERVER; Database=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Category";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            //Open
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Catagory> catagories = new List<Catagory>();
            //int i = 1;
            while (sqlDataReader.Read())
            {
                Catagory catagorie = new Catagory();
                //catagorie.SL = i;
                catagorie.Id = Convert.ToInt32(sqlDataReader["Category_Id"]);
                //catagorie.Category_Code = sqlDataReader["Category_Code"].ToString();
                catagorie.Category_Name = sqlDataReader["Category_Name"].ToString();
                catagories.Add(catagorie);
                //i++;
            }
            sqlConnection.Close();
            return catagories;
        }

        public List<Customer> DisplayCustomer()
        {
            //Connection
            string connectionString = @"Server=DESKTOP-FJFQ4S2\SQLSERVER; Database=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Customer";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            //Open
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Customer> customers = new List<Customer>();
            while (sqlDataReader.Read())
            {
                Customer customer = new Customer();
                customer.Id = Convert.ToInt32(sqlDataReader["Customer_Id"]);
                customer.Customer_Name = sqlDataReader["Customer_Name"].ToString();
                customer.Customer_LoyalityPoint = Convert.ToInt32(sqlDataReader["Customer_Loyality"]);
                customers.Add(customer);
            }
            sqlConnection.Close();
            return customers;
        }

        public int DisplayCustomerLoylityPoint(string customerName)
        {
            //Connection
            string connectionString = @"Server=DESKTOP-FJFQ4S2\SQLSERVER; Database=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT Customer_Loyality FROM Customer where Customer_Name ='" + customerName + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            //Open
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Customer customer = new Customer();
            while (sqlDataReader.Read())
            {
                //Customer customer = new Customer();
                customer.Customer_LoyalityPoint = Convert.ToInt32(sqlDataReader["Customer_Loyality"]);
                //int loyalityPoint = customer.Customer_LoyalityPoint;  
            }
            sqlConnection.Close();
            return customer.Customer_LoyalityPoint;
        }
        public List<Product> DisplayProduct()
        {
            //Connection
            string connectionString = @"Server=DESKTOP-FJFQ4S2\SQLSERVER; Database=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Product";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            //Open
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Product> products = new List<Product>();
            while (sqlDataReader.Read())
            {
                Product product = new Product();
                product.Product_Id = Convert.ToInt32(sqlDataReader["Product_Id"]);
                product.Product_Name = sqlDataReader["Product_Name"].ToString();
                products.Add(product);
            }
            sqlConnection.Close();
            return products;

        }
        public List<Product> DisplayProductByCategoryID(string catagory)
        {
            //Connection
            string connectionString = @"Server=DESKTOP-FJFQ4S2\SQLSERVER; Database=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Product where Product_Category ='" + catagory + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            //Open
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Product> products = new List<Product>();
            while (sqlDataReader.Read())
            {
                Product product = new Product();
                product.Product_Id = Convert.ToInt32(sqlDataReader["Product_Id"]);
                product.Product_Name = sqlDataReader["Product_Name"].ToString();
                products.Add(product);
            }
            sqlConnection.Close();
            return products;

        }
    }
}
