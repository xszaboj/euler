using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReciprocalCycles;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test2()
        {
            var number = 2;
            var result = Calculator.CalculateCycle(number);
            Assert.AreEqual(0, result);
        }
        
        [TestMethod]
        public void Test3()
        {
            var number = 3;
            var result = Calculator.CalculateCycle(number);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test4()
        {
            var number = 4;
            var result = Calculator.CalculateCycle(number);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test5()
        {
            var number = 5;
            var result = Calculator.CalculateCycle(number);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test6()
        {
            var number = 6;
            var result = Calculator.CalculateCycle(number);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void Test7()
        {
            var number = 7;
            var result = Calculator.CalculateCycle(number);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void Test8()
        {
            var number = 8;
            var result = Calculator.CalculateCycle(number);
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Test9()
        {
            var number = 9;
            var result = Calculator.CalculateCycle(number);
            Assert.AreEqual(1, result);
        }
    }
}
