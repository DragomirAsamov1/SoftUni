using System;
using System.Collections.Generic;

namespace Animals {
    public class StartUp {
        static void Main(string[] args) {
            Dictionary<Animals, string> animals = new Dictionary<Animals, string>();
            while (true) {
                string type = Console.ReadLine();

                if (type == "Beast!") {
                    break;
                }

                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                int age = int.Parse(input[1]);

                if (age < 0) {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                Animals animal = default;

                switch (type) {
                    case "Dog":
                        animal = new Dog(name, age, input[2]);
                        break;
                    case "Cat":
                        animal = new Cat(name, age, input[2]);
                        break;
                    case "Frog":
                        animal = new Frog(name, age, input[2]);
                        break;
                    case "Kitten":
                        animal = new Kittens(name, age);
                        break;
                    case "Tomcat":
                        animal = new Tomcat(name, age);
                        break;
                    default:
                        break;
                }
                animals.Add(animal, type);
            }

            foreach (var animal in animals) {
                Console.WriteLine(animal.Value);
                Console.WriteLine($"{animal.Key.Name} {animal.Key.Age} {animal.Key.Gender}");
                animal.Key.ProduceSound();
            }
        }
    }
}
