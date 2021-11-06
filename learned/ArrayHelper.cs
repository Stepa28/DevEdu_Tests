using System;
using System.Collections.Generic;
using System.Text;

namespace learned
{
    static class ArrayHelper
    {        
        public static int[] GenerateArrayInt(int min, int max, int size)
        {
            int[] arr = new int[size];
            Random rnd = new Random();
            for(int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(min, max + 1);
            }
            return arr;
        }
        public static int[,] GenerateArrayInt(int min, int max, int rows, int cols)
        {
            int[,] arr = new int[rows, cols];
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j< cols; j++)
                {
                    arr[i, j] = rnd.Next(min, max + 1);
                }                
            }
            return arr;
        }
        public static double[] GenerateArrayDouble(int min, int max, int size)
        {
            double[] arr = new double[size];
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.NextDouble()*(max - min) + min;
            }
            return arr;
        }
        public static double[,] GenerateArrayDouble(int min, int max, int rows, int cols)
        {
            double[,] arr = new double[rows, cols];
            Random rnd = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i,j] = rnd.NextDouble() * (max - min) + min;
                }
            }
            return arr;
        }
        public static void PrintArray<T>(T[] arr, bool nextLine = false, bool lineOnTop = false)
        {
            if (lineOnTop) Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
            if (nextLine) Console.WriteLine();
        }
        public static void PrintArray<T>(T[,] arr, bool nextLine = false, bool lineOnTop = false)
        {
            if (lineOnTop) Console.WriteLine();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]:f2}\t");
                }
                Console.WriteLine();
            }
            if (nextLine) Console.WriteLine();
        }
    }
}
