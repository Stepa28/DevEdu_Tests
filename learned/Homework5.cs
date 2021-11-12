using System;

namespace learned
{
    static public class Homework5
    {
        static public void GetNumberOfEvenAndOddElements(int[] arr, out int cntEven, out int cntOdd)
        {
            cntEven = 0;
            cntOdd = 0;
            foreach (int t in arr)
                if (t % 2 == 0)
                    cntEven++;
                else
                    cntOdd++;
        }

        static public int[] ReplaceThirdItemWithTheSumOfThePreviousTwo(int[] arr)
        {
            for (int i = 2; i < arr.Length; i += 3)
            {
                if (Math.Abs((long)arr[i - 2] + arr[i - 1]) > int.MaxValue)
                    throw new ArgumentOutOfRangeException(nameof(arr),"Переполнение int");
                arr[i] = arr[i - 2] + arr[i - 1];
            }

            return arr;
        }

        static public int[] GluingTwoArrays(int[] arrOne, int[] arrTwo)
        {
            int[] arrGlue = new int[arrOne.Length + arrTwo.Length];
            for (int i = 0; i < arrOne.Length; i++)
            {
                arrGlue[i] = arrOne[i];
            }

            for (int i = 0; i < arrTwo.Length; i++)
            {
                arrGlue[i + arrOne.Length] = arrTwo[i];
            }

            return arrGlue;
        }

        static public int[] SwapFirstAndSecondHalfArray(int[] arr)
        {
            for (int i = 0; i < arr.Length / 2; i++)
                NumberHelper.Swap(ref arr[i], ref arr[arr.Length / 2 + i + (arr.Length % 2 == 0 ? 0 : 1)]);

            return arr;
        }

        static public int[] ShiftArrayToRightByN(int[] arr, int shift)
        {
            if (shift < 0)
                throw new ArgumentOutOfRangeException(nameof(shift),"Сдвиг должен быть положительным");
            if (shift % arr.Length != 0)
                for (int j = 0; j < shift; j++)
                {
                    int last = arr[^1];

                    for (int i = arr.Length - 1; i >= 1; i--)
                        arr[i] = arr[i - 1];

                    arr[0] = last;
                }

            return arr;
        }

        static public int[] SwapEvenAndOddPosition(int[] arr)
        {
            for (int i = 1; i < arr.Length; i += 2)
                NumberHelper.Swap(ref arr[i], ref arr[i - 1]);
            return arr;
        }

        static public (int, long) FindingAbsMaxAndSumAfterZero(int[] arr)
        {
            int max = arr[0];
            long sumAfterZero = 0;
            bool flag = false;
            foreach (int t in arr)
            {
                if (Math.Abs(t) > Math.Abs(max))
                    max = t;
                if (flag)
                    sumAfterZero += t;
                if (t == 0)
                    flag = true;
            }

            return (max, sumAfterZero);
        }

        static public int[] ShortInsert(int[] arr)
        {
            int[] arrayTmp = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int j = i;
                while (j > 0 && arrayTmp[j - 1] > arr[i])
                {
                    arrayTmp[j] = arrayTmp[j - 1];
                    j--;
                }

                arrayTmp[j] = arr[i];
            }

            return arrayTmp;
        }

        static public int[] ShortSelect(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minInArr = arr[i];
                int index = i;
                for (int j = i + 1; j < arr.Length; j++)
                    if (minInArr > arr[j])
                    {
                        minInArr = arr[j];
                        index = j;
                    }

                if (index != i) NumberHelper.Swap(ref arr[i], ref arr[index]);
            }
            return arr;
        }
    }
}