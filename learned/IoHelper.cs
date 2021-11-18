using System;

namespace learned
{
    static class IoHelper
    {
        static public int SaveInput(int minValue, int maxValue, string message)
        {
            bool flag;
            int num;
            do
            {
                Console.Write($"{message} [{minValue} - {maxValue}]: ");
                flag = int.TryParse(Console.ReadLine()?.Trim(), out num);
            } while (num < minValue || num > maxValue || !flag);
            
            return num;
        }
        static public double SaveInput(double minValue, double maxValue, string message)
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
        static public void PrintLine(int length)
        {
            Console.Write('+');
            for (int i= 0; i < length; i++)
                Console.Write('-');

            Console.WriteLine('+');
        }
    }
}
