using DoubleBasePalindrom;
using System;
using Xunit;

namespace Tests
{
    public class ConvertorTests
    {
        [Theory]
        [InlineData("11", 3)]
        [InlineData("1001001001", 585)]
        [InlineData("11110100001001000000", 1000000)]
        [InlineData("10000000011100101", 65765)]
        public void IntToBinary_Theory(string binary, int number)
        {
            Assert.Equal(binary, Convertor.IntToBinary(number));
        }
    }
}
