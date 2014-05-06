using System;

namespace CalculatorOfDeath.UnaryOperations
{
    class Absolute: IUnaryCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}
