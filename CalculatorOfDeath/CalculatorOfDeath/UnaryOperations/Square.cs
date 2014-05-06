using System;

namespace CalculatorOfDeath.UnaryOperations
{
    class Square: IUnaryCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception("Не может быть отрицательным");
            }
            return Math.Sqrt(firstArgument);
        }
    }
}
