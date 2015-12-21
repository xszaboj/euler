using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglePath
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new Reader("triangle.txt");
            var arr = reader.ReadTriangle(15);
            reader.Print(arr);

            var calucator = new PathCalculator(arr);
            var max =calucator.GetMaxPath();
            Console.WriteLine("MAX: {0}", max);

            Console.ReadLine();
        }
    }
}
