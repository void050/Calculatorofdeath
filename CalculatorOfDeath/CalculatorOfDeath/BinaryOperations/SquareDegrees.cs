using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.BinaryOperations
{
    public class SquareDegrees: IBinaryCalculator
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, (1/secondArgument)).ToString();
        }
    }
}
