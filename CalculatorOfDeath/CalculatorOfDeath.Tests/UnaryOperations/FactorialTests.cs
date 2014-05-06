using CalculatorOfDeath.UnaryOperations;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.UnaryOperations
{
    [TestFixture]
    public class FactorialTests
    {
        [Test]
        public void FactorialTest()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("Factorial");
            double result = calculator.Calculate(3);
            Assert.AreEqual(6, result);
        }
    }
}
