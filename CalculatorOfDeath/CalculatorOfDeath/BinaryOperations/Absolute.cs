using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.BinaryOperations
{
    class Absolute: IBinaryCalculator
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            return Convert.ToString(Math.Abs(firstArgument));
        }
    }
}
