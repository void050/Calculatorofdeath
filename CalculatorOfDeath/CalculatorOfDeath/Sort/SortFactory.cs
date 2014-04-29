using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.Sort
{
    public static class SortFactory
    {
        public static ISort CreateOperation(string name)
        {
            switch (name)
            {
                case "BubbleSort":
                    return new BubbleSort();
                case "CombSort":
                    return new CombSort();
                case "CocktailSort":
                    return new CocktailSort();
                default:
                    throw new ArgumentException("Unknown calculator", "name");
            }
        }
    }
}
