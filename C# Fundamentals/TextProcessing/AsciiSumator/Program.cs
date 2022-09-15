using System;

namespace AsciiSumator {
    internal class Program {
        static void Main(string[] args) {
            char first = char.Parse(Console.ReadLine());
            char last = char.Parse(Console.ReadLine());

            string input = Console.ReadLine();

            int result = 0;

            foreach (char ch in input) {
                if (ch > first && ch < last) {
                    result += ch;
                }
            }

            Console.WriteLine(result);
        }
    }
}
