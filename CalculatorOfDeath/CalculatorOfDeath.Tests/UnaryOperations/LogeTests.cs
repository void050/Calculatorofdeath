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
    public class LogeTests
    {
        [Test]
        public void LogeTest()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("Loge");
            double result = calculator.Calculate(1);
            Assert.AreEqual(0, result);
        }
    }
}