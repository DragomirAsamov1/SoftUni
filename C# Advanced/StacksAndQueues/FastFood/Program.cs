using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood {
    internal class Program {
        static void Main(string[] args) {
            int quantity = int.Parse(Console.ReadLine());

            Queue<int> foodOrders = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());
            int count = foodOrders.Count;

            Console.WriteLine(foodOrders.Max());

            for (int i = 0; i < count; i++) {
                if (quantity >= foodOrders.Peek()) {
                    quantity -= foodOrders.Dequeue();
                } else {
                    break;
                }
            }

            if (foodOrders.Count == 0) {
                Console.WriteLine("Orders complete");
            } else {
                Console.WriteLine("Orders left: {0}", string.Join(' ', foodOrders));
            }
        }
    }
}
