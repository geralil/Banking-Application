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
    using BankingApplicationLogicEngine;

    /// <summary>
    /// form that is used to get information about funds transfer.
    /// </summary>
    public partial class TransferFundsForm : Form
    {
        /// <summary>
        /// user that initiated transfer
        /// </summary>
        private readonly User selectedUser;

        /// <summary>
        /// recipient of funds.
        /// </summary>
        public string ToUser
        {
            get
            {
                return this.toUserNameBox.Text;
            }
        }

        /// <summary>
        /// transfer amount
        /// </summary>
        public double TransferAmount
        {
            get
            {
                double amount;
                double.TryParse(this.transferAmountBox.Text, out amount);
                return amount;
            }
        }

        /// <summary>
        /// type of account that funds need to be sent to.
        /// </summary>
        public string ToAccountType
        {
            get
            {
                if (this.checkingAccountButton2.Checked)
                {
                    return "Checking Account";
                }
                else
                {
                    return "Savings Account";
                }
            }
        }
        
        /// <summary>
        /// type of account that funds need to be withdrawn from.
        /// </summary>
        public string FromAccountType
        {
            get
            {
                if (this.checkingAccountButton.Checked)
                {
                    return "Checking Account";
                }
                else
                {
                    return "Savings Account";
                }
            }
        }

        /// <summary>
        /// disables options for accounts that user does not have.
        /// </summary>
        /// <param name="selectedUser"></param>
        public TransferFundsForm(User selectedUser)
        {
            InitializeComponent();
            this.selectedUser = selectedUser;

            if (!this.selectedUser.CheckAccountTypeExists("Checking Account"))
            {
                this.checkingAccountButton.Enabled = false;
            }
            if (!this.selectedUser.CheckAccountTypeExists("Savings Account"))
            {
                this.savingsAccountButton.Enabled = false;
            }
        }

        private void TransferFundsForm_Load(object sender, EventArgs e)
        {

        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
