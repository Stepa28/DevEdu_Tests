using System;

namespace learned
{
    public class Homework4
    {
        public static int[] GetNumbersDivided(int num)
        {
            if (num > 1000)
                throw new ArgumentException("Входное А больше 1000");
            if (num == 0)
                throw new ArgumentException("Входное А == 0");
            if (num < 0)
                throw new ArgumentException("Входное А < 0");
            int[] arr = new int[1000 / num];
            int count = 0;
            for (int i = num; i <= 1000; i += num)
            {
                arr[count] = i;
                count++;
            }

            return arr;
        }

        public static int GetNumbersLessThanASquare(int num) =>
            (int)(Math.Sqrt(num));

        public static int GetGreatestDivisor(int num)
        {
            for (int i = num / 2; i >= 2; i--)
                if (num % i == 0)
                    return i;
            return 1;
        }

        public static long GetSumOfMultiplesOf7InARange(int a, int b)
        {
            long sum = 0;
            for (long i = Math.Min(a, b); i < Math.Max(a, b); i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                    i += 6;
                }
            }

            return sum;
        }

        public static int FindingTheCommonDivisor(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else
                    b -= a;
            }

            return a;
        }

        public static int FindingTheCubeRoot(int num)
        {
            if (num < 0)
                throw new ArgumentException("Число должно быть положительным");
            int min = 0, max = (int)Math.Pow(int.MaxValue, 1.0 / 3), midle = -1;
            while (Math.Pow(midle, 3) != num)
            {
                midle = (min + max) / 2;
                if (midle == min)
                    throw new ArgumentException("У числа нет кубического корня");
                if (Math.Pow(midle, 3) > num)
                    max = midle;
                else
                    min = midle;
            }

            return midle;
        }

        public static int GetNumberOfOddDigits(int num)
        {
            int coutOdd = 0;
            sbyte[] arr = NumberHelper.GetDecompositionNumber(num);
            for (int i = 0; i < arr.Length; i++)            
                if (Math.Abs(arr[i]) % 2 == 1) coutOdd++;            

            return coutOdd;
        }

        public static int GetMirrorNumber(int num) =>
            NumberHelper.GetMirrorNumber(num);        

        public static int[] GetNubbersInRangeSumEvenDigitsGreaterOdd(int num)
        {
            if (num < 1)
                throw new ArgumentException("Неверное входное значение");
            int[] arrTmp = new int[num];
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                sbyte[] arr = NumberHelper.GetDecompositionNumber(i);
                int sumEven = 0;
                int sumOdd = 0;
                foreach (sbyte elem in arr)
                {
                    if (elem % 2 == 0) sumEven += elem;
                    else sumOdd += elem;
                }

                if (sumEven > sumOdd)
                {
                    arrTmp[count] = i;
                    count++;
                }
            }

            int[] arrTwo = new int[count];
            Array.Copy(arrTmp, arrTwo, count);
            return arrTwo;
        }

        public static bool GetThereSameNumbers(int numOne, int numTwo)
        {
            sbyte[] arrOne = NumberHelper.GetDecompositionNumber(Math.Abs(numOne));
            sbyte[] arrTwo = NumberHelper.GetDecompositionNumber(Math.Abs(numTwo));
            foreach (sbyte one in arrOne)
            foreach (sbyte two in arrTwo)
                if (one == two)
                    return true;

            return false;
        }
    }
}