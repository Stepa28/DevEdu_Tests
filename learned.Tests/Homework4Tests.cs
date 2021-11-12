using NUnit.Framework;
using System;

namespace learned.Tests
{
    static class Homework4Tests
    {
        //Задание 1
        [TestCase(100, new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 })]
        [TestCase(300, new int[] { 300, 600, 900 })]
        [TestCase(500, new int[] { 500, 1000 })]
        [TestCase(400, new int[] { 400, 800 })]
        [TestCase(50, new int[] { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500, 550, 600, 650, 700, 750, 800, 850, 900, 950, 1000 })]
        public static void GetNumbersDividedTest(int num, int[] expected)
        {
            int[] actual = Homework4.GetNumbersDivided(num);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(0)]
        [TestCase(165465)]
        [TestCase(-498)]
        public static void GetNumbersDividedNegativTest(int num)
        {
            Assert.Throws<ArgumentException>(() => Homework4.GetNumbersDivided(num));
        }

        //Задание 2
        [TestCase(16, 4)]
        [TestCase(26, 5)]
        [TestCase(0, 0)]
        [TestCase(15, 3)]
        [TestCase(10000, 100)]        
        public static void GetNumbersLessThanASquareTest(int num, int expected)
        {
            int actual = Homework4.GetNumbersLessThanASquare(num);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public static void GetNumbersLessThanASquareNegativTest()
        {
            Assert.Throws<ArgumentException>(() => Homework4.GetNumbersLessThanASquare(-498));
        }

        //Задание 3
        [TestCase(100, 50)]
        [TestCase(997, 1)]
        [TestCase(229, 1)]
        [TestCase(794, 397)]
        [TestCase(81, 27)]
        [TestCase(0, 1)]
        [TestCase(-46, 23)]
        public static void GetGreatestDivisorTest(int num, int expected)
        {
            int actual = Homework4.GetGreatestDivisor(num);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public static void GetGreatestDivisorNegativTest()
        {
            Assert.Throws<OverflowException>(() => Homework4.GetGreatestDivisor(int.MinValue));
        }

        //Задание 4
        [TestCase(int.MinValue, int.MaxValue, 0)]
        [TestCase(-4869, 4869, 0)]
        [TestCase(0, 1000, 71071)]
        [TestCase(-4989843, 45654, -1778316730498)]
        [TestCase(0, int.MaxValue, 329406144633559917)]
        public static void GetSumOfMultiplesOf7InARangeTest(int a, int b, long expected)
        {
            long actual = Homework4.GetSumOfMultiplesOf7InARange(a, b);
            Assert.AreEqual(expected, actual);
        }

        //Задание 5
        [TestCase(10, 5, 5)]
        [TestCase(-80, 10, 10)]
        [TestCase(64510, 55465, 5)]
        [TestCase(int.MinValue + 1, 645684, 1)]
        [TestCase(int.MaxValue, 41561464, 1)]
        public static void FindingTheCommonDivisorTest(int a, int b, int expected)
        {
            int actual = Homework4.FindingTheCommonDivisor(a, b);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public static void FindingTheCommonDivisorNegativeTest()
        {
            Assert.Throws<OverflowException>(() => Homework4.FindingTheCommonDivisor(int.MinValue, int.MinValue));
        }

        //Задание 6
        [TestCase(3375, 15)]
        [TestCase(1331, 11)]
        [TestCase(64, 4)]
        [TestCase(125, 5)]
        [TestCase(125, 5)]
        public static void FindingTheCubeRootTest(int num, int expected)
        {
            int actual = Homework4.FindingTheCubeRoot(num);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-645)]
        [TestCase(0)]
        [TestCase(15654)]
        public static void FindingTheCubeRootNegativTest(int num)
        {
            Assert.Throws<ArgumentException>(() => Homework4.FindingTheCubeRoot(num));
        }

        //Задание 7
        [TestCase(165165165, 6)]
        [TestCase(-694981961, 5)]
        [TestCase(1111111111, 10)]
        [TestCase(-2049845168, 3)]
        [TestCase(125561651, 6)]
        public static void GetNumberOfOddDigitsTest(int num, int expected)
        {
            int actual = Homework4.GetNumberOfOddDigits(num);
            Assert.AreEqual(expected, actual);
        }

        //Задание 8
        [TestCase(365, 563)]
        [TestCase(947, 749)]
        [TestCase(111, 111)]
        [TestCase(894, 498)]
        [TestCase(125, 521)]
        public static void GetMirrorNumberTest(int num, int expected)
        {
            int actual = Homework4.GetMirrorNumber(num);
            Assert.AreEqual(expected, actual);
        }

        //Задание 9
        [TestCase(15, new int[] { 2, 4, 6, 8, 12, 14 })]
        [TestCase(3, new int[] { 2 })]
        [TestCase(25, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24 })]
        [TestCase(30, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28 })]
        [TestCase(45, new int[] { 2, 4, 6, 8, 12, 14, 16, 18, 20, 21, 22, 24, 26, 28, 34, 36, 38, 40, 41, 42, 43, 44 })]
        public static void GetNumbersInRangeSumEvenDigitsGreaterOddTest(int num, int[] expected)
        {
            int[] actual = Homework4.GetNumbersInRangeSumEvenDigitsGreaterOdd(num);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(-4654)]
        [TestCase(0)]        
        public static void GetNumbersInRangeSumEvenDigitsGreaterOddNegativTest(int num)
        {
            Assert.Throws<ArgumentException>(() => Homework4.GetNumbersInRangeSumEvenDigitsGreaterOdd(num));
        }

        //Задание 10
        [TestCase(4648469,56548498, true)]
        [TestCase(464,64998, true)]
        [TestCase(-8974984,8498, true)]
        [TestCase(465,21212, false)]
        [TestCase(11111111,222222222, false)]
        public static void GetThereSameNumbersTest(int numOne, int numTwo, bool expected)
        {
            bool actual = Homework4.GetThereSameNumbers(numOne, numTwo);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public static void GetThereSameNumbersNegativeTest()
        {
            Assert.Throws<OverflowException>(() => Homework4.GetThereSameNumbers(int.MinValue,int.MinValue));
        }
    }
}
