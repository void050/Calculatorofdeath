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
    public class SquarePowerTests
    {
        [Test]
        public void SquarePowerTest()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("SquarePower");
            double result = calculator.Calculate(8);
            Assert.AreEqual(64, result);
        }
    }

}
