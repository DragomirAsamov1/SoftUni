using System;
using System.IO;
using System.Text.RegularExpressions;

namespace LineNumbersAnother {
    internal class Program {
        static void Main(string[] args) {
            string letterPattern = @"[a-zA-Z]";
            string signPattern = @"[\-?!\.,']";

            using (StreamReader reader = new StreamReader("../../../input.txt")) {

                string line = reader.ReadLine();
                int counter = 1;

                using (StreamWriter writer = new StreamWriter("../../../output.txt")) {

                    while (line != null) {

                        MatchCollection letterMatches = Regex.Matches(line, letterPattern);
                        MatchCollection signMatches = Regex.Matches(line, signPattern);

                        writer.WriteLine($"Line {counter}: {line} ({letterMatches.Count})({signMatches.Count})");

                        line = reader.ReadLine();
                        counter++;
                    }
                }
            }
        }
    }
}
