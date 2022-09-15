using System;

namespace _16._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int sumResult = Sum(num1, num2);
            int finalResult = Subtract(sumResult, num3);
            Console.WriteLine(finalResult);
        }
        static int Sum(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }
        static int Subtract(int sumResult, int num3)
        {
            int result = sumResult - num3;
            return result;
        }
    }
}
