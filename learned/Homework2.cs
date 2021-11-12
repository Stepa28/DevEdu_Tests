using System;

namespace learned
{
    static public class Homework2
    {
        static public int GetSumOfDigitsOfNumber(int num)
        {
            if (num < 100 || num > 999)
                throw new ArgumentOutOfRangeException(nameof(num),"Число не трёхзначное");
            int sum = 0;
            sbyte[] arr = NumberHelper.GetDecompositionNumber(num);
            foreach (sbyte t in arr)
                sum += t;

            return sum;
        }

        static public bool GetHitTheTarget(double x, double y, double rad)
        {
            if (Math.Abs(x) > Math.Sqrt(double.MaxValue) || Math.Abs(y) > Math.Sqrt(double.MaxValue) ||
                Math.Abs(rad) > Math.Sqrt(double.MaxValue))
                throw new ArgumentOutOfRangeException("Переполнение переменной");

            return Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(rad, 2);
        }

        static public bool GetMiddleFigureBetween(int num)
        {
            if (Math.Abs(num) < 100 || Math.Abs(num) > 999)
                throw new ArgumentOutOfRangeException(nameof(num),"Число не трёхзначное");
            sbyte[] arr = NumberHelper.GetDecompositionNumber(Math.Abs(num));

            return arr[1] <= arr[2] && arr[1] > arr[0];
        }

        static public int GetMirrorNumber(int num)
        {
            if (Math.Abs(num) < 100 || Math.Abs(num) > 999)
                throw new ArgumentOutOfRangeException(nameof(num),"Число не трёхзначное");

            return NumberHelper.GetMirrorNumber(num);
        }

        static public bool GetZeroFractionalPart(double num) => 
            num % 1 == 0;
    }
}