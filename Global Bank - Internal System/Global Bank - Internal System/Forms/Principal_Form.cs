using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Global_Bank___Internal_System.Forms
{
    public partial class Principal_Form : Form
    {

        public Principal_Form()
        {
            InitializeComponent();
        }


        public void display_options()
        {
            string rol = Connections.Instances.fast_information_instance.User_rol;

            switch (rol)
            {
                case "HRS_8246":
                    PrincipalPanel_Panel_HumanResources_Options.Visible = true;
                    break;
            }
        }

        private void PrincipalForm_Button_NewUser_Click(object sender, EventArgs e)
        {
            PrincipalPanel_Panel_HumanResources_NewUser.Visible = true;


            string[] birthday_months_options = { "Month", "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December", };
            string[] offices_options = Connections.Instances.database_connection_instance.humanresources_get_offices().ToArray();
            string[] roles_options = Connections.Instances.database_connection_instance.humanresources_get_roles().ToArray();

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


            PrincipalPanel_Panel_HumanResources_NewUser.Visible = true;
        }

        private void PrincipalPanel_Button_HumanResources_NewUser_CreateNewUser_Click(object sender, EventArgs e)
        {
            MessageBox.Show(PrincipalPanel_ComboBox_HumanResources_NewUser_Office.Text);
            /*Connections.Instances.database_connection_instance.humanresources_insert_newuser(
                PrincipalPanel_TextBox_HumanResources_NewUser_Id.Text,
                PrincipalPanel_TextBox_HumanResources_NewUser_FirstName.Text,
                PrincipalPanel_TextBox_HumanResources_NewUser_LastName.Text,
                PrincipalPanel_TextBox_HumanResources_NewUser_SecondLastName.Text,
                PrincipalPanel_TextBox_HumanResources_NewUser_Email.Text,
                PrincipalPanel_TextBox_HumanResources_NewUser_Password.Text,
                PrincipalPanel_TextBox_HumanResources_NewUser_PhoneNumber.Text,
                PrincipalPanel_TextBox_HumanResources_NewUser_SecondPhoneNumber.Text,
                PrincipalPanel_TextBox_HumanResources_NewUser_BirthdayDay.Text,
                PrincipalPanel_TextBox_HumanResources_NewUser_BirthdayMonth.Text,
                PrincipalPanel_TextBox_HumanResources_NewUser_BirthdayYear.Text,
                PrincipalPanel_ComboBox_HumanResources_NewUser_Office.Text,
                PrincipalPanel_ComboBox_HumanResources_NewUser_Rol.Text
                );*/
        }
    }
}
