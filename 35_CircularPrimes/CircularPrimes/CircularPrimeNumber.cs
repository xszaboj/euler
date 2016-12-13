using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularPrimes
{
    public class CircularPrimeNumber
    {
        private readonly int _primeNumber;

        public CircularPrimeNumber(int primeNumber)
        {
            if(!PrimeNumberGenerator.IsPrimeNumber(primeNumber))
            {
                throw new ArgumentException("not a prime number!");
            }
            _primeNumber = primeNumber;
        }

        private int[] GetNumbers
        {
            get
            {
                return _primeNumber.ToString().ToCharArray().Select(a => (int)char.GetNumericValue(a)).ToArray();
            }
        }

        public int PrimeNumber
        {
            get { return _primeNumber; }
        }

        public IEnumerable<int> GetAllRotations()
        {
            var numbers = GetNumbers;
            var rotations = new List<int>();
            for (int i = 1; i < numbers.Length; i++)
            {
                var s = "";
                var last = numbers.Skip(i).Take(numbers.Length - i);
                var first = numbers.Take(i);
                s += string.Join("", last);
                s += string.Join("", first);
                rotations.Add(Int32.Parse(s));
            }
            return rotations;
        }

        public bool IsCircularPrimeNumber()
        {
            foreach (var rotation in GetAllRotations())
            {
                if (!PrimeNumberGenerator.IsPrimeNumber(rotation))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
