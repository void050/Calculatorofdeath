using System;

namespace CalculatorOfDeath.UnaryOperations
{
   public class SquarePower: IUnaryCalculator
   {
       public double Calculate(double firstArgument)
       {
           return Math.Pow(firstArgument, 2);

       }

   }
}
