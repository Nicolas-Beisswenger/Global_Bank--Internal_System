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
            this.login_label_username = new System.Windows.Forms.Label();
            this.login_label_password = new System.Windows.Forms.Label();
            this.login_textbox_username = new System.Windows.Forms.TextBox();
            this.login_textbox_password = new System.Windows.Forms.TextBox();
            this.login_button_login = new System.Windows.Forms.Button();
            this.login_button_forgotpassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // login_label_username
            // 
            this.login_label_username.AutoSize = true;
            this.login_label_username.Location = new System.Drawing.Point(188, 124);
            this.login_label_username.Name = "login_label_username";
            this.login_label_username.Size = new System.Drawing.Size(55, 13);
            this.login_label_username.TabIndex = 0;
            this.login_label_username.Text = "Username";
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
            // login_textbox_username
            // 
            this.login_textbox_username.Location = new System.Drawing.Point(250, 124);
            this.login_textbox_username.Name = "login_textbox_username";
            this.login_textbox_username.Size = new System.Drawing.Size(100, 20);
            this.login_textbox_username.TabIndex = 2;
            // 
            // login_textbox_password
            // 
            this.login_textbox_password.Location = new System.Drawing.Point(251, 194);
            this.login_textbox_password.Name = "login_textbox_password";
            this.login_textbox_password.Size = new System.Drawing.Size(100, 20);
            this.login_textbox_password.TabIndex = 3;
            // 
            // login_button_login
            // 
            this.login_button_login.Location = new System.Drawing.Point(194, 247);
            this.login_button_login.Name = "login_button_login";
            this.login_button_login.Size = new System.Drawing.Size(156, 23);
            this.login_button_login.TabIndex = 4;
            this.login_button_login.Text = "Login";
            this.login_button_login.UseVisualStyleBackColor = true;
            this.login_button_login.Click += new System.EventHandler(this.login_button_login_Click);
            // 
            // login_button_forgotpassword
            // 
            this.login_button_forgotpassword.Location = new System.Drawing.Point(194, 314);
            this.login_button_forgotpassword.Name = "login_button_forgotpassword";
            this.login_button_forgotpassword.Size = new System.Drawing.Size(157, 23);
            this.login_button_forgotpassword.TabIndex = 5;
            this.login_button_forgotpassword.Text = "Forgot password";
            this.login_button_forgotpassword.UseVisualStyleBackColor = true;
            this.login_button_forgotpassword.Click += new System.EventHandler(this.login_button_forgotpassword_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_button_forgotpassword);
            this.Controls.Add(this.login_button_login);
            this.Controls.Add(this.login_textbox_password);
            this.Controls.Add(this.login_textbox_username);
            this.Controls.Add(this.login_label_password);
            this.Controls.Add(this.login_label_username);
            this.Name = "login_form";
            this.Text = "Global Bank - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_label_username;
        private System.Windows.Forms.Label login_label_password;
        private System.Windows.Forms.TextBox login_textbox_username;
        private System.Windows.Forms.TextBox login_textbox_password;
        private System.Windows.Forms.Button login_button_login;
        private System.Windows.Forms.Button login_button_forgotpassword;
    }
}

