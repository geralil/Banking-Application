namespace BankingApplicationLogicEngine
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BankingApplicationLogicEngine.BankingOperations;

    /// <summary>
    /// operation builder class that builds different operations.
    /// </summary>
    public class OperationBuilder
    {
        // fields that all operations require.//
        private string type;
        private double amount;
        private string payee;
        private double interestValue;

        // setters for different fields.//
        public OperationBuilder SetType(string type) { this.type = type;    return this; }
        public OperationBuilder SetAmount(double amount) { this.amount = amount;    return this; }
        public OperationBuilder SetPayee(string payee) { this.payee = payee;    return this; }
        public OperationBuilder SetInterestValue(double interestValue) { this.interestValue = interestValue;    return this; }

        /// <summary>
        /// build function returns an Ioperation object
        /// that is built of the class's fields.
        /// </summary>
        /// <returns></returns>
        public IOperation Build()
        {
            Type operationType = Type.GetType("BankingApplicationLogicEngine.BankingOperations." + this.type);
            IOperation operation = (IOperation)Activator.CreateInstance(operationType);

            operation.SetAmount(this.amount);

            if (operation is IPurchaseOperation)
            {
                IPurchaseOperation purchase = operation as IPurchaseOperation;
                purchase.SetPayee(this.payee);
                operation = purchase;
            }
            if (operation is IInterestOperation)
            {
                IInterestOperation interest = operation as IInterestOperation;
                interest.SetInterestValue(this.interestValue);
                operation = interest;
            }

            return operation;
        }
    }
}
