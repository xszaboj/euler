using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Abundant;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetDivisors()
        {
            AbundantNumbers a = new AbundantNumbers();
            var result = a.GetDivisiorsOfNumber(220);
            Assert.AreEqual(11, result.Count);
        }

        [TestMethod]
        public void GetDivisorsSum()
        {
            AbundantNumbers a = new AbundantNumbers();
            var result = a.GetDivisorsSum(220);
            Assert.AreEqual(284, result);
        }

        [TestMethod]
        public void IsAbundant()
        {
            AbundantNumbers a = new AbundantNumbers();
            var result = a.IsAbundant(12);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsAbundant2()
        {
            AbundantNumbers a = new AbundantNumbers();
            var result = a.IsAbundant(20);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void IsNotAbundant()
        {
            AbundantNumbers a = new AbundantNumbers();
            var result = a.IsAbundant(28);
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SumOfNonAbundant()
        {
            AbundantNumbers a = new AbundantNumbers();
            var abundants = a.GetAbundatnNumbers(100);
            var sum = a.SumOfNonAbundant(100, abundants);
            Assert.AreEqual(2766, sum);
        }
    }
}
