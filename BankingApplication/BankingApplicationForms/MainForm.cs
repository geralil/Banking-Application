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
    using BankingApplicationLogicEngine.BankingEntities;
    using BankingApplicationLogicEngine.BankingOperations;

    /// <summary>
    /// Form that displays user account details.
    /// </summary>
    public partial class MainForm : Form
    {
        private BankingApplication bankingApplication;

        /// <summary>
        /// the user that was authenticated from login
        /// </summary>
        private User selectedUser;

        private readonly string userName;

        public MainForm(string userName, ref BankingApplication application)
        {
            InitializeComponent();
            InitializeDataGridView();
            bankingApplication = application;
            this.userName = userName;
        }

        /// <summary>
        /// initializes data grid view in the main form for last 10 operations.
        /// </summary>
        private void InitializeDataGridView()
        {
            string[] columnNames = { "Log", "Value" };
            // Adding columns from A-Z.//
            for (int i = 0; i < columnNames.Length; i++)
            {
                this.dataGridView1.Columns.Add(i.ToString(), columnNames[i]);
            }

            // Adding rows from 1-50 with header value.//
            for (int i = 1; i <= 10; i++)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView1.Rows[i - 1].HeaderCell.Value = i.ToString();
            }

            // Adding default background color.//
            this.dataGridView1.BackgroundColor = Color.White;
        }

        /// <summary>
        /// function that gets the selected user from bank application.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.selectedUser = this.bankingApplication.GetUser(this.userName);
            this.Text = this.Text + " - " + this.userName;
        }

        /// <summary>
        /// triggered when accounts button is clicked.
        /// Shows the different accounts a user has.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.CheckingAccountToolStripMenuItem.Enabled = false;
            this.SavingsAccountToolStripMenuItem.Enabled = false;
            this.LoanAccountToolStripMenuItem.Enabled = false;

            if (this.selectedUser.CheckAccountTypeExists("Checking Account"))
            {
                this.CheckingAccountToolStripMenuItem.Enabled = true;
            }
            if (this.selectedUser.CheckAccountTypeExists("Savings Account"))
            {
                this.SavingsAccountToolStripMenuItem.Enabled = true;
            }
            if (this.selectedUser.CheckAccountTypeExists("Loan Account"))
            {
                this.LoanAccountToolStripMenuItem.Enabled = true;
            }
        }

        /// <summary>
        /// triggered when savings account button is clicked.
        /// shows savings account details of user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SavingsAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEntity entity = this.selectedUser.CheckStatus("Savings Account");

            this.ClearAllText(this);
            this.accountType.Text = "Savings Account";
            this.ShowAccountDetails(entity);
            this.ShowOperationDetails(entity);
        }

        /// <summary>
        /// function to display operation details in datagridview.
        /// </summary>
        /// <param name="entity"></param>
        private void ShowOperationDetails(IEntity entity)
        {
            Stack<IOperation> operations = entity.GetLastNOperations();
            int counter = 0;
            
            foreach (var operation in operations)
            {
                string logValue = operation.GetOperationLog();
                string amountValue = operation.GetOperationValue().ToString();
                this.dataGridView1.Rows[counter].Cells[0].Value = logValue;
                this.dataGridView1.Rows[counter].Cells[1].Value = amountValue;
                counter++;
            }
        }

        /// <summary>
        /// Shows selected account details on mainform textboxes.
        /// </summary>
        /// <param name="entity"></param>
        private void ShowAccountDetails(IEntity entity)
        {
            if (entity is IAccountEntity)
            {
                IAccountEntity accountEntity = entity as IAccountEntity;
                this.accountNumberBox.Text = accountEntity.GetEntityNumber().ToString();
                this.currentBalanceBox.Text = accountEntity.GetCurrentAmount().ToString();
            }
            if (entity is IInterestEntity)
            {
                IInterestEntity interestEntity = entity as IInterestEntity;
                this.interestRateBox.Text = interestEntity.GetInterestRate().ToString();
                this.totalInterestAmountBox.Text = interestEntity.GetInterestValue().ToString();
            }
            if (entity is ILoanEntity)
            {
                LoanAccount loanEntity = entity as LoanAccount;
                this.label7.Text = "Total Loan Amount";
                this.totalAmountBox.Text = loanEntity.GetLoanAmount().ToString();
            }
        }

        /// <summary>
        /// triggered when checking account tool strip menu item is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckingAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEntity entity = this.selectedUser.CheckStatus("Checking Account");

            this.ClearAllText(this);
            this.accountType.Text = "Checking Account";
            this.ShowAccountDetails(entity);
            this.ShowOperationDetails(entity);
        }

        /// <summary>
        /// triggered when loan account tool strip menu item is clicked.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoanAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IEntity entity = this.selectedUser.CheckStatus("Loan Account");

            this.ClearAllText(this);
            this.accountType.Text = "Loan Account";
            this.ShowAccountDetails(entity);
            this.ShowOperationDetails(entity);
        }

        /// <summary>
        /// clears previous account details text from form.
        /// </summary>
        /// <param name="con"></param>
        private void ClearAllText(Control con)
        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }

        /// <summary>
        /// triggered when transfer funds is clicked.
        /// creates a new form that asks for details of transfer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TransferFundsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransferFundsForm transferFunds = new TransferFundsForm(this.selectedUser);
            transferFunds.ShowDialog();

            if (transferFunds.TransferAmount != 0)
            {
                User user = this.bankingApplication.GetUser(transferFunds.ToUser);

                if (user.CheckAccountTypeExists(transferFunds.ToAccountType))
                {
                    IAccountEntity entity = this.selectedUser.CheckStatus(transferFunds.FromAccountType) as IAccountEntity;

                    if (entity.GetCurrentAmount() > transferFunds.TransferAmount)
                    {
                        this.bankingApplication.TransferFundsBetweenAccounts(this.userName, transferFunds.ToUser, transferFunds.FromAccountType,
                            transferFunds.ToAccountType, transferFunds.TransferAmount);
                    }
                    else
                    {
                        MessageBox.Show("You don't have enough funds.");
                    }
                }
                else
                {
                    MessageBox.Show("Recipient does not have that type of account. Try Again.");
                }
            }
        }
    }
}
