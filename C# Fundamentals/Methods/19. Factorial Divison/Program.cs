using System;

namespace _19._Factorial_Divison
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            
            double output = Factorial(firstNum)/Factorial(secondNum);
            Console.WriteLine($"{output:f2}");
        }
        static double Factorial(double num)
        {
            double fact = 1;

            for (int i = 1; i <= num; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
