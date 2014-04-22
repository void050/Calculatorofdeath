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
    public class SubtractionTests
    {
        [Test]
        public void SubtractionTest()
        {
            IBinaryCalculator calculator = BinaryOperationFactory.Create("Subtraction");
            double result = calculator.Calculate(7, 4);
            Assert.AreEqual(3, result);
        }
    }

}
