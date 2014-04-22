using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculatorOfDeath.UnaryOperations;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.UnaryOperations
{
    [TestFixture]
    public class FactorialTests
    {
        [Test]
        public void FactorialTest()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("Factorial");
            double result = calculator.Calculate(3);
            Assert.AreEqual(6, result);
        }
    }
}
