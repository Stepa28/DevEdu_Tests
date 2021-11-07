using System;

namespace learned
{
    public class Homework3
    {
        public static double GetFunctionByCondition(double a, double b) => 
            a > b ? a + b : b > a ? a - b : a * b;

        public static int DetermineQuadrant(double x, double y)
        {            
            if (x > 0)
            {
                if (y > 0) return 1;               
                if (y < 0) return 2;
                throw new ArgumentException("Точка лежит на пересечении первой и второй четверти");              
            }
            if (x < 0)
            {
                if (y > 0) return 4;
                if (y < 0) return 3;
                throw new ArgumentException("Точка лежит на пересечении третьей и четвертой четверти");
            }
            if (y > 0) throw new ArgumentException("Точка лежит на пересечении первой и четвертой четверти");
            if (y < 0) throw new ArgumentException("Точка лежит на пересечении второй и третьей четверти");
            throw new ArgumentException("Точка лежит в центре координатной плоскости");
        }

        public static double[] SortingThreeNumbers(double a, double b, double c)
        {
            //double[] arr = new[] { a, b, c };
            //Array.Sort(arr);
            double[] arr = new double[3];            
            arr[2] = Math.Max(a, Math.Max(b, c)); //Max
            arr[0] = Math.Min(a, Math.Min(b, c)); //Min
            arr[1] = a == arr[2] ? Math.Max(b, c) : 
                b == arr[2] ? Math.Max(a, c) : 
                Math.Max(a, b); //Midle
            return arr;           
        }

        public static double[] ResolveQuadEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                if (b != 0)
                    return new double[] { -c / b };
                throw new ArgumentException("X не определён");
            }
            double D = Math.Pow(b, 2) - 4 * a * c;
            if (D < 0)
                throw new ArgumentException("Дискриминант меньше нуля, действительных корней нет");
            if (D > 0)
                return new double[] { (-b + Math.Sqrt(D)) / (2 * a), (-b - Math.Sqrt(D)) / (2 * a) };
            return new double[] { -b / (2 * a) };
        }

        public static string ToStringTwoDigitNumber(int num)
        {
            if (num > 99 || num < 10)
                throw new ArgumentOutOfRangeException("Число не двухзначное");
            string str = null;
            sbyte[] arr = NumberHelper.GetDecompositionNumber(num);
            if (arr[1] == 1)
            {
                if (arr[0] == 0) str += "десять";
                else if (arr[0] == 1) str += "одиннадцать";
                else if (arr[0] == 2) str += "двенадцать";
                else if (arr[0] == 3) str += "тринадцать";
                else if (arr[0] == 4) str += "четырнадцать";
                else if (arr[0] == 5) str += "пятнадцать";
                else if (arr[0] == 6) str += "шестнадцать";
                else if (arr[0] == 7) str += "семнадцать";
                else if (arr[0] == 8) str += "восемнадцать";
                else str += "девятнадцать";
            }
            else if (arr[1] == 2) str += "двадцать ";
            else if (arr[1] == 3) str += "тридцать ";
            else if (arr[1] == 4) str += "сорок ";
            else if (arr[1] == 5) str += "пятьдесят ";
            else if (arr[1] == 6) str += "шестьдесят ";
            else if (arr[1] == 7) str += "семьдесят ";
            else if (arr[1] == 8) str += "восемьдесят ";
            else str += "девяносто ";
            if (arr[1] > 1 && arr[1] <= 9)
            {
                if (arr[0] == 1) str += "один";
                else if (arr[0] == 2) str += "два";
                else if (arr[0] == 3) str += "три";
                else if (arr[0] == 4) str += "четыре";
                else if (arr[0] == 5) str += "пять";
                else if (arr[0] == 6) str += "шесть";
                else if (arr[0] == 7) str += "семь";
                else if (arr[0] == 8) str += "восемь";
                else if (arr[0] == 9) str += "девять";
            }
            return str;
        }

        public static bool IsRectangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }
    }
}
