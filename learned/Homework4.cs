using System;

namespace learned
{
    public class Homework4
    {
        static public int[] GetNumbersDivided(int num)
        {
            switch (num)
            {
                case > 1000:
                    throw new ArgumentException("Входное А больше 1000");
                case 0:
                    throw new ArgumentException("Входное А == 0");
                case < 0:
                    throw new ArgumentException("Входное А < 0");
            }
            int[] arr = new int[1000 / num];
            int count = 0;
            for (int i = num; i <= 1000; i += num)
            {
                arr[count] = i;
                count++;
            }

            return arr;
        }

        static public int GetNumbersLessThanASquare(int num)
        {
            if (num < 0)
                throw new ArgumentException("Число должно быть больше нуля");

            return (int)Math.Sqrt(num);
        }
            

        static public int GetGreatestDivisor(int num)
        {
            num = Math.Abs(num);
            for (int i = num / 2; i >= 2; i--)
                if (num % i == 0)
                    return i;
            return 1;
        }

        static public long GetSumOfMultiplesOf7InARange(int a, int b)
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

        static public int FindingTheCommonDivisor(int a, int b)
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

        static public int FindingTheCubeRoot(int num)
        {
            if (num < 0)
                throw new ArgumentException("Число должно быть положительным");
            int min = 0, max = (int)Math.Pow(int.MaxValue, 1.0 / 3), middle = -1;
            while (Math.Pow(middle, 3) != num)
            {
                middle = (min + max) / 2;
                if (middle == min)
                    throw new ArgumentException("У числа нет кубического корня");
                if (Math.Pow(middle, 3) > num)
                    max = middle;
                else
                    min = middle;
            }

            return middle;
        }

        static public int GetNumberOfOddDigits(int num)
        {
            int coutOdd = 0;
            sbyte[] arr = NumberHelper.GetDecompositionNumber(num);
            foreach (sbyte t in arr)
                if (Math.Abs(t) % 2 == 1) coutOdd++;

            return coutOdd;
        }

        static public int GetMirrorNumber(int num) =>
            NumberHelper.GetMirrorNumber(num);        

        static public int[] GetNumbersInRangeSumEvenDigitsGreaterOdd(int num)
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
            int[] arrTwo = arrTmp[..count];            
            
            return arrTwo;
        }

        static public bool GetThereSameNumbers(int numOne, int numTwo)
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