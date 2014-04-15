using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorOfDeath.BinaryOperations
{
    public static class BinaryOperationFactory
    {
        public static IBinaryCalculator Create(string name)
        {
            switch (name)
            {
                case "Adder":
                    return new Adder();
                case "Division":
                    return new Division();
                case "Multiplication":
                    return new Multiplication();
                case "Substraction":
                    return new Subtraction();
                case "Binary":
                    return new Binary();
                case "Octal":
                    return new Octal();
                case "Mod":
                    return new Mod();
                case "Percent":
                    return new Percent();
                case "Degree":
                    return new Degree();
                case "Log":
                    return new Log();
                case "SquareDegrees":
                    return new SquareDegrees();
                case "SqrtAB":
                    return new SqrtAB();
                default:
                throw new ArgumentException("Unknown calculator","name");
            }
        }
    }
}
