using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamesScores
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = new Names();
            var result = n.CalculateNamesSum();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
