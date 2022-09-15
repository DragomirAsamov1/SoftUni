﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements {
    internal class Program {
        static void Main(string[] args) {
            int[] input = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToArray();

            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            for (int i = 0; i < input[0]; i++) {
                int num = int.Parse(Console.ReadLine());

                firstSet.Add(num);
            }

            for (int i = 0; i < input[1]; i++) {
                int num = int.Parse(Console.ReadLine());

                secondSet.Add(num);
            }

            foreach (int num in firstSet) {
                if (secondSet.Contains(num)) {
                    Console.Write(num + " ");
                }
            }

            
        }
    }
}
