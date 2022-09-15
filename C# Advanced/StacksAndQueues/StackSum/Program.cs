using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum {
    internal class Program {
        static void Main(string[] args) {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Stack<int> numbers = new Stack<int>(nums);

            string input = String.Empty;

            while ((input = Console.ReadLine()) != "end") {
                string[] command = input.Split(' ');
                
                switch (command[0].ToLower()) {
                    case "add":
                        numbers.Push(int.Parse(command[1]));
                        numbers.Push(int.Parse(command[2]));
                        break;
                    case "remove":
                        if (numbers.Count > int.Parse(command[1])) {
                            for (int i = 0; i < int.Parse(command[1]); i++) {
                                numbers.Pop();
                            }
                        }
                        break;
                    default:
                        break;
                }

            }

            Console.WriteLine("Sum: {0}", numbers.Sum());
        }
    }
}
