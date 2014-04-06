using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.UnaryOperations
{
    public class TenPower: IUnaryCalculator
    {
        public string Calculate(double firstArgument)
        {
            return Math.Pow(10, firstArgument).ToString();
        }
    }
}
