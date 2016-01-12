using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AmicableNumbers;

namespace Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void GetDivisors()
        {
            AmicableCalculator a = new AmicableCalculator();
            var result = a.GetDivisiorsOfNumber(220);
            Assert.AreEqual(11, result.Count);
        }

        [TestMethod]
        public void GetDivisorsSum()
        {
            AmicableCalculator a = new AmicableCalculator();
            var result = a.GetDivisorsSum(220);
            Assert.AreEqual(284, result);
        }

        [TestMethod]
        public void IsAmicable()
        {
            AmicableCalculator a = new AmicableCalculator();
            var result = a.IsAmicable(220, 284);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNotAmicable()
        {
            AmicableCalculator a = new AmicableCalculator();
            var result = a.IsAmicable(221, 284);
            Assert.IsFalse(result);
        }
    }
}
