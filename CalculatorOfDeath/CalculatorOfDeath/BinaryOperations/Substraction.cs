namespace CalculatorOfDeath.BinaryOperations
{
    public class Substraction : IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument - secondArgument;        
        }
    }
}
