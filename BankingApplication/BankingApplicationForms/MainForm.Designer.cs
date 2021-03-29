namespace BankingApplicationForms
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SavingsAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckingAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoanAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TransferFundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.accountNumberBox = new System.Windows.Forms.TextBox();
            this.totalInterestAmountBox = new System.Windows.Forms.TextBox();
            this.interestRateBox = new System.Windows.Forms.TextBox();
            this.currentBalanceBox = new System.Windows.Forms.TextBox();
            this.accountType = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.totalAmountBox = new System.Windows.Forms.TextBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AccountsToolStripMenuItem,
            this.TransferFundsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AccountsToolStripMenuItem
            // 
            this.AccountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SavingsAccountToolStripMenuItem,
            this.CheckingAccountToolStripMenuItem,
            this.LoanAccountToolStripMenuItem});
            this.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem";
            this.AccountsToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.AccountsToolStripMenuItem.Text = "Accounts";
            this.AccountsToolStripMenuItem.Click += new System.EventHandler(this.AccountsToolStripMenuItem_Click);
            // 
            // SavingsAccountToolStripMenuItem
            // 
            this.SavingsAccountToolStripMenuItem.Name = "SavingsAccountToolStripMenuItem";
            this.SavingsAccountToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.SavingsAccountToolStripMenuItem.Text = "Savings Account";
            this.SavingsAccountToolStripMenuItem.Click += new System.EventHandler(this.SavingsAccountToolStripMenuItem_Click);
            // 
            // CheckingAccountToolStripMenuItem
            // 
            this.CheckingAccountToolStripMenuItem.Name = "CheckingAccountToolStripMenuItem";
            this.CheckingAccountToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.CheckingAccountToolStripMenuItem.Text = "Checking Account";
            this.CheckingAccountToolStripMenuItem.Click += new System.EventHandler(this.CheckingAccountToolStripMenuItem_Click);
            // 
            // LoanAccountToolStripMenuItem
            // 
            this.LoanAccountToolStripMenuItem.Name = "LoanAccountToolStripMenuItem";
            this.LoanAccountToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.LoanAccountToolStripMenuItem.Text = "Loan Account";
            this.LoanAccountToolStripMenuItem.Click += new System.EventHandler(this.LoanAccountToolStripMenuItem_Click);
            // 
            // TransferFundsToolStripMenuItem
            // 
            this.TransferFundsToolStripMenuItem.Name = "TransferFundsToolStripMenuItem";
            this.TransferFundsToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.TransferFundsToolStripMenuItem.Text = "Transfer Funds";
            this.TransferFundsToolStripMenuItem.Click += new System.EventHandler(this.TransferFundsToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Account Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Current Balance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Interest Rate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Total Interest Amount";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 274);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 177);
            this.dataGridView1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Last 10 Operations";
            // 
            // accountNumberBox
            // 
            this.accountNumberBox.Location = new System.Drawing.Point(172, 95);
            this.accountNumberBox.Name = "accountNumberBox";
            this.accountNumberBox.Size = new System.Drawing.Size(182, 20);
            this.accountNumberBox.TabIndex = 8;
            // 
            // totalInterestAmountBox
            // 
            this.totalInterestAmountBox.Location = new System.Drawing.Point(172, 197);
            this.totalInterestAmountBox.Name = "totalInterestAmountBox";
            this.totalInterestAmountBox.Size = new System.Drawing.Size(182, 20);
            this.totalInterestAmountBox.TabIndex = 9;
            // 
            // interestRateBox
            // 
            this.interestRateBox.Location = new System.Drawing.Point(172, 161);
            this.interestRateBox.Name = "interestRateBox";
            this.interestRateBox.Size = new System.Drawing.Size(182, 20);
            this.interestRateBox.TabIndex = 10;
            // 
            // currentBalanceBox
            // 
            this.currentBalanceBox.Location = new System.Drawing.Point(172, 126);
            this.currentBalanceBox.Name = "currentBalanceBox";
            this.currentBalanceBox.Size = new System.Drawing.Size(182, 20);
            this.currentBalanceBox.TabIndex = 11;
            // 
            // accountType
            // 
            this.accountType.Location = new System.Drawing.Point(233, 38);
            this.accountType.Name = "accountType";
            this.accountType.Size = new System.Drawing.Size(147, 20);
            this.accountType.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(433, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total Amount";
            // 
            // totalAmountBox
            // 
            this.totalAmountBox.Location = new System.Drawing.Point(563, 94);
            this.totalAmountBox.Name = "totalAmountBox";
            this.totalAmountBox.Size = new System.Drawing.Size(196, 20);
            this.totalAmountBox.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalAmountBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.accountType);
            this.Controls.Add(this.currentBalanceBox);
            this.Controls.Add(this.interestRateBox);
            this.Controls.Add(this.totalInterestAmountBox);
            this.Controls.Add(this.accountNumberBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SavingsAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckingAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoanAccountToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox accountNumberBox;
        private System.Windows.Forms.TextBox totalInterestAmountBox;
        private System.Windows.Forms.TextBox interestRateBox;
        private System.Windows.Forms.TextBox currentBalanceBox;
        private System.Windows.Forms.TextBox accountType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox totalAmountBox;
        private System.Windows.Forms.ToolStripMenuItem TransferFundsToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}