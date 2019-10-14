using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using BMS_Final.Model;

namespace BMS_Final.Repository
{
    class CategoryRepository
    {
        public bool SaveInfo(Category _category)
        {
            string connectionString = @"Server=BRINTA-PC; Database=BMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"insert into Category values('"+_category.Code+"','"+_category.Name+"')";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            int isSaved = sqlCommand.ExecuteNonQuery();
            if (isSaved>0)
            {
                return true;
            }
            sqlConnection.Close();
            return false;
        }

        public List<Category> ShowCategories(Category _category)
        {
            List<Category> categories=new List<Category>();
            string connectionString = @"Server=BRINTA-PC; Database=BMS; Integrated Security=True";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            string commandString = @"select * from Category";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                Category category=new Category();
                category.Code = sqlDataReader["Code"].ToString();
                category.Name = sqlDataReader["Name"].ToString();
                categories.Add(category);
            }
            sqlConnection.Close();
            return categories;

        }
    }
}
