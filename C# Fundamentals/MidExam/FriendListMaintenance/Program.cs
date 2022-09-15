using System;
using System.Collections.Generic;
using System.Linq;

namespace FriendListMaintenance {
    internal class Program {
        static void Main(string[] args) {
            List<string> friends = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string command = string.Empty;


            while ((command = Console.ReadLine()) != "Report") {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0]) {
                    case "Blacklist":
                        if (BlackListed(friends, tokens[1])) {
                            Console.WriteLine($"{tokens[1]} was blacklisted.");
                        } else {
                            Console.WriteLine($"{tokens[1]} was not found.");
                        }
                        break;
                    case "Error":
                        Error(friends, int.Parse(tokens[1]));
                        break;
                    case "Change":
                        Change(friends, int.Parse(tokens[1]), tokens[2]);
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine($"Blacklisted names: {friends.Where(x => x == "Blacklisted").ToList().Count}");
            Console.WriteLine($"Lost names: {friends.Where(x => x == "Lost").ToList().Count}");
            Console.WriteLine(String.Join(' ', friends));


            static bool BlackListed(List<string> friends, string name) {

                for (int i = 0; i < friends.Count; i++) {
                    if (friends[i] == name) {
                        friends[i] = "Blacklisted";
                        return true;
                    }
                }
                return false;
            }

            static void Error(List<string> friends, int index) {
                if (index < friends.Count && index >= 0 && friends[index] != "Blacklisted" && friends[index] != "Lost") {
                    Console.WriteLine($"{friends[index]} was lost due to an error.");
                    friends[index] = "Lost";
                }
            }

            static void Change(List<string> friends, int index, string name) {
                if (index < friends.Count - 1 && index >= 0) {
                    Console.WriteLine($"{friends[index]} changed his username to {name}.");
                    friends[index] = name;
                }
            }

        }
    }
}
