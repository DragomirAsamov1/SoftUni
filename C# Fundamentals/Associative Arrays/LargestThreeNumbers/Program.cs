﻿using System;
using System.Linq;

namespace LargestThreeNumbers {
    internal class Program {
        static void Main(string[] args) {
            //int[] numbers = Console.ReadLine()
            //    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
            //    .Select(int.Parse)
            //    .OrderByDescending(x => x)
            //    .ToArray();

            //int count = numbers.Length >= 3 ? 3 : numbers.Length;

            //for (int i = 0; i < count; i++) {
            //    Console.Write($"{numbers[i]} ");
            //}

            //-------------------------------------------------------------------------------------------------------

            Console.WriteLine(String.Join(' ', Console.ReadLine().Split(' ').OrderByDescending(x => x).Take(3)));


        }
    }
}
