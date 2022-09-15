using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique {
    internal class Program {
        static void Main(string[] args) {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToArray());

            int capacity = int.Parse(Console.ReadLine());

            int racks = 1;

            int tempRackCount = 0;

            while (clothes.Count > 0) {
                if ((tempRackCount + clothes.Peek()) > capacity) {
                    racks++;
                    tempRackCount = clothes.Pop();
                } else {
                    tempRackCount += clothes.Pop();
                }
            }

            Console.WriteLine(racks);
        }
    }
}
