using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumberSpiralDiagonals;


namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod3x3()
        {
            var spiral = new NumberSpiral();
            var result = spiral.CalculateDiagonal(1);
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void TestMethod5x5()
        {
            var spiral = new NumberSpiral();
            var result = spiral.CalculateDiagonal(3);
            Assert.AreEqual(101, result);
        }

        [TestMethod]
        public void TestMethod1001x1001()
        {
            var spiral = new NumberSpiral();
            var result = spiral.CalculateDiagonal(999);
            Assert.AreEqual(669171001, result);
        }

        [TestMethod]
        public void GetSize_zero()
        {
            var result = NumberSpiral.GetSize(0);
            Assert.AreEqual(-1,result);
        }

        [TestMethod]
        public void GetSize_one()
        {
            var result = NumberSpiral.GetSize(1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetSize_two()
        {
            var result = NumberSpiral.GetSize(2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetSize_three()
        {
            var result = NumberSpiral.GetSize(3);
            Assert.AreEqual(5, result);
        }

    }
}
