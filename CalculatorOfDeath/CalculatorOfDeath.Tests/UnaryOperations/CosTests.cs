using CalculatorOfDeath.UnaryOperations;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.UnaryOperations
{
    [TestFixture]
    public class CosTests
    {
        [Test]
        public void CosTest()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("Cos");
            double result = calculator.Calculate(0);
            Assert.AreEqual(1, result);
        }
    }
}
