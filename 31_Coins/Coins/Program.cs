using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            CoinCompute c = new CoinCompute(new int[] { 1, 2, 5, 10, 20, 50 , 100, 200 }, 200);
            var result = c.HowManyWaysCanYouCreate(200);
            Console.ReadLine();
        }
    }
}
