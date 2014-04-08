using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.BinaryOperations
{
    class Percent:IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            return firstArgument+(secondArgument*firstArgument)/100;
        }
    }
}
