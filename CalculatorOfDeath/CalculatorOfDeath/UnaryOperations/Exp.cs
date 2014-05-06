using System;

namespace CalculatorOfDeath.UnaryOperations
{
    public class Exp: IUnaryCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument);
        }
    }
}
