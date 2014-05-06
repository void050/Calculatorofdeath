using System;

namespace CalculatorOfDeath.UnaryOperations
{
    public class Tan : IUnaryCalculator
    {
        public double Calculate(double firstArgument)
        {
            if (Math.Abs(firstArgument - Math.PI/2) <= 0.00001)
            {
                throw new Exception("Тангенс Pi/2(90 градусов) не существует");
            }
            return Math.Tan(firstArgument);
        }
    }
}
