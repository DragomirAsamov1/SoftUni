﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            HashSet<string> elements = new HashSet<string>();

            for (int i = 0; i < n; i++) {
                string[] input = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (string item in input) {
                    elements.Add(item);
                }

            }

            foreach (string item in elements.OrderBy(x => x)) {
                Console.Write(item + " ");
            }
        }
    }
}
