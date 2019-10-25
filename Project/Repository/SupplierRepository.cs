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
     public class SupplierRepository
    {
        public bool AddSupplierInfo(Supplier supplier)
        {
            bool isAdded = false;
            // SQL connection 
            string connectionString = @"Server=localhost; DataBase=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //Sql Command

            string commandString = "INSERT INTO Customer(Supplier_Code,Supplier_Name,Customer_Address,Supplierr_Email,Supplier_Contact,Contact_Person) VALUES ('" + supplier.Supplier_Code + "','" + supplier.Supplier_Name + "','" + supplier.Supplier_Address + "','" + supplier.Supplier_Email + "','" + supplier.Supplier_Contact + "','" + supplier.Contact_Person + "')";
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
        public bool IsNameExists(Supplier name)
        {
            bool exists = false;
            //Connection
            string connectionString = @"Server=localhost; DataBase=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Supplier WHERE Customer_Name ='" + name.Supplier_Name + "'";
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
        public bool IsCodeExist(Supplier id)
        {
            bool exists = false;
            //Connection
            string connectionString = @"Server=localhost; DataBase=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Supplier WHERE Supplier_Code ='" + id.Supplier_Code + "'";
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
        public bool IsEmailExist(Supplier email)
        {
            bool exists = false;
            //Connection
            string connectionString = @"Server=localhost; DataBase=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Supplier WHERE Supplier_Email ='" + email.Supplier_Email + "'";
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
        public List<Supplier> Display()
        {
            //Connection
            string connectionString = @"Server=localhost; DataBase=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Supplier";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            //Open
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Supplier> suppliers = new List<Supplier>();
            int i = 1;
            while (sqlDataReader.Read())
            {
                Supplier supplier = new Supplier();
                supplier.SL = i;
                supplier.Id = Convert.ToInt32(sqlDataReader["Supplier_Id"]);
                supplier.Supplier_Code = sqlDataReader["Supplier_Code"].ToString();
                supplier.Supplier_Name = sqlDataReader["Supplier_Name"].ToString();
                supplier.Supplier_Address = sqlDataReader["Supplier_Address"].ToString();
                supplier.Supplier_Email = sqlDataReader["Supplier_Email"].ToString();
                supplier.Supplier_Contact = sqlDataReader["Supplier_Contact"].ToString();
                supplier.Contact_Person = Convert.ToInt32(sqlDataReader["Contact_Person"]);
                suppliers.Add(supplier);
                i++;
            }
            sqlConnection.Close();
            return suppliers;

        }
    }
}
