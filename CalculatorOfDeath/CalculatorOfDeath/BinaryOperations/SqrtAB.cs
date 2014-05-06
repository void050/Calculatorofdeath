using System;

namespace CalculatorOfDeath.BinaryOperations
{
    public class SqrtAB : IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument + secondArgument < 0)
            {
                throw new Exception("Не может быть отрицательным");
            }
            return Math.Pow(firstArgument+secondArgument, 0.5);
        }
    }
}
