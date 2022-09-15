using System;
using System.Linq;

namespace Stack {
    public class StartUp {
        static void Main(string[] args) {
            Stack<int> stack = new Stack<int>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "END") {
                string[] tokens = command.Split(new string[] { " ", ", "}, StringSplitOptions.RemoveEmptyEntries );

                if (tokens[0] == "Push") {
                    for (int i = 1; i < tokens.Length; i++) {
                        stack.Push(int.Parse(tokens[i]));
                    }
                } else if (tokens[0] == "Pop") {
                    try {
                        stack.Pop();
                    } catch (ArgumentOutOfRangeException ex) {
                        Console.WriteLine(ex.Message);
                    }
                    
                }
            }

            foreach (int item in stack) {
                Console.WriteLine(item);
            }

            Console.WriteLine(String.Join(Environment.NewLine, stack));
        }
    }
}
