using System;
using System.Collections.Generic;

namespace AMinerTask {
    internal class Program {
        static void Main(string[] args) {

            Dictionary<string, int> dict = new Dictionary<string, int>();

            while (true) {

                string resource = Console.ReadLine();
                
                if (resource.Equals("stop")) {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());

                if (dict.ContainsKey(resource)) {
                    dict[resource] += quantity;
                } else {
                    dict.Add(resource, quantity);
                }
            }
            foreach (KeyValuePair<string, int> item in dict) {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }
    }
}
