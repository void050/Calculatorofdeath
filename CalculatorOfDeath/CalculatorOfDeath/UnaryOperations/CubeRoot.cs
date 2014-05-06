using System;

namespace CalculatorOfDeath.UnaryOperations
{
    public class CubeRoot: IUnaryCalculator
    {
        public double Calculate(double firstArgument)
        {
            int negative = 1; 
            if (firstArgument < 0)
            {
                negative = -1;
            }
            return negative * Math.Pow(Math.Abs(firstArgument), (double)1 / 3);
        }
    }
}
