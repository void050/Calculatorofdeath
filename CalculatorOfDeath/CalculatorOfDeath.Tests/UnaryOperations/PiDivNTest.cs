using CalculatorOfDeath.UnaryOperations;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.UnaryOperations
{
    [TestFixture]
    public class PiDivNTests
    {
        [Test]
        public void PiDivNTest()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("PiDivN");
            double result = calculator.Calculate(3.14159);
            Assert.AreEqual(1, result);
        }
    }
}