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
    public class CubeRootTests
    {
        [Test]
        public void CubeRootTest()
        {
            IUnaryCalculator calculator = UnaryOperationFactory.Create("CubeRoot");
            double result = calculator.Calculate(8);
            Assert.AreEqual(2, result);
        }
    }

}
