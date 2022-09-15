using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCountWithFiles {
    internal class Program {
        static void Main(string[] args) {
            string pattern = @"[a-zA-Z']+";

            Dictionary<string, int> wordsFrequency = new Dictionary<string, int>();

            string[] words = File.ReadAllLines("../../../words.txt");
            string text = File.ReadAllText("../../../text.txt");

            //string[] testWords = File.ReadAllText("../../../text.txt")
            //    .ToLower()
            //    .Split(new string[] { " ", ",", ".", "!", "?", "-", Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (string word in words) {
                foreach (Match match in matches) {
                    if (word == match.ToString().ToLower()) {
                        if (!wordsFrequency.ContainsKey(word)) {
                            wordsFrequency.Add(word, 0);
                        }
                        wordsFrequency[word]++;
                    }
                }
            }

            Dictionary<string, int> sortedWords = wordsFrequency.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

            string[] actualWordsArr = new string[wordsFrequency.Keys.Count];
            string[] expectedWordsArr = new string[sortedWords.Keys.Count];

            int index = 0;
            foreach (var word in wordsFrequency) {
                actualWordsArr[index] = $"{word.Key} - {word.Value}";
                index++;
            }

            index = 0;

            foreach (var word in sortedWords) {
                expectedWordsArr[index] = $"{word.Key} - {word.Value}";
                index++;
            }
            File.WriteAllLines("../../../expectedResult.txt", expectedWordsArr);
            File.WriteAllLines("../../../actualResult.txt", actualWordsArr);
            
        }
    }
}
