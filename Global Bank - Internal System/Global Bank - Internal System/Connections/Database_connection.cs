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


        #region Login
        public bool login_user_existence_verification(string userid, string password)
        {
            bool userExists = false;
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection_String))
                {
                    sqlConnection.Open();
                    if (sqlConnection.State == System.Data.ConnectionState.Open)
                    {
                        string query = "SELECT id_number, first_name, last_name, email, fk_rol_id FROM User_Employees WHERE id_number = @UserId COLLATE Latin1_General_CS_AS AND password = @Password COLLATE Latin1_General_CS_AS";
                        SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@UserId", userid);
                        sqlCommand.Parameters.AddWithValue("@Password", password);
                        SqlDataReader reader = sqlCommand.ExecuteReader();
                        
                        if (reader.HasRows)
                        {
                            userExists = true;
                            while (reader.Read())
                            {
                                Connections.Instances.fast_information_instance.User_id = reader.GetString(0);
                                Connections.Instances.fast_information_instance.User_name = reader.GetString(1);
                                Connections.Instances.fast_information_instance.User_first_lastname = reader.GetString(2);
                                Connections.Instances.fast_information_instance.User_email = reader.GetString(3);
                                Connections.Instances.fast_information_instance.User_rol = reader.GetString(4);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Usuario no encontrado.");
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
                MessageBox.Show("Unexpected error \nPlease contact for support");
            }
            return userExists;
        }

        #endregion


        #region New User

        public string[] humanresources_get_offices()
        {
            List<string> offices_list = new List<string>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection_String))
                {
                    string query = "SELECT name FROM Offices";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        offices_list.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error \nPlease contact for support");
            }
            return offices_list.ToArray();
        }

        public string[] humanresources_get_roles()
        {
            List<string> roles_list = new List<string>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connection_String))
                {
                    string query = "SELECT name FROM Roles";
                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    sqlConnection.Open();
                    SqlDataReader reader = sqlCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        roles_list.Add(reader.GetString(0));
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected error \nPlease contact for support");
            }
            return roles_list.ToArray();
        }

        public string humanresources_insert_newuser(string id, string firstname, string lastname, string secondlastname, string email, string password, string phonenumber, string secondphonenumber, string birthday_day, string birthday_month, string birthday_year, string office, string rol)
        {
            /*
            PrincipalPanel_TextBox_HumanResources_NewUser_Id.Text = "";
            PrincipalPanel_TextBox_HumanResources_NewUser_FirstName.Text = "";
            PrincipalPanel_TextBox_HumanResources_NewUser_LastName.Text = "";
            PrincipalPanel_TextBox_HumanResources_NewUser_SecondLastName.Text = "";
            PrincipalPanel_TextBox_HumanResources_NewUser_Email.Text = "";
            PrincipalPanel_TextBox_HumanResources_NewUser_Password.Text = "";
            PrincipalPanel_TextBox_HumanResources_NewUser_PhoneNumber.Text = "";
            PrincipalPanel_TextBox_HumanResources_NewUser_SecondPhoneNumber.Text = "";
            //PrincipalPanel_TextBox_HumanResources_NewUser_BirthdayDay = "Day";
            PrincipalPanel_TextBox_HumanResources_NewUser_BirthdayMonth.Items.AddRange(birthday_months_options);
            //PrincipalPanel_ComboBox_HumanResources_NewUser_BirthdayMonth
            //PrincipalPanel_TextBox_HumanResources_NewUser_BirthdayYear = "Year";
            PrincipalPanel_ComboBox_HumanResources_NewUser_Office.Items.AddRange(offices_options);
            PrincipalPanel_ComboBox_HumanResources_NewUser_Rol.Items.AddRange(roles_options); 
            */

            return;
        }
        #endregion





    }
}
