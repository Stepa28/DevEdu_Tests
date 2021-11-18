using NUnit.Framework;
using System;

namespace learned.Tests
{
    static class Homework5Tests
    {
        //Задание 1
        [TestCase(new int[] { -35, 11, 76, -21, 15, 35, 91, 90, 57, -88, 38, -25, 69, 35, -18, -48, -61, -34, -4, -65, 34, -7, 7, -84, -49 }, 10)]
        [TestCase(new int[] { -88, -80, 7, -37, 3, 31, -17, 57, -86, 80, -26, -29, -26, -77, 33, -56, -64, -69, -64, 7, 31, 59, 47, 33, -16 }, 10)]
        [TestCase(new int[] { -32, 28, -57, -24, -68, 51, 76, -74, 47, -6, 67, 14, 73, 1, 8, 82, 98, 76, 9, -35, -28, -42, 65, 98, 66 }, 16)]
        [TestCase(new int[] { -13, -29, 39, 87, 31, 58, 18, -96, 53, 98, 64, -60, -22, -68, 41, -54, -88, 78, -75, 19, -9, 42, 93, 10, 18 }, 14)]
        [TestCase(new int[] { 47, -57, -6, -88, -8, 65, 44, 0, -56, 78, -5, 77, 75, -48, -84, -27, 63, -3, -60, -39, -34, 30, 73, -62, 28 }, 14)]
        public static void GetNumberOfEvenAndOddElementsTestEven(int[] arr, int expected)
        {
            Homework5.GetNumberOfEvenAndOddElements(arr, out int actual,out int cntOdd);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { -35, 11, 76, -21, 15, 35, 91, 90, 57, -88, 38, -25, 69, 35, -18, -48, -61, -34, -4, -65, 34, -7, 7, -84, -49 }, 15)]
        [TestCase(new int[] { -88, -80, 7, -37, 3, 31, -17, 57, -86, 80, -26, -29, -26, -77, 33, -56, -64, -69, -64, 7, 31, 59, 47, 33, -16 }, 15)]
        [TestCase(new int[] { -32, 28, -57, -24, -68, 51, 76, -74, 47, -6, 67, 14, 73, 1, 8, 82, 98, 76, 9, -35, -28, -42, 65, 98, 66 }, 9)]
        [TestCase(new int[] { -13, -29, 39, 87, 31, 58, 18, -96, 53, 98, 64, -60, -22, -68, 41, -54, -88, 78, -75, 19, -9, 42, 93, 10, 18 }, 11)]
        [TestCase(new int[] { 47, -57, -6, -88, -8, 65, 44, 0, -56, 78, -5, 77, 75, -48, -84, -27, 63, -3, -60, -39, -34, 30, 73, -62, 28 }, 11)]
        public static void GetNumberOfEvenAndOddElementsTestOdd(int[] arr, int expected)
        {
            Homework5.GetNumberOfEvenAndOddElements(arr, out int cntEven, out int actual);
            Assert.AreEqual(expected, actual);
        }

        //Задание 2
        [TestCase(new int[] { -35, 11, 76, -21, 15, 35, 91, 90, 57, -88, 38, -25, 69, 35, -18, -48, -61, -34, -4, -65, 34, -7, 7, -84, -49 },
            new int[] { -35, 11, -24, -21, 15, -6, 91, 90, 181, -88, 38, -50, 69, 35, 104, -48, -61, -109, -4, -65, -69, -7, 7, 0, -49 })]
        [TestCase(new int[] { -88, -80, 7, -37, 3, 31, -17, 57, -86, 80, -26, -29, -26, -77, 33, -56, -64, -69, -64, 7, 31, 59, 47, 33, -16 },
            new int[] { -88, -80, -168, -37, 3, -34, -17, 57, 40, 80, -26, 54, -26, -77, -103, -56, -64, -120, -64, 7, -57, 59, 47, 106, -16 })]
        [TestCase(new int[] { -32, 28, -57, -24, -68, 51, 76, -74, 47, -6, 67, 14, 73, 1, 8, 82, 98, 76, 9, -35, -28, -42, 65, 98, 66 }, 
            new int[] { -32, 28, -4, -24, -68, -92, 76, -74, 2, -6, 67, 61, 73, 1, 74, 82, 98, 180, 9, -35, -26, -42, 65, 23, 66 })]
        [TestCase(new int[] { -13, -29, 39, 87, 31, 58, 18, -96, 53, 98, 64, -60, -22, -68, 41, -54, -88, 78, -75, 19, -9, 42, 93, 10, 18 }, 
            new int[] { -13, -29, -42, 87, 31, 118, 18, -96, -78, 98, 64, 162, -22, -68, -90, -54, -88, -142, -75, 19, -56, 42, 93, 135, 18 })]
        [TestCase(new int[] { 47, -57, -6, -88, -8, 65, 44, 0, -56, 78, -5, 77, 75, -48, -84, -27, 63, -3, -60, -39, -34, 30, 73, -62, 28 }, 
            new int[] { 47, -57, -10, -88, -8, -96, 44, 0, 44, 78, -5, 73, 75, -48, 27, -27, 63, 36, -60, -39, -99, 30, 73, 103, 28 })]
        public static void ReplaceThirdItemWithTheSumOfThePreviousTwoTest(int[] arr, int[] expected)
        {
            int[] actual = Homework5.ReplaceThirdItemWithTheSumOfThePreviousTwo(arr);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { int.MaxValue, int.MaxValue, 0 })]
        [TestCase(new int[] { int.MinValue, int.MinValue, 0 })]
        public static void ReplaceThirdItemWithTheSumOfThePreviousTwoNegativeTest(int[] arr)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Homework5.ReplaceThirdItemWithTheSumOfThePreviousTwo(arr));
        }

        //Задание 3
        [TestCase(new int[] { 71, -59, 68, -22, -89, 34, 52, -80, 10, 62 }, new int[] { 99, 37, 94, -82, 90, 72, 60, -98, 69, 29 }, 
            new int[] { 71, -59, 68, -22, -89, 34, 52, -80, 10, 62, 99, 37, 94, -82, 90, 72, 60, -98, 69, 29 })]
        [TestCase(new int[] { -1, -49, 4, -5, 57, 35, -46, 17, 36, -6, 78, -6, -19, -2, -76 }, new int[] { -32, 41, -95, 28, -51, -14, -11, 17, -46, 26 }, 
            new int[] { -1, -49, 4, -5, 57, 35, -46, 17, 36, -6, 78, -6, -19, -2, -76, -32, 41, -95, 28, -51, -14, -11, 17, -46, 26 })]
        [TestCase(new int[] { 91, -21, -69, 96, -70 }, new int[] { 51, -21, -17, -10, -67, 75, 57, -82, 34, 4, -30, -65, 63, 98, 36 },
            new int[] { 91, -21, -69, 96, -70, 51, -21, -17, -10, -67, 75, 57, -82, 34, 4, -30, -65, 63, 98, 36 })]
        [TestCase(new int[] { -42, 11, 75, 71, -41, 65, -12, 31, -87, 78, 61, -60, 43, -86, -75 }, new int[] { -93, 61, -10, -73, -61 },
            new int[] { -42, 11, 75, 71, -41, 65, -12, 31, -87, 78, 61, -60, 43, -86, -75, -93, 61, -10, -73, -61 })]
        [TestCase(new int[] { -4, 20, 33, 67, 23 }, new int[] { -85, -30, 87, -89, -86 },
            new int[] { -4, 20, 33, 67, 23, -85, -30, 87, -89, -86 })]
        public static void GluingTwoArraysTest(int[] arrOne, int[] arrTwo, int[] expected)
        {
            int[] actual = Homework5.GluingTwoArrays(arrOne, arrTwo);
            Assert.AreEqual(expected, actual);
        }

        //Задание 4
        [TestCase(new int[] { -18, 45, -21, -68, 27, -38, -55, 26, -59, 79 },
            new int[] { -38, -55, 26, -59, 79, -18, 45, -21, -68, 27 })]
        [TestCase(new int[] { 3, -9, 72, -64, 29, 4, 0, 77, 52, -32, -19, 86, -74, -83, -43 }, 
            new int[] { 52, -32, -19, 86, -74, -83, -43, 3, -9, 72, -64, 29, 4, 0, 77 })]
        [TestCase(new int[] { -89, -72, -43, -70, 47 }, new int[] {-70, 47, -89, -72, -43 })]
        [TestCase(new int[] { -78, 58 }, new int[] { 58, -78 })]
        [TestCase(new int[] { -21, -88, 67, -10, -47, -2, -98, -58, 80, -86, 80, 63, -85, -47, -70, -92, -28, 85, 95, -8 },
            new int[] { 80, 63, -85, -47, -70, -92, -28, 85, 95, -8, - 21, -88, 67, -10, -47, -2, -98, -58, 80, -86 })]
        public static void SwapFirstAndSecondHalfArrayTest(int[] arr, int[] expected)
        {
            int[] actual = Homework5.SwapFirstAndSecondHalfArray(arr);
            Assert.AreEqual(expected, actual);
        }

        //Задание 5
        [TestCase(new int[] { -71, -29, 2, -80, -55, -65, 90, 86, -68, 97 }, 5,
            new int[] { -65, 90, 86, -68, 97, -71, -29, 2, -80, -55 })]
        [TestCase(new int[] { -71, -29, 2, -80, -55, -65, 90, 86, -68, 97 }, 1,
            new int[] { 97, -71, -29, 2, -80, -55, -65, 90, 86, -68 })]
        [TestCase(new int[] { -71, -29, 2, -80, -55, -65, 90, 86, -68, 97 }, 9,
            new int[] { -29, 2, -80, -55, -65, 90, 86, -68, 97, -71 })]
        [TestCase(new int[] { -71, -29, 2, -80, -55, -65, 90, 86, -68, 97 }, 11,
            new int[] { 97, -71, -29, 2, -80, -55, -65, 90, 86, -68 })]
        [TestCase(new int[] { -71, -29, 2, -80, -55, -65, 90, 86, -68, 97 }, 10,
            new int[] { -71, -29, 2, -80, -55, -65, 90, 86, -68, 97 })]
        public static void ShiftArrayToRightByNTest(int[] arr, int shift, int[] expected)
        {
            int[] actual = Homework5.ShiftArrayToRightByN(arr, shift);
            Assert.AreEqual(expected, actual);
        }
        [TestCase(new int[] { 0, 0 }, -1)]
        [TestCase(new int[] { 0, 0 }, -9848486)]
        public static void ShiftArrayToRightByNNegativTest(int[] arr, int shift)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => Homework5.ShiftArrayToRightByN(arr, shift));
        }

        //Задание 6
        [TestCase(new int[] { -69, -30, -13, -59, -77, -86, -23, -4, -39, -18 },
            new int[] { -30, -69, -59, -13, -86, -77, -4, -23, -18, -39 })]
        [TestCase(new int[] { -72, 5, -62, -99, -89, -13, 97 },
            new int[] { 5, -72, -99, -62, -13, -89, 97 })]
        [TestCase(new int[] { -82, -7, 73, -13, -82, 47, -24, -30, 12 },
            new int[] { -7, -82, -13, 73, 47, -82, -30, -24, 12 })]
        [TestCase(new int[] { -70 },
            new int[] { -70 })]
        [TestCase(new int[] { },
            new int[] { })]
        [TestCase(new int[] { -80, 48 },
            new int[] { 48, -80 })]
        public static void SwapEvenAndOddPositionTest(int[] arr, int[] expected)
        {
            int[] actual = Homework5.SwapEvenAndOddPosition(arr);
            Assert.AreEqual(expected, actual);
        }

        //Задание 7        
        [TestCase(new int[] { 58, 85, -35, -81, 75 }, 85, 0)]
        [TestCase(new int[] { 58, 958, 0, -81, 75 }, 958, -6)]
        [TestCase(new int[] { 4, -9, 0, -5, -17, 50, -94 }, -94, -66)]
        [TestCase(new int[] { -51, 0, 32, -4, -1, 46, 48, -70, -3, -98 }, -98, -50)]
        [TestCase(new int[] { -81, 87, -99, 23, -68 }, -99, 0)]
        public static void FindingAbsMaxAndSumAfterZeroTest(int[] arr, int maxAbs, long sumAfterZero)
        {
            (int, long) expected = (maxAbs, sumAfterZero);
            (int, long) actual = Homework5.FindingAbsMaxAndSumAfterZero(arr);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public static void FindingAbsMaxAndSumAfterZeroNegativTest()
        {
            Assert.Throws<OverflowException>(() => Homework5.FindingAbsMaxAndSumAfterZero(new int[] { 0, int.MinValue}));
        }

        //Задание 8
        [TestCase(new int[] { },
            new int[] { })]
        [TestCase(new int[] { -70, 50, -87, 18, 35, -47, 10, -44, 21, -61, -9, 9, -45, -99, 55 },
            new int[] { -99, -87, -70, -61, -47, -45, -44, -9, 9, 10, 18, 21, 35, 50, 55 })]
        [TestCase(new int[] { 8, 31, -99, -73, -51, -6, 26, 37, 49, 26, 63, -30, -20, 59, 37, 6, 58, -84, -1, -81 },
            new int[] { -99, -84, -81, -73, -51, -30, -20, -6, -1, 6, 8, 26, 26, 31, 37, 37, 49, 58, 59, 63 })]
        [TestCase(new int[] { 44, -44 },
            new int[] { -44, 44 })]
        [TestCase(new int[] { 8, 49, -13, 29, -32, 96, -24, -46, -41, 18, 99, -30, -91, 70, -40, 35, -62, 22, 82, 5, -42, -50, -54, -28, 99, -25, 93, 58, 33, -1, -32, -86, -29, -5, -99, -60, 90, -28, 2, 81 },
            new int[] { -99, -91, -86, -62, -60, -54, -50, -46, -42, -41, -40, -32, -32, -30, -29, -28, -28, -25, -24, -13, -5, -1, 2, 5, 8, 18, 22, 29, 33, 35, 49, 58, 70, 81, 82, 90, 93, 96, 99, 99 })]
        public static void ShortInsertTest(int[] arr, int[] expected)
        {
            int[] actual = Homework5.ShortInsert(arr);
            Assert.AreEqual(expected, actual);
        }

        //Задание 9
        [TestCase(new int[] { },
            new int[] { })]
        [TestCase(new int[] { -70, 50, -87, 18, 35, -47, 10, -44, 21, -61, -9, 9, -45, -99, 55 },
            new int[] { -99, -87, -70, -61, -47, -45, -44, -9, 9, 10, 18, 21, 35, 50, 55 })]
        [TestCase(new int[] { 8, 31, -99, -73, -51, -6, 26, 37, 49, 26, 63, -30, -20, 59, 37, 6, 58, -84, -1, -81 },
            new int[] { -99, -84, -81, -73, -51, -30, -20, -6, -1, 6, 8, 26, 26, 31, 37, 37, 49, 58, 59, 63 })]
        [TestCase(new int[] { 44, -44 },
            new int[] { -44, 44 })]
        [TestCase(new int[] { 8, 49, -13, 29, -32, 96, -24, -46, -41, 18, 99, -30, -91, 70, -40, 35, -62, 22, 82, 5, -42, -50, -54, -28, 99, -25, 93, 58, 33, -1, -32, -86, -29, -5, -99, -60, 90, -28, 2, 81 },
            new int[] { -99, -91, -86, -62, -60, -54, -50, -46, -42, -41, -40, -32, -32, -30, -29, -28, -28, -25, -24, -13, -5, -1, 2, 5, 8, 18, 22, 29, 33, 35, 49, 58, 70, 81, 82, 90, 93, 96, 99, 99 })]
        public static void ShortSelectTest(int[] arr, int[] expected)
        {
            int[] actual = Homework5.ShortSelect(arr);
            Assert.AreEqual(expected, actual);
        }
    }
}
