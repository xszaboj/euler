using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace DigitCancelingFractions
{
    /* The fraction 49/98 is a curious fraction, as an inexperienced mathematician in attempting to simplify it may incorrectly believe that 49/98 = 4/8, which is correct, is obtained by cancelling the 9s.
        We shall consider fractions like, 30/50 = 3/5, to be trivial examples.
        There are exactly four non-trivial examples of this type of fraction, less than one in value, and containing two digits in the numerator and denominator.
        If the product of these four fractions is given in its lowest common terms, find the value of the denominator. 
     */
    [TestFixture]
    public class FractionCalculatorTest
    {
        [TestCase(1, 2, 0.5f)]
        public void TestCalculator(int nominator, int denominator, float result)
        {
            float res = FractionCalculator.Calculate(nominator, denominator);
            Assert.That(res, Is.EqualTo(result));
        }

        [TestCase(1, 2, 0.5f)]
        public void FractionResult(int nominator, int denominator, float result)
        {
            Fraction fraction = new Fraction(nominator, denominator);
            Assert.That(fraction.Result, Is.EqualTo(result));
        }

        [TestCase(49, 98, true)]
        [TestCase(12, 21, true)]
        [TestCase(59, 76, false)]
        [TestCase(11, 99, false)]
        [TestCase(3, 5, false)]
        [TestCase(3, 15, false)]
        public void HasSameNumberInNominatorAndDenominator(int nominator, int denominator, bool result)
        {
            Fraction fraction = new Fraction(nominator, denominator);
            Assert.That(fraction.HasSameNumberInNominatorAndDenominator(), Is.EqualTo(result));
        }

        [TestCase(49, 98, 9)]
        [TestCase(12, 21, 2)]
        public void SameNumberInNominatorAndDenominator(int nominator, int denominator, int result)
        {
            Fraction fraction = new Fraction(nominator, denominator);
            Assert.That(fraction.SameNumberInNominatorAndDenominator(), Is.EqualTo(result));
        }

        [TestCase(11, 99, true)]
        [TestCase(3, 5, false)]
        [TestCase(3, 15, false)]
        public void CanBeReduced(int nominator, int denominator, bool result)
        {
            Fraction fraction = new Fraction(nominator, denominator);
            Assert.That(fraction.CanBeReduced(), Is.EqualTo(result));
        }

        [TestCase(10, 50, true)]
        [TestCase(11, 11, true)]
        [TestCase(15, 25, false)]
        public void IsSimpleReduce(int nominator, int denominator, bool result)
        {
            Fraction fraction = new Fraction(nominator, denominator);
            Assert.That(fraction.IsSimpleReduce(), Is.EqualTo(result));
        }

        [TestCase(49, 98, true)]
        [TestCase(10, 50, false)]
        [TestCase(11, 11, false)]
        [TestCase(15, 25, false)]
        public void IsSameResultAfterReduce(int nominator, int denominator, bool result)
        {
            Fraction fraction = new Fraction(nominator, denominator);
            Assert.That(fraction.IsSameResultAfterReduce(), Is.EqualTo(result));
        }

        [TestCase(18, 1)]
        [TestCase(58, 5)]
        [TestCase(89, 9)]
        public void Reduce_8(int number, int result)
        {
            var res = number.Reduce(8);
            Assert.That(res, Is.EqualTo(res));
        }

        [Test]
        public void DivideByZero()
        {
            Assert.That(() => FractionCalculator.Calculate(1, 0), Throws.Exception.TypeOf<ArgumentException>().With.Message.EqualTo("Invalid denominator"));
        }

        [Test]
        public void CalculateSameAsReduced()
        {
            var calculator = new FractionCalculator();
            var same = calculator.CalculateSameAsReduced();
            Assert.AreEqual(4, same.Count);
            //results:
            /*
             16/64 = 1/4
             19/95 = 1/5
             26/65 = 2/5
             49/98 = 1/2
             1/4 * 1/5 * 2/5 * 1/2 = 2/200 = 1/100
             */
        }
    }
}
