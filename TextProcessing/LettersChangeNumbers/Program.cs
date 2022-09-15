using System;

namespace LettersChangeNumbers {
    internal class Program {
        static void Main(string[] args) {
            string[] arr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            char firstChar = '\0';
            char lastChar = '\0';

            double result = 0;

            for (int i = 0; i < arr.Length; i++) {
                string word = arr[i];

                firstChar = char.Parse(word[0].ToString());
                lastChar = char.Parse(word[word.Length-1].ToString());

                word = word.Remove(word.Length - 1, 1);
                word = word.Remove(0, 1);

                double num = double.Parse(word);

                if (char.IsUpper(firstChar)) {
                    num /= (firstChar - 64); 
                } else {
                    num *= (firstChar - 96);
                }

                if (char.IsUpper(lastChar)) {
                    num -= lastChar - 64;
                } else {
                    num += lastChar - 96;
                }

                result += num;
            }

            Console.WriteLine($"{result:f2}");
        }
    }
}
