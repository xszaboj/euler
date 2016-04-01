using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctPowers
{
    public class CompositeNumber
    {
        private int a;
        private int minb;
        private int maxb;


        public CompositeNumber(int a, int minb, int maxb)
        {
            this.a = a;
            this.minb = minb;
            this.maxb = maxb;
        }

        public List<double> CalculatePowers()
        {
            var list = new List<double>();
            for (int b = minb; b <= maxb; b++)
            {
                var result = Math.Pow(a, b);
                list.Add(result);
            }
            return list;
        }
    }
}
