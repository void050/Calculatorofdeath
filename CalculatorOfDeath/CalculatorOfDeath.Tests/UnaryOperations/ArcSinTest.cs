using CalculatorOfDeath.UnaryOperations;
using NUnit.Framework;


namespace CalculatorOfDeath.Tests.UnaryOperations
{
    [TestFixture]
    class ArcSinTest
    {

        [Test]
        public void ArcCosTests()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("ArcCos");
            double result = calculator.Calculate(1);
            Assert.AreEqual(0, result);
        }
    }
}
