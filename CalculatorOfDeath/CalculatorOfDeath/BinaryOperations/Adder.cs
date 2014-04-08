using System;

namespace CalculatorOfDeath.BinaryOperations
{
    public class Adder : IBinaryCalculator
   {
       public double Calculate(double firstArgument, double secondArgument)
       {
          return firstArgument + secondArgument;
       }
   }
}
