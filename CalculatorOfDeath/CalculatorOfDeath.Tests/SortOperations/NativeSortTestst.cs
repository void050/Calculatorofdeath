using CalculatorOfDeath.Sort;
using NUnit.Framework;

namespace CalculatorOfDeath.Tests.SortOperations
{
    [TestFixture]
    class NativeSortTestst
    {
        [Test]
        public void NativeSortTest()
        {
            int[] mass = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            int[] result = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ISort calculator = SortFactory.CreateOperation("CocktailSort");
            int[] result_sort = calculator.Sort(mass);
            Assert.AreEqual(result, result_sort);
        }
    }
}
