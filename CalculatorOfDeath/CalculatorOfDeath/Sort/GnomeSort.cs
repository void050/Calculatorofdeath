using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.Sort
{
    class GnomeSort : ISort
    {
        public int[] Sort(int[] mass)
        {
            int temp;
            int i = 1;
            int j = 2;
            while (i < mass.Length)
            {
                if (mass[i - 1] <= mass[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    temp = mass[i - 1];
                    mass[i - 1] = mass[i];
                    mass[i] = temp;
                    i--;
                    if (i == 0)
                    {
                        i = 1;
                        j = 2;
                    }
                }
            }
            return mass;
        }
    }
}