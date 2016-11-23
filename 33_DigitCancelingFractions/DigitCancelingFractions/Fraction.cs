using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace DigitCancelingFractions
{
    public struct Fraction
    {
        private readonly int _nominator;
        private readonly int _denominator;

        private int[] NominatorNumbers
        {
            get
            {
                return Nominator.ToString().ToCharArray().Select(a => (int)char.GetNumericValue(a)).ToArray();
            }
        }

        private int[] DenominatorNumbers
        {
            get
            {
                return Denominator.ToString().ToCharArray().Select(a => (int)char.GetNumericValue(a)).ToArray();
            }
        }

        public Fraction(int nominator, int denominator)
        {
            _nominator = nominator;
            _denominator = denominator;
        }

        public int Nominator
        {
            get { return _nominator; }
        }

        public int Denominator
        {
            get { return _denominator; }
        }

        public float Result
        {
            get { return FractionCalculator.Calculate(Nominator, Denominator); }
        }

        public bool HasSameNumberInNominatorAndDenominator()
        {
            foreach (var denominatorNumber in DenominatorNumbers)
            {
                if (NominatorNumbers.Contains(denominatorNumber))
                {
                    return true;
                }
            }
            return false;
        }

        public int SameNumberInNominatorAndDenominator()
        {
            foreach (var denominatorNumber in DenominatorNumbers)
            {
                if (NominatorNumbers.Contains(denominatorNumber))
                {
                    return denominatorNumber;
                }
            }
            throw new ArgumentException("No same numbers in fraction!");
        }

        public bool CanBeReduced()
        {
            return Nominator > 10 && Denominator > 10;
        }

        public bool IsSimpleReduce()
        {
            if (Nominator == Denominator)
            {
                return true;
            }
            if (Nominator%10 == 0 || Denominator%10 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsSameResultAfterReduce()
        {
            if (CanBeReduced() && HasSameNumberInNominatorAndDenominator() && !IsSimpleReduce())
            {
                var reducedNominator = Nominator.Reduce(SameNumberInNominatorAndDenominator());
                var reducedDenominator = Denominator.Reduce(SameNumberInNominatorAndDenominator());
                var fraction = new Fraction(reducedNominator, reducedDenominator);
                return fraction.Result == this.Result;
            }
            return false;
        }
    }
}
