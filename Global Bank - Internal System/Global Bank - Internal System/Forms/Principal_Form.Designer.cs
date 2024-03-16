namespace Global_Bank___Internal_System.Forms
{
    partial class Principal_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrincipalForm_Panel_TopPanel = new System.Windows.Forms.Panel();
            this.PrincipalForm_Button_SignOff = new System.Windows.Forms.Button();
            this.PrincipalPanel_Panel_HumanResources_Options = new System.Windows.Forms.Panel();
            this.PrincipalForm_Button_NewUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.PrincipalPanel_Panel_HumanResources_NewUser = new System.Windows.Forms.Panel();
            this.PrincipalForm_Panel_TopPanel.SuspendLayout();
            this.PrincipalPanel_Panel_HumanResources_Options.SuspendLayout();
            this.SuspendLayout();
            // 
            // PrincipalForm_Panel_TopPanel
            // 
            this.PrincipalForm_Panel_TopPanel.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.PrincipalForm_Panel_TopPanel.Controls.Add(this.PrincipalForm_Button_SignOff);
            this.PrincipalForm_Panel_TopPanel.Location = new System.Drawing.Point(0, 0);
            this.PrincipalForm_Panel_TopPanel.Name = "PrincipalForm_Panel_TopPanel";
            this.PrincipalForm_Panel_TopPanel.Size = new System.Drawing.Size(800, 55);
            this.PrincipalForm_Panel_TopPanel.TabIndex = 0;
            // 
            // PrincipalForm_Button_SignOff
            // 
            this.PrincipalForm_Button_SignOff.Location = new System.Drawing.Point(713, 12);
            this.PrincipalForm_Button_SignOff.Name = "PrincipalForm_Button_SignOff";
            this.PrincipalForm_Button_SignOff.Size = new System.Drawing.Size(75, 23);
            this.PrincipalForm_Button_SignOff.TabIndex = 0;
            this.PrincipalForm_Button_SignOff.Text = "Sign Off";
            this.PrincipalForm_Button_SignOff.UseVisualStyleBackColor = true;
            // 
            // PrincipalPanel_Panel_HumanResources_Options
            // 
            this.PrincipalPanel_Panel_HumanResources_Options.BackColor = System.Drawing.Color.RoyalBlue;
            this.PrincipalPanel_Panel_HumanResources_Options.Controls.Add(this.PrincipalForm_Button_NewUser);
            this.PrincipalPanel_Panel_HumanResources_Options.Location = new System.Drawing.Point(0, 54);
            this.PrincipalPanel_Panel_HumanResources_Options.Name = "PrincipalPanel_Panel_HumanResources_Options";
            this.PrincipalPanel_Panel_HumanResources_Options.Size = new System.Drawing.Size(143, 396);
            this.PrincipalPanel_Panel_HumanResources_Options.TabIndex = 2;
            // 
            // PrincipalForm_Button_NewUser
            // 
            this.PrincipalForm_Button_NewUser.Location = new System.Drawing.Point(12, 16);
            this.PrincipalForm_Button_NewUser.Name = "PrincipalForm_Button_NewUser";
            this.PrincipalForm_Button_NewUser.Size = new System.Drawing.Size(118, 23);
            this.PrincipalForm_Button_NewUser.TabIndex = 0;
            this.PrincipalForm_Button_NewUser.Text = "New User";
            this.PrincipalForm_Button_NewUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(400, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select an option";
            // 
            // PrincipalPanel_Panel_HumanResources_NewUser
            // 
            this.PrincipalPanel_Panel_HumanResources_NewUser.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PrincipalPanel_Panel_HumanResources_NewUser.Location = new System.Drawing.Point(136, 54);
            this.PrincipalPanel_Panel_HumanResources_NewUser.Name = "PrincipalPanel_Panel_HumanResources_NewUser";
            this.PrincipalPanel_Panel_HumanResources_NewUser.Size = new System.Drawing.Size(664, 396);
            this.PrincipalPanel_Panel_HumanResources_NewUser.TabIndex = 4;
            // 
            // Principal_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PrincipalPanel_Panel_HumanResources_NewUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PrincipalPanel_Panel_HumanResources_Options);
            this.Controls.Add(this.PrincipalForm_Panel_TopPanel);
            this.Name = "Principal_Form";
            this.Text = "Principal_Form";
            this.PrincipalForm_Panel_TopPanel.ResumeLayout(false);
            this.PrincipalPanel_Panel_HumanResources_Options.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PrincipalForm_Panel_TopPanel;
        private System.Windows.Forms.Button PrincipalForm_Button_SignOff;
        private System.Windows.Forms.Panel PrincipalPanel_Panel_HumanResources_Options;
        private System.Windows.Forms.Button PrincipalForm_Button_NewUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PrincipalPanel_Panel_HumanResources_NewUser;
    }
}