using System;
using System.Collections.Generic;
using System.Linq;

namespace SortEvenNumbers {
    internal class Program {
        static void Main(string[] args) {
            //Console.WriteLine(String.Join(", ", Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray().Where(x => x % 2 == 0)));
            int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            double sum = nums.Sum();
            int count = nums.Length;

            Console.WriteLine(sum);
            Console.WriteLine(count);
            Console.WriteLine(sum/count);
        }
    }
}
