using System;
using System.Collections.Generic;
using System.Linq;

namespace CountSymbols {
    internal class Program {
        static void Main(string[] args) {
            Dictionary<char, int> symbols = new Dictionary<char, int>();

            string line = Console.ReadLine();

            foreach (char ch in line) {
                if (!symbols.ContainsKey(ch)) {
                    symbols.Add(ch, 0);
                }

                symbols[ch]++;
            }

            foreach (var ch in symbols.OrderBy(x => x.Key)) {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
