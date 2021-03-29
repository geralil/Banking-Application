namespace BankingApplicationForms
{
    partial class Login_form
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
            this.UserName = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.userText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.UserLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(13, 65);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(60, 13);
            this.UserName.TabIndex = 0;
            this.UserName.Text = "User Name";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(16, 131);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 1;
            this.Password.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(131, 187);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(106, 46);
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // userText
            // 
            this.userText.Location = new System.Drawing.Point(108, 65);
            this.userText.Name = "userText";
            this.userText.Size = new System.Drawing.Size(190, 20);
            this.userText.TabIndex = 3;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(108, 131);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(190, 20);
            this.passwordText.TabIndex = 4;
            // 
            // UserLogin
            // 
            this.UserLogin.AutoSize = true;
            this.UserLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLogin.Location = new System.Drawing.Point(16, 13);
            this.UserLogin.Name = "UserLogin";
            this.UserLogin.Size = new System.Drawing.Size(111, 24);
            this.UserLogin.TabIndex = 5;
            this.UserLogin.Text = "User Login";
            // 
            // Login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 446);
            this.Controls.Add(this.UserLogin);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.userText);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UserName);
            this.Name = "Login_form";
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox userText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Label UserLogin;
    }
}

