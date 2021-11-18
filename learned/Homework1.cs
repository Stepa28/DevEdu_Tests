using System;

namespace learned
{
    static public class Homework1
    {
        static public string GetHelloByeString(int a, double b) => 
            $"привет, {a}!\n{a} + {b} = {a + b}\nпока, {b}...";

        static public double EquationSolution(double a, double b)
        {
            if (b == a)
                throw new DivideByZeroException("Деление на ноль");

            return (a * 5 + Math.Pow(b, 4)) / (b - a);
        }

        static public void SwapStrings(ref string s1,ref string s2) =>        
            NumberHelper.Swap(ref s1, ref s2);       


        static public double FirstDegreeEquationSolution(double a, double b, double c)
        {
            if (a == 0)
                throw new DivideByZeroException("Деление на ноль");

            return (c - b) / a;
        }
    }
}
