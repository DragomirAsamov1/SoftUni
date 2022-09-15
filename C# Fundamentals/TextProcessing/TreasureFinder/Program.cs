using System;
using System.Linq;
using System.Text;

namespace TreasureFinder {
    internal class Program {
        static void Main(string[] args) {
            int[] nums = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int index = 0;

            string command = string.Empty;

            StringBuilder sb = new StringBuilder();

            while ((command = Console.ReadLine()) != "find") {
                foreach (char ch in command) {
                    if (index >= nums.Length - 1) {
                        index = 0;
                    }

                    sb.Append(ch + nums[index]);
                }
            }
        }
    }
}
