using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumbersToWords;

namespace Tests
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void One()
        {
            int one = 1;
            var translator = new IntToWordConverter();
            var result = translator.GetText(one);
            Assert.AreEqual("one", result);
        }

        [TestMethod]
        public void Two()
        {
            int number = 2;
            var translator = new IntToWordConverter();
            var result = translator.GetText(number);
            Assert.AreEqual("two", result);
        }

        [TestMethod]
        public void Thirteen()
        {
            int number = 13;
            var translator = new IntToWordConverter();
            var result = translator.GetText(number);
            Assert.AreEqual("thirteen", result);
        }

        [TestMethod]
        public void ThirtySix()
        {
            int number = 36;
            var translator = new IntToWordConverter();
            var result = translator.GetText(number);
            Assert.AreEqual("thirty-six", result);
        }

        [TestMethod]
        public void Forty()
        {
            int number = 40;
            var translator = new IntToWordConverter();
            var result = translator.GetText(number);
            Assert.AreEqual("forty", result);
        }

        [TestMethod]
        public void TwentySeven()
        {
            int number = 27;
            var translator = new IntToWordConverter();
            var result = translator.GetText(number);
            Assert.AreEqual("twenty-seven", result);
        }

        [TestMethod]
        public void NinetyNine()
        {
            int number = 99;
            var translator = new IntToWordConverter();
            var result = translator.GetText(number);
            Assert.AreEqual("ninety-nine", result);
        }

        [TestMethod]
        public void fiftyfive()
        {
            int number = 55;
            var translator = new IntToWordConverter();
            var result = translator.GetText(number);
            Assert.AreEqual("fifty-five", result);
        }


        [TestMethod]
        public void OneHundredAndFour()
        {
            int number = 104;
            var translator = new IntToWordConverter();
            var result = translator.GetText(number);
            Assert.AreEqual("one hundred and four", result);
        }

        [TestMethod]
        public void OneHundredAndEightySeven()
        {
            int number = 187;
            var translator = new IntToWordConverter();
            var result = translator.GetText(number);
            Assert.AreEqual("one hundred and eighty-seven", result);
        }

        [TestMethod]
        public void fiveHundred()
        {
            int number = 500;
            var translator = new IntToWordConverter();
            var result = translator.GetText(number);
            Assert.AreEqual("five hundred", result);
        }

        [TestMethod]
        public void SevenHundredNinetyNine()
        {
            int number = 799;
            var translator = new IntToWordConverter();
            var result = translator.GetText(number);
            Assert.AreEqual("seven hundred and ninety-nine", result);
        }

        [TestMethod]
        public void thousand()
        {
            int number = 1000;
            var translator = new IntToWordConverter();
            var result = translator.GetText(number);
            Assert.AreEqual("one thousand", result);
        }

        
    }
}
