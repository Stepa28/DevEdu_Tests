using System;

namespace learned
{
    static class NumberHelper
    {
        static public sbyte[] GetDecompositionNumber(int num) //разложение числа на цифры по разрядам
        {
            sbyte[] arr = new sbyte[GetIntLength(num)];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = (sbyte)(num % 10);
                num /= 10;
            }
            return arr;
        }

        static public int GetMirrorNumber(int num) //зеркальное отражение числа
        {
            sbyte[] arr = GetDecompositionNumber(num);
            int newNum = 0;
            foreach (sbyte elem in arr)
                newNum = newNum * 10 + elem;

            return newNum;
        }

        static public int GetIntLength(int num) //вычисление длинны int'овой переменной
        {
            int k = 0;
            while (Math.Abs(num) > 0) { k++; num /= 10;}
            return k;
        }

        static public void Swap<T>(ref T a,ref T b) => (a, b) = (b, a);        
    }

}
