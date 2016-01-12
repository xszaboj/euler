using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new FibonaciSequence();
            var result = f.Fibonaci(1000);
            Console.WriteLine(f.index);
            Console.ReadLine();
        }
    }
}
