using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LexicographicPermutations;
using System.Linq;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FindLargestMobileElement()
        {
            var p = new Permutations();
            var largest = p.GetLargestMobile(GetElements());
            Assert.AreEqual(3, largest.Value);
        }

        [TestMethod]
        public void FindLargestMobileElement2()
        {
            var p = new Permutations();
            var largest = p.GetLargestMobile(GetElements2());
            Assert.AreEqual(2, largest.Value);
        }

        [TestMethod]
        public void FindLargestMobileElement3()
        {
            var p = new Permutations();
            var largest = p.GetLargestMobile(GetElements3());
            Assert.AreEqual(3, largest.Value);
        }

        [TestMethod]
        public void FindLargestAndSwap()
        {
            var p = new Permutations();
            var elements = GetElements();
            p.FirstStepSwapAdj(elements);
            Assert.AreEqual(3, elements[1].Value);
            Assert.AreEqual(2, elements[2].Value);
        }

        [TestMethod]
        public void TestRun_3Elements()
        {
            var p = new Permutations();
            var elements = GetElements();
            var result = p.CreatePermutationsWithoutRepetition(elements.ToList());
            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, result[0].GetValues());
            CollectionAssert.AreEqual(new int[] { 1, 3, 2 }, result[1].GetValues());
            CollectionAssert.AreEqual(new int[] { 3, 1, 2 }, result[2].GetValues());
            CollectionAssert.AreEqual(new int[] { 3, 2, 1 }, result[3].GetValues());
            CollectionAssert.AreEqual(new int[] { 2, 3, 1 }, result[4].GetValues());
            CollectionAssert.AreEqual(new int[] { 2, 1, 3 }, result[5].GetValues());
        }

        [TestMethod]
        public void TestRun_4Elements()
        {
            var p = new Permutations();
            var elements = GetElements4();
            var result = p.CreatePermutationsWithoutRepetition(elements.ToList());
            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4 }, result[0].GetValues());
            CollectionAssert.AreEqual(new int[] { 1, 2, 4, 3 }, result[1].GetValues());
            CollectionAssert.AreEqual(new int[] { 1,4,2,3}, result[2].GetValues());
            CollectionAssert.AreEqual(new int[] {4,1,2,3 }, result[3].GetValues());
            CollectionAssert.AreEqual(new int[] { 4,1,3,2 }, result[4].GetValues());
            CollectionAssert.AreEqual(new int[] { 1,4,3,2 }, result[5].GetValues());
            CollectionAssert.AreEqual(new int[] { 2, 1, 3, 4 }, result[23].GetValues());
        }


        private Element[] GetElements()
        {
            return new Element[]{ 
                new Element(){ Value = 1, Position = LexicographicPermutations.Enums.Positions.Left},
                new Element(){ Value = 2, Position = LexicographicPermutations.Enums.Positions.Left},
                new Element(){ Value = 3, Position = LexicographicPermutations.Enums.Positions.Left},
            };
        }

        private Element[] GetElements2()
        {
            return new Element[]{ 
                new Element(){ Value = 3, Position = LexicographicPermutations.Enums.Positions.Left},
                new Element(){ Value = 1, Position = LexicographicPermutations.Enums.Positions.Left},
                new Element(){ Value = 2, Position = LexicographicPermutations.Enums.Positions.Left},
            };
        }

        private Element[] GetElements3()
        {
            return new Element[]{ 
                new Element(){ Value = 3, Position = LexicographicPermutations.Enums.Positions.Right},
                new Element(){ Value = 2, Position = LexicographicPermutations.Enums.Positions.Left},
                new Element(){ Value = 1, Position = LexicographicPermutations.Enums.Positions.Left},
            };
        }

        private Element[] GetElements4()
        {
            return new Element[]{ 
                new Element(){ Value = 1, Position = LexicographicPermutations.Enums.Positions.Left},
                new Element(){ Value = 2, Position = LexicographicPermutations.Enums.Positions.Left},
                new Element(){ Value = 3, Position = LexicographicPermutations.Enums.Positions.Left},
                new Element(){ Value = 4, Position = LexicographicPermutations.Enums.Positions.Left},
            };
        }
    }
}
