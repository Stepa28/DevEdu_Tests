using System;
using System.Collections.Generic;
using System.Text;

namespace learned
{
    public class Homework6
    {
        public static int[,] Task1(int[,] arr)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[0, j] *= -1;
                arr[arr.GetLength(0) - 1, j] *= -1;
            }
            for (int i = 1; i < arr.GetLength(0) - 1; i++)
            {
                arr[i, 0] *= -1;
                arr[i, arr.GetLength(1) - 1] *= -1;
            }
            return arr;
        }

        public static int[,] Task2(int size)
        {
            int[,] arr = new int[size, size];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = (i + 1) * (j + 1);                    
                }                
            }
            return arr;
        }

        public static char[,] Task3(int size)
        {
            char[,] arr = new char[size, size];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = ((arr.GetLength(0) - i) + j + 1) % 2 == 0 ? '0' : '1';                   
                }                
            }
            return arr;
        }

        public static bool Task4(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 1; j < arr.GetLength(1) - 1; j++)
                {
                    if (arr[i, j] == arr[i, j - 1] || arr[i, j] == arr[i, j + 1])
                    {
                        return true;                        
                    }
                }                
            }
            return false;
        }

        public static void Task5(double[,] arr, out double min, out double max, out double[] sumMonths, out double[] sumOneShop) 
        {
            min = double.MaxValue;
            max = double.MinValue;
            sumMonths = new double[6] { 0, 0, 0, 0, 0, 0 };
            sumOneShop = new double[10] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < arr.GetLength(0); i++)
            {                
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    sumOneShop[i] += arr[i, j];
                    sumMonths[j] += arr[i, j];
                    if (max < arr[i, j]) max = arr[i, j];
                    if (min > arr[i, j]) min = arr[i, j];
                }                
            }
        }

        public static int Task6(int[,] arr)
        {
            int cntMax = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int sosedi = (i > 0 ? arr[i - 1, j] : 0)
                        + (i < arr.GetLength(0) - 1 ? arr[i + 1, j] : 0)
                        + (j > 0 ? arr[i, j - 1] : 0)
                        + (j < arr.GetLength(1) - 1 ? arr[i, j + 1] : 0);
                    if (arr[i, j] > sosedi)
                        cntMax++;
                }
            }
            return cntMax;
        }

        public static char[,] Task7(char[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if ((i < j && arr.GetLength(1) - j - 1 < i) ||
                        (i > j && arr.GetLength(1) - j - 1 > i)) 
                        arr[i, j] = '0';                    
                    else arr[i, j] = '1';                    
                }                
            }
            return arr;
        }

        public static int[,] Task8(int[,] arrOne, int[,] arrTwo)
        {
            int[,] arrThree = new int[arrOne.GetLength(0), arrTwo.GetLength(1)];
            if (arrOne.GetLength(1) != arrTwo.GetLength(0))
            {
                throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
            }
            else
            {
                for (int i = 0; i < arrOne.GetLength(0); i++)
                {
                    for (int j = 0; j < arrTwo.GetLength(1); j++)
                    {
                        arrThree[i, j] = 0;
                        for (int k = 0; k < arrOne.GetLength(1); k++)
                        {
                            arrThree[i, j] += arrOne[i, k] * arrTwo[k, j];
                        }
                    }
                }

            }
            return arrThree;
        }


    }
}
