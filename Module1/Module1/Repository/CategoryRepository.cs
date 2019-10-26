using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Module1.Model;

namespace Module1.Repository
{
    public class CategoryRepository
    {


        public DataTable ShowAllInformation()
        {


            string connectionString = @"Server=DESKTOP-QREDJ0M; Database=Module1; Integrated Security=True";
            SqlConnection sqlConncetion = new SqlConnection(connectionString);

            //Command 

            string commandString = @"SELECT * FROM ProductCategorys";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConncetion);



            sqlConncetion.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            //show

            sqlConncetion.Close();
            return dataTable;




        }

        public bool SaveData(CategoryModel categoryModel)
        {

            string conncetionString = @"Server=DESKTOP-QREDJ0M; DATABASE=Module1; Integrated Security=TRUE";
            SqlConnection sqlConnection = new SqlConnection(conncetionString);

            //sqlquery
            string commandString = @"INSERT INTO ProductCategorys(Code,Name) VALUES('" + categoryModel.Code + "','" +
                                   categoryModel.Name + "')";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Excution
            sqlConnection.Open();

            int isExcuted = sqlCommand.ExecuteNonQuery();
            if (isExcuted > 0)
            {
                return true;
            }


            sqlConnection.Close();
            return false;
        }


        public bool IsCodeExist(CategoryModel categoryModel)
        {

            //Connection
            string connectionString = @"Server=DESKTOP-QREDJ0M; Database=Module1; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 

            string commandString = @"SELECT * FROM ProductCategorys WHERE Code='" + categoryModel.Code + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();
            //Show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }

            //Close
            sqlConnection.Close();


            return false;
        }


        public bool IsNameExist(CategoryModel categoryModel)
        {

            //Connection
            string connectionString = @"Server=DESKTOP-QREDJ0M; Database=Module1; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            //Command 

            string commandString = @"SELECT * FROM ProductCategorys WHERE Name='" + categoryModel.Name + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            //Open
            sqlConnection.Open();
            //Show
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            if (dataTable.Rows.Count > 0)
            {
                return true;
            }

            //Close
            sqlConnection.Close();


            return false;
        }

        public DataTable SeachInformation(CategoryModel categoryModel)
        {


            string connectionString = @"Server=DESKTOP-QREDJ0M; Database=Module1; Integrated Security=True";
            SqlConnection sqlConncetion = new SqlConnection(connectionString);

            //Command 

            string commandString = @"SELECT * FROM ProductCategorys WHERE Code='" + categoryModel.Code + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConncetion);

            sqlConncetion.Open();
            SqlDataAdapter sqlDataAdapater = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapater.Fill(dataTable);

           



            sqlConncetion.Close();
            return dataTable;

        }



        public bool UpdateInformation(CategoryModel categoryModel)
        {

            //conncetion
            string connectionString = @"Server=DESKTOP-QREDJ0M; Database=Module1; Integrated Security=True";
            SqlConnection sqlConncetion = new SqlConnection(connectionString);

            //command
            string command = "UPDATE ProductCategorys  SET Code='"+categoryModel.Code+ "',Name='"+categoryModel.Name+"' WHERE Id='"+categoryModel.Id +"' ";
            SqlCommand sqlCommand = new SqlCommand(command, sqlConncetion);

            //Exute
            sqlConncetion.Open();
            int isExcuted = sqlCommand.ExecuteNonQuery();
            if (isExcuted > 0)
            {
                return true;

            }
            sqlConncetion.Close();
            return false;

        }

        public DataTable SearchName(CategoryModel categoryModel)
        {


            string connectionString = @"Server=DESKTOP-QREDJ0M; Database=Module1; Integrated Security=True";
            SqlConnection sqlConncetion = new SqlConnection(connectionString);

            //Command 

            string commandString = @"SELECT * FROM ProductCategorys WHERE Name='" + categoryModel.Name + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConncetion);

            sqlConncetion.Open();
            SqlDataAdapter sqlDataAdapater = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapater.Fill(dataTable);





            sqlConncetion.Close();
            return dataTable;

        }












}
}
