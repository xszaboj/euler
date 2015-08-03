using System;
using HighlyDivisibleTriangularNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetTriangualNumberTest()
        {
            double sum = 0;
            for (int i = 0; i < 7; i++)
            {
                sum = Program.GetNextTriangularNumber(i, sum);
            }

            Assert.AreEqual(28, sum);
        }

        [TestMethod]
        public void GetDivisors()
        {
            var primeNumbers = Program.GetPrimeNumbers(100);
            var divisors = Program.GetDivisors(28, primeNumbers.ToArray());
            Assert.AreEqual(6, divisors);
        }

        [TestMethod]
        public void GetDivisors2()
        {
            var primeNumbers = Program.GetPrimeNumbers(1001);
            var divisors = Program.GetDivisors(5, primeNumbers.ToArray());
            Assert.AreEqual(2, divisors);
        }
    }
}
