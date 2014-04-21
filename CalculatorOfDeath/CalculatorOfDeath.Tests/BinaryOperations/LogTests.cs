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
    class LogTests
    {
        [Test]
        public void LogTest()
        {
            IBinaryCalculator calculator = BinaryOperationFactory.Create("Log");
            double result = calculator.Calculate(1, 4);
            Assert.AreEqual(0, result);
        }
    }
}
