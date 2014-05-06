using System;

namespace CalculatorOfDeath.UnaryOperations
{
    public class Factorial : IUnaryCalculator
    {
        public double Calculate(double firstArgument)
        {
            ulong factorial = 1,i;
            if (firstArgument < 0)
            {
                throw new Exception("Не может быть отрицательным");
            }
            for ( i=Convert.ToUInt64(firstArgument); i >= 1; i--) 
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}