using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.BinaryOperations
{
    class Mod: IBinaryCalculator
    {
        public double Calculate(double firstArgument, double secondArgument)
        {
            int first=(int) firstArgument;
            int second = (int) secondArgument;
            return first-(first/second)*second;
        }
    }
}
