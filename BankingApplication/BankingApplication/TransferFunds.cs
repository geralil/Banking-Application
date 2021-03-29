namespace BankingApplicationLogicEngine
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BankingApplicationLogicEngine.BankingEntities;

    /// <summary>
    /// class that is encapsulates methods and fields required
    /// to transfer funds from one account to other.
    /// </summary>
    public class TransferFunds
    {
        private string fromUser;
        private string toUser;
        private double transferAmount;
        private string toAccountType;
        private string fromAccountType;
        private Dictionary<string, User> bankUsers;

        public TransferFunds(ref Dictionary<string, User> keyValuePairs)
        {
            this.bankUsers = keyValuePairs;
        }

        public TransferFunds SetFromAccountType(string type) { this.fromAccountType = type;     return this; }
        public TransferFunds SetFromUser(string payor) { this.fromUser = payor;    return this; }
        public TransferFunds SetToUser(string payee) { this.toUser = payee;     return this; }
        public TransferFunds SetTransferAmount(double amount) { this.transferAmount = amount;   return this; }
        public TransferFunds SetToAccountType(string type) { this.toAccountType = type;     return this; }

        public void TransferAmount()
        {
            User fromUser = this.bankUsers[this.fromUser];
            User toUser = this.bankUsers[this.toUser];

            IAccountEntity toAccount = toUser.CheckStatus(this.toAccountType) as IAccountEntity;
            IAccountEntity fromAccount = fromUser.CheckStatus(this.fromAccountType) as IAccountEntity;

            toAccount.SetCurrentAmount(toAccount.GetCurrentAmount() + this.transferAmount);
            fromAccount.SetCurrentAmount(fromAccount.GetCurrentAmount() - this.transferAmount);

            // create operations on both accounts for transfer.//
            OperationBuilder operationBuilder = new OperationBuilder()
                .SetType("TransferOperation")
                .SetAmount(this.transferAmount)
                .SetPayee(this.toUser);
            fromAccount.PushOperation(operationBuilder.Build());

            operationBuilder = new OperationBuilder()
                .SetType("DepositOperation")
                .SetAmount(this.transferAmount)
                .SetPayee(this.fromUser);
            toAccount.PushOperation(operationBuilder.Build());
        }
    }
}
