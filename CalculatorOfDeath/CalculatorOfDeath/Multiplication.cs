using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath
{
    public class Multiplication : IBinaryCalculator
    {
        public string Calculate(double firstArgument, double secondArgument)
        {
            return Convert.ToString(firstArgument * secondArgument);            
        }
    }
}
