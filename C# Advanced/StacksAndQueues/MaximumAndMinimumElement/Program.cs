using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAndMinimumElement {
    internal class Program {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            Stack<int> nums = new Stack<int>();

            for (int i = 0; i < n; i++) {
                int[] command = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                switch (command[0]) {
                    case 1:
                        nums.Push(command[1]);
                        break;
                    case 2:
                        nums.Pop();
                        break;
                    case 3:
                        if (nums.Count > 0) {
                            Console.WriteLine(nums.Max());
                        }
                        break;
                    case 4:
                        if (nums.Count > 0) {
                            Console.WriteLine(nums.Min());
                        }
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(String.Join(", ", nums));
        }
    }
}
