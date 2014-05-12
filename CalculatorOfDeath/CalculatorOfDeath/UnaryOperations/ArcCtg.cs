using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.UnaryOperations
{
    class ArcCtg: IUnaryCalculator
    {
        public double Calculate(double firstargument)
        {
            return Math.Atan(firstargument);
        }
    }
}
