using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingSundays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = new DateTime(1901, 1, 6);
            DateTime endDate = new DateTime(2000, 12, 31);
            DateTime currentDate = startDate;
            int counter = 0;
            while (currentDate <= endDate)
            {
                if (currentDate.Day == 1)
                {
                    counter++;
                }
                currentDate = currentDate.AddDays(7);
            }
            Console.WriteLine(counter);
            Console.ReadLine();
        }
    }
}
