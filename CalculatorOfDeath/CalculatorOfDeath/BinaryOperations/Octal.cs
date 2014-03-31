using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.BinaryOperations
{
    class Octal:IBinaryCalculator
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            int first;
            first = (int)firstArgument;
            return Convert.ToString(first, 8);
        }
    }
}
