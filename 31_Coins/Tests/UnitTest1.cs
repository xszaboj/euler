using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Coins;

namespace Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void GetNumberOfSolutionsCoin1Value1()
        {
            CoinCompute c = new CoinCompute(new int[]{ 1 }, 1);
            var result = c.HowManyWaysCanYouGetWithCoin(1, 1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetNumberOfSolutionsCoin1Value2()
        {
            CoinCompute c = new CoinCompute(new int[] { 1 }, 2);
            var result = c.HowManyWaysCanYouGetWithCoin(2, 1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetNumberOfSolutionsCoin1Value3()
        {
            CoinCompute c = new CoinCompute(new int[] { 1 }, 3);
            var result = c.HowManyWaysCanYouGetWithCoin(3, 1);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetNumberOfSolutionsCoin1And2Value3()
        {
            CoinCompute c = new CoinCompute(new int[] { 1, 2 }, 3);
            var result = c.HowManyWaysCanYouGetWithCoin(3, 1);
            Assert.AreEqual(1, result);
            result = c.HowManyWaysCanYouGetWithCoin(3, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void GetNumberOfSolutionsCoin1And2Value5()
        {
            CoinCompute c = new CoinCompute(new int[] { 1, 2 }, 5);
            var result = c.HowManyWaysCanYouGetWithCoin(5, 1);
            Assert.AreEqual(1, result);
            result = c.HowManyWaysCanYouGetWithCoin(5, 2);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetNumberOfSolutionsCoin1And2Value5Auto()
        {
            CoinCompute c = new CoinCompute(new int[] { 1, 2 }, 5);
            var result = c.HowManyWaysCanYouCreate(5);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void GetNumberOfSolutionsCoin1And2And5Value5Auto()
        {
            CoinCompute c = new CoinCompute(new int[] { 1, 2, 5 }, 5);
            var result = c.HowManyWaysCanYouCreate(5);
            Assert.AreEqual(4, result);
        }
    }
}
