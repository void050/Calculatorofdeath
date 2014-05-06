using System;

namespace CalculatorOfDeath.UnaryOperations
{
    public class Sin : IUnaryCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Sin(firstArgument);
        }
    }
}
