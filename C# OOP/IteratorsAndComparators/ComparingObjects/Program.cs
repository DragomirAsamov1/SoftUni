using System;
using System.Collections.Generic;

namespace ComparingObjects {
    public class Program {
        static void Main(string[] args) {
            List<Person> people = new List<Person>();
            string input = string.Empty;

            while ((input = Console.ReadLine()) != "END") {
                string[] tokens = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(tokens[0], int.Parse(tokens[1]), tokens[2]);

                people.Add(person);
            }

            int n = int.Parse(Console.ReadLine());

            Person personToCompare = people[n - 1];
            people.Remove(people[n - 1]);
        }
    }
}
