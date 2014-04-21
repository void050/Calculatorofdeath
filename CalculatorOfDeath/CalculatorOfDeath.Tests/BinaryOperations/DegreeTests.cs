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
    class DegreeTests
    {
        [Test]
        public void DegreeTest()
        {
            IBinaryCalculator calculator = BinaryOperationFactory.Create("Degree");
            double result = calculator.Calculate(2, 3);
            Assert.AreEqual(8, result);
        }
    }
}
