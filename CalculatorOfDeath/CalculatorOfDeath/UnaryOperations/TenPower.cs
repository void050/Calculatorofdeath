using System;

namespace CalculatorOfDeath.UnaryOperations
{
    public class TenPower: IUnaryCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(10, firstArgument);
        }
    }
}
