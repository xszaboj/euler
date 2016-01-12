using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fibonaci;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var f = new FibonaciSequence();
            var result = f.Fibonaci(3);
            Assert.AreEqual("144", result.ToString());
            Assert.AreEqual(12,f.index);
        }

        [TestMethod]
        public void TestMethod2()
        {
            var f = new FibonaciSequence();
            var result = f.Fibonaci(1);
            Assert.AreEqual("2", result.ToString());
            Assert.AreEqual(3, f.index);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var f = new FibonaciSequence();
            var result = f.Fibonaci(1000);
            Assert.AreEqual("2", result.ToString());
        }
    }
}
