using System;
using System.Collections.Generic;
using System.Text;

namespace learned
{
    static class IOHelper
    {
        public static int SaveInput(int min_value, int max_value, string message)
        {
            bool flag;
            int num;
            do
            {
                Console.Write($"{message} [{min_value} - {max_value}]: ");
                flag = int.TryParse(Console.ReadLine().Trim(), out num);
            } while (num < min_value || num > max_value || !flag);
            return num;
        }
        public static double SaveInput(double minValue, double maxValue, string message)
        {
            bool flag;
            double num;
            do
            {
                Console.Write($"{message} [{minValue} - {maxValue}]: ");
                flag = double.TryParse(Console.ReadLine()?.Trim(), out num);
            } while (num < minValue || num > maxValue || !flag);
            return num;
        }
        public static void PrintLine(int length)
        {
            Console.Write('+');
            for (int i= 0; i < length; i++)
                Console.Write('-');

            Console.WriteLine('+');

        }
    }
}
