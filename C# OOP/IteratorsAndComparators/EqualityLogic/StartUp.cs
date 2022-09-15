using System;
using System.Collections.Generic;

namespace EqualityLogic {
    public class StartUp {
        static void Main(string[] args) {
            int n = int.Parse(Console.ReadLine());

            HashSet<Person> hashSet = new HashSet<Person>();
            SortedSet<Person> sortedSet = new SortedSet<Person>();

            for (int i = 0; i < n; i++) {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(input[0], int.Parse(input[1]));
                hashSet.Add(person);
                sortedSet.Add(person);
            }

            Console.WriteLine(hashSet.Count);
            Console.WriteLine(sortedSet.Count);
        }
    }
}
