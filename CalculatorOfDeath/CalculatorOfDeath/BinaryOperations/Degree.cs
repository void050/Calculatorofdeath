using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.BinaryOperations
{
    public class Degree: IBinaryCalculator
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            return Math.Pow(firstArgument, secondArgument).ToString();
        }
    }
}
