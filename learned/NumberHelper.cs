using System;
using System.Collections.Generic;
using System.Text;

namespace learned
{
    class NumberHelper
    {
        public static sbyte[] GetDecompositionNumber(int num)
        {
            sbyte[] arr = new sbyte[NumberHelper.GetIntLength(num)];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (sbyte)(num % 10);
                num /= 10;
            }
            return arr;
        }

        public static int GetMirrorNumber(int num)
        {
            sbyte[] arr = NumberHelper.GetDecompositionNumber(num);
            int newNum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                newNum = newNum * 10 + arr[i];
            }
            return newNum;
        }

        public static int GetIntLength(int num)
        {
            int k = 0;
            while (Math.Abs(num) > 0) { k++; num /= 10;}
            return k;
        }

        public static void Swap(ref int a,ref int b)
        {
            var tmp = a;
            a = b;
            b = tmp;            
        }
        public static void Swap(ref double a, ref double b)
        {
            var tmp = a;
            a = b;
            b = tmp;
        }
    }

}
