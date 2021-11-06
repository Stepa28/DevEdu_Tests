using System;
using System.Collections.Generic;
using System.Text;

namespace learned
{
    public class Homework1
    {
        public static string GetHelloByeString(int a, double b)
        {
            //if (a + b > double.MaxValue)
            //    throw new ArgumentOutOfRangeException("Переполнение переменной");
            return $"привет, {a}!\n{a} + {b} = {a + b}\nпока, {b}...";      
        }

        public static double EquationSolution(double a, double b)
        {
            if (b - a == 0)
                throw new DivideByZeroException("Деление на ноль");
            return (a * 5 + Math.Pow(b, 4)) / (b - a);
        }

        public static void SwapStrings(ref string s1,ref string s2) 
        {
            string tmp = s1;           
            s1 = s2;
            s2 = tmp;            
        }

        public static double FirstDegreeEquationSolution(double a, double b, double c)
        {
            if (a == 0)
                throw new DivideByZeroException("Деление на ноль");
            return (c - b) / a;
        }
    }
}
