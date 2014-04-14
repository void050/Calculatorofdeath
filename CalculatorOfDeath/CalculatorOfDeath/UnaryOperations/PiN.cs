using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.UnaryOperations
{
    public class PiN : IUnaryCalculator
    {
        public double Calculate(double firstArgument)
        {
            return Math.Pow(3.14159, firstArgument);
        }
    }
}