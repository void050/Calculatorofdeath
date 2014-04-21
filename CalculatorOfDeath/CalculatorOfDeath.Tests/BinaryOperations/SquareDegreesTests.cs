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
    class SquareDegreesTests
    {
        [Test]
        public void SquareDegreesTest()
        {
            IBinaryCalculator calculator = BinaryOperationFactory.Create("SquareDegrees");
            double result = calculator.Calculate(4, 2);
            Assert.AreEqual(2, result);
        }
    }
}
