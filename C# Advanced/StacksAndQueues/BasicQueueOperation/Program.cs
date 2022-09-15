using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperation {
    internal class Program {
        static void Main(string[] args) {
            int[] operations = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Queue<int> nums = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());

            for (int i = 0; i < operations[1]; i++) {
                nums.Dequeue();
            }

            if (nums.Count > 0) {
                if (nums.Contains(operations[2])) {
                    Console.WriteLine("true");
                } else {
                    Console.WriteLine(nums.Min());
                }
            } else {
                Console.WriteLine(0);
            }
        }
    }
}
