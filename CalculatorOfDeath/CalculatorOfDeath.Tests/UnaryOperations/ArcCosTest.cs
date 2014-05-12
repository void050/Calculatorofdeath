using CalculatorOfDeath.UnaryOperations;
using NUnit.Framework;


namespace CalculatorOfDeath.Tests.UnaryOperations
{
    [TestFixture]
    class ArcCosTest
    {
        [Test]
        public void ArcSinTests()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("ArcSin");
            double result = calculator.Calculate(0);
            Assert.AreEqual(0, result);
        }
    }
}
