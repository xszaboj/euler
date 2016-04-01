using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DigitFifthPowers;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            FifthPower pw = new FifthPower(2);
            var result = pw.CalculateFifthPowerOfDigits();
            Assert.AreEqual(32, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            FifthPower pw = new FifthPower(55);
            var result = pw.CalculateFifthPowerOfDigits();
            Assert.AreEqual(6250, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            FifthPower pw = new FifthPower(20);
            var result = pw.CalculateFifthPowerOfDigits();
            Assert.AreEqual(32, result);
        }
    }
}
