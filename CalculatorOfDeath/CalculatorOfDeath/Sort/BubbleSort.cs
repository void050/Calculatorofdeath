using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.Sort
{
    public class BubbleSort : ISort
    {
        public int[] Sort(int[] mass)
        {
            int temp;
            for (int i = 0; i < mass.Length - 1; i++)
            {
                for (int j = 0; j < mass.Length - i - 1; j++)
                {
                    if (mass[j] > mass[j + 1])
                    {
                        temp = mass[j];
                        mass[j] = mass[j + 1];
                        mass[j + 1] = temp;
                    }
                }
            }
            return mass;
        }
    }
}
