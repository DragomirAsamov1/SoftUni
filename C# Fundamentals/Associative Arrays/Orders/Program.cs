using System;
using System.Collections.Generic;

namespace Orders {
    internal class Program {
        static void Main(string[] args) {
            string input = Console.ReadLine();

            Dictionary<string, List<decimal>> dict = new Dictionary<string, List<decimal>>();

            while (input != "buy") {
                string[] command = input.Split(' ');

                string name = command[0];
                decimal price = decimal.Parse(command[1]);
                decimal count = decimal.Parse(command[2]);

                if (!dict.ContainsKey(name)) {
                    dict.Add(name, new List<decimal>() { price, count });
                } else {
                    dict[name][0] = price;
                    dict[name][1] += count;
                }

                input = Console.ReadLine();
            }

            foreach (var item in dict) {
                Console.WriteLine($"{item.Key} -> {item.Value[0] * item.Value[1]:f2}");
            }
        }
    }
}
