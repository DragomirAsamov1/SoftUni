using System;
using System.Collections.Generic;

namespace Judge {
    internal class Program {
        static void Main(string[] args) {
            string input = string.Empty;

            Dictionary<string, Dictionary<string, int>> contests = new Dictionary<string, Dictionary<string, int>>();

            Dictionary<string, int> individualStatistics = new Dictionary<string, int>();

            while ((input = Console.ReadLine()) != "no more time") {
                string[] command = input.Split(" -> ");

                string user = command[0];
                string contest = command[1];
                int points = int.Parse(command[2]);

                if (!contests.ContainsKey(contest)) {
                    contests.Add(contest, new Dictionary<string, int> {
                        { user, points } 
                    });
                    continue;
                }

                if (!contests[contest].ContainsKey(user)) {
                    contests[contest].Add(user, points);
                    continue;
                }

                if (contests[contest][user] < points) {
                    contests[contest][user] = points;
                    
                }
            }


        }
    }

    internal class Student {
        public string Name { get; set; }
        //public Dictionary<string, int>
    }
}
