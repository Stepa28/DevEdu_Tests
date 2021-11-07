using System;

namespace learned
{
    public class Homework5
    {
        public static void GetNumberOfEvenAndOddElements(int[] arr, out int cntEven, out int cntOdd)
        {
            cntEven = 0;
            cntOdd = 0;
            for (int i = 0; i < arr.Length; i++)            
                if (arr[i] % 2 == 0)
                    cntEven++;
                else
                    cntOdd++;            
        }

        public static int[] ReplaceThirdItemWithTheSumOfThePreviousTwo(int[] arr)
        {
            for (int i = 2; i < arr.Length; i += 3)
            {
                if (Math.Abs((long)arr[i - 2] + arr[i - 1]) > int.MaxValue)
                    throw new ArgumentOutOfRangeException("Переполнение int");
                arr[i] = arr[i - 2] + arr[i - 1];
            }

            return arr;
        }

        public static int[] GluingTwoArrays(int[] arrOne, int[] arrTwo)
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

        public static int[] SwapFirstAndSecondHalfArray(int[] arr)
        {
            bool flag = arr.Length % 2 == 0;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                if (flag)
                    NumberHelper.Swap(ref arr[i], ref arr[arr.Length / 2 + i]);
                else
                    NumberHelper.Swap(ref arr[i], ref arr[arr.Length / 2 + i + 1]);
            }

            return arr;
        }

        public static int[] ShiftArrayToRightByN(int[] arr, int shift)
        {
            if (shift < 0)
                throw new ArgumentOutOfRangeException("Сдвиг должен быть положительным");
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

        public static int[] SwapEvenAndOddPosition(int[] arr)
        {
            for (int i = 1; i < arr.Length; i += 2)
                NumberHelper.Swap(ref arr[i], ref arr[i - 1]);
            return arr;
        }

        public static (int, long) FindingAbsMaxAndSumAfterZero(int[] arr)
        {
            int max = arr[0];
            long sumAfterZero = 0;
            bool flag = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > Math.Abs(max))
                    max = arr[i];
                if (flag)
                    sumAfterZero += arr[i];
                if (arr[i] == 0)
                    flag = true;
            }

            return (max, sumAfterZero);
        }

        public static int[] ShortInsert(int[] arr)
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

        public static int[] ShortSelect(int[] arr)
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