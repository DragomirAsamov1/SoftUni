using System;
using System.Text;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace StarEnigma {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"@(?<planet>[A-Za-z]*)[^@,\-!:>]*:(?<population>[1-9][0-9]*)[^@,\-!:>]*!(?<attackType>[A|D])![^@,\-!:>]*\->(?<soldierCount>[1-9][0-9]*)";

            char[] checkSymbols = new char[] { 's', 't', 'a', 'r', 'S', 'T', 'A', 'R'};

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++) {

                StringBuilder sb = new StringBuilder();
                string input = Console.ReadLine();
                int subtracter = 0;

                foreach (char ch in input) {
                    if (checkSymbols.Contains(ch)) {
                        subtracter++;
                    }
                }

                foreach (char ch in input) {
                    sb.Append((char)(ch - subtracter));
                }

                if (Regex.IsMatch(sb.ToString(), pattern)) {
                    Match match = Regex.Match(sb.ToString(), pattern);

                    string planet = match.Groups["planet"].Value;
                    int population = int.Parse(match.Groups["population"].Value);
                    char attackType = char.Parse(match.Groups["attackType"].Value);
                    int soldierCount = int.Parse(match.Groups["soldierCount"].Value);

                    Team team = new Team(planet, population, attackType, soldierCount);

                    teams.Add(team);
                }
            }

            List<Team> destroyedPlanets = teams.Where(x => x.AttackType == 'D').ToList();
            List<Team> attackedPlanets = teams.Where(x => x.AttackType == 'A').ToList();

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (Team planet in attackedPlanets.OrderBy(x => x.Name)) {
                Console.WriteLine("-> {0}", planet.Name);
            }
            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count}");
            foreach (Team planet in destroyedPlanets.OrderBy(x => x.Name)) {
                Console.WriteLine("-> {0}", planet.Name);
            }
        }
    }
}
