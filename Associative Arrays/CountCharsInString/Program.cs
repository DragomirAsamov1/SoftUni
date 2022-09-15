using System;
using System.Collections.Generic;
using System.Linq;

namespace CountCharsInString {
    internal class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();

            Dictionary<char, int> dict = new Dictionary<char, int>();

            foreach (var letter in input) {
                if (letter == ' ') {
                    continue;
                }
                if (dict.ContainsKey(letter)) {
                    dict[letter]++;
                } else {
                    dict.Add(letter, 1);
                }
            }

            foreach (var item in dict) {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
