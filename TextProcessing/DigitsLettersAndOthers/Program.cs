using System;
using System.Text;

namespace DigitsLettersAndOthers {
    internal class Program {
        static void Main(string[] args) {
            string word = Console.ReadLine();

            StringBuilder digits = new StringBuilder();
            StringBuilder letters = new StringBuilder();
            StringBuilder others = new StringBuilder();


            foreach (char letter in word) {
                if (char.IsDigit(letter)) {
                    digits.Append(letter);
                } else if (char.IsLetter(letter)) {
                    letters.Append(letter);
                } else {
                    others.Append(letter);
                }
            }

            Console.WriteLine($"{digits}\n{letters}\n{others}");
        }
    }
}
