using System;
using CalculatorOfDeath.BinaryOperations;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.BinaryOperations
{
    [TestFixture]
    public class SqrtABTests
    {
        [Test]
        public void SqrtABTest()
        {
            IBinaryCalculator calculator = BinaryOperationFactory.Create("SqrtAB");
            double result = calculator.Calculate(2, 2);
            Assert.AreEqual(2, result);
        }

        [Test]
        [ExpectedException(typeof(Exception))]
        public void SqrtABFailTest()
        {
            IBinaryCalculator calculator = BinaryOperationFactory.Create("SqrtAB");
            double result = calculator.Calculate(-1, -2);
        }
    }

}
