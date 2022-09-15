using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace NetherRealms {
    internal class Program {
        static void Main(string[] args) {

            List<Demon> demons = new List<Demon>();

            string pattern = @"-?\d+\.?\d*";
            string letterPattern = @"[a-zA-Z]+";
            
            decimal damagePoints = 0;

            string[] input = Console.ReadLine().Split(new char[] {',', ' '}, StringSplitOptions.RemoveEmptyEntries);

            foreach (string name in input) {

                int healthPoints = name.Where(x => Regex.IsMatch(x.ToString(), letterPattern)).Sum(x => x);

                MatchCollection matches = Regex.Matches(name, pattern);

                foreach (Match match in matches) {
                    if (match.Value != string.Empty) {
                        damagePoints += decimal.Parse(match.Value);
                    }
                    
                }

                foreach (char ch in name) {
                    if (ch == '*') {
                        damagePoints *= 2;
                    } else if (ch == '/') {
                        damagePoints /= 2;
                    }
                }

                Demon demon = new Demon(name, healthPoints, damagePoints);
                demons.Add(demon);

                damagePoints = 0;
                
            }

            foreach (Demon demon in demons.OrderBy(x => x.Name)) {
                Console.WriteLine(demon);
            }

        }
    }
}
