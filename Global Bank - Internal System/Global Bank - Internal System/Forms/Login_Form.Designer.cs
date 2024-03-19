namespace Global_Bank___Internal_System
{
    partial class Login_Form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Login_Label_UserId = new System.Windows.Forms.Label();
            this.login_label_password = new System.Windows.Forms.Label();
            this.Login_TextBox_UserId = new System.Windows.Forms.TextBox();
            this.Login_TextBox_Password = new System.Windows.Forms.TextBox();
            this.Login_Button_Login = new System.Windows.Forms.Button();
            this.Login_Button_ForgotPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login_Label_UserId
            // 
            this.Login_Label_UserId.AutoSize = true;
            this.Login_Label_UserId.Location = new System.Drawing.Point(188, 124);
            this.Login_Label_UserId.Name = "Login_Label_UserId";
            this.Login_Label_UserId.Size = new System.Drawing.Size(43, 13);
            this.Login_Label_UserId.TabIndex = 0;
            this.Login_Label_UserId.Text = "User ID";
            // 
            // login_label_password
            // 
            this.login_label_password.AutoSize = true;
            this.login_label_password.Location = new System.Drawing.Point(191, 194);
            this.login_label_password.Name = "login_label_password";
            this.login_label_password.Size = new System.Drawing.Size(53, 13);
            this.login_label_password.TabIndex = 1;
            this.login_label_password.Text = "Password";
            // 
            // Login_TextBox_UserId
            // 
            this.Login_TextBox_UserId.Location = new System.Drawing.Point(250, 124);
            this.Login_TextBox_UserId.Name = "Login_TextBox_UserId";
            this.Login_TextBox_UserId.Size = new System.Drawing.Size(100, 20);
            this.Login_TextBox_UserId.TabIndex = 2;
            // 
            // Login_TextBox_Password
            // 
            this.Login_TextBox_Password.Location = new System.Drawing.Point(251, 194);
            this.Login_TextBox_Password.Name = "Login_TextBox_Password";
            this.Login_TextBox_Password.Size = new System.Drawing.Size(100, 20);
            this.Login_TextBox_Password.TabIndex = 3;
            // 
            // Login_Button_Login
            // 
            this.Login_Button_Login.Location = new System.Drawing.Point(194, 247);
            this.Login_Button_Login.Name = "Login_Button_Login";
            this.Login_Button_Login.Size = new System.Drawing.Size(156, 23);
            this.Login_Button_Login.TabIndex = 4;
            this.Login_Button_Login.Text = "Login";
            this.Login_Button_Login.UseVisualStyleBackColor = true;
            this.Login_Button_Login.Click += new System.EventHandler(this.Login_Button_Login_Click);
            // 
            // Login_Button_ForgotPassword
            // 
            this.Login_Button_ForgotPassword.Location = new System.Drawing.Point(194, 314);
            this.Login_Button_ForgotPassword.Name = "Login_Button_ForgotPassword";
            this.Login_Button_ForgotPassword.Size = new System.Drawing.Size(157, 23);
            this.Login_Button_ForgotPassword.TabIndex = 5;
            this.Login_Button_ForgotPassword.Text = "Forgot password";
            this.Login_Button_ForgotPassword.UseVisualStyleBackColor = true;
            this.Login_Button_ForgotPassword.Click += new System.EventHandler(this.Login_Button_ForgotPassword_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login_Button_ForgotPassword);
            this.Controls.Add(this.Login_Button_Login);
            this.Controls.Add(this.Login_TextBox_Password);
            this.Controls.Add(this.Login_TextBox_UserId);
            this.Controls.Add(this.login_label_password);
            this.Controls.Add(this.Login_Label_UserId);
            this.Name = "Login_Form";
            this.Text = "Global Bank - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login_Label_UserId;
        private System.Windows.Forms.Label login_label_password;
        private System.Windows.Forms.TextBox Login_TextBox_UserId;
        private System.Windows.Forms.TextBox Login_TextBox_Password;
        private System.Windows.Forms.Button Login_Button_Login;
        private System.Windows.Forms.Button Login_Button_ForgotPassword;
    }
}

