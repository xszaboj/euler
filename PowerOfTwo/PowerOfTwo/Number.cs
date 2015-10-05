using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTwo
{
    public class BigNumber
    {
        private string num;
        private List<int> sequence;
        public BigNumber(string number)
        {
            num = number;
        }
        

        public string Number { get {
            return this.num;
        } }

        public List<int> SequenceOfNumbers
        {
            get
            {
                if (sequence == null)
                {
                    var list = new List<int>();
                    foreach (var number in num)
                    {
                        int n = (int)Char.GetNumericValue(number);
                        list.Add(n);
                    }
                    sequence = list;
                }
                return sequence;
            }
        }
    }
}
