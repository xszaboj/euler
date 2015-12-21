using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrianglePath;

namespace Test
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        public void CalculateSumSimple()
        {
            var triangle = new int[3][];
            triangle[0] = new int[1]    { 1 };
            triangle[1] = new int[2]  { 2 , 3 };
            triangle[2] = new int[3] { 4, 5, 6 };
            PathCalculator p = new PathCalculator(triangle);
            var sumRow = p.CalculateSum(triangle[2], triangle[1]);
            CollectionAssert.AreEqual(new int[3] { 6, 8, 9 }, sumRow);
        }

        [TestMethod]
        public void CalculateSumExtended()
        {
            var triangle = new int[2][];
            triangle[0] = new int[5]    { 08 , 06 , 09 , 11 , 99 };
            triangle[1] = new int[6] { 22 , 33 , 66 , 12 , 15 , 20 };
            PathCalculator p = new PathCalculator(triangle);
            var sumRow = p.CalculateSum(triangle[1], triangle[0]);
            CollectionAssert.AreEqual(new int[6] { 30, 41, 75, 23, 114, 119 }, sumRow);
        }
    }
}
