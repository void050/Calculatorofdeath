using CalculatorOfDeath.UnaryOperations;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.UnaryOperations
{
    [TestFixture]
    public class TanTests
    {
        [Test]
        public void TanTest()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("Tan");
            double result = calculator.Calculate(0);
            Assert.AreEqual(0, result);
        }
    }
}
