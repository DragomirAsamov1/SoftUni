using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Furniture {
    internal class Program {
        static void Main(string[] args) {
            string pattern = @">>(?<furniture>[A-Za-z]+)<<(?<price>\d+(\.\d+)?)!(?<quantity>\d+)";

            string furnitures = string.Empty;

            decimal sum = 0;

            List<string> items = new List<string>();

            while((furnitures = Console.ReadLine()) != "Purchase") {
                var furnituresMatches = Regex.Matches(furnitures, pattern);

                foreach (Match furniture in furnituresMatches) {
                    decimal price = decimal.Parse(furniture.Groups["price"].Value);

                    int quantity = int.Parse(furniture.Groups["quantity"].Value);

                    items.Add(furniture.Groups["furniture"].Value);

                    sum += price * quantity;
                }
            }

            Console.WriteLine("Bought furniture:");
            if (items.Count > 0) {
                Console.WriteLine(string.Join(Environment.NewLine, items));
            }
            
            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
