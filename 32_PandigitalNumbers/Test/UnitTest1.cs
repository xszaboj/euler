using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PandigitalNumbers;

namespace Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void Pandigital()
        {
            var number = new Number(39, 186);
            Assert.IsTrue(number.IsPandigital);
        }

        [TestMethod]
        public void NotPandigital_too_long()
        {
            var number = new Number(99, 186);
            Assert.IsFalse(number.IsPandigital);
        }

        [TestMethod]
        public void NotPandigital_too_short()
        {
            var number = new Number(1, 186);
            Assert.IsFalse(number.IsPandigital);
        }

        [TestMethod]
        public void NotPandigital()
        {
            var number = new Number(40, 186);
            Assert.IsFalse(number.IsPandigital);
        }

    }
}
