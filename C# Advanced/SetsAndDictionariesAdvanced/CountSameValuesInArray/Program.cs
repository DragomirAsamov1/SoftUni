using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSameValuesInArray {
    internal class Program {
        static void Main(string[] args) {
            double[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            Dictionary<double, int> dict = new Dictionary<double, int>();

            foreach (double num in array) {
                if (!dict.ContainsKey(num)) {
                    dict.Add(num, 0);
                }
                dict[num]++;
            }

            foreach (KeyValuePair<double,int> item in dict) {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}
