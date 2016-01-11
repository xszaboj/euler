using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Numerics;
using PowerOfTwo;

namespace Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            double number = 2;
            int power = 2;
            BigInteger num = PowerCalculator.Power(number, power);
            Assert.AreEqual("4", num.ToString());
        }

        [TestMethod]
        public void TestMethod2()
        {
            double number = 5;
            int power = 2;
            BigInteger num = PowerCalculator.Power(number, power);
            Assert.AreEqual("25", num.ToString());
        }

        [TestMethod]
        public void TestMethod3()
        {
            double number = 2;
            int power = 1000;
            BigInteger num = PowerCalculator.Power(number, power);
        }
    }
}
