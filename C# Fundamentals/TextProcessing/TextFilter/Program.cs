using System;

namespace TextFilter {
    internal class Program {
        static void Main(string[] args) {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();

            foreach (var word in bannedWords) {
                string replaceString = new string('*', word.Length);

                text = text.Replace(word, replaceString);
            }

            Console.WriteLine(text);
        }
    }
}
