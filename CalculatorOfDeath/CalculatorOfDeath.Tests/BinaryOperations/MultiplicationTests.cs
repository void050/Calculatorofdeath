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
    public class MultiplicationTests
    {
        [Test] 
        public void MultiTest()
        {
            IBinaryCalculator calculator = BinaryOperationFactory.Create("Multiplication");
            double result = calculator.Calculate(3, 7);
            Assert.AreEqual(21, result);
        }
    }
}
