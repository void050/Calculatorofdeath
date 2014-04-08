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
    public class SubstractionTests
    {
        [Test]
        public void SubtractTest()
        {
            IBinaryCalculator calculator = BinaryOperationFactory.Create("Substraction");
            double result = calculator.Calculate(10, 7);
            Assert.AreEqual(3, result);
        }
    }
}
