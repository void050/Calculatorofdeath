using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.BinaryOperations
{
    public class Factorial : IBinaryCalculator
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            ulong factorial = 1,i;
            for ( i=Convert.ToUInt64(firstArgument); i >= 1; i--) 
            {
                factorial *= i;
            }
            return Convert.ToString(factorial);
        }
    }
}