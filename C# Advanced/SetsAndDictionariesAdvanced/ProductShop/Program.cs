using System;
using System.Collections.Generic;

namespace ProductShop {
    internal class Program {
        static void Main(string[] args) {
            string command = string.Empty;

            SortedDictionary<string, Dictionary<string, double>> shops = new SortedDictionary<string, Dictionary<string, double>>();

            while ((command = Console.ReadLine()) != "Revision") {
                string[] tokens = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string store = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (!shops.ContainsKey(store)) {
                    shops.Add(store, new Dictionary<string, double>());
                }

                shops[store].Add(product, price);
            }

            foreach (KeyValuePair<string, Dictionary<string, double>> shop in shops) {
                Console.WriteLine($"{shop.Key}->");

                foreach (KeyValuePair<string, double> product in shop.Value) {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
