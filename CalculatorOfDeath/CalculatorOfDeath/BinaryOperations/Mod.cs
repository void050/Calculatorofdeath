namespace CalculatorOfDeath.BinaryOperations
{
    class Mod: IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            int first=(int) firstArgument;
            int second = (int) secondArgument;
            return first-(first/second)*second;
        }
    }
}
