using CalculatorOfDeath.UnaryOperations;
using NUnit.Framework;


namespace CalculatorOfDeath.Tests.UnaryOperations
{
    [TestFixture] 

    class ArcCtgTests
    {

        [Test]
        public void ArcCtgTest()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("ArcCtg");
            double result = calculator.Calculate(0);
            Assert.AreEqual(0, result);
        }
    }
}
