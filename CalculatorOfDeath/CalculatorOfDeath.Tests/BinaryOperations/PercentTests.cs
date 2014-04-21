using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorOfDeath.BinaryOperations;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.BinaryOperations
{
    [TestFixture]
    class PercentTests
    {
        [Test]
        public void PercenTest()
        {
            IBinaryCalculator calculator = BinaryOperationFactory.Create("Percent");
            double result = calculator.Calculate(100, 10);
            Assert.AreEqual(110, result);
        }
    }
}
