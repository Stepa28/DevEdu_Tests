using NUnit.Framework;
using System;

namespace learned.Tests
{
    public class Homework1Tests
    {
        //Задание 1
        [TestCase(10, 2.5, "привет, 10!\n10 + 2,5 = 12,5\nпока, 2,5...")]
        [TestCase(0, -3.77, "привет, 0!\n0 + -3,77 = -3,77\nпока, -3,77...")]
        [TestCase(0, 0.0, "привет, 0!\n0 + 0 = 0\nпока, 0...")]
        [TestCase(-8468, 7.994, "привет, -8468!\n-8468 + 7,994 = -8460,006\nпока, 7,994...")]
        [TestCase(189484984, 8.941964, "привет, 189484984!\n189484984 + 8,941964 = 189484992,941964\nпока, 8,941964...")]
        public static void GetHelloByeStringTest(int a, double b, string expected)
        {
            string actual = Homework1.GetHelloByeString(a, b);
            Assert.AreEqual(expected, actual);
        }
        //[Test] //Оно не переполняется мб т.к. складываются внутри строки($)
        //public static void GetHelloByeStringNegativTest()
        //{
        //    Assert.Throws<ArgumentOutOfRangeException>(() => Homework1.GetHelloByeString(165, double.MaxValue));
        //}

        //Задание 2
        [TestCase(49.5, 15.7, -1804.8763343195264)]
        [TestCase(-489.1, 87.4, 101211.11680416307)]
        [TestCase(98.0, 478.1, 137460243.61418602)]
        [TestCase(-89, -97, -11066104.5)]
        [TestCase(114.88, 47.5, -75560.084038290312)]
        public static void EquationSolutionTest(double a, double b, double expected)
        {
            double actual = Homework1.EquationSolution(a, b);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public static void EquationSolutionNegativTest()
        {
            Assert.Throws<DivideByZeroException>(() => Homework1.EquationSolution(165.4, 165.4));           
        }

        //Задание 3
        [TestCase("Привет!", "Это я, ", "Это я, Привет!")]
        [TestCase("вафыафпва", "45468фываф ", "45468фываф вафыафпва")]
        [TestCase("╰(▔∀▔)╯ (─‿‿─) (*^‿^*) ヽ(o^―^o)ﾉ", "Тецувы", "Тецувы╰(▔∀▔)╯ (─‿‿─) (*^‿^*) ヽ(o^―^o)ﾉ")]
        [TestCase("(⌒_⌒;) (o^ ^o) (*/ω＼) (*/。＼)", "Это я, ", "Это я, (⌒_⌒;) (o^ ^o) (*/ω＼) (*/。＼)")]
        [TestCase("(￣︿￣)", "", "(￣︿￣)")]
        [TestCase("", "", "")]
        public static void SwapStrings(string s1, string s2, string expected)
        {
            Homework1.SwapStrings(ref s1,ref s2);
            string actual = s1 + s2;
            Assert.AreEqual(expected, actual);            
        }

        //Задание 4
        [TestCase(5.4, 4.15, 3.2, -0.17592592592592596)]
        [TestCase(-89.1, 48.5,6465.16489, -72.016440965207636)]
        [TestCase(5.0, 10.48, 20.98, 2.1)]
        [TestCase(51.15, -984.14, 156.0, 22.29012707722385)]
        [TestCase(double.MaxValue, double.MaxValue, double.MinValue, double.NegativeInfinity)]
        [TestCase(double.MaxValue, double.MinValue, double.MaxValue, double.PositiveInfinity)]
        public static void FirstDegreeEquationSolutionTest(double a, double b, double c, double expected)
        {
            double actual = Homework1.FirstDegreeEquationSolution(a, b, c);
            Assert.AreEqual(expected, actual);            
        }
        [Test]
        public static void FirstDegreeEquationSolutionNegativTest()
        {
            Assert.Throws<DivideByZeroException>(() => Homework1.FirstDegreeEquationSolution(0, 165.4, 456));
        }
    }
}