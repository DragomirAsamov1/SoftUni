﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ForceBook {
    internal class Program {
        static void Main(string[] args) {
            string command = string.Empty;

            Dictionary<string, string> users = new Dictionary<string, string>();

            while ((command = Console.ReadLine()) != "Lumpawaroo") {
                string side = string.Empty;
                string member = string.Empty;
                string[] action = command.Split();

                if (action.Contains("|")) {
                    side = command.Split(" | ")[0];
                    member = command.Split(" | ")[1];

                    if (!users.ContainsKey(member)) {
                        users.Add(member, side);
                    }
                } else if (action.Contains("->")) {
                    member = command.Split(" -> ")[0];
                    side = command.Split(" -> ")[1];

                    if (users.ContainsKey(member)) {
                        users[member] = side;
                    } else {
                        users.Add(member, side);
                    }
                    Console.WriteLine($"{member} joins the {side} side!");
                }
            }

            foreach (var orderedSide in users.GroupBy(x => x.Value).OrderByDescending(x => x.Count()).ThenBy(x => x.Key)) {
                Console.WriteLine($"Side: {orderedSide.Key}, Members: {orderedSide.Count()}");

                foreach (var orderedUser in orderedSide.OrderBy(x => x.Key)) {
                    Console.WriteLine($"! {orderedUser.Key}");
                }
            }
        }
    }
}
