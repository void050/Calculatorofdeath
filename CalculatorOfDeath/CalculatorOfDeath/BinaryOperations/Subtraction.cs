using System;

namespace CalculatorOfDeath.BinaryOperations
{
    public class Subtraction : IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;        
        }
    }
}
