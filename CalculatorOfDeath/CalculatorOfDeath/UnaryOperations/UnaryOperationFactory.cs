using System;

namespace CalculatorOfDeath.UnaryOperations
{
    public static class UnaryOperationFactory
    {
        public static IUnaryCalculator Create(string name)
        {
            switch (name)
            {
                case "ArcCtg":
                    return new ArcCtg();
                case "ArcCos":
                    return new ArcCos();
                case "ArcSin":
                    return new ArcSin();
                case "ArcTan":
                    return new ArcTan();
                case "Square":
                    return new Square();
                case "Factorial":
                    return new Factorial();
                case "SquarePower":
                    return new SquarePower();
                case "Sin":
                    return new Sin();
                case "TenPower":
                    return new TenPower();
                case "DeleteX":
                    return new DeleteX();
                case "CubeRoot":
                    return new CubeRoot();
                case "Cos":
                    return new Cos();
                case "Exp":
                    return new Exp();
                case "Loge":
                    return new Loge();
                case "Absolute":
                    return new Absolute();
                case "PiN":
                    return new PiN();
                case "Tan":
                    return new Tan();
                case "PiDivN":
                    return new PiDivN();
                default:
                throw new ArgumentException("Unknown calculator","name");
            }
        }
    }
}
