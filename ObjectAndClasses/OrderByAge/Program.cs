using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge {
    internal class Program {
        static void Main(string[] args) {

            List<Person> people = new List<Person>();
            while (true) {
                string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "End") {
                    break;
                }

                Person person = new Person(input[0], input[1], int.Parse(input[2]));
                people.Add(person);

            }

            List<Person> listOfMembers = people.OrderBy(x => x.Age).ToList();
            foreach (Person person in listOfMembers) {
                Console.WriteLine(person);
            }
            
        }
    }
}
