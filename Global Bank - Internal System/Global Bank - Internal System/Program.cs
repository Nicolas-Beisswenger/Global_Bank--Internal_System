using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Global_Bank___Internal_System
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Login_Form()); //Original and defult version
            Application.Run(new Forms.Principal_Form()); //Original and defult version

            /*Login_Form login_Form = new Login_Form();
            Forms.Principal_Form principal_form_instance = new Forms.Principal_Form();

            if (login_Form.ShowDialog() == DialogResult.OK)
            {
                Application.Run(principal_form_instance);
            }*/
        }
    }
}
