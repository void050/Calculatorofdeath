using CalculatorOfDeath.UnaryOperations;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.UnaryOperations
{
    [TestFixture]
    public class ExpTests
    {
        [Test]
        public void ExpTest()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("Exp");
            double result = calculator.Calculate(2);
            Assert.AreEqual(7.3890560989306504, result);
        }
    }

}
