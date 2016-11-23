using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCancelingFractions
{
    public class FractionCalculator
    {
        public static float Calculate(int nominator, int denominator)
        {
            if (denominator <= 0)
            {
                throw new ArgumentException("Invalid denominator");
            }
            return (nominator/(float)denominator);
        }

        public List<Fraction> CalculateSameAsReduced()
        {
            var same = new List<Fraction>();
            for (int nominator = 10; nominator <= 99; nominator++)
            {
                for (int denominator = nominator+1; denominator <= 99; denominator++)
                {
                    Fraction f = new Fraction(nominator, denominator);
                    if (f.IsSameResultAfterReduce())
                    {
                        same.Add(f);
                    }
                }
            }
            return same;
        }
    }
}
