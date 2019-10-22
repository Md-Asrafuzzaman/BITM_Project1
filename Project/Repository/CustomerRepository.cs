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
    public class CustomerRepository
    {
        public bool AddCustomerInfo(Customer customer)
        {
            bool isAdded = false;
            // SQL connection 
            string connectionString = @"Server=DESKTOP-FJFQ4S2\SQLSERVER; DataBase=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //Sql Command

            string commandString = "INSERT INTO Customer(Customer_Code,Customer_Name,Customer_Address,Customer_Email,Customer_Contact,Customer_Loyality) VALUES ('" + customer.Customer_Code + "','" + customer.Customer_Name + "','" + customer.Customer_Address + "','" + customer.Customer_Email + "','" + customer.Customer_Contact + "','" + customer.Customer_LoyalityPoint + "')";
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
        public bool IsNameExists(Customer name)
        {
            bool exists = false;
            //Connection
            string connectionString = @"Server=DESKTOP-FJFQ4S2\SQLSERVER; DataBase=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Customer WHERE Customer_Name ='" + name.Customer_Name + "'";
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
        public bool IsCodeExist(Customer id)
        {
            bool exists = false;
            //Connection
            string connectionString = @"Server=DESKTOP-FJFQ4S2\SQLSERVER; DataBase=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Customer WHERE Customer_Code ='" + id.Customer_Code + "'";
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
        public bool IsEmailExist(Customer email)
        {
            bool exists = false;
            //Connection
            string connectionString = @"Server=DESKTOP-FJFQ4S2\SQLSERVER; DataBase=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Customer WHERE Customer_Email ='" + email.Customer_Email + "'";
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
        public List<Customer> Display()
        {
            //Connection
            string connectionString = @"Server=DESKTOP-FJFQ4S2\SQLSERVER; DataBase=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Customer";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            //Open
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Customer> customers = new List<Customer>();
            int i = 1;
            while (sqlDataReader.Read())
            {
                Customer customer = new Customer();
                customer.SL = i;
                customer.Id = Convert.ToInt32(sqlDataReader["Customer_Id"]);
                customer.Customer_Code = sqlDataReader["Customer_Code"].ToString();
                customer.Customer_Name = sqlDataReader["Customer_Name"].ToString();
                customer.Customer_Address = sqlDataReader["Customer_Address"].ToString();
                customer.Customer_Email = sqlDataReader["Customer_Email"].ToString();
                customer.Customer_Contact = sqlDataReader["Customer_Contact"].ToString();
                customer.Customer_LoyalityPoint = Convert.ToInt32(sqlDataReader["Customer_Loyality"]);
                customers.Add(customer);
                i++;
            }
            sqlConnection.Close();
            return customers;

        }
    }
}
