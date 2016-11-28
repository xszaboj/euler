using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Factorial
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void CalculateFactorial_3()
        {
            Calculate c = new Calculate();
            var result = c.CalculateFactorial(3);
            Assert.That(new BigInteger(6), Is.EqualTo(result));
        }

        [Test]
        public void CalculateFactorial_10()
        {
            Calculate c = new Calculate();
            var result = c.CalculateFactorial(10);
            Assert.That(new BigInteger(3628800), Is.EqualTo(result));
        }

        [Test]
        public void CalculateFactorial_9()
        {
            Calculate c = new Calculate();
            var result = c.CalculateFactorial(9);
            Assert.That(new BigInteger(362880), Is.EqualTo(result));
        }

        [Test]
        public void CalculateFactorial_20()
        {
            Calculate c = new Calculate();
            var result = c.CalculateFactorial(20);
            Assert.That(new BigInteger((ulong)2432902008176640000), Is.EqualTo(result));
        }
    }
}
