using CalculatorOfDeath.UnaryOperations;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.UnaryOperations
{
    [TestFixture]

    class ArcTanTest
    {
        [Test]
        public void ArcTanTests()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("ArcTan");
            double result = calculator.Calculate(0);
            Assert.AreEqual(0, result);
        }
    }
}
