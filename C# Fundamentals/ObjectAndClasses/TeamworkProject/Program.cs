using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamworkProject {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < n; i++) {
                string[] inputForTeam = Console.ReadLine().Split('-', StringSplitOptions.RemoveEmptyEntries);

                string currentCreator = inputForTeam[0];
                string currentTeamName = inputForTeam[1];

                bool isTeamNameExist = teams.Select(x => x.TeamName).Contains(currentTeamName);
                bool isCreatorExist = teams.Any(x => x.CreatorName == currentCreator);

                if (!isTeamNameExist && !isCreatorExist) {
                    Team currentTeam = new Team(currentTeamName, currentCreator);
                    teams.Add(currentTeam);
                    Console.WriteLine($"Team {currentTeamName} has been created by {currentCreator}!");
                } else if (isTeamNameExist) {
                    Console.WriteLine("Team {0} was already created!", currentTeamName);
                } else if (isCreatorExist) {
                    Console.WriteLine("{0} cannot create another team!", currentCreator);
                }
            }

            while (true) {
                string command = Console.ReadLine();

                if (command == "end of assignment") {
                    break;
                }

                string[] memsForTeam = command.Split("->", StringSplitOptions.RemoveEmptyEntries);

                string currentMember = memsForTeam[0];
                string currentTeam = memsForTeam[1];

                bool isTeamExist = teams.Any(x => x.TeamName == currentTeam);
                bool isCreatorCheating = teams.Any(x => x.CreatorName == currentMember);
                bool isAlreadyMember = teams.Any(x => x.Members.Contains(currentMember));

                if (isTeamExist && !isCreatorCheating && !isAlreadyMember) {
                    int indexOfTeam = teams.FindIndex(x => x.TeamName == currentTeam);

                    teams[indexOfTeam].Members.Add(currentMember);
                } else if (!isTeamExist) {
                    Console.WriteLine("Team {0} does not exist!", currentTeam);
                } else if(isCreatorCheating || isAlreadyMember) {
                    Console.WriteLine("Member {0} cannot join team {1}!", currentMember, currentTeam);
                }
            }

            List<Team> teamsWithMembers = teams
                .Where(x => x.Members.Count > 0)
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName)
                .ToList();

            List<Team> notValidTeams = teams
                .Where(x => x.Members.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            foreach (Team team in teamsWithMembers) {
                Console.WriteLine(team.TeamName);
                Console.WriteLine("- " + team.CreatorName);
                team.Members.Sort();
                Console.WriteLine(String.Join(Environment.NewLine, team.Members.Select(x => "-- " + x)));
            }

            Console.WriteLine("Teams to disband:");

            foreach (Team team in notValidTeams) {
                Console.WriteLine(team.TeamName);
            }
        }
    }
}
