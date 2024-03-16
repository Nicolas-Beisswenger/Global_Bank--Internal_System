using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Global_Bank___Internal_System
{
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        Database.Database_connection database_connection_instance = new Database.Database_connection();
        Forms.Principal_Form principal_form_instance = new Forms.Principal_Form();
        Forms.ForgotPassword_Form forgotpassword_form_instance = new Forms.ForgotPassword_Form();

        private void login_button_login_Click(object sender, EventArgs e)
        {
            bool user_exist = database_connection_instance.user_existence_verification(login_textbox_username.Text, login_textbox_password.Text);
            
            if (user_exist == true)
            {
                //MessageBox.Show("Ingreso exitoso");

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario no encontrado");
            }
            
        }

        private void login_button_forgotpassword_Click(object sender, EventArgs e)
        {
            forgotpassword_form_instance.Show();
            this.Close();
        }
    }
}
