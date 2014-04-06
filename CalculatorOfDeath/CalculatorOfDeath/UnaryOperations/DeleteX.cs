using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.UnaryOperations
{
     public class DeleteX: IUnaryCalculator
    {
         public string Calculate(double firstArgument)
         {
             return Convert.ToString(1 / firstArgument);
         }
    }
}
