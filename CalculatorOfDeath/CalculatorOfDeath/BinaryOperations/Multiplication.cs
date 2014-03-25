using System;

namespace CalculatorOfDeath.BinaryOperations
{
    public class Multiplication : IBinaryCalculator
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            return Convert.ToString(firstArgument * secondArgument);            
        }
    }
}
