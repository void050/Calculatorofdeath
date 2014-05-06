using CalculatorOfDeath.BinaryOperations;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.BinaryOperations
{
    [TestFixture]
    class ModTests
    {
        [Test]
        public void ModTest()
        {
            IBinaryCalculator calculator = BinaryOperationFactory.Create("Mod");
            double result = calculator.Calculate(7, 3);
            Assert.AreEqual(1, result);
        }
    }
}
