using System;

namespace InterestValueCalculation
{
    public static class InterestCalculator
    {
        public static double CalculateInterestValue (double interestRate, double principalValue)
        {
            double interestValue = (interestRate * principalValue * 1)/100;

            return interestValue;
        }
    }
}
