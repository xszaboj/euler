using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CircularPrimes;
using NUnit.Framework;

namespace Test
{
    [TestFixture]
    public class CircularPrimesTests
    {
        [Test]
        public void GetPrimeNumbers()
        {
            var result = PrimeNumberGenerator.GetPrimeNumbers(11).ToList();
            Assert.That(result.Count, Is.EqualTo(5));
        }

        [Test]
        public void GetAllRotations_197()
        {
            CircularPrimeNumber number = new CircularPrimeNumber(197);
            var rotations = number.GetAllRotations().ToList();
            Assert.That(rotations.Count, Is.EqualTo(2));
            Assert.That(rotations[0], Is.EqualTo(971));
            Assert.That(rotations[1], Is.EqualTo(719));
        }

        [Test]
        public void GetAllRotations_13()
        {
            CircularPrimeNumber number = new CircularPrimeNumber(13);
            var rotations = number.GetAllRotations().ToList();
            Assert.That(rotations.Count, Is.EqualTo(1));
            Assert.That(rotations[0], Is.EqualTo(31));
        }

        [Test]
        public void GetAllRotations_7()
        {
            CircularPrimeNumber number = new CircularPrimeNumber(7);
            var rotations = number.GetAllRotations().ToList();
            Assert.That(rotations.Count, Is.EqualTo(0));
        }

        [TestCase(197, true)]
        [TestCase(101, false)]
        public void IsCircular(int number, bool result)
        {
            CircularPrimeNumber cp = new CircularPrimeNumber(number);
            Assert.That(cp.IsCircularPrimeNumber(), Is.EqualTo(result));
        }
    }
}
