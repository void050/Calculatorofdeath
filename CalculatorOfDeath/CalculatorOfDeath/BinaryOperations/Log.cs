using System;

namespace CalculatorOfDeath.BinaryOperations
{
    public class Log: IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            if (firstArgument < 0)
            {
                throw new Exception(@"Не может быть отрицательным или равным нулю");
            }
            return Math.Log(firstArgument, secondArgument);
        }
    }
}
