using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSpiralDiagonals
{
    class Program
    {
        //999 because i don't count corners  so 999 + 2 (2 corners on both sides = 1001)
        static void Main(string[] args)
        {
            var spiral = new NumberSpiral();
            var result = spiral.CalculateDiagonal(999);

        }
    }
}
