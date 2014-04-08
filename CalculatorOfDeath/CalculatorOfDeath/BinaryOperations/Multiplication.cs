using System;

namespace CalculatorOfDeath.BinaryOperations
{
    public class Multiplication : IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument * secondArgument;            
        }
    }
}
