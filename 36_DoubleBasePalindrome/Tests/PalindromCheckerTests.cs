using DoubleBasePalindrom;
using System;
using Xunit;

namespace Tests
{
    public class PalindromCheckerTests
    {
        [Theory]
        [InlineData("585", true)]
        [InlineData("1001001001", true)]
        [InlineData("aaa", true)]
        [InlineData("not a palindrom", false)]
        public void IsPalindrom_Theory(string text, bool result)
        {
            Assert.Equal(PalindromChecker.IsPalindrom(text), result);
        }

    }
}
