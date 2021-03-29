using System;

namespace BankingApplicationForms
{
    partial class TransferFundsForm
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
            this.doneButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkingAccountButton = new System.Windows.Forms.RadioButton();
            this.savingsAccountButton = new System.Windows.Forms.RadioButton();
            this.savingsAccountButton2 = new System.Windows.Forms.RadioButton();
            this.checkingAccountButton2 = new System.Windows.Forms.RadioButton();
            this.toUserNameBox = new System.Windows.Forms.TextBox();
            this.transferAmountBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(151, 273);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(127, 50);
            this.doneButton.TabIndex = 0;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Username of Recipient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Amount";
            // 
            // checkingAccountButton
            // 
            this.checkingAccountButton.AutoSize = true;
            this.checkingAccountButton.Location = new System.Drawing.Point(12, 33);
            this.checkingAccountButton.Name = "checkingAccountButton";
            this.checkingAccountButton.Size = new System.Drawing.Size(113, 17);
            this.checkingAccountButton.TabIndex = 3;
            this.checkingAccountButton.TabStop = true;
            this.checkingAccountButton.Text = "Checking Account";
            this.checkingAccountButton.UseVisualStyleBackColor = true;
            // 
            // savingsAccountButton
            // 
            this.savingsAccountButton.AutoSize = true;
            this.savingsAccountButton.Location = new System.Drawing.Point(12, 66);
            this.savingsAccountButton.Name = "savingsAccountButton";
            this.savingsAccountButton.Size = new System.Drawing.Size(106, 17);
            this.savingsAccountButton.TabIndex = 4;
            this.savingsAccountButton.TabStop = true;
            this.savingsAccountButton.Text = "Savings Account";
            this.savingsAccountButton.UseVisualStyleBackColor = true;
            // 
            // savingsAccountButton2
            // 
            this.savingsAccountButton2.AutoSize = true;
            this.savingsAccountButton2.Location = new System.Drawing.Point(16, 68);
            this.savingsAccountButton2.Name = "savingsAccountButton2";
            this.savingsAccountButton2.Size = new System.Drawing.Size(106, 17);
            this.savingsAccountButton2.TabIndex = 5;
            this.savingsAccountButton2.TabStop = true;
            this.savingsAccountButton2.Text = "Savings Account";
            this.savingsAccountButton2.UseVisualStyleBackColor = true;
            // 
            // checkingAccountButton2
            // 
            this.checkingAccountButton2.AutoSize = true;
            this.checkingAccountButton2.Location = new System.Drawing.Point(16, 35);
            this.checkingAccountButton2.Name = "checkingAccountButton2";
            this.checkingAccountButton2.Size = new System.Drawing.Size(113, 17);
            this.checkingAccountButton2.TabIndex = 6;
            this.checkingAccountButton2.TabStop = true;
            this.checkingAccountButton2.Text = "Checking Account";
            this.checkingAccountButton2.UseVisualStyleBackColor = true;
            // 
            // toUserNameBox
            // 
            this.toUserNameBox.Location = new System.Drawing.Point(245, 42);
            this.toUserNameBox.Name = "toUserNameBox";
            this.toUserNameBox.Size = new System.Drawing.Size(129, 20);
            this.toUserNameBox.TabIndex = 9;
            // 
            // transferAmountBox
            // 
            this.transferAmountBox.Location = new System.Drawing.Point(167, 96);
            this.transferAmountBox.Name = "transferAmountBox";
            this.transferAmountBox.Size = new System.Drawing.Size(144, 20);
            this.transferAmountBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.savingsAccountButton);
            this.groupBox1.Controls.Add(this.checkingAccountButton);
            this.groupBox1.Location = new System.Drawing.Point(46, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 107);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "From Account Type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkingAccountButton2);
            this.groupBox2.Controls.Add(this.savingsAccountButton2);
            this.groupBox2.Location = new System.Drawing.Point(245, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(140, 108);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "To Account Type";
            // 
            // TransferFundsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 335);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.transferAmountBox);
            this.Controls.Add(this.toUserNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.doneButton);
            this.Name = "TransferFundsForm";
            this.Text = "TransferFundsForm";
            this.Load += new System.EventHandler(this.TransferFundsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton checkingAccountButton;
        private System.Windows.Forms.RadioButton savingsAccountButton;
        private System.Windows.Forms.RadioButton savingsAccountButton2;
        private System.Windows.Forms.RadioButton checkingAccountButton2;
        private System.Windows.Forms.TextBox toUserNameBox;
        private System.Windows.Forms.TextBox transferAmountBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}