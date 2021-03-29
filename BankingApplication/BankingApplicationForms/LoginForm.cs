namespace BankingApplicationForms
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using Authentication;
    using BankingApplicationLogicEngine;

    /// <summary>
    /// Form for login authentication
    /// </summary>
    public partial class Login_form : Form
    {
        private Authenticate authenticate;
        private BankingApplication application;

        public Login_form()
        {
            InitializeComponent();
            this.authenticate = new Authenticate();
            this.application = new BankingApplication();    // initializing bank app initializes new users.//
        }

        /// <summary>
        /// Function that is triggered when login button is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (userText.Text != string.Empty || passwordText.Text != string.Empty)
            {
                if (this.authenticate.AuthenticateLogin(userText.Text, passwordText.Text))
                {
                    MainForm mainForm = new MainForm(userText.Text, ref this.application);
                    mainForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Incorrect Username or Password");
                }
            }
            else
            {
                MessageBox.Show("Please enter a username and password to continue!");
            }
        }
    }
}
