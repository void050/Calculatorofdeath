using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.Sort
{
    class CocktailSort: ISort
    {
        public int[] Sort(int[] mass)
        {
            bool swap;
            do
            {
                swap = false;
                for (int i = 0; i <= mass.Length - 2; i++)
                {
                    if (mass[i] > mass[i + 1])
                    {
                        int temp = mass[i];
                        mass[i] = mass[i + 1];
                        mass[i + 1] = temp;
                        swap = true;
                    }
                }
                if (!swap)
                {
                    break;
                }
                swap = false;
                for (int i = mass.Length - 2; i >= 0; i--)
                {
                    if (mass[i] > mass[i + 1])
                    {
                        int temp = mass[i];
                        mass[i] = mass[i + 1];
                        mass[i + 1] = temp;
                        swap = true;
                    }
                }
            }
            while (swap);
            return mass;
        }
    }
}
