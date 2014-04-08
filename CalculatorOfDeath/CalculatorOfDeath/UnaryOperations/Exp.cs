using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.UnaryOperations
{
    public class Exp: IUnaryCalculator
    {
        public string Calculate(double firstArgument)
        {
            return Math.Exp(firstArgument).ToString();
        }
    }
}
