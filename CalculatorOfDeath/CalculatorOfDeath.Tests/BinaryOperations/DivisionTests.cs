using CalculatorOfDeath.BinaryOperations;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.BinaryOperations
{
    [TestFixture]
    public class DivisionTests
    {
        [Test]
        public void DivisTest()
        {
            IBinaryCalculator calculator = BinaryOperationFactory.Create("Division");
            double result = calculator.Calculate(21, 7);
            Assert.AreEqual(3, result);
        }
    }
}
