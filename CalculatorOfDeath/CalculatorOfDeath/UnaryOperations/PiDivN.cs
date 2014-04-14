using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.UnaryOperations
{
    public class PiDivN : IUnaryCalculator
    {
        public double Calculate(double firstArgument)
        {
            return 3.14159/firstArgument;
        }
    }
}