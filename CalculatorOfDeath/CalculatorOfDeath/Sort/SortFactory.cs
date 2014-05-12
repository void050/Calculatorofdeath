using System;

namespace CalculatorOfDeath.Sort
{
    public static class SortFactory
    {
        public static ISort CreateOperation(string name)
        {
            switch (name)
            {
                case "GS":
                    return new GnomeSort();
                case "BubbleSort":
                    return new BubbleSort();
                case "CombSort":
                    return new CombSort();
                case "CocktailSort":
                    return new CocktailSort();
                case "NativeSort":
                    return new NativeSort();
                default:
                    throw new ArgumentException("Unknown calculator", "name");
            }
        }
    }
}
