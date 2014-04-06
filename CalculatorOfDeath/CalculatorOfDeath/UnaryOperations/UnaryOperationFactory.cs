using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.UnaryOperations
{
    public static class UnaryOperationFactory
    {
        public static IUnaryCalculator Create(string name)
        {
            switch (name)
            {
                case "Square":
                    return new Square();
                case "Factorial":
                    return new Factorial();
                case "SquarePower":
                    return new SquarePower();
                case "Sin":
                    return new Sin();
                default:
                throw new ArgumentException("Unknown calculator","name");
            }
        }
    }
}
