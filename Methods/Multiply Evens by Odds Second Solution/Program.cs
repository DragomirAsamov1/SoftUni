using System;
using System.Linq;

namespace Multiply_Evens_by_Odds_Second_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int sumOfEvens = 0;
            int sumOfOdds = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sumOfOdds += arr[i];
                }
                else if (arr[i] % 2 == 1)
                {
                    sumOfEvens += arr[i];
                }
            }
            Console.WriteLine(sumOfEvens);
        }
    }
}
