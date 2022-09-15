using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator {
    public class StartUp {
        static void Main(string[] args) {
            Dictionary<string, Team> teams = new Dictionary<string, Team>();

            string command = Console.ReadLine();
            while (command != "END") {
                string[] tokens = command.Split(';');

                switch (tokens[0]) {
                    case "Team":
                        try {
                            Team team = new Team(tokens[1]);
                            teams.Add(tokens[1], team);
                        } catch (ArgumentException ex) {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "Add":
                        if (!teams.ContainsKey(tokens[1])) {
                            Console.WriteLine($"Team {tokens[1]} does not exist.");
                            command = Console.ReadLine();
                            continue;
                        }
                        try {
                            Player player = new Player(
                                tokens[2], 
                                int.Parse(tokens[3]), 
                                int.Parse(tokens[4]), 
                                int.Parse(tokens[5]), 
                                int.Parse(tokens[6]), 
                                int.Parse(tokens[7]));
                            teams[tokens[1]].Add(player);
                        } catch (ArgumentException ex) {
                            Console.WriteLine(ex.ParamName);
                        }
                        break;
                    case "Remove":
                        try {
                            teams[tokens[1]].Remove(tokens[2]);
                        } catch (ArgumentException ex) {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    case "Rating":
                        Console.WriteLine($"{tokens[1]} - {teams[tokens[1]].Rating}");
                        break;
                    default:
                        break;
                }

                command = Console.ReadLine();
            }
            
        }
    }
}
