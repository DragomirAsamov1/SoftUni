﻿using System;
using System.Collections.Generic;

namespace WordSynonyms {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            for (int i = 0; i < n; i++) {

                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (dict.ContainsKey(word)) {
                    dict[word].Add(synonym);
                } else {
                    dict.Add(word, new List<string>() {synonym});
                }
            }

            foreach (var word in dict) {
                Console.WriteLine($"{word.Key} - {String.Join(", ", word.Value)}");
            }
        }
    }
}
