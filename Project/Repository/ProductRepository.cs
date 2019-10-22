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
        public bool AddProductInfo(Product product)
        {
            bool isAdded = false; 
           // SQL connection 
                string connectionString = @"Server=PC-301-05\SQLEXPRESS; Database=ProjectDB; Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                //Sql Command

                string commandString = "INSERT INTO Product(Product_Code,Product_Name,Product_Category,Product_RecordedLevel,Product_Description) VALUES ('" + product.Product_Code + "','" + product.Product_Name + "','" + product.Product_Category + "','" + product.Product_RecordedLevel + "','" + product.Product_Description + "')";
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

        public bool IsNameExists(Product product)
        {
            bool exists = false;
            //Connection
            string connectionString = @"Server=PC-301-05\SQLEXPRESS; Database=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Product WHERE Product_Name ='" + product.Product_Name + "'";
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

        public bool IsCodeExist(Product product)
        {
            bool exists = false;
            //Connection
            string connectionString = @"Server=PC-301-05\SQLEXPRESS; Database=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Product WHERE Product_Code ='" + product.Product_Code + "'";
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
        public List<Catagory> Display()
        {
            //Connection
            string connectionString = @"Server=PC-301-05\SQLEXPRESS; Database=ProjectDB; Integrated Security=True";
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
                catagorie.Id = Convert.ToInt32(sqlDataReader["Catergory_Id"]);
                //catagorie.Category_Code = sqlDataReader["Category_Code"].ToString();
                catagorie.Category_Name = sqlDataReader["Category_Name"].ToString();
                catagories.Add(catagorie);
                //i++;
            }
            sqlConnection.Close();
            return catagories;
        }

        public List<Product> DisplayProduct()
        {
            //Connection
            string connectionString = @"Server=PC-301-05\SQLEXPRESS; Database=ProjectDB; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            //Command 
            //INSERT INTO Items (Name, Price) Values ('Black', 120)
            string commandString = @"SELECT * FROM Product";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            //Open
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            List<Product> products = new List<Product>();
            int i = 1;
            while (sqlDataReader.Read())
            {
                Product product = new Product();
                product.SL = i;
                product.Product_Id = Convert.ToInt32(sqlDataReader["Product_Id"]);
                product.Product_Category = sqlDataReader["Product_Category"].ToString();
                product.Product_Code = sqlDataReader["Product_Code"].ToString();
                product.Product_Name = sqlDataReader["Product_Name"].ToString();
                product.Product_RecordedLevel = sqlDataReader["Product_RecordedLevel"].ToString();
                product.Product_Description = sqlDataReader["Product_Description"].ToString();
                products.Add(product);
                i++;
            }
            sqlConnection.Close();
            return products;

        }
    }
}
