using System;
using System.Collections.Generic;
using System.Linq;

namespace PrintEvenNumbers {
    internal class Program {
        static void Main(string[] args) {


            Queue<int> numbers = new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());

            int count = numbers.Count;

            for (int i = 0; i < count; i++) {
                if (numbers.Peek() % 2 == 0) {
                    numbers.Enqueue(numbers.Dequeue());
                } else {
                    numbers.Dequeue();
                }
            }

            Console.Write(string.Join(", ", numbers));

            //Console.WriteLine(String.Join(", ", new Queue<int>(Console.ReadLine().Split(' ').Select(int.Parse).Where(x => x % 2 == 0))));
        }
    }
}
