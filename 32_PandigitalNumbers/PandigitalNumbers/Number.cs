using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PandigitalNumbers
{
    public class Number
    {
        private int _a;
        private int _b;
        private List<int> numbers;

        public Number(int a, int b)
        {
            _a = a;
            _b = b;
            numbers = new List<int>();
        }

        public int A { get { return _a; } }
        public int B { get { return _b; } }

        public int Sum
        {
            get
            {
                return _a * _b;
            }
        }

        public bool IsPandigital
        {
            get
            {
                char[] first = _a.ToString().ToCharArray();
                char[] second = _b.ToString().ToCharArray();
                char[] sum = this.Sum.ToString().ToCharArray();
                var length = first.Length + second.Length + sum.Length;
                if (length == 9)
                {
                    List<int> ordered = GetOrderedNumbers(first, second, sum);
                    if (GetListValue(ordered) == "123456789")
                    {
                        return true;
                    }
                    return false;
                }
                else
                {
                    return false;
                }
            }
        }

        private List<int> GetOrderedNumbers(char[] first, char[] second, char[] sum)
        {
            AddToNumbers(first);
            AddToNumbers(second);
            AddToNumbers(sum);
            return numbers.OrderBy(a => a).ToList();
        }

        private void AddToNumbers(char[] number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                numbers.Add((int)Char.GetNumericValue(number[i]));
            }
        }

        private string GetListValue(List<int> list)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < list.Count; i++)
            {
                sb.Append(list[i]);
            }
            return sb.ToString();
        }
    }

    
}
