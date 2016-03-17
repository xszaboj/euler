using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CalculateFormulaTest()
        {
            var result = QuadraticPrimes.QuadraticPrimes.CalculateFormula(1, 1, 5);
            Assert.AreEqual(31, result);
        }

        [TestMethod]
        public void CalculateFormulaTestNegative()
        {
            var result = QuadraticPrimes.QuadraticPrimes.CalculateFormula(1, 1, -5);
            Assert.AreEqual(21, result);
        }

        [TestMethod]
        public void CalculateNumberOfConsecutivesPrimes()
        {
            var result = QuadraticPrimes.QuadraticPrimes.GetNumberOfConsecutivesPrimes(1, 41);
            Assert.AreEqual(40, result);
        }
    }
}
