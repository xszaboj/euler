using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coins
{
    public class CoinCompute
    {
        int[] _possibleCoins;
        int[] _valuesComb;

        public CoinCompute(int[] possibleCoins, int maxValue)
        {
            _possibleCoins = possibleCoins;
            _valuesComb = new int[maxValue+1];
            _valuesComb[0] = 1;
        }

        public int HowManyWaysCanYouCreate(int number)
        {
            int result = 0;
            for (int i = 0; i < _possibleCoins.Length; i++)
            {
                var coin = _possibleCoins[i];
                result = HowManyWaysCanYouGetWithCoin(number, coin);
                Console.WriteLine("Coin: {0}, Value: {1}", coin, result);
            }
            return result;
        }

        public int HowManyWaysCanYouGetWithCoin(int number, int coin)
        {
            for (int i = coin; i <= number; i++)
            {
                var res = HowManyWaysCanYouGet(i, coin);
                _valuesComb[i] = _valuesComb[i] + res;
            }
            return _valuesComb[number];
        }

        private int HowManyWaysCanYouGet(int number, int coin)
        {
            var res = number - coin;
            return _valuesComb[res];
        }
    }
}
