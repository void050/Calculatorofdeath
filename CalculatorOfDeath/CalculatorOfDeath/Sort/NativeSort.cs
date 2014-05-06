using System;

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
