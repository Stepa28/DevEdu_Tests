using System;
using System.Collections.Generic;
using System.Text;

namespace learned
{
    public class Homework2
    {        
        public static int GetSumOfDigitsOfNumber(int num)
        {
            if (num < 100 || num > 999)
                throw new ArgumentOutOfRangeException("Число не трёхзначное");
            int sum = 0;
            sbyte[] arr = NumberHelper.GetDecompositionNumber(num);
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        public static bool GetHitTheTarget(double x, double y, double rad) 
        {
            if (Math.Abs(x) > Math.Sqrt(double.MaxValue) || Math.Abs(y) > Math.Sqrt(double.MaxValue) || Math.Abs(rad) > Math.Sqrt(double.MaxValue))
                throw new ArgumentOutOfRangeException("Переполнение переменной");
            return Math.Pow(x, 2) + Math.Pow(y, 2) <= Math.Pow(rad, 2);
        }

        public static bool GetMiddleFigureBetween(int num) 
        {
            if (Math.Abs(num) < 100 || Math.Abs(num) > 999)
                throw new ArgumentOutOfRangeException("Число не трёхзначное");
            sbyte[] arr = NumberHelper.GetDecompositionNumber(Math.Abs(num));
            return arr[1] <= arr[2] && arr[1] > arr[0];
        }

        public static int GetMirrorNumber(int num)
        {
            if (Math.Abs(num) < 100 || Math.Abs(num) > 999)
                throw new ArgumentOutOfRangeException("Число не трёхзначное");
            return NumberHelper.GetMirrorNumber(num);
        }

        public static bool GetZeroFractionalPart(double num)
        {            
            return num == (int)num;
        }
    }
}
