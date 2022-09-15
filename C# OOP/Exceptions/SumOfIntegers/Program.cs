using System;
using System.Numerics;

namespace SumOfIntegers {
    public class Program {
        static void Main(string[] args) {
            int sum = 0;

            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++) {
                try {
                    int num = TryParse(input[i]);
                    sum += num;
                } catch (FormatException ex1) {
                    Console.WriteLine(ex1.Message);
                } catch (OverflowException ex2) {
                    Console.WriteLine(ex2.Message);
                } finally {
                    Console.WriteLine($"Element '{input[i]}' processed  - current sum: {sum}"); 
                }
            }

            Console.WriteLine($"The total sum of all integers is: {sum}");
        }

        static int TryParse(string input) {
            char[] chars = input.ToCharArray();
            foreach (char ch in chars) {
                if (char.IsLetter(ch) || ch == '.') {
                    throw new FormatException($"The element '{input}' is in wrong format!");
                }
            }
            BigInteger bigNum = BigInteger.Parse(input);
            if (bigNum > int.MaxValue || bigNum < int.MinValue) {
                throw new OverflowException($"The element '{input}' is out of range!");
            }
            return (int)bigNum;
        }
    }
}
