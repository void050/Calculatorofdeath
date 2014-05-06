using System;

namespace CalculatorOfDeath.UnaryOperations
{
    public class PiN : IUnaryCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(3.14159, firstArgument);
        }
    }
}