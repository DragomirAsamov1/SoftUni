using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicStackOperations {
    internal class Program {
        static void Main(string[] args) {
            int[] operations = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> nums = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());

            for (int i = 0; i < operations[1]; i++) {
                nums.Pop();
            }

            if (nums.Count > 0) {
                if (nums.Contains(operations[2])) {
                    Console.WriteLine("true");
                } else {
                    Console.WriteLine(nums.Peek());
                }
            } else {
                Console.WriteLine(0);
            }
        }
    }
}
