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

        private void Login_Button_Login_Click(object sender, EventArgs e)
        {
            bool user_exist = Connections.Instances.database_connection_instance.login_user_existence_verification(Login_TextBox_UserId.Text, Login_TextBox_Password.Text);
            if (user_exist == true)
            {
                Connections.Instances.principal_form_instance.display_options();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                Login_TextBox_UserId.Text = "";
                Login_TextBox_Password.Text = "";
                MessageBox.Show("Incorrect information");
            } 
        }

        private void Login_Button_ForgotPassword_Click(object sender, EventArgs e)
        {
            //forgotpassword_form_instance.Show();
            this.Close();
        }
    }
}
