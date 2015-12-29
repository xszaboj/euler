using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NamesScores;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var n = new Names();
            var result = n.CalculateName("COLIN");
            Assert.AreEqual(53, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var n = new Names();
            var result = n.CalculateName("AaaAAB");
            Assert.AreEqual(7, result);
        }
    }
}
