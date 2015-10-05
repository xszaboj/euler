using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PowerOfTwo;

namespace PowerOfTwoTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var numberOne = new BigNumber("925");
            var numberTwo = new BigNumber("125");
            var result = Program.Multiply(numberOne, numberTwo);
            Assert.AreEqual("115625", result.Number);
        }
    }
}
