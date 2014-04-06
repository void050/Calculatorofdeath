using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.UnaryOperations
{
    public class CubeRoot: IUnaryCalculator
    {
        public string Calculate(double firstArgument)
        {
            return Math.Pow(firstArgument, (double)1/3).ToString();
        }
    }
}
