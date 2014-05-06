namespace CalculatorOfDeath.UnaryOperations
{
    public class PiDivN : IUnaryCalculator
    {
        public double Calculate(double firstArgument)
        {
            return 3.14159/firstArgument;
        }
    }
}