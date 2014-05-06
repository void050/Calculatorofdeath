namespace CalculatorOfDeath.BinaryOperations
{
    class Percent:IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument + (secondArgument * firstArgument) / 100;
        }
    }
}
