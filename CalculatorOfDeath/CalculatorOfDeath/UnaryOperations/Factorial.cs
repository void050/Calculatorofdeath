using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.UnaryOperations
{
    public class Factorial : IUnaryCalculator
    {
        public double Calculate(double firstArgument)
        {
            ulong factorial = 1,i;
            for ( i=Convert.ToUInt64(firstArgument); i >= 1; i--) 
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}