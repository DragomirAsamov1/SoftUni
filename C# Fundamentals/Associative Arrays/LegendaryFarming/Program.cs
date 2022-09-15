using System;
using System.Collections.Generic;
using System.Linq;

namespace LegendaryFarming {
    internal class Program {
        static void Main(string[] args) {

            List<string> input = new List<string>();

            Dictionary<string, int> dict = new Dictionary<string, int>();

            Dictionary<string, int> craftItems = new Dictionary<string, int>();
            Dictionary<string, int> junkItems = new Dictionary<string, int>();

            string shadowmourne = "Shadowmourne";
            string valanyr = "Valanyr";
            string dragonwrath = "Dragonwrath";

            string winner = string.Empty;

            bool isThereWinner = false;

            while (!isThereWinner) {

                input = Console.ReadLine().Split(' ').ToList();

                for (int i = 0; i < input.Count; i += 2) {

                    int quantity = int.Parse(input[i]);
                    string item = input[i + 1].ToLower();

                    if (item.Equals("shards") || item.Equals("fragments") || item.Equals("motes")) {
                        if (!craftItems.ContainsKey(item)) {
                            craftItems.Add(item, 0);
                        }
                        craftItems[item] += quantity;

                        if (!isThereWinner && craftItems[item] >= 250) {

                            if (item.Equals("shards")) {
                                winner = shadowmourne;
                            } else if (item.Equals("fragments")) {
                                winner = valanyr;
                            } else if (item.Equals("motes")) {
                                winner = dragonwrath;
                            }
                            craftItems[item] -= 250;

                            Console.WriteLine("{0} obtained!", winner);
                            isThereWinner = true;
                            break;
                        }
                    } else {
                        if (!junkItems.ContainsKey(item)) {
                            junkItems.Add(item, 0);
                        }
                        junkItems[item] += quantity;
                    }
                }
            }

            foreach (var item in craftItems) {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }

            foreach (var item in junkItems) {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
