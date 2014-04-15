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
    public class SquareTests
    {
        [Test]
        public void SqrtTest()
        {
            IBinaryCalculator calculator = BinaryOperationFactory.Create("Square");
            double result = calculator.Calculate(4, 0);
            Assert.AreEqual(2, result);
        }
    }
}

