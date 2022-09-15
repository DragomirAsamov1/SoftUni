using System;
using System.Collections.Generic;

namespace DictionaryExercise {
    internal class Program {
        static void Main(string[] args) {

            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            string[] pairs = input.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

            foreach (string pair in pairs) {
                string[] definitionWords = pair.Split(": ", StringSplitOptions.RemoveEmptyEntries);

                if (!dictionary.ContainsKey(definitionWords[0])) {
                    dictionary.Add(definitionWords[0], new List<string>());
                }

                dictionary[definitionWords[0]].Add(definitionWords[1]);
            }

            string[] words = Console.ReadLine().Split(" | ", StringSplitOptions.RemoveEmptyEntries);

            string command = Console.ReadLine();

            if (command == "Test") {
                foreach (string word in words) {
                    if (dictionary.ContainsKey(word)) {
                        Console.WriteLine($"{word}:");
                        foreach (string definition in dictionary[word]) {
                            Console.WriteLine($" -{definition}");
                        }
                    }
                }
            } else if (command == "Hand Over") {
                Console.WriteLine(string.Join(" ", dictionary.Keys));
            }
        }
    }
}
