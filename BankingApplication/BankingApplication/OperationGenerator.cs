namespace BankingApplicationLogicEngine
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using BankingApplicationLogicEngine.BankingEntities;

    /// <summary>
    /// class to populate the operations stack of accounts.
    /// </summary>
    public static class OperationGenerator
    {
        /// <summary>
        /// function to generate operations and load them on to an entity.
        /// </summary>
        /// <param name="entity"> bank entity like account.</param>
        public static void GenerateOperations(IEntity entity)
        {
            if (entity is CheckingAccount || entity is SavingsAccount)
            {
                OperationBuilder operationBuilder = new OperationBuilder()
                    .SetType("TransactionalOperation")
                    .SetAmount(134.56)
                    .SetPayee("McDonalds");
                entity.PushOperation(operationBuilder.Build());

                operationBuilder = new OperationBuilder()
                    .SetType("TransactionalOperation")
                    .SetAmount(234.64)
                    .SetPayee("Zarra");
                entity.PushOperation(operationBuilder.Build());

                operationBuilder = new OperationBuilder()
                    .SetType("TransactionalOperation")
                    .SetAmount(345.66)
                    .SetPayee("WinCo");
                entity.PushOperation(operationBuilder.Build());
            }
            if (entity is LoanAccount)
            {
                OperationBuilder operationBuilder = new OperationBuilder()
                    .SetType("LoanPaymentOperation")
                    .SetAmount(134.56)
                    .SetInterestValue(23.55);
                entity.PushOperation(operationBuilder.Build());

                operationBuilder = new OperationBuilder()
                    .SetType("LoanPaymentOperation")
                    .SetAmount(2432)
                    .SetInterestValue(243.12);
                entity.PushOperation(operationBuilder.Build());

                operationBuilder = new OperationBuilder()
                    .SetType("LoanPaymentOperation")
                    .SetAmount(2134)
                    .SetInterestValue(1354);
                entity.PushOperation(operationBuilder.Build());
            }
        }
    }
}
