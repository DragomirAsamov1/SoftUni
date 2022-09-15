using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount {
    internal class Program {
        static void Main(string[] args) {

            Dictionary<string, int> wordsFrequency = new Dictionary<string, int>();

            string pattern = @"[a-zA-Z']+";

            using (StreamReader reader = new StreamReader("../../../input.txt")) {
                StreamReader wordsTxt = new StreamReader("../../../words.txt");

                string[] words = wordsTxt.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string sentenceBeforeRegex = reader.ReadLine();

                while (sentenceBeforeRegex != null) {

                    MatchCollection matches = Regex.Matches(sentenceBeforeRegex, pattern);

                    foreach (Match match in matches) {
                        foreach (var word in words) {
                            if (word == match.ToString().ToLower()) {
                                if (!wordsFrequency.ContainsKey(word)) {
                                    wordsFrequency.Add(word, 0);
                                }

                                wordsFrequency[word]++;
                            }
                        }
                    }

                    sentenceBeforeRegex = reader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter("../../../output.txt")) {

                foreach (var dict in wordsFrequency.OrderByDescending(x => x.Value)) {
                    writer.WriteLine($"{dict.Key} - {dict.Value}");
                }
            }
        }
    }
}
