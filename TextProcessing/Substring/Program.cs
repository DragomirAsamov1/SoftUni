using System;

namespace Substring {
    internal class Program {
        static void Main(string[] args) {
            string bannedWord = Console.ReadLine().ToLower();

            string word = Console.ReadLine();

            int index = word.IndexOf(bannedWord);

            while (index != -1) {
                word = word.Remove(index, bannedWord.Length);

                index = word.IndexOf(bannedWord);
            }

            Console.WriteLine(word);
        }
    }
}
