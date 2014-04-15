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
    public class DeleteXTests
    {
        [Test]
        public void DeleteXTest()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("DeleteX");
            double result = calculator.Calculate(2);
            Assert.AreEqual(0.5, result);
        }
    }

}
