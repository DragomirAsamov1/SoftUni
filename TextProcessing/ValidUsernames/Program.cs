using System;
using System.Collections.Generic;
using System.Linq;

namespace ValidUsernames {
    internal class Program {
        static void Main(string[] args) {
            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string name in names) {
                if (name.Length >= 3 && name.Length <= 16 && IsValid(name) ) {
                    Console.WriteLine(name);
                }
            }
        }

        static bool IsValid(string word) {
            List<char>letters = word.ToList();

            foreach (char letter in letters) {
                if (char.IsLetterOrDigit(letter) || letter == '-' || letter == '_') {
                    continue;
                } else {
                    return false;
                }
            }

            return true;
        }
    }
}
