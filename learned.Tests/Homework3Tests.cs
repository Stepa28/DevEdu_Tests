using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learned.Tests
{
    class Homework3Tests
    {
        //Задание 1
        [TestCase(4566.14, 987.4, 5553.54)]
        [TestCase(-4566.14, -48987.4, -53553.54)]
        [TestCase(0.0, 0.0, 0.0)]
        [TestCase(20.5, 20.5, 420.25)]
        [TestCase(20.5, 65446.156, -65425.656)]
        [TestCase(-9.41, 498.4, -507.81)]
        [TestCase(double.MaxValue, double.MaxValue, double.PositiveInfinity)]
        [TestCase(double.MinValue, double.MinValue, double.PositiveInfinity)]       
        public static void GetFunctionByConditionTest(double a, double b, double expected)
        {
            double actual = Homework3.GetFunctionByCondition(a, b);
            Assert.AreEqual(expected, actual);
        }

        //Задание 2
        [TestCase(54498.4165, 4646.1465, 1)]
        [TestCase(54498.4165, -4646.1465, 2)]
        [TestCase(-54498.4165, -4646.1465, 3)]
        [TestCase(-54498.4165, 4646.1465, 4)]
        public static void DetermineQuadrantTest(double x, double y, int expected)
        {
            int actual = Homework3.DetermineQuadrant(x, y);
            Assert.AreEqual(expected, actual);
        }        
        [TestCase(0.0, 654)]
        [TestCase(654, 0.0)]
        [TestCase(0.0, -654)]
        [TestCase(-654, 0.0)]
        [TestCase(0.0, 0.0)]       
        public static void DetermineQuadrantNegativTest(double x, double y)
        {
            Assert.Throws<ArgumentException>(() => Homework3.DetermineQuadrant(x ,y));
        }

        //Задание 3
        [TestCase(6.2, 7.5, 2.5, new double[] { 2.5, 6.2, 7.5 })]
        [TestCase(7.5, 6.2, 2.5, new double[] { 2.5, 6.2, 7.5 })]
        [TestCase(7.5, 2.5, 6.2, new double[] { 2.5, 6.2, 7.5 })]
        [TestCase(6.2, 6.2, 2.5, new double[] { 2.5, 6.2, 6.2 })]
        [TestCase(0, 0, 0, new double[] { 0, 0, 0 })]
        public static void SortingThreeNumbersTest(double a, double b, double c, double[] expented)
        {
            double[] actual = Homework3.SortingThreeNumbers(a, b, c);
            Assert.AreEqual(expented, actual);
        }

        //Задание 4
        [TestCase(0, -4, 2, new double[] { 0.5 })]
        [TestCase(1, -4, -5, new double[] { 5, -1 })]
        [TestCase(1, -6, 9, new double[] { 3 })]
        [TestCase(1, -2, -3, new double[] { 3, -1 })]
        [TestCase(-1, -2, 15, new double[] { -5, 3 })]
        public void ResolveQuadEquationTest(double a, double b, double c, double[] expected)
        {
            double[] actual = Homework3.ResolveQuadEquation(a, b, c);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(3, -4, 2)]
        [TestCase(0, 0, 245)]
        [TestCase(5, 3, 7)]
        public void ResolveQuadEquationNegativTest(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => Homework3.ResolveQuadEquation(a, b, c));
        }

        //Задание 5
        [TestCase(12, "двенадцать")]
        [TestCase(99, "девяносто девять")]
        [TestCase(19, "девятнадцать")]
        [TestCase(26, "двадцать шесть")]
        [TestCase(48, "сорок восемь")]
        public static void ToStringTwoDigitNumberTest(int num, string expected)
        {
            string actual = Homework3.ToStringTwoDigitNumber(num);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(3)]
        [TestCase(0)]
        [TestCase(548)]
        [TestCase(-89198)]
        [TestCase(100)]
        public void ToStringTwoDigitNumberNegativTest(int num)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Homework3.ToStringTwoDigitNumber(num));
        }

        //Задание 6
        [TestCase(4685.1456, 4654.4, 456, true)]
        [TestCase(4685.1456, 44.4, 49, false)]
        [TestCase(0, 4654.4, 456, false)]
        [TestCase(789, 4654.4, 456, false)]
        [TestCase(96, 449, 456, true)]
        public static void IsRectangleTest(double a, double b, double c, bool expected)
        {
            bool actual = Homework3.IsRectangle(a, b, c);
            Assert.AreEqual(expected, actual);
        }
    }
}
