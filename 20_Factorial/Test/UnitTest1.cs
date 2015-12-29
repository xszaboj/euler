using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Factorial;
using System.Numerics;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Calculate c = new Calculate();
            var result = c.CalculateFactorial(3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Calculate c = new Calculate();
            var result = c.CalculateFactorial(10);
            Assert.AreEqual(3628800, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            Calculate c = new Calculate();
            var result = c.CalculateFactorial(20);
            Assert.AreEqual(new BigInteger((ulong)2432902008176640000), result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            Calculate c = new Calculate();
            BigInteger result = c.CalculateFactorial(100);
            result.ToString();

        }
    }
}
