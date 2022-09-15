using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree {
    public class StartUp {
        static void Main(string[] args) {
            Dictionary<string, Person> people = new Dictionary<string, Person>();
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            string[] peopleInput = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);
            string[] productsInput = Console.ReadLine().Split(new char[] { '=', ';' }, StringSplitOptions.RemoveEmptyEntries);

            try {
                for (int i = 0; i < peopleInput.Length; i += 2) {
                    string name = peopleInput[i];
                    decimal money = decimal.Parse(peopleInput[i + 1]);

                    Person person = new Person(name, money);

                    people.Add(name, person);
                }

                for (int i = 0; i < productsInput.Length; i += 2) {
                    string name = productsInput[i];
                    decimal cost = decimal.Parse(productsInput[i + 1]);

                    Product product = new Product(name, cost);

                    products.Add(name, product);
                }

                string command = Console.ReadLine();

                while (command != "END") {
                    string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                    string personName = tokens[0];
                    string productName = tokens[1];

                    Person person = people[personName];
                    Product product = products[productName];

                    bool IsAdded = person.AddProduct(product);

                    if (!IsAdded) {
                        Console.WriteLine($"{personName} can't afford {productName}");
                    } else {
                        Console.WriteLine($"{personName} bought {productName}");
                    }
                    command = Console.ReadLine();
                }

                foreach (var (name, person) in people) {
                    string output = person.Products.Count > 0 ? string.Join(' ', person.Products.Select(x => x.Name)) : "Noting bought";
                    Console.WriteLine($"{name} - {output}");
                }
            } catch (ArgumentException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
