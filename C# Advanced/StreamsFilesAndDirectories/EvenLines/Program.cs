using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace EvenLines {
    internal class Program {
        static void Main(string[] args) {
            string pattern = @"[\-,\.!?]";


            using (StreamReader reader = new StreamReader("../../../input.txt")) {

                string line = reader.ReadLine();

                int counter = 0;

                using (StreamWriter writer = new StreamWriter("../../../output.txt")) {

                    while (line != null) {

                        if (counter % 2 == 0) {

                            string sanitized = Regex.Replace(line, pattern, "@");

                            string[] words = sanitized.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                            string[] reversedWords = words.Reverse().ToArray();

                            string result = string.Empty;

                            foreach (var word in reversedWords) {
                                result = result + word + " ";
                            }

                            if (result != string.Empty) {
                                result = result.Remove(result.Length - 1, 1);
                            }

                            writer.WriteLine(result);

                        }

                        line = reader.ReadLine();

                        counter++;
                    }
                }
            }
        }
    }
}
