using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.UnaryOperations
{
    public class SixteenScale: IUnaryCalculator
    {
        public double Calculate(double firstArgument)
        {
            int first;
            first = (int)firstArgument;
            return first;
        }
    }
}
