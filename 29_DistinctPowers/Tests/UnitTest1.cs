using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DistinctPowers;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var composite = new CompositeNumber(2, 2, 5);
            var result = composite.CalculatePowers();
            Assert.AreEqual(4, result[0]);
            Assert.AreEqual(8, result[1]);
            Assert.AreEqual(16, result[2]);
            Assert.AreEqual(32, result[3]);
        }
    }
}
