using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = Math.Abs(int.Parse(Console.ReadLine()));

            int result = GetMultipleOfEvenAndOdds(num);
            Console.WriteLine(result);
        }
        static int GetMultipleOfEvenAndOdds(int num)
        {
            int result = GetSumOfEvenDigits(num) * GetSumOfOddDigits(num);
            return result;
        }
        static int GetSumOfEvenDigits(int num)
        {
            int sumOfEvens = 0;
            while (num!=0)
            {
                int nextDigit = num % 10;

                if (nextDigit%2==1)
                {
                    sumOfEvens += nextDigit;
                }
                num -= nextDigit;
                num /= 10;
            }
            return sumOfEvens;
        }
        static int GetSumOfOddDigits(int num)
        {
            int sumOfOdd = 0;
            while (num!=0)
            {
                int nextDigit = num % 10;

                if (nextDigit%2==0)
                {
                    sumOfOdd += nextDigit;
                }
                num -= nextDigit;
                num /= 10;
            }
            return sumOfOdd;
        }
    }
}

/*
 using System;
using System.Xml.Schema;

namespace _10.MultiplyEvenByOdds
{
    class Program
    {
        static void Main()
        {
            string givenNumber = Console.ReadLine();
            string output = Get(givenNumber);

            Console.WriteLine(output);
        }

        static string Plus(string givenNumber)
        {
            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < givenNumber.Length; i++)
            {
                int number = int.Parse(givenNumber[i].ToString());
                if (number % 2 == 0)
                {
                    evenSum += number;
                }
                else
                {
                    oddSum += number;
                }
            }

            int total = evenSum * oddSum;
            return total.ToString();
        }
    }
} 
 */
