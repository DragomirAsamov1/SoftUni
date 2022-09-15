using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket {
    internal class Program {
        static void Main(string[] args) {
            string command = string.Empty;

            Queue<string> names = new Queue<string>();

            while ((command = Console.ReadLine()) != "End") {
                if (command == "Paid") {
                    while (names.Any()) {
                        Console.WriteLine(names.Dequeue());
                    }
                } else {
                    names.Enqueue(command);
                }
            }

            Console.WriteLine("{0} people remaining.", names.Count);
        }
    }
}
