using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato {
    internal class Program {
        static void Main(string[] args) {
            Queue<string> names = new Queue<string>(Console.ReadLine().Split(' ').ToArray());

            int hotPotato = int.Parse(Console.ReadLine());

            while (names.Count > 1) {
                for (int i = 1; i < hotPotato; i++) {
                    names.Enqueue(names.Dequeue());
                }
                Console.WriteLine("Removed " + names.Dequeue());
            }

            Console.WriteLine("Last is " + names.Dequeue());
        }
    }
}
