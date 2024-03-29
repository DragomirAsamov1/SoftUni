﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers {
    internal class Program {
        static void Main(string[] args) {
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            foreach (double number in numbers) {
                if (counts.ContainsKey(number)) {
                    counts[number]++;
                } else {
                    counts.Add(number, 1);
                }
            }

            foreach (var number in counts) {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
