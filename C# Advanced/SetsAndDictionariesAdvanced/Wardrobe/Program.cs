using System;
using System.Collections.Generic;

namespace Wardrobe {
    internal class Program {
        static void Main(string[] args) {
            Dictionary<string, Dictionary<string, int>> clothesColors = 
                new Dictionary<string, Dictionary<string, int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {

                string[] input = Console.ReadLine()
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string color = input[0];

                string[] clothes = input[1].Split(',');

                foreach (string garment in clothes) {
                    if (!clothesColors.ContainsKey(color)) {
                        clothesColors.Add(color, new Dictionary<string, int>());
                    }

                    if (!clothesColors[color].ContainsKey(garment)) {
                        clothesColors[color].Add(garment, 0);
                    }

                    clothesColors[color][garment]++;
                }
            }

            string[] matchResult = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var color in clothesColors) {

                Console.WriteLine($"{color.Key} clothes:");

                foreach (var garment in color.Value) {

                    if (matchResult[0].Contains(color.Key) && matchResult[1].Contains(garment.Key)) {
                        Console.WriteLine(($"* {garment.Key} - {garment.Value} (found!)"));
                        continue;
                    }
                    Console.WriteLine($"* {garment.Key} - {garment.Value}");
                }
            }
        }
    }
}
