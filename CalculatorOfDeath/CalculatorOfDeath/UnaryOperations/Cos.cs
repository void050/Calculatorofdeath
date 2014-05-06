using System;

namespace CalculatorOfDeath.UnaryOperations
{
    public class Cos: IUnaryCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Cos(firstArgument);
        }
    }
}
