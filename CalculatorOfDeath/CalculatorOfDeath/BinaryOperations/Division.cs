using System;
using System.Globalization;

namespace CalculatorOfDeath.BinaryOperations
{

    public class Division : IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument / secondArgument;    
        }
    }
}
