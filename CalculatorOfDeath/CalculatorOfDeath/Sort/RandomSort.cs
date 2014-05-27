using System;

namespace CalculatorOfDeath.Sort

{
    class RandomSort : ISort
    {
        public int[] Sort(int[] mass)
        {
            int randN,tempValue;
            bool sorted = false;
            Random rand = new Random();

            while (!sorted)
            {
                randN = rand.Next(0, mass.Length - 1);

                if (mass[randN] > mass[randN + 1])
                {
                    tempValue = mass[randN];
                    mass[randN] = mass[randN + 1];
                    mass[randN + 1] = tempValue;
                }
                for (int i = 0; i < mass.Length; i++)
                {
                    if (i != mass.Length - 1 && mass[i] > mass[i + 1])
                    {
                        break;
                    }

                    if (i == mass.Length - 1) sorted = true;
                }

            }
            return mass;
        }
    }
}
