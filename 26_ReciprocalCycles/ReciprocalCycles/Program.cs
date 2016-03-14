using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReciprocalCycles
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            int maxlength = 0;
            for (int i = 1000; i > 0; i--)
            {
                length = Calculator.CalculateCycle(i);
                if (length > maxlength)
                {
                    Console.WriteLine("Length: {0} - Number: {1}", maxlength, i);
                    maxlength = length;
                }
            }
            Console.ReadLine();
        }
    }
}
