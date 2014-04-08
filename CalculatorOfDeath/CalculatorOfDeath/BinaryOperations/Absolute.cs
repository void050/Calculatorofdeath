using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.BinaryOperations
{
    class Absolute: IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return Math.Abs(firstArgument);
        }
    }
}
