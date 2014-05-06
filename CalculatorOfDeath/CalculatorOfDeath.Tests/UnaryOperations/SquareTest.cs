using CalculatorOfDeath.UnaryOperations;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.UnaryOperations
{
    [TestFixture]
    public class SquareTests
    {
        [Test]
        public void SqrtTest()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("Square");
            double result = calculator.Calculate(4);
            Assert.AreEqual(2, result);
        }
    }
}

