namespace CalculatorOfDeath.UnaryOperations
{
     public class DeleteX: IUnaryCalculator
    {
         public double Calculate(double firstArgument)
         {
             return 1 / firstArgument;
         }
    }
}
