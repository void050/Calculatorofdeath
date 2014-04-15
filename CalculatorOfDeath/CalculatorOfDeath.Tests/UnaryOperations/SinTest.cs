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
    public class SinTests
    {
        [Test]
        public void SinTest()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("Sin");
            double result = calculator.Calculate(0);
            Assert.AreEqual(0, result);
        }
    }
}
