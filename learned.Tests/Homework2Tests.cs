using NUnit.Framework;
using System;

namespace learned.Tests
{
    public static class Homework2Tests
    {
        //Задание 1
        [TestCase(548, 17)]
        [TestCase(849, 21)]
        [TestCase(957, 21)]
        [TestCase(656, 17)]
        [TestCase(100, 1)]
        public static void GetSumOfDigitsOfNumberTest(int num, int expected)
        {
            int actual = Homework2.GetSumOfDigitsOfNumber(num);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(649898)]
        [TestCase(0)]
        [TestCase(78)]
        [TestCase(-416)]
        [TestCase(int.MinValue)]
        public static void GetSumOfDigitsOfNumberNegativTest(int num)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Homework2.GetSumOfDigitsOfNumber(num));
        }

        //Задание 2
        [TestCase(4654.46, 56489.64, 548948956.6546, true)]
        [TestCase(-4654.46, -5648.64, 48956.6546, true)]
        [TestCase(4654.46, 56489.64, 156, false)]
        [TestCase(2, 2, 2, false)]
        [TestCase(2, 2, 4, true)]
        public static void GetHitTheTargetTest(double x, double y, double rad, bool expected)
        {
            bool actual = Homework2.GetHitTheTarget(x, y, rad);
            Assert.AreEqual(expected, actual);
        }            
        [TestCase(double.MaxValue, double.MaxValue, double.MaxValue)]
        [TestCase(double.MinValue, double.MinValue, double.MinValue)]
        [TestCase(1.3407807929942596 * 10000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000000.0 + 1, 0,0)] //Math.Sqrt(double.MaxValue) + 1
        public static void GetHitTheTargetNegativTest(double x, double y, double rad)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Homework2.GetHitTheTarget(x, y, rad));
        }

        //Задание 3
        [TestCase(742, true)]
        [TestCase(773, true)]
        [TestCase(755, false)]
        [TestCase(354, false)]
        [TestCase(335, false)]
        [TestCase(-742, true)]
        public static void GetMiddleFigureBetweenTest(int num, bool expected)
        {
            bool actual = Homework2.GetMiddleFigureBetween(num);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(8948998)]
        [TestCase(-8499)]
        [TestCase(0)]
        [TestCase(99)]
        [TestCase(-1000)]
        public static void GetMiddleFigureBetweenNegativTest(int num)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Homework2.GetMiddleFigureBetween(num));
        }

        //Задание 4
        [TestCase(365, 563)]
        [TestCase(947, 749)]
        [TestCase(111, 111)]
        [TestCase(894, 498)]
        [TestCase(125, 521)]
        public static void GetMirrorNumberTest(int num, int expected)
        {
            int actual = Homework2.GetMirrorNumber(num);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(8948998)]
        [TestCase(-8499)]
        [TestCase(0)]
        [TestCase(99)]
        [TestCase(-1000)]
        public static void GetMirrorNumberNegativTest(int num)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Homework2.GetMirrorNumber(num));
        }

        //Задание 5
        [TestCase(1468498.0, true)]
        [TestCase(-8498.0, true)]
        [TestCase(1468.1516516, false)]
        [TestCase(0.6546, false)]
        [TestCase(-9489.06541, false)]
        public static void GetZeroFractionalPart(double num, bool expected)
        {
            bool actual = Homework2.GetZeroFractionalPart(num);
            Assert.AreEqual(expected, actual);
        }
    }
}
