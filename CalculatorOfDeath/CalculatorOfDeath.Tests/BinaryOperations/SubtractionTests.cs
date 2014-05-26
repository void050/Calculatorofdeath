using CalculatorOfDeath.BinaryOperations;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.BinaryOperations
{
    [TestFixture]
    public class SubstractionTests
    {
        [Test]
        public void SubstractionTest()
        {
            IBinaryCalculator calculator = BinaryOperationFactory.Create("Substraction");
            double result = calculator.Calculate(7, 4);
            Assert.AreEqual(3, result);
        }
    }

}
