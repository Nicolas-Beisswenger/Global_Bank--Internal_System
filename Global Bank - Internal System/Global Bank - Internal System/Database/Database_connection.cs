using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Global_Bank___Internal_System.Database
{
    public class Database_connection
    {

        public string connection_String = "Data Source=DESKTOP-VJJ88KN\\SQLEXPRESS;Initial Catalog=" + "Global Bank - DB" + ";Integrated Security=True";

        #region Select's
            public bool user_existence_verification(string username, string password)
            {
                bool userExists = false;

                try
                {
                    using (SqlConnection sqlConnection = new SqlConnection(connection_String))
                    {
                        sqlConnection.Open();
                        if (sqlConnection.State == System.Data.ConnectionState.Open)
                        {
                            string query = "SELECT COUNT(*) FROM users_employees WHERE first_name = @Username COLLATE Latin1_General_CS_AS AND password = @Password COLLATE Latin1_General_CS_AS";
                            SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                            sqlCommand.Parameters.AddWithValue("@Username", username);
                            sqlCommand.Parameters.AddWithValue("@Password", password);
                            object result = sqlCommand.ExecuteScalar();
                            if (result != null && Convert.ToInt32(result) > 0)
                            {
                                userExists = true;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                return userExists;
            }

        #endregion


        #region Insert's

        #endregion





    }
}
