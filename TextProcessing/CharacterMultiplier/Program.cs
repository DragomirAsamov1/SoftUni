using System;

namespace CharacterMultiplier {
    internal class Program {
        static void Main(string[] args) {
            string[] input = Console.ReadLine().Split(' ');

            string word = input[0];

            string secondWord = input[1];

            int sum = 0;
            int count = 0;

            for (int i = 0; i < Math.Min(word.Length, secondWord.Length); i++) {
                sum += word[i] * secondWord[i];
                count++;
            }

            for (int i = count; i < Math.Max(word.Length, secondWord.Length); i++) {
                if (word.Length > secondWord.Length) {
                    sum += word[i];
                } else if (secondWord.Length > word.Length) {
                    sum += secondWord[i];
                }
            }

            Console.WriteLine(sum);
        }
    }
}
