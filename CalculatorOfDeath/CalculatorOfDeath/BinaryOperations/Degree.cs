using System;

namespace CalculatorOfDeath.BinaryOperations
{
    public class Degree: IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument);
        }
    }
}
