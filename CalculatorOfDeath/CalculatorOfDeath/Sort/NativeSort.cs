using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.Sort
{
    class NativeSort: ISort
    {
        public int[] Sort(int[] mass)
        {
            Array.Sort(mass);
            return mass;
        }
    }
}
