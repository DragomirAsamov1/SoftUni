using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            Console.WriteLine(RaiseToPower(num, power));
        }
        static double RaiseToPower(double num, int power)
        {
            return Math.Pow(num, power);
        }
    }
}
