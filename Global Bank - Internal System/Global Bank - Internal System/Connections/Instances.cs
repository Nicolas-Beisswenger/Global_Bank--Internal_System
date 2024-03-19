using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global_Bank___Internal_System.Connections
{
    internal class Instances
    {
        public static Database.Database_connection database_connection_instance { get; } = new Database.Database_connection();
        public static Database.Fast_Information fast_information_instance { get; } = new Database.Fast_Information();
        public static Forms.Principal_Form principal_form_instance { get; } = new Forms.Principal_Form();
        public static Forms.ForgotPassword_Form forgotpassword_form_instance { get; } = new Forms.ForgotPassword_Form();  
    }
}
