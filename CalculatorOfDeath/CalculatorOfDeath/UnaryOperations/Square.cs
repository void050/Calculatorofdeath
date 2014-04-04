using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.UnaryOperations
{
    class Square: IUnaryCalculator
    {
        public string Calculate(double firstArgument)
        {
            return Convert.ToString(Math.Sqrt(firstArgument));
        }
    }
}
