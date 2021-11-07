using System;
using System.Collections.Generic;
using System.Text;

namespace learned
{
    class NumberHelper
    {
        public static sbyte[] GetDecompositionNumber(int num) //зарложение числа на цифры по разрядам
        {
            sbyte[] arr = new sbyte[GetIntLength(num)];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (sbyte)(num % 10);
                num /= 10;
            }
            return arr;
        }

        public static int GetMirrorNumber(int num) //зеркальное отражение числа
        {
            sbyte[] arr = GetDecompositionNumber(num);
            int newNum = 0;
            foreach (sbyte elem in arr)
                newNum = newNum * 10 + elem;

            return newNum;
        }

        public static int GetIntLength(int num) //вычисление длинны int'овой переменой
        {
            int k = 0;
            while (Math.Abs(num) > 0) { k++; num /= 10;}
            return k;
        }

        public static void Swap(ref int a,ref int b) => (a, b) = (b, a);
        public static void Swap(ref double a, ref double b) => (a, b) = (b, a);
    }

}
