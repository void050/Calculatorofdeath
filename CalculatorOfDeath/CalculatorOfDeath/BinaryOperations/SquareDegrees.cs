using System;

namespace CalculatorOfDeath.BinaryOperations
{
    public class SquareDegrees : IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, (1/secondArgument));
        }
    }
}
