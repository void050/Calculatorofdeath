using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
