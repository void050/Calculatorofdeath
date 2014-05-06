using System;

namespace CalculatorOfDeath.UnaryOperations
{
    public class Loge : IUnaryCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (firstArgument <= 0)
            {
              throw new Exception(@"Не может быть отрицательным или равным нулю");
            }
            return Math.Log(firstArgument);
        }
    }
}
