using System;
using System.Collections.Generic;
using System.Linq;

namespace TheV_Logger {
    internal class Program {
        static void Main(string[] args) {
            string command = string.Empty;

            string following = "following";
            string followers = "followers";

            Dictionary<string, Dictionary<string, HashSet<string>>> database = 
                new Dictionary<string, Dictionary<string, HashSet<string>>>();

            //Saffrona followed EmilConrad

            while ((command = Console.ReadLine()) != "Statistics") {
                string[] tokens = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string vlogger = tokens[0];

                string action = tokens[1];

                if (action.Contains("joined")) {

                    if (!database.ContainsKey(vlogger)) {
                        database.Add(vlogger, new Dictionary<string, HashSet<string>>());
                        database[vlogger].Add(followers, new HashSet<string>());
                        database[vlogger].Add(following, new HashSet<string>());
                    }
                    
                } else if (action.Contains("followed")) {

                    string member = tokens[2];


                    if (vlogger != member && database.ContainsKey(vlogger) && database.ContainsKey(member)) {
                        database[vlogger][following].Add(member);
                        database[member][followers].Add(vlogger);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {database.Count} vloggers in its logs.");

            int count = 0;

            foreach (var vlogger in database.OrderByDescending(x => x.Value[followers].Count).ThenBy(x => x.Value[following].Count)) {
                count++;

                Console.WriteLine($"{count}. {vlogger.Key} : {vlogger.Value[followers].Count} {followers}, {vlogger.Value[following].Count} {following}");
                
                

                if (count == 1) {
                    foreach (var follower in vlogger.Value[followers].OrderBy(x => x)) {
                        Console.WriteLine($"*  {follower}");
                    }
                }
                

            }
        }
    }
}
