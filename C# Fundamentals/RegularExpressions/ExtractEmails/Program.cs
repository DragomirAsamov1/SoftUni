using System;
using System.Text.RegularExpressions;

namespace ExtractEmails {
    internal class Program {
        static void Main(string[] args) {
            string pattern = @"([a-zA-Z|\d]+)([\.\-\_][a-zA-Z|\d]+)?@([a-zA-Z]+)(\-[a-zA-Z]+)*(\.([a-zA-Z]+)(\-[a-zA-Z]+)*)+";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches) {
                Console.WriteLine(match.Value);
            }
        }
    }
}
