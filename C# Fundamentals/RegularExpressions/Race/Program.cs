using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Race {
    internal class Program {
        static void Main(string[] args) {
            List<string> participants = Console.ReadLine().Split(", ").ToList();

            Dictionary<string, int> members = new Dictionary<string, int>();

            foreach (var item in participants) {
                members.Add(item, 0);
            }

            string wordPattern = @"[A-Za-z]+";
            string numPattern = @"[0-9]";

            string name = string.Empty;
            int km = 0;
            StringBuilder nameBuilder = new StringBuilder();

            while ((name = Console.ReadLine()) != "end of race") {
                
                MatchCollection wordMatches = Regex.Matches(name, wordPattern);

                foreach (Match letter in wordMatches) {
                    nameBuilder.Append(letter.Value);
                }

                if (participants.Contains(nameBuilder.ToString())) {
                    MatchCollection numMatches = Regex.Matches(name, numPattern);
                    foreach (Match num in numMatches) {
                        km += int.Parse(num.Value);
                    }

                    members[nameBuilder.ToString()] += km;
                }

                km = 0;
                nameBuilder = nameBuilder.Clear();

            }

            Dictionary<string, int> sortedMembers = members.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, y => y.Value);

            Console.WriteLine($"1st place: {sortedMembers.Keys.ElementAt(0)}");
            Console.WriteLine($"2nd place: {sortedMembers.Keys.ElementAt(1)}");
            Console.WriteLine($"3rd place: {sortedMembers.Keys.ElementAt(2)}");
        }
    }
}
